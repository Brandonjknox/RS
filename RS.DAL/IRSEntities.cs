using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace RS.DAL
{
    public interface IRSEntities
    {
        IDbSet<Genre> Genres { get; set; }
        IDbSet<Image> Images { get; set; }
        Database Database { get; }
        DbChangeTracker ChangeTracker { get; }
        DbContextConfiguration Configuration { get; }
        DbSet Set(Type entityType);
        int SaveChanges();
        IEnumerable<DbEntityValidationResult> GetValidationErrors();
        DbEntityEntry Entry(TEntity entity) where TEntity : class;
        string ToString();
        bool Equals(object obj);
        int GetHashCode();
        Type GetType();
    }
}