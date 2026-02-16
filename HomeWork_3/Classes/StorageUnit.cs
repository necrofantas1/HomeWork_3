namespace HomeWork_3.Classes;

public class StorageUnit<T> where T : class , new()
{
    private List<T> items;
    
    public void Add(T item) => items.Add(item);
    
    public T GetItem(int index) => items[index];
}