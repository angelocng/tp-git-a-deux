using src.ClassesMetier;
using System.Text.Json;

Console.WriteLine("Programme Personne");

//
string? prenom;
string? nom;
Person myPerson; 
PeopleContainer myPeopleContainer = new PeopleContainer();

Console.WriteLine("Programme de saisie d'un prénom et d'un nom d'une personne. Pour commencer, appuyer sur entrée. ");

myPerson = new Person("Joe", "Doe");
myPeopleContainer.AddPerson(myPerson);
myPerson = new Person("Jean", "Dupont");
myPeopleContainer.AddPerson(myPerson);
myPerson = new Person("Pierre", "Dupond");
myPeopleContainer.AddPerson(myPerson);

while (Console.ReadLine() != "q")
{
    Console.WriteLine("Saisir le prénom : ");
    prenom = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(prenom.Trim()))
    {
        Console.WriteLine("Saisie invalide, veuillez recommencer la saisie du prénom : ");
        prenom = Console.ReadLine();
    }
    prenom = prenom.Trim();

    Console.WriteLine("Saisir le nom : ");
    nom = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(nom.Trim()))
    {
        Console.WriteLine("Saisie invalide, veuillez recommencer la saisie du nom : ");
        nom = Console.ReadLine();
    }
    nom = nom.Trim();

    Console.WriteLine("La personne s'appelle : " + prenom + " " + nom);

    myPerson = new Person(prenom, nom);

    Console.WriteLine("La personne s'appelle : " +  myPerson.Prenom + " "+ myPerson.Nom);

    if(!myPeopleContainer.People.Exists(person=>person.Prenom==myPerson.Prenom&&person.Nom==myPerson.Nom))
    {
        myPeopleContainer.AddPerson(myPerson);
    }
    else
    {
        Console.WriteLine("Attention, ce couple de prénom et nom est déjà présent. ");
    }

    Console.WriteLine("Pour arrêter la saisie de personnes, saisir q sinon appuyer sur entrée : ");
}

Console.WriteLine("Vous avez la possibilité de sauvegarder la liste de personne en JSON\nSaisir y si vous êtes d'accord :");
string? result = Console.ReadLine();
if(result=="y")
{
    string fileName = "PeopleList.json";
    string jsonString = JsonSerializer.Serialize(myPeopleContainer.People);
    File.WriteAllText(fileName, jsonString);
}
