
string numOfStatementStr = Console.ReadLine();
int numOfStatement = int.Parse(numOfStatementStr);
int x = 0;
for (int i = 0; i < numOfStatement; i++)
{
    string statement = Console.ReadLine();
    if (statement == "X++" || statement == "++X")
    {
        x = x + 1;
    }
    else if (statement == "X--" || statement == "--X")
    {
        x = x - 1;
    }
}
Console.WriteLine(x);
