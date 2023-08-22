using src.ClassesMetier;

Console.WriteLine("Programme Personne");

//
string? prenom;
string? nom;
Person myPerson; 
PeopleContainer myPeopleContainer = new PeopleContainer();

Console.WriteLine("Programme de saisie d'un prénom et d'un nom d'une personne. Pour commencer, appuyer sur entrée. ");

while(Console.ReadLine() != "q")
{
    Console.WriteLine("Saisir le prénom : ");
    prenom = Console.ReadLine();

    Console.WriteLine("Saisir le nom : ");
    nom = Console.ReadLine();

    Console.WriteLine("La personne s'appelle : " + prenom + " " + nom);

    myPerson = new Person(prenom, nom);

    Console.WriteLine("La personne s'appelle : " +  myPerson.Prenom + " "+ myPerson.Nom);

    myPeopleContainer.AddPerson(myPerson);

    Console.WriteLine("Pour arrêter la saisie de personnes, saisir q : ");
}
