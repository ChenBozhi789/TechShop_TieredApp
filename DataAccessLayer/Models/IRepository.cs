public interface IRepository<T> where T : class
{
    void Add(T entity);
    void Delete(T entity);
    void Delete(int id);
    T Get(int id);
    List<T> GetAll();
    void Update(T entity);
    IEnumerable<T> List();
}