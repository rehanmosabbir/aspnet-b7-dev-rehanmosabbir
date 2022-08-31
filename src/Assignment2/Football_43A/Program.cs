
int n, goal = 0;
n = int.Parse(Console.ReadLine());

string team, win = null;
for (int i = n; i > 0; i--)
{
    if (goal != 0)
    {
        team = Console.ReadLine();
        if (team == win)
        {
            goal += 1;
        }
        else
        {
            goal -= 1;
        }
    }
    else
    {
        win = Console.ReadLine();
        goal = 1;
    }
}
Console.WriteLine(win);
