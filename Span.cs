namespace AllAboutSpanInCsharp;


/*
#Provides a type-safe and memory-safe representation of a contiguous region of arbitrary memory.
#Restrictions  they can't be assigned to variables of type Object, dynamic or to any interface type,
 they can't be fields in a reference type, and they can't be used across await and yield boundaries.
 In addition, calls to two methods, Equals(Object) and GetHashCode, throw a NotSupportedException.

  Span is very fast and doesn't occupy any memory
*/
public class AllAboutSpan
{


  public void SpanWithArrays()
  {

    var array = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
    //This will create a view to an array starting from index 2 to length 5
    var slice = new Span<int>(array, 2, 5);
    for (int ctr = 0; ctr < slice.Length; ctr++)
      slice[ctr] *= 2;

    // Examine the original array values.
    foreach (var value in array)
      Console.Write($"{value}  ");
    Console.WriteLine();
  }

  public void SpanWithString()
  {
    string contentLength = "Content-Length: 132";
    var length = GetContentLength(contentLength.ToCharArray());
    Console.WriteLine($"Content length: {length}");
  }

  private static int GetContentLength(ReadOnlySpan<char> span)
  {
    var slice = span.Slice(16);
    return int.Parse(slice);
  }


  

}