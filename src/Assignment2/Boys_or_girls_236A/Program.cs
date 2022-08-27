
string userName = Console.ReadLine();
char[] charArr = userName.ToCharArray();
string unique = "";

for (int i = 0; i < charArr.Length; i++)
{
    if (unique.Contains(charArr[i]))
    {
        continue;
    }
    else
    {
        unique = unique + charArr[i];

    }
}


if (unique.Length % 2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");
}
