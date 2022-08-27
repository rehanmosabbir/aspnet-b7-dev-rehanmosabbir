

string[] str = Console.ReadLine().Split(' ');
string substract = str[0];
int substractNum = int.Parse(substract);
int lastDigit = substractNum % 10;
int times = int.Parse(str[1]);
for (int i = 0; i < times; i++)
{
    if (lastDigit == 0)
    {
        substractNum = substractNum / 10;
        lastDigit = substractNum % 10;

    }
    else
    {

        substractNum--;
        lastDigit = substractNum % 10;
    }
}
Console.WriteLine(substractNum);