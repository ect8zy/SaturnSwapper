using System.Collections.Generic;
using CUE4Parse.UE4.Assets.Objects;

namespace CUE4Parse;

public class SaturnData
{
    public static bool isCompressed { get; set; } = false;
    public static byte[] CompressedData { get; set; }
    public static long Offset { get; set; }
    public static string Path { get; set; }
    public static string UAssetPath { get; set; }
    public static ZLIBBlock? Block { get; set; } = null;
    public static string SearchCID { get; set; } = "NOCID";
    public static int Parition { get; set; } = 0;
    public static Dictionary<long, ArrayProperty> ChildArrayAssets = new Dictionary<long, ArrayProperty>();
    public static Dictionary<long, string> ChildSoftAssets = new Dictionary<long, string>();
}

public class ZLIBBlock
{
    public long Start { get; set; }
    public long End { get; set; }
    public byte[] DecompressedData { get; set; }
    public byte[] CompressedData { get; set; }
    public ZLIBBlock(long start, long end, byte[] decompressedData, byte[] compressedData)
    {
        Start = start;
        End = end;
        DecompressedData = decompressedData;
        CompressedData = compressedData;
    }
}
