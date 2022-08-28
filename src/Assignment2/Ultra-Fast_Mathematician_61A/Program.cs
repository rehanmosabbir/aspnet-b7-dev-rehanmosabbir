

string firstNum = Console.ReadLine();

string secondNum = Console.ReadLine();

string newStr = string.Empty;

for (int i = 0; i < firstNum.Length; i++)
{

    if (firstNum[i] == secondNum[i])
    {
        newStr += "0";
    }
    else
    {
        newStr += "1";
    }

}

Console.WriteLine(newStr);