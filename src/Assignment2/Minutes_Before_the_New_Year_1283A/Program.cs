int h, m, t, day, time;
t = int.Parse(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    time = 0;
    string[] line = Console.ReadLine().Split(" ");
    h = int.Parse(line[0]);
    m = int.Parse(line[1]);
    day = 24 * 60;
    time = h * 60 + m;
    Console.WriteLine(day - time);
}
