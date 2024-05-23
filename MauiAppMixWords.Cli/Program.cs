Console.WriteLine("Mix a word...");

Console.Write("Your word...");
string word =Console.ReadLine();


// S´tatische Klassen : Methoden werden nicht bei einem Objekt aufgerufen -new fehlt
string mix = Rasser.Lib.String.Shuffle(word);
Console.WriteLine("Mix words: {0}", mix);