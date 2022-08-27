

int noOfGames = int.Parse(Console.ReadLine());

string status = Console.ReadLine();
int countAnton = 0;
int countDanik = 0;

for (int i = 0; i < status.Length; i++)
{
    if (status[i] == 'A')
    {
        countAnton++;
    }
    else
    {
        countDanik++;
    }
}

if (countAnton == countDanik)
{
    Console.WriteLine("Friendship");
}
else if (countAnton > countDanik)
{
    Console.WriteLine("Anton");
}
else
{
    Console.WriteLine("Danik");
}