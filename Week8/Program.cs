//string[] heroes = {"Harry Potter", "Jhon Wick", "Black Widow", "Mr.Pibody" };
//string[] villans = {"Voldemort", "Lokhi", "Dragon", "Tedd Bundy", "Silver Surfar" };

string folderPath = @"C:\Users\Documents\data\";
string heroFile = "heroes.txt";
string villainFail = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath,heroFile));
string[] villans = File.ReadAllLines(Path.Combine(folderPath,villainFail));


string[] weapon = { "wand", "spoon", "pencel", "Pasta" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} saves the day with {heroWeapon}!");


string villain = GetRandomValueFromArray(villans);
string villanWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} tries to take over the world with {villanWeapon}!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}
