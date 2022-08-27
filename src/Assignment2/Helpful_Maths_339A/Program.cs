

string s = Console.ReadLine();
string[] numStr = s.Split('+');
int[] numbers = Array.ConvertAll(numStr, int.Parse);

Array.Sort(numbers);

string[] newStrArr = Array.ConvertAll(numbers, ele => ele.ToString());
string str = string.Join("+", newStrArr);
Console.WriteLine(str);
