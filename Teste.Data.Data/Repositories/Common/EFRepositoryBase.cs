using Microsoft.EntityFrameworkCore;
using Teste.Data.Data.Context;
using Teste.Data.Domain.Interfaces.Repositories.Common;

namespace Teste.Data.Data.Repositories.Common
{
    public class EFRepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected BDContext _db;
        public Exception Ex { get; set; }

        public EFRepositoryBase(BDContext db) {
            _db = db;
        }

        public string Add(TEntity obj) {
            try {
                _db.Add(obj);
                _db.SaveChanges();
                return "";
            } catch (Exception ex) {
                Ex = ex;
                return ex.Message.ToString();
            }
        }

        public List<TEntity> GetAll() {
            return _db.Set<TEntity>().ToList();
        }

        public IQueryable<TEntity> GetAllQuery() {
            return _db.Set<TEntity>();
        }

        public TEntity GetById(string id) {
            return _db.Set<TEntity>().Find(id);
        }

        public string Remove(TEntity obj) {
            try {
                _db.Set<TEntity>().Remove(obj);
                _db.SaveChanges();
                return "";
            } catch (Exception ex) {
                Ex = ex;
                return ex.Message.ToString();
            }
        }

        public string Update(TEntity obj) {
            try {
                _db.Entry(obj).State = EntityState.Modified;
                _db.SaveChanges();
                return "";
            } catch (Exception ex) {
                Ex = ex;
                return ex.Message.ToString();
            }
        }

        public void Dispose() {
            GC.SuppressFinalize(this);
        }
    }
}
