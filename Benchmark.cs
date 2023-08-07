using BenchmarkDotNet.Attributes;

namespace AllAboutSpanInCsharp.Benchmark;

[MemoryDiagnoser]
public class BenchmarForSpan
{
  private int[] _myArray;

  [Params(10)]
   public int Size{get; set;}

  [GlobalSetup]
   public void SetUp()
   {
    _myArray = new int[Size];
    for(int   i = 0; i < Size; i++){
      _myArray[i] = i;
    } 
   }
[Benchmark(Baseline =true)]
   public int[] Original()
   {
    return _myArray.Skip(Size/2).Take(Size/2).ToArray();
   }

[Benchmark]
  public int[] CopyArray()
  {
    var copy = new int[Size/4];
    Array.Copy(_myArray, Size/2, copy, 0, Size/4);
    return _myArray.Skip(Size / 2).Take(Size / 2).ToArray();
  }


[Benchmark]
  public Span<int> Span()
  {
    return _myArray.AsSpan().Slice(Size / 2, Size / 4);
  }





}