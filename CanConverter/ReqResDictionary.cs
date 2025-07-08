namespace CanConverter;

public class ReqResDictionary
{
    public Dictionary<string, Dictionary<string, string>> Jesus(string filepath3)
    {
        Dictionary<string, Dictionary<string, string>> lord = new Dictionary<string, Dictionary<string, string>>();
        
        List<string> lines = File.ReadAllLines(filepath3).ToList();

        List<string> uds = new List<string>  { "10", "11", "14", "19", "22", "23", "27", "28", "31", "34", "36", "37" };

        List<string> answer = new List<string>  { "50", "51", "54", "59", "62", "63", "67", "68", "71", "74", "76", "77" };
        
        string replaced = "0000000000000000000000000000000000000000000000000000000000000000000000";

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
                            if (lord[lines[i].Substring(5, 3)].ContainsValue("Response: " + lines[k].Substring(27, 20)))
                            {
                                lines[i] = lines[i].Replace(lines[i].Substring(0,lines[i].Length), replaced);
                                lines[k] = lines[k].Replace(lines[k].Substring(0,lines[k].Length), replaced);
                            }
                            else if (lines[k].Substring(27, 2) == a && lord.ContainsKey(lines[i].Substring(5, 3)))
                            {
                                lord[lines[i].Substring(5, 3)].Add("Request: " + lines[i].Substring(27, 20), "Response: " + lines[k].Substring(27, 20));
                                lines[i] = lines[i].Replace(lines[i].Substring(0,lines[i].Length), replaced);
                                lines[k] = lines[k].Replace(lines[k].Substring(0,lines[k].Length), replaced);
                            } else if (lines[k].Substring(27, 2) == a)
                            {
                                lord.Add(lines[i].Substring(5, 3), new Dictionary<string, string> {
                                    { "Request: " + lines[i].Substring(27, 20), "Response: " + lines[k].Substring(27, 20) }
                                    });
                                
                                lines[i] = lines[i].Replace(lines[i].Substring(0,lines[i].Length), replaced);
                                lines[k] = lines[k].Replace(lines[k].Substring(0,lines[k].Length), replaced);
                            
                                if (lines[k].Substring(27, 2) == a && lord.ContainsKey(lines[k].Substring(5, 3)))
                                {
                                    lord[lines[k].Substring(5, 3)].Add("Request: " + lines[i].Substring(27, 20), "Response: " + lines[k].Substring(27, 20));
                                    lines[i] = lines[i].Replace(lines[i].Substring(0,lines[i].Length), replaced);
                                    lines[k] = lines[k].Replace(lines[k].Substring(0,lines[k].Length), replaced);
                                } else if (lines[k].Substring(27, 2) == a)
                                {
                                    lord.Add(lines[k].Substring(5, 3), new Dictionary<string, string>
                                    {
                                        { "Request: " + lines[i].Substring(27, 20), "Response: " + lines[k].Substring(27, 20) }
                                    });
                                    lines[i] = lines[i].Replace(lines[i].Substring(0,lines[i].Length), replaced);
                                    lines[k] = lines[k].Replace(lines[k].Substring(0,lines[k].Length), replaced);
                                }
                                i = 0;
                            } else if (lines[k].Substring(29, 2) == a)
                            {
                                int r = int.Parse(lines[k].Substring(27, 2), System.Globalization.NumberStyles.HexNumber);

                                int e = (r - 6) % 7;

                                string multi = "";

                                for (int w = k; w <= e; w++)
                                {
                                   multi += String.Join(" ", lines[w].Substring(27, 20));
                                   lines[w] = lines[w].Replace(lines[w].Substring(0,lines[w].Length), replaced);
                                }
                                
                                lord.Add(lines[i].Substring(5, 3), new Dictionary<string, string>
                                {
                                    { "Request: " + lines[i].Substring(27, 20), "Response: " + multi }
                                }); 
                                lord.Add(lines[k].Substring(5, 3), new Dictionary<string, string>{
                                    { "Request: " + lines[i].Substring(27, 20), "Response: " + multi }
                                });
                                
                                lines [i] = lines[i].Replace(lines[i].Substring(0,lines[i].Length), replaced);
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