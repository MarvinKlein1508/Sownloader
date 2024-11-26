namespace Sownloader.Core.Utilities;
public class IPAdressGenerator
{
    private static readonly Random _random = new();

    public static string GeneratePublicIPv4Address()
    {
        var validRanges = new List<Tuple<byte, byte>>
        {
            Tuple.Create((byte)1, (byte)126),
            Tuple.Create((byte)128, (byte)223)
        };

        byte part1 = GenerateRandomByte(validRanges);
        byte part2 = (byte)_random.Next(0, 256);
        byte part3 = (byte)_random.Next(0, 256);
        byte part4 = (byte)_random.Next(1, 256); // Avoid broadcast addresses

        string ipAddress = $"{part1}.{part2}.{part3}.{part4}";
        return ipAddress;
    }

    private static byte GenerateRandomByte(List<Tuple<byte, byte>> ranges)
    {
        int totalRangeCount = ranges.Count;
        var selectedRange = ranges[_random.Next(totalRangeCount)];

        return (byte)_random.Next(selectedRange.Item1, selectedRange.Item2 + 1);
    }
}
