
int stops = int.Parse(Console.ReadLine());
int[] passengersOnStops = new int[stops];
int[] newArr = new int[passengersOnStops.Length];

for (int i = 0; i < stops; i++)
{
    string[] passengers = Console.ReadLine().Split(' ');
    int exit = int.Parse(passengers[0]);
    int enter = int.Parse(passengers[1]);
    passengersOnStops[i] = (enter - exit);

}

int sum = 0;

for (int i = 0; i < passengersOnStops.Length; i++)
{

    sum = sum + passengersOnStops[i];
    newArr[i] = sum;

}

int max = 0;

for (int i = 0; i < newArr.Length; i++)
{
    if (newArr[i] > max)
    {
        max = newArr[i];
    }
}

Console.WriteLine(max);