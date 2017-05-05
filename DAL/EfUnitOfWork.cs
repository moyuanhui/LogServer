using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogServer.Common;
using LogServer.DAL.Mapping;

namespace LogServer.DAL
{
    public class EfUnitOfWork : DbContext
    {
        private static readonly string Conn = ConfigurationManager.ConnectionStrings["ContextConnectionString"].ConnectionString;
        public EfUnitOfWork()
            : base(Conn)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientLogMap());
            //base.OnModelCreating(modelBuilder);
        }

        #region 公共方法
        public DbSet<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        public void Attach<TEntity>(TEntity item) where TEntity : class
        {
            //attach and set as unchanged
            base.Entry<TEntity>(item).State = EntityState.Unchanged;
        }
        public void SetModified<TEntity>(TEntity item) where TEntity : class
        {
            //this operation also attach item in object state manager
            base.Entry<TEntity>(item).State = EntityState.Modified;
        }
        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class
        {
            //if it is not attached, attach original and set current values
            base.Entry<TEntity>(original).CurrentValues.SetValues(current);
        }
        public void Commit()
        {
            try
            {
                base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                string errorMessage = string.Empty;
                ex.EntityValidationErrors.ToList().ForEach(
                        entry =>
                        {
                            entry.ValidationErrors.ToList().ForEach(item =>
                            {
                                errorMessage += item.ErrorMessage;
                            });
                        }
                    );
                throw new NeedToShowFrontException(errorMessage);
            }
        }

        public void CommitAndRefreshChanges()
        {
            bool saveFailed = false;

            do
            {
                try
                {
                    base.SaveChanges();

                    saveFailed = false;

                }
                catch (DbUpdateConcurrencyException ex)
                {
                    saveFailed = true;

                    ex.Entries.ToList()
                              .ForEach(entry =>
                              {
                                  entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                              });

                }
            } while (saveFailed);
        }
        public IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            return base.Database.SqlQuery<TEntity>(sqlQuery, parameters);
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return base.Database.ExecuteSqlCommand(sqlCommand, parameters);
        }
        #endregion
    }
}
