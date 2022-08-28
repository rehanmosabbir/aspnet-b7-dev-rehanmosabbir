
string mainWord = Console.ReadLine();
string reversedWord = Console.ReadLine();

string newString = string.Empty;

for (int i = reversedWord.Length - 1; i >= 0; i--)
{
    newString += reversedWord[i];
}

if (mainWord == newString)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
