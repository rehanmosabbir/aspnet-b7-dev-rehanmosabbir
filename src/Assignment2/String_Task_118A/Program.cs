
string line = Console.ReadLine().ToLower();
string str = "";
for (int i = 0; i < line.Length; i++)
{
    if (line[i].Equals('a') || line[i].Equals('e') || line[i].Equals('i') || line[i].Equals('o') || line[i].Equals('u') || line[i].Equals('y'))
    {
        continue;
    }
    else
    {
        str += "." + line[i];
    }
}
Console.WriteLine(str);
