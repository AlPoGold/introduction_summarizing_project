Console.Write("Please, enter words with spaces between: ");
string[] words = Console.ReadLine()!.Split(" ");
int size = words.Length;
int count = 0;
for(int i =0; i<size; i++)
{
    if (words[i].Length<=3)
    {
        count++;
    } 
}
string[] wordsWithThreeChars = new string[count];
int index = 0;
foreach (string word in words)
{
    if(word.Length<=3)
    {
        wordsWithThreeChars[index] = word;
        index++;

    }
}

foreach(string word in wordsWithThreeChars) Console.WriteLine(word);