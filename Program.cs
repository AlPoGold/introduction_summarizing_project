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
string[] newArray = new string[count];
int newIndex = 0;
foreach (string word in words)
{
    if(word.Length<=3)
    {
        newArray[newIndex] = word;
        newIndex++;

    }
}

foreach(string word in newArray) Console.WriteLine(word);