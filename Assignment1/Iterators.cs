namespace Assignment1;

public static class Iterators
{
    public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
    {
        foreach (IEnumerable<T> item in items){
            foreach(T x in item){
                yield return x;
            }
        }
    }

    public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate){
        using (var enumerator = items.GetEnumerator())
            while (enumerator.MoveNext())
            {
                var element = enumerator.Current; 
                   if (predicate(element)){
                    yield return element;
                   }
            }
    }
        
}
