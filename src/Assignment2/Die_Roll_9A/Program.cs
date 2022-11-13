int Y, W;
string[] line = Console.ReadLine().Split(" ");
Y = int.Parse(line[0]);
W = int.Parse(line[1]);

string[] probability = new string[7]{ "", "1/1", "5/6", "2/3", "1/2", "1/3", "1/6" };
int D = Math.Max(Y, W);
Console.WriteLine(probability[D]);
