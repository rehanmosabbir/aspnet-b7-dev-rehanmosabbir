
string line = Console.ReadLine();
string line2 = Console.ReadLine();
string[] splitedLine = line.Split(' ');
string[] splitedLine2 = line2.Split(' ');
int[] userHeight = new int[splitedLine2.Length];
int[] userNumAndWallHeight = new int[splitedLine.Length];
int[] newarray = new int[userHeight.Length];



for (int i = 0; i < splitedLine2.Length; i++)
{
    userHeight[i] = int.Parse(splitedLine2[i]);
}
for (int i = 0; i < splitedLine.Length; i++)
{
    userNumAndWallHeight[i] = int.Parse(splitedLine[i]);
}

int userNum = userNumAndWallHeight[0];
int wallHeight = userNumAndWallHeight[1];

for (int i = 0; i < userNum; i++)
{

    if (((float)userHeight[i] / (float)wallHeight) <= 1)
    {
        newarray[i] = 1;
    }
    else
    {
        newarray[i] = 2;
    }
}



int sum = 0;
for (int i = 0; i < newarray.Length; i++)
{
    sum += newarray[i];
}

Console.WriteLine(sum);
