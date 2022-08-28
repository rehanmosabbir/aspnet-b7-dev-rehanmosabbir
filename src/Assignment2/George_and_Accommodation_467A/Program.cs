
int noOfRooms = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < noOfRooms; i++)
{
    string[] people = Console.ReadLine().Split(' ');
    int alreadyLive = int.Parse(people[0]);
    int capacity = int.Parse(people[1]);

    if (alreadyLive + 2 <= capacity)
    {
        count++;
    }
    else
    {
        continue;
    }
}

Console.WriteLine(count);
