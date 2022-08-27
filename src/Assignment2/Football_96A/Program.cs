
string line = Console.ReadLine();
string zero = string.Empty;
string one = string.Empty;
int countZero = 0;
int countOne = 0;

for (int i = 0; i < line.Length; i++)
{
    if (line[i] == '0')
    {
        if (countZero < 7)
        {
            zero += "0";
            countZero++;
            if (countOne != 7)
            {
                countOne = 0;
                one = string.Empty;
            }

        }
    }
    else if (line[i] == '1')
    {
        if (countOne < 7)
        {
            one += "1";
            countOne++;
            if (countZero != 7)
            {
                countZero = 0;
                zero = string.Empty;
            }

        }
    }

}

if (countZero == 7 || countOne == 7)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
