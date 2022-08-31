
int a, count = 0;
a = int.Parse(Console.ReadLine());
string[] arr = new string[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Console.ReadLine();
    if (arr[i] == "Tetrahedron")
    {
        count += 4;
    }
    else if (arr[i] == "Cube")
    {
        count += 6;
    }
    else if (arr[i] == "Octahedron")
    {
        count += 8;
    }
    else if (arr[i] == "Dodecahedron")
    {
        count += 12;
    }
    else if (arr[i] == "Icosahedron")
    {
        count += 20;
    }
}
Console.WriteLine(count);
