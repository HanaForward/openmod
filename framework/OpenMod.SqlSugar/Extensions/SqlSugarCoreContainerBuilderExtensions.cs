using Autofac;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SqlSugar;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace OpenMod.SqlSugar.Extensions
{
    public static class SqlSugarContainerBuilderExtensions
    {
        public static ContainerBuilder AddSqlSugarClient(this ContainerBuilder containerBuilder, ConnectionConfig connectionConfig, MappingTableList mappingTables)
        {
            StackFrame frame = new StackTrace().GetFrame(1);
            Type refType = frame.GetMethod().ReflectedType;
            AssemblyName assemblyName = refType.Assembly.GetName();

            containerBuilder
               .Register<ISqlSugarClient>(context =>
               {
                   IConfiguration configuration = context.Resolve<IConfiguration>();
                   ILoggerFactory loggerFactory = context.Resolve<ILoggerFactory>();
                   ILogger logger = loggerFactory.CreateLogger($"{assemblyName.Name}-{assemblyName.Version}");

                   SqlSugarClient sqlSugarClient = new SqlSugarClient(connectionConfig);
                   sqlSugarClient.MappingTables = mappingTables;
                   sqlSugarClient.Aop.OnError = (exp) =>
                   {
                       logger.LogError(exp.Message);
                   };
                   sqlSugarClient.Aop.OnLogExecuted = (sql, pars) =>
                   {
                       logger.LogDebug(sql + "\n" + pars.ToDictionary(it => it.ParameterName, it => it.Value));
                   };
                   return sqlSugarClient;
               })
               .PropertiesAutowired()
               .InstancePerLifetimeScope()
               .OwnedByLifetimeScope();

            return containerBuilder;
        }
        public static ContainerBuilder AddSqlSugarClient(this ContainerBuilder containerBuilder, MappingTableList mappingTables)
        {
            StackFrame frame = new StackTrace().GetFrame(1);
            Type refType = frame.GetMethod().ReflectedType;
            AssemblyName assemblyName = refType.Assembly.GetName();

            containerBuilder
                .Register<ISqlSugarClient>(context =>
                {
                    IConfiguration configuration = context.Resolve<IConfiguration>();
                    ILoggerFactory loggerFactory = context.Resolve<ILoggerFactory>();
                    ILogger logger = loggerFactory.CreateLogger($"{assemblyName.Name}-{assemblyName.Version}");

                    configuration = configuration.GetSection("DataBase");
                    Enum.TryParse(configuration["DbType"], out DbType dbType);
                    ConnectionConfig connectionConfig = new ConnectionConfig
                    {
                        ConfigId = configuration["ConfigId"],
                        ConnectionString = configuration["ConnectionString"],
                        DbType = dbType,
                        IsAutoCloseConnection = true,
                        InitKeyType = InitKeyType.Attribute
                    };
                    SqlSugarClient sqlSugarClient = new SqlSugarClient(connectionConfig);
                    sqlSugarClient.MappingTables = mappingTables;
                    sqlSugarClient.Aop.OnError = (exp) =>
                    {
                        logger.LogError(exp.Message);
                    };
                    sqlSugarClient.Aop.OnLogExecuted = (sql, pars) =>
                    {
                        logger.LogDebug(sql + "\n" + pars.ToDictionary(it => it.ParameterName, it => it.Value));
                    };
                    return sqlSugarClient;
                })
                .PropertiesAutowired()
                .InstancePerLifetimeScope()
                .OwnedByLifetimeScope();

            return containerBuilder;
        }
    }
}
