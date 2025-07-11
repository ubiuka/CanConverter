﻿using System.Text;
using CanConverter;

string filePath = Path.Combine("D:", "AmIWorkingOrNot", "CanConverter", "new test.log");
string filePath2 = Path.Combine("D:", "AmIWorkingOrNot", "CanConverter", "sort1.txt");
string filePath3 = Path.Combine("D:", "AmIWorkingOrNot", "CanConverter", "sort2.txt");
string filePath4 = Path.Combine("D:", "AmIWorkingOrNot", "CanConverter", "result.txt");
string filePath5 = Path.Combine("D:", "AmIWorkingOrNot", "CanConverter", "tester.txt");
SortOut.SortedTime(filePath, filePath2);
SortOut.SortedSkip(filePath2, filePath3);
Dictionary <string, Dictionary<string, string>> work = new IdSearch().EnterId(filePath3);

var output = new StringBuilder();
foreach (var outer in work)
{
    output.AppendLine($"[{outer.Key}]");
    foreach (var inner in outer.Value)
    {
        output.AppendLine($"  {inner.Key}: {inner.Value}");
    }
    output.AppendLine(); 
}
File.WriteAllText(filePath4, output.ToString());


