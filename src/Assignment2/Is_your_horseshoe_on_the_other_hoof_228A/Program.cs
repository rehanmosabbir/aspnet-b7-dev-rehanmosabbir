int[] mas = new int[4]; 
int e = 3;


string[] line = Console.ReadLine().Split(" ");

for (int i = 0; i < 4; i++)
{
    mas[i] = int.Parse(line[i]);
}
Array.Sort(mas);
for (int i = 0; i < 3; i++)
{
    if (mas[i] != mas[i + 1])
    {
        e--;
    }
}
Console.WriteLine(e);
