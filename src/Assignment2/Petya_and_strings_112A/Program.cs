
string firstLine = Console.ReadLine().ToLower();
string secondLine = Console.ReadLine().ToLower();

if (firstLine == secondLine)
{
    Console.WriteLine(0);
}
else if (firstLine.CompareTo(secondLine) < 0)
{
    Console.WriteLine(-1);
}
else if (firstLine.CompareTo(secondLine) > 0)
{
    Console.WriteLine(1);
}
