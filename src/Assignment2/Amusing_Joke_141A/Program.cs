
string s1, s2, s3;
s1 = Console.ReadLine();
s2 = Console.ReadLine();
s3 = Console.ReadLine();
string s4 = s1 + s2;


string s5 = String.Concat(s3.OrderBy(c => c));
string s6 = String.Concat(s4.OrderBy(c => c));

if (s5 == s6)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
