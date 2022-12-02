namespace Common.Extensions;

public static class PartitionByExtensions
{
    public static IEnumerable<IEnumerable<T>> ChunkBy<T>(this IEnumerable<T> enumerable, Predicate<T> separator)
    {
        var current = new List<T>();
        foreach (var element in enumerable)
        {
            if (separator(element) && current.Count != 0)
            {
                yield return current;
                current = new List<T>();
            }
            else
            {
                current.Add(element);
            }
        }
    }
}