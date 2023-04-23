using System.Collections;

namespace DSA;

public class CustomList<T> : IEnumerable
{
    private T[] _customLists;

    public CustomList()
    {
        _customLists = new T[] { };
    }

    public T this[int index] => _customLists[index];

    public T Get(int index)
    {
        //ThrowIfIndexOutOfRange(index);
        return _customLists[index];
    }

    public int Get(T element)
    {
        return _customLists.ToList().IndexOf(element);
    }

    private void SetAt(T newElement, int index)
    {

    }

    private void InsertAt(T newElement, int index)
    {

        //to be implemented...
    }


    public IEnumerator GetEnumerator()
    {
        return _customLists.GetEnumerator();
    }

    public void Add(T element)
    {
        var t = new T[_customLists.Length + 1];
        _customLists.CopyTo(t, 0);

        t[_customLists.Length] = element;
        _customLists = t;
    }
}