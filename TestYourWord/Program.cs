// See https://aka.ms/new-console-template for more information
using CrypticWizard.RandomWordGenerator;

Console.WriteLine("Welcome to Test Your Word In English");
Console.WriteLine("Please Enter your Word");
string word = Console.ReadLine().ToLower();
var wordGenerator = new WordGenerator();

var incorrectWord = wordGenerator.IsWord(word);
if(incorrectWord == true)
{
    Console.WriteLine("It is a word in English");
    var wordIsNoun = wordGenerator.IsPartOfSpeech(word, WordGenerator.PartOfSpeech.noun);
    if(wordIsNoun == true)
        Console.WriteLine("it is a noun");
    var wordIsVerb = wordGenerator.IsPartOfSpeech(word, WordGenerator.PartOfSpeech.verb);
    if (wordIsVerb == true)
        Console.WriteLine("it is a verb");
    var wordIsadj = wordGenerator.IsPartOfSpeech(word, WordGenerator.PartOfSpeech.adj);
    if (wordIsadj == true)
        Console.WriteLine("it is an adj");


}
    
else
    Console.WriteLine("it is not a word in English");

