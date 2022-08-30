
int noOfRound = int.Parse(Console.ReadLine());

int countMishka = 0;
int countChris = 0;
for (int i = 0; i < noOfRound; i++)
{
    string[] points = Console.ReadLine().Split(' ');
    int pointOfMishka = int.Parse(points[0]);
    int pointOfChris = int.Parse(points[1]);
    if (pointOfMishka > pointOfChris)
    {
        countMishka++;
    }
    else if (pointOfChris > pointOfMishka)
    {
        countChris++;
    }
    else
    {
        continue;
    }
}

if (countMishka > countChris)
{
    Console.WriteLine("Mishka");
}
else if (countChris > countMishka)
{
    Console.WriteLine("Chris");
}
else
{
    Console.WriteLine("Friendship is magic!^^");
}
