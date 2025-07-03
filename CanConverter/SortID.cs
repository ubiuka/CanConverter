namespace CanConverter;

public class SortId
{
    public static void SortById(string filePath3, string filePath4)
    {
        var lines = File.ReadAllLines(filePath3).ToList();
        
        for (int i = 0; i < lines.Count - 9; i++)
        {
            string current = lines[i];
            string next = lines[i + 1];
            string next2 = lines[i + 2];
            string next3 = lines[i + 3];
            string next4 = lines[i + 4];
            string next5 = lines[i + 5];
            string next6 = lines[i + 6];
            string next7 = lines[i + 7];
            string next8 = lines[i + 8];
            string next9 = lines[i + 9];

            for (int k = 1; k < 59; k++)
            {
                if (current.Contains(k.ToString()) && next.Contains((k + 40).ToString()) && next2.Contains("= 21") && next3.Contains("= 22") && next4.Contains("= 23") && next5.Contains("= 24")) 
                {
                    lines[i] = current;
                    lines[i + 1] = next;
                    lines[i + 2] = next2;
                    lines[i + 3] = next3;
                    lines[i + 4] = next4;
                    lines[i + 5] = next5;
                    i += 6;
                } else if (current.Contains(k.ToString()) && next.Contains((k + 40).ToString()) && next2.Contains("= 21") &&
                           next3.Contains("= 22") && next4.Contains("= 23"))
                {
                    lines[i] = current;
                    lines[i + 1] = next;
                    lines[i + 2] = next2;
                    lines[i + 3] = next3;
                    lines[i + 4] = next4;
                    i += 5;
                } else if (current.Contains(k.ToString()) && next.Contains((k + 40).ToString()) && next2.Contains("= 21") &&
                           next3.Contains("= 22"))
                {
                    lines[i] = current;
                    lines[i + 1] = next;
                    lines[i + 2] = next2;
                    lines[i + 3] = next3;
                    i += 4;
                } else if (current.Contains(k.ToString()) && next.Contains((k + 40).ToString()) && next2.Contains("= 21"))
                {
                    lines[i] = current;
                    lines[i + 1] = next;
                    lines[i + 2] = next2;
                    i += 3;
                } else if (current.Contains(k.ToString()) && next.Contains((k + 40).ToString()))
                {
                    lines[i] = current;
                    lines[i + 1] = next;
                    i += 2;
                }
                else
                {
                    if (current.Contains(k.ToString()) && next2.Contains((k + 40).ToString()) && next3.Contains("= 21") && next4.Contains("= 22")
                        && next5.Contains("= 23") && next6.Contains("= 24"))
                    {
                        lines[i] = current;
                        lines[i + 1] = next6;
                        lines[i + 2] = next;
                        lines[i + 3] = next2;
                        lines[i + 4] = next3;
                        lines[i + 5] = next4;
                        lines[i + 6] = next5;
                        i += 6;
                    } else if (current.Contains(k.ToString()) && next2.Contains((k + 40).ToString()) && next3.Contains("= 21") && next4.Contains("= 22")
                               && next5.Contains("= 23"))
                    {
                        lines[i] = current;
                        lines[i + 1] = next5;
                        lines[i + 2] = next;
                        lines[i + 3] = next2;
                        lines[i + 4] = next3;
                        lines[i + 5] = next4;
                        i += 5;
                    } else if (current.Contains(k.ToString()) && next2.Contains((k + 40).ToString()) &&
                               next3.Contains("= 21") && next4.Contains("= 22"))
                    {
                        lines[i] = current;
                        lines[i + 1] = next4;
                        lines[i + 2] = next;
                        lines[i + 3] = next2;
                        lines[i + 4] = next3;
                        i += 4;
                    } else if (current.Contains(k.ToString()) && next2.Contains((k + 40).ToString()) &&
                               next3.Contains("= 21"))
                    {
                        lines[i] = current;
                        lines[i + 1] = next3;
                        lines[i + 2] = next;
                        lines[i + 3] = next2;
                        i += 3;
                    } else if (current.Contains(k.ToString()) && next2.Contains((k + 40).ToString()))
                    {
                        lines[i] = current;
                        lines[i + 1] = next2;
                        lines[i + 2] = next;
                        i += 2;
                    }
                    else
                    {
                        if (current.Contains(k.ToString()) && next3.Contains((k + 40).ToString()) &&
                            next4.Contains("= 21") && next5.Contains("= 22") && next6.Contains("= 23") && next7.Contains("= 24"))
                        {
                            lines[i] = current;
                            lines[i + 1] = next6;
                            lines[i + 2] = next7;
                            lines[i + 3] = next;
                            lines[i + 4] = next2;
                            lines[i + 5] = next3;
                            lines[i + 6] = next4;
                            lines[i + 7] = next5;
                            i += 6;
                        } else if (current.Contains(k.ToString()) && next3.Contains((k + 40).ToString()) &&
                                   next4.Contains("= 21") && next5.Contains("= 22") && next6.Contains("= 23"))
                        {
                            lines[i] = current;
                            lines[i + 1] = next5;
                            lines[i + 2] = next6;
                            lines[i + 3] = next;
                            lines[i + 4] = next2;
                            lines[i + 5] = next3;
                            lines[i + 6] = next4;
                            i += 5;
                        } else if (current.Contains(k.ToString()) && next3.Contains((k + 40).ToString()) &&
                                   next4.Contains("= 21") && next5.Contains("= 22"))
                        {
                            lines[i] = current;
                            lines[i + 1] = next4;
                            lines[i + 2] = next5;
                            lines[i + 3] = next;
                            lines[i + 4] = next2;
                            lines[i + 5] = next3;
                            i += 4;
                        } else if (current.Contains(k.ToString()) && next3.Contains((k + 40).ToString()) &&
                                   next4.Contains("= 21"))
                        {
                            lines[i] = current;
                            lines[i + 1] = next3;
                            lines[i + 2] = next4;
                            lines[i + 3] = next;
                            lines[i + 4] = next2;
                            i += 3;
                        } else if (current.Contains(k.ToString()) && next3.Contains((k + 40).ToString()))

                        {
                            lines[i] = current;
                            lines[i + 1] = next2;
                            lines[i + 2] = next3;
                            lines[i + 3] = next;
                            i += 2;
                        }
                        else
                        {
                            if (current.Contains(k.ToString()) && next4.Contains((k + 40).ToString()) && next5.Contains("= 21")
                                && next6.Contains("= 22") && next7.Contains("= 23") && next8.Contains("= 24"))
                            {
                                lines[i] = current;
                                lines[i + 1] = next6;
                                lines[i + 2] = next7;
                                lines[i + 3] = next8;
                                lines[i + 4] = next;
                                lines[i + 5] = next2;
                                lines[i + 6] = next3;
                                lines[i + 7] = next4;
                                lines[i + 8] = next5;
                                i += 6;
                            } else if (current.Contains(k.ToString()) && next4.Contains((k + 40).ToString()) &&
                                       next5.Contains("= 21") && next6.Contains("= 22") && next7.Contains("= 23"))
                            {
                                lines[i] = current;
                                lines[i + 1] = next5;
                                lines[i + 2] = next6;
                                lines[i + 3] = next7;
                                lines[i + 4] = next;
                                lines[i + 5] = next2;
                                lines[i + 6] = next3;
                                lines[i + 7] = next4;
                                i += 5;
                            } else if (current.Contains(k.ToString()) && next4.Contains((k + 40).ToString()) && next5.Contains("= 21") && next6.Contains("= 22"))
                            {
                                lines[i] = current;
                                lines[i + 1] = next4;
                                lines[i + 2] = next5;
                                lines[i + 3] = next6;
                                lines[i + 4] = next;
                                lines[i + 5] = next2;
                                lines[i + 6] = next3;
                                i += 4;
                            } else if (current.Contains(k.ToString()) && next4.Contains((k + 40).ToString()) && next5.Contains("= 21"))
                            {
                                lines[i] = current;
                                lines[i + 1] = next3;
                                lines[i + 2] = next4;
                                lines[i + 3] = next5;
                                lines[i + 4] = next;
                                lines[i + 5] = next2;
                                i += 3;
                            } else if (current.Contains(k.ToString()) && next4.Contains((k + 40).ToString()))
                            {
                                lines[i] = current;
                                lines[i + 1] = next2;
                                lines[i + 2] = next3;
                                lines[i + 3] = next4;
                                lines[i + 4] = next;
                                i += 2;
                            }
                            else
                            {
                                if (current.Contains(k.ToString()) && next5.Contains((k + 40).ToString()) &&
                                    next6.Contains("= 21") && next7.Contains("= 22") && next8.Contains("= 23") && next9.Contains("= 24"))
                                {
                                    lines[i] = current;
                                    lines[i + 1] = next6;
                                    lines[i + 2] = next7;
                                    lines[i + 3] = next8;
                                    lines[i + 4] = next9;
                                    lines[i + 5] = next;
                                    lines[i + 6] = next2;
                                    lines[i + 7] = next3;
                                    lines[i + 8] = next4;
                                    lines[i + 9] = next5;
                                    i += 6;
                                }
                                else if (current.Contains(k.ToString()) && next5.Contains((k + 40).ToString()) &&
                                         next6.Contains("= 21") && next7.Contains("= 22") && next8.Contains("= 23"))
                                {
                                    lines[i] = current;
                                    lines[i + 1] = next5;
                                    lines[i + 2] = next6;
                                    lines[i + 3] = next7;
                                    lines[i + 4] = next8;
                                    lines[i + 5] = next;
                                    lines[i + 6] = next2;
                                    lines[i + 7] = next3;
                                    lines[i + 8] = next4;
                                    i += 5;
                                }
                                else if (current.Contains(k.ToString()) && next5.Contains((k + 40).ToString()) &&
                                         next6.Contains("= 21") && next7.Contains("= 22"))
                                {
                                    lines[i] = current;
                                    lines[i + 1] = next4;
                                    lines[i + 2] = next5;
                                    lines[i + 3] = next6;
                                    lines[i + 4] = next7;
                                    lines[i + 5] = next;
                                    lines[i + 6] = next2;
                                    lines[i + 7] = next3;
                                    i += 4;
                                }
                                else if (current.Contains(k.ToString()) && next5.Contains((k + 40).ToString()) &&
                                         next6.Contains("= 21"))
                                {
                                    lines[i] = current;
                                    lines[i + 1] = next3;
                                    lines[i + 2] = next4;
                                    lines[i + 3] = next5;
                                    lines[i + 4] = next6;
                                    lines[i + 5] = next;
                                    lines[i + 6] = next2;
                                    i += 3;
                                }
                                else if (current.Contains(k.ToString()) && next5.Contains((k + 40).ToString()))

                                {
                                    lines[i] = current;
                                    lines[i + 1] = next2;
                                    lines[i + 2] = next3;
                                    lines[i + 3] = next4;
                                    lines[i + 4] = next5;
                                    lines[i + 5] = next;
                                    i += 2;
                                }
                                else
                                { break;}
                            }
                        }
                    }
                }
            }
        }

        File.WriteAllLines(filePath4, lines);
    }
}