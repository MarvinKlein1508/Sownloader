using Sownloader.Core.Utilities;
internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(UserAgentGenerator.GenerateRandomUserAgent());
            Console.WriteLine(IPAdressGenerator.GeneratePublicIPv4Address());
        }
        Console.WriteLine("Hello, World!");
    }
}