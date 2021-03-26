
using OpenMod.API.Ioc;
using SqlSugar;
using System.Collections.Generic;

namespace OpenMod.SqlSugar
{
    [Service]
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        #region Insertable
        public IInsertable<TEntity> Insertable(TEntity[] insertObjs);
        public IInsertable<TEntity> Insertable(TEntity insertObj);
        public IInsertable<TEntity> Insertable(List<TEntity> insertObjs);
        public IInsertable<TEntity> Insertable(dynamic insertDynamicObject);
        public IInsertable<TEntity> Insertable(Dictionary<string, object> columnDictionary);
        #endregion

        #region Deleteable
        public IDeleteable<TEntity> Deleteable();
        public IDeleteable<TEntity> Deleteable(TEntity deleteObj);
        public IDeleteable<TEntity> Deleteable(List<TEntity> deleteObjs);
        #endregion

        #region Updateable
        public IUpdateable<TEntity> Updateable();
        public IUpdateable<TEntity> Updateable(TEntity UpdateObj);
        public IUpdateable<TEntity> Updateable(TEntity[] UpdateObjs);
        public IUpdateable<TEntity> Updateable(List<TEntity> UpdateObjs);
        #endregion

        #region Queryable
        public ISugarQueryable<TEntity> Queryable();
        #endregion
    }
}
