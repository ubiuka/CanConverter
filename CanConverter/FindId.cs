namespace CanConverter;

public class FindId
{
    public static Array Id(string filePath)
    {
        string request = "= 02";
        string request2 = "= 05";
        
        var requestlines = File.ReadAllLines(filePath)
            .Where(requestlines => requestlines.Contains(request))
            .Where(requestlines => requestlines.Contains(request2))
            .ToArray();
        return requestlines;
    }

    public static Array Id2(string filePath)
    {
        string request = "= 02";
        string request2 = "= 05";

        var responseLines = File.ReadAllLines(filePath)
            .Where(requestlines => !requestlines.Contains(request))
            .Where(requestlines => !requestlines.Contains(request2))
            .ToArray();
        return responseLines;
    }
}