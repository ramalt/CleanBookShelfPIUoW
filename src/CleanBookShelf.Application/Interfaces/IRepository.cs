namespace CleanBookShelf.Application.Interfaces;

public interface IRepository<T>
    where T : class
{
    T GetById(int id);
    void Add(T Tobject);
    void Update(T Tobject);
    void Remove(T Tobject);
    List<T> GetAll();
}
