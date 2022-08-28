
int noOfPeople = int.Parse(Console.ReadLine());
string result = string.Empty;

string[] question = Console.ReadLine().Split(' ');
for (int i = 0; i < question.Length; i++)
{
    if (int.Parse(question[i]) == 0)
    {
        result = "EASY";
        continue;
    }
    else
    {
        result = "Hard";
        break;
    }
}

Console.WriteLine(result);