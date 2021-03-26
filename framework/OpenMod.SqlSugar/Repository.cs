using Microsoft.Extensions.DependencyInjection;
using OpenMod.API.Ioc;
using OpenMod.API.Prioritization;
using SqlSugar;
using System.Collections.Generic;

namespace OpenMod.SqlSugar
{
    [ServiceImplementation(Lifetime = ServiceLifetime.Scoped, Priority = Priority.High)]
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        public readonly ISqlSugarClient sqlSugarClient;
        public Repository(ISqlSugarClient sqlSugarClient)
        {
            this.sqlSugarClient = sqlSugarClient;
        }

        #region Insertable
        public IInsertable<TEntity> Insertable(TEntity[] insertObjs)
        {
            return sqlSugarClient.Insertable<TEntity>(insertObjs);
        }
        public IInsertable<TEntity> Insertable(TEntity insertObj)
        {
            return sqlSugarClient.Insertable<TEntity>(insertObj);
        }
        public IInsertable<TEntity> Insertable(List<TEntity> insertObjs)
        {
            return sqlSugarClient.Insertable<TEntity>(insertObjs);
        }
        public IInsertable<TEntity> Insertable(dynamic insertDynamicObject)
        {
            return sqlSugarClient.Insertable<TEntity>(insertDynamicObject);
        }
        public IInsertable<TEntity> Insertable(Dictionary<string, object> columnDictionary)
        {
            return sqlSugarClient.Insertable<TEntity>(columnDictionary);
        }
        #endregion

        #region Deleteable
        public IDeleteable<TEntity> Deleteable()
        {
            return sqlSugarClient.Deleteable<TEntity>();
        }
        public IDeleteable<TEntity> Deleteable(TEntity deleteObj)
        {
            return sqlSugarClient.Deleteable<TEntity>(deleteObj);
        }
        public IDeleteable<TEntity> Deleteable(List<TEntity> deleteObjs)
        {
            return sqlSugarClient.Deleteable<TEntity>(deleteObjs);
        }
        #endregion

        #region Queryable
        public ISugarQueryable<TEntity> Queryable()
        {
            return sqlSugarClient.Queryable<TEntity>();
        }
        #endregion

        #region Updateable
        public IUpdateable<TEntity> Updateable()
        {
            return sqlSugarClient.Updateable<TEntity>();
        }
        public IUpdateable<TEntity> Updateable(TEntity UpdateObj)
        {
            return sqlSugarClient.Updateable<TEntity>(UpdateObj);
        }
        public IUpdateable<TEntity> Updateable(TEntity[] UpdateObjs)
        {
            return sqlSugarClient.Updateable<TEntity>(UpdateObjs);
        }
        public IUpdateable<TEntity> Updateable(List<TEntity> UpdateObjs)
        {
            return sqlSugarClient.Updateable<TEntity>(UpdateObjs);
        }
        #endregion
    }
}
