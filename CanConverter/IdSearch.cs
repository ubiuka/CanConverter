using System.Runtime.InteropServices.JavaScript;

namespace CanConverter;

public class IdSearch
{
    public Dictionary<string, Dictionary<string, string>> EnterId(string filepath)
    {
        Dictionary<string, Dictionary<string, string>> returner = new Dictionary<string, Dictionary<string, string>>();
        
        HashSet<string> uds = new () {"10", "11", "14", "19", "22", "23", "27", "28", "31", "34", "36", "37"};

        List<string> lines = File.ReadAllLines(filepath).ToList();
        
        List<string> request = new List<string>();
        
        List<string> response = new List<string>();
        
        int i = -1;
        
        string cfLine = "";

        foreach (string line in lines)
        {
            i += 1;
            
            string[] currentLine = line.Split(" ");

            foreach (string ud in uds)
            {
                if (currentLine[2].Contains(ud))
                {
                    string idLine = $"{currentLine[0]}: {currentLine[2]} {currentLine[3]} {currentLine[4]} {currentLine[5]} {currentLine[6]} {currentLine[7]} {currentLine[8]}";
                    request.Add(idLine);
                }

                if (Int32.Parse(currentLine[3]) == Int32.Parse(ud) + 40)
                {
                    cfLine +=
                        $"{currentLine[0]}: {currentLine[3]} {currentLine[4]} {currentLine[5]} {currentLine[6]} {currentLine[7]} {currentLine[8]}";
                    int k = Int32.Parse(currentLine[2]);
                    int r = (k - 6) % 7;
                    for (int j = i + 1; j <= r; j++)
                    {
                        string[] currentLine2 = lines[j].Split(" ");
                        cfLine += $"{currentLine2[1]} {currentLine2[2]} {currentLine2[3]} {currentLine2[4]} {currentLine2[5]} {currentLine2[6]} {currentLine2[7]} {currentLine2[8]}";
                    }
                    response.Add(cfLine);
                    cfLine = "";
                }
                
                else if (Int32.Parse(currentLine[2]) == Int32.Parse(ud) + 40)
                {
                    string idLine = $"{currentLine[0]}: {currentLine[2]} {currentLine[3]} {currentLine[4]} {currentLine[5]} {currentLine[6]} {currentLine[7]} {currentLine[8]}";
                    response.Add(idLine);
                }
            }
        }

        string joined = string.Empty;
        
        for (int k = 0; k < response.Count; k++)
        {
            joined = $"Request : {request[k].Substring(4, request[k].Length - 4)} Response: {response[k].Substring(4,response[k].Length - 4)}";
            returner.Add(request[k].Substring(0,3), new Dictionary<string, string>());
            returner[request[k].Substring(0,3)].Add(response[k].Substring(0,3), joined);
        }
        return returner;
    }
}