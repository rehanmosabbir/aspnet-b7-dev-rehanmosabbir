
string[] weights = Console.ReadLine().Split(' ');

int a = int.Parse(weights[0]);
int b = int.Parse(weights[1]);

int sum = 0;

int i = 3;
int j = 2;

while (true)
{
    if (a * i > b * j)
    {
        sum++;
        break;
    }
    else
    {
        sum++;
        i = i * 3;
        j = j * 2;
        continue;
    }
}

Console.WriteLine(sum);
