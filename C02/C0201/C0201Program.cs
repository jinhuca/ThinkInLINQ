namespace C0201;

internal class C0201Program
{
  static void Main(string[] args)
  {
    DotProductDemo();
  }

  private static void DotProductDemo()
  {
    int[] v1 = { 1, 2, 3 };
    int[] v2 = { 3, 2, 1 };
    var zipped = v1.Zip(v2, (a, b) => a * b);
    foreach (var z in zipped)
    {
      Console.WriteLine(z);
    }
  }
}