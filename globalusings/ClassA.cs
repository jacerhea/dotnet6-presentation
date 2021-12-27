public class ClassA
{
    public static List<string> SayHello(int times){
        return Enumerable.Range(0, times)
        .Select(index => $"Hello v{index}!")
        .ToList();
    }
}
