using System.Text.RegularExpressions;

namespace CanConverter;
public class SortOut
{
    public static void SortedTime(string filePath, string filePath2)
    {
        string[] lines = File.ReadAllLines(filePath)
            .Select(line => line.Length > 21 ? line[21..] : line)
            .Select(line => line.Replace(" DLC = 8 DATA =", "")).ToArray();
        
        File.WriteAllLines(filePath2, lines);
    }

    public static void SortedSkip(string filePath2, string filePath3)
    {
        
        
        string digitSequence = "3E 00";
        string digitSequence2 = "7E 00"; 
        string digitSequence3 = "78";
        string digitSequence4 = "30 08";
        string digitSequence5 = "00 0B";
        
        var filteredLines = File.ReadAllLines(filePath2)
            .Where(line => !line.Contains(digitSequence))
            .Where(line => !line.Contains(digitSequence2))
            .Where(line => !line.Contains(digitSequence3))
            .Where(line => !line.Contains(digitSequence4))
            .Where(line => !line.Contains(digitSequence5))
            .ToArray();

        File.WriteAllLines(filePath3, filteredLines);
    }
}



