namespace MauiAppMixWord.Core7;

public class Mix
{
    public string MixIt(string word)
    {
        string mixString = Rasser.Lib.String.Shuffle(word);
        return mixString;   

    }
}


