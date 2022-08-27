

String noOfWordsInStr = Console.ReadLine();
int noOfWords = int.Parse(noOfWordsInStr);

String[] words = new String[noOfWords];

for (int i = 0; i < noOfWords; i++)
{
    words[i] = Console.ReadLine();
}

foreach (String word in words)
{
    if (word.Length <= 10)
    {
        Console.WriteLine(word);
    }
    else
    {
        char firstChar = word[0];
        string middleWord = word.Substring(1, word.Length - 2);
        int middleWordLength = middleWord.Length;
        string middleWordLengthStr = middleWordLength.ToString();
        char lastChar = word[word.Length - 1];
        Console.WriteLine(firstChar + middleWordLengthStr + lastChar);
    }
}
