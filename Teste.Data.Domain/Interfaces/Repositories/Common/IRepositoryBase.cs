namespace Teste.Data.Domain.Interfaces.Repositories.Common
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Exception Ex { get; set; }
        string Add(TEntity obj);
        TEntity GetById(string id);
        List<TEntity> GetAll();
        IQueryable<TEntity> GetAllQuery();
        string Update(TEntity obj);
        string Remove(TEntity obj);
    }
}
