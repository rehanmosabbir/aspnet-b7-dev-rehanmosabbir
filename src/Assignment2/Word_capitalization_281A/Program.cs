
string line = Console.ReadLine();
string splitedString = line.Substring(1);

char firstLetter = line[0];
char firstLetterUpper = Char.ToUpper(firstLetter);
Console.WriteLine(firstLetterUpper + splitedString);
