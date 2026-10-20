using Random = UnityEngine.Random;

namespace ScpLimiter;

public static class Extensions
{
    public static T[] ToShuffled<T>(this IEnumerable<T> enumerable)
    {
        var buffer = enumerable.ToArray();

        for (var i = buffer.Length - 1; i > 0; i--)
        {
            var j = Random.Range(0, i + 1);
            (buffer[i], buffer[j]) = (buffer[j], buffer[i]);
        }

        return buffer;
    }
}
