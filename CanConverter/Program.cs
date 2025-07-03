using CanConverter;

string filePath = Path.Combine("D:", "AmIWorkingOrNot", "CanConverter", "new test.log");
string filePath2 = Path.Combine("D:", "AmIWorkingOrNot", "CanConverter", "sort1.txt");
string filePath3 = Path.Combine("D:", "AmIWorkingOrNot", "CanConverter", "sort2.txt");
string filePath4 = Path.Combine("D:", "AmIWorkingOrNot", "CanConverter", "sort3.txt");
SortOut.SortedTime(filePath, filePath2);
SortOut.SortedSkip(filePath2, filePath3);


