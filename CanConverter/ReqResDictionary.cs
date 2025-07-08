namespace CanConverter;

public class ReqResDictionary
{
    public Dictionary<string, Dictionary<string, string>> Jesus(string filepath3)
    {
        Dictionary<string, Dictionary<string, string>> lord = new Dictionary<string, Dictionary<string, string>>();
        
        List<string> lines = File.ReadAllLines(filepath3).ToList();

        List<string> uds = new List<string>  { "10", "11", "14", "19", "22", "23", "27", "28", "31", "34", "36", "37" };

        List<string> answer = new List<string>  { "50", "51", "54", "59", "62", "63", "67", "68", "71", "74", "76", "77" };
        
        string replaced = "Boss";

        for (int i = 0; i < lines.Count; i++)
        {
            foreach (string ud in uds)
            {
                if (lines[i].Substring(27, 2) == ud)
                {
                    for (int k = i; k < lines.Count; k++)
                    {
                        foreach (string a in answer)
                        {
                            if (lines[k].Substring(27, 2) == a)
                            {
                                lord.Add(lines[i].Substring(5, 3), new Dictionary<string, string>
                                {
                                    {"Request: " + lines[i].Substring(27, 20), "Response: " + lines[k].Substring(27, 20)}
                                });

                                lord.Add(lines[k].Substring(5, 3), new Dictionary<string, string>
                                {
                                    {"Request: " + lines[i].Substring(27, 20), "Response: " + lines[k].Substring(27, 20)}
                                });
                                
                                lines[i].Replace(lines[i], replaced);
                                lines[k].Replace(lines[k], replaced);
                                i = 0;
                            } else if (lines[k].Substring(29, 2) == a)
                            {
                                int r = int.Parse(lines[k].Substring(27, 2), System.Globalization.NumberStyles.HexNumber);

                                int e = (r - 6) % 7;

                                string multi = "";

                                for (int w = k; w <= e; w++)
                                {
                                   multi += String.Join(" ", lines[w].Substring(27, 20));
                                   lines[w].Replace(lines[w], replaced);
                                }
                                
                                lord.Add(lines[i].Substring(5, 3), new Dictionary<string, string>
                                {
                                    { "Request: " + lines[i].Substring(27, 20), "Response: " + multi }
                                }); 
                                lord.Add(lines[k].Substring(5, 3), new Dictionary<string, string>{
                                    { "Request: " + lines[i].Substring(27, 20), "Response: " + multi }
                                });
                                
                                lines[i].Replace(lines[i], replaced);
                                i = 0;
                            }
                        }
                    }
                }
            }
        }
        return lord;
    }
}