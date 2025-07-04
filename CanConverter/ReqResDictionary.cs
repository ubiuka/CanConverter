namespace CanConverter;

public class ReqResDictionary
{
    public Dictionary<int, Dictionary<string, string>> Jesus(string filepath3, string filepath4)
    {
        List<string> lines = File.ReadAllLines(filepath3).ToList();

        List<string> uds = new List<string>  { "10", "11", "14", "19", "22", "23", "27", "28", "31", "34", "36", "37" };

        List<string> answer = new List<string>  { "50", "51", "54", "59", "62", "63", "67", "68", "71", "74", "76", "77" };

        foreach (string line in lines)
        {
            foreach (string ud in uds)
            {
                if (line.Substring(27, 2) == ud)
                {
                    foreach (string line2 in lines)
                    {
                        foreach (string a in answer)
                        {
                            if (line2.Substring(27, 2) == a || line2.Substring(29, 2) == a)
                            {
                                
                            }
                        }
                    }
                }
            }
        }
    }
}