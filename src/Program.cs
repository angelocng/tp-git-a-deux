using src.ClassesMetier;

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

    Console.WriteLine("Saisir le nom : ");
    nom = Console.ReadLine();

    Console.WriteLine("La personne s'appelle : " + prenom + " " + nom);

    myPerson = new Person(prenom, nom);

    Console.WriteLine("La personne s'appelle : " +  myPerson.Prenom + " "+ myPerson.Nom);

    if(!myPeopleContainer.People.Exists(person=>person.Prenom==myPerson.Prenom&&person.Nom==myPerson.Nom))
    {
        myPeopleContainer.AddPerson(myPerson);
    }

    Console.WriteLine("Pour arrêter la saisie de personnes, saisir q sinon appuyer sur entrée : ");
}
