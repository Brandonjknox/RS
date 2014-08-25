using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.DAL.Contracts
{
    public interface IDbContext
    {

        //void OnModelCreating(DbModelBuilder modelBuilder);
        Database Database { get; }
        DbChangeTracker ChangeTracker { get; }
        DbContextConfiguration Configuration { get; }
        // InternalContext InternalContext { get; }
        //  void InitializeLazyInternalContext(IInternalConnection internalConnection, DbCompiledModel model);
        //void DiscoverAndInitializeSets();
        //   void CallOnModelCreating(DbModelBuilder modelBuilder);
        //    DbSet Set() where TEntity : class;
        DbSet Set(Type entityType);
        int SaveChanges();
        IEnumerable<DbEntityValidationResult> GetValidationErrors();
        //    bool ShouldValidateEntity(DbEntityEntry entityEntry);
        //    DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items);
        //     DbEntityValidationResult CallValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items);
        //   DbEntityEntry Entry(TEntity entity) where TEntity : class;
        DbEntityEntry Entry(object entity);
        //  void Dispose();
        // void Dispose(bool disposing);
        string ToString();
        bool Equals(object obj);
        int GetHashCode();
        Type GetType();
    }
}
