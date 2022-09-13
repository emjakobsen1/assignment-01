namespace Assignment1;

public static class GreaterCountMethods
{
    public static int GreaterCount<T, U>(IEnumerable<T> items, T x) where T : IComparable<T>
    {
        int sum = 0;
        using (var enumerator = items.GetEnumerator())
            while (enumerator.MoveNext())
            {
                var element = enumerator.Current; 
                   if (element.CompareTo(x) > 0)  {
                    sum++;
                   }
            }
        return sum;    
    }

    public static int GreaterCountWithNakedTypeConstraint<T, U>(IEnumerable<T> items, T x)
        where T : U
        where U : IComparable<U>
    {
        int sum = 0;
        using (var enumerator = items.GetEnumerator())
            while (enumerator.MoveNext())
            {
                var element = enumerator.Current; 
                   if (element.CompareTo(x) > 0)  {
                    sum++;
                   }
            }
        return sum;    
    }
    
    
    
    
}
