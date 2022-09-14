using AdoApplication.Class;
using AdoApplication.Repositories;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

string connectionString = "server=E6KOLL0102\\TFTIC;database=HeroVsMonster;integrated security=true";
CharacterRepository repo = new CharacterRepository();

IEnumerable<Character> characters = new List<Character>();

string choix="";
while (choix != "Q")
{
    do
    {
        Console.Clear();
        Console.WriteLine("Choisissez une action : ");
        Console.WriteLine("Add Char: A");
        Console.WriteLine("Select Char : S");
        Console.WriteLine("Quitter : Q");
        choix = (Console.ReadLine()).ToUpper();
    }
    while (choix != "A" && choix != "S" && choix != "Q");
    switch (choix)
    {
    case "A":
        {
            Console.Write("Indiquez le nom du personnage :");
            string name = Console.ReadLine();
            repo.AddChar(name);
        }
        break;
    case "S":
        {
            ShowChar();
            Console.ReadLine();
        }
        break;
    case "Q":
        {
            Console.Clear();
            Console.WriteLine("J espere que tu as KIFFER mon jeux ;)");
            Console.WriteLine("Bonne journée");
            Console.WriteLine();
            break;
        }
    }
}

void ShowChar()
{
    characters = repo.ChargerLesPersonnages();
    foreach (Character character in characters)
    {
        Console.WriteLine(character.Id+" - "+character.Name + " - " + character.Money);
    }
}




