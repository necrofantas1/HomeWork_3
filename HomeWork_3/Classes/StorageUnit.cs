namespace HomeWork_3.Classes;

public class StorageUnit<T> where T : class , new()
{
    private List<T> _items = new List<T>();
    
    public void AddItem(T item) => _items.Add(item);
    
    public T GetItem(int index) => _items[index];
}