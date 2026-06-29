//used gerneric code which included a Container<T> from last oppgave 
namespace Core;
public interface IStorable<T>
{
    void Store (T item);
    T GetItem();
    T Pop();
    int Count { get; }
}



public class Container<T> : IStorable<T>
{
private List<T> items = new List<T>();
public void Store (T item)
{
    items.Add(item);
}
public T GetItem()
    {
        return items[items.Count - 1];
    }


// Added Count

public int Count => items.Count;

// Added pop
public T Pop()
    {
        if (items.Count == 0)
            throw new IndexOutOfRangeException("Container is empty");

        T last = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return last;
    }

    }

