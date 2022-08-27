
string inputStr = Console.ReadLine();
int input = int.Parse(inputStr);
int move;

if (input > 5 && input % 5 != 0)
{
    decimal value = input / 5;
    int remainder = (int)Math.Floor(value);
    move = remainder + 1;
}
else if (input > 5 && input % 5 == 0)
{
    decimal value = input / 5;
    int remainder = (int)Math.Floor(value);
    move = remainder;
}
else
{
    move = 1;
}

Console.WriteLine(move);
