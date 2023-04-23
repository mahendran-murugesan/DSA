using System.Collections;

namespace DSA;

public class CustomDictionary<TKey, TValue>: IEnumerable
{
    public CustomDictionary()
    {
        _list = new System.Collections.Generic.List<KeyValuePair<TKey, TValue>>();
    }

    private readonly System.Collections.Generic.List<KeyValuePair<TKey, TValue>> _list;
    
    public void Add(TKey key, TValue value)
    {
        var keyExists = _list.Where(x => x.Key != null && x.Key.Equals(key)).ToList();
        if (keyExists.Count == 0)
        {
            _list.Add(new KeyValuePair<TKey, TValue>(key, value));
        }
        else
        {
            throw new Exception("Key already Exists");
        }
    }

    public KeyValuePair<TKey,TValue> this[int index] => _list[index];

    public TValue this[TKey key] => _list.FirstOrDefault(x => x.Key != null && x.Key.Equals(key)).Value;


    public IEnumerator GetEnumerator()
    {
        return _list.GetEnumerator();
    }
}