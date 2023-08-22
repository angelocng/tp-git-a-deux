using src.ClassesMetier;

Console.WriteLine("Programme Personne");

//
string? prenom;
string? nom;

Console.WriteLine("Programme de saisie d'un prénom et d'un nom d'une personne. ");
Console.WriteLine("Saisir le prénom : ");
prenom = Console.ReadLine();

Console.WriteLine("Saisir le nom : ");
nom = Console.ReadLine();

Console.WriteLine("La personne s'appelle : " +  prenom +" "+ nom);

Person myPerson = new Person(prenom,nom);

Console.WriteLine("La personne s'appelle : " +  myPerson.Prenom +" "+ myPerson.Nom);

PeopleContainer myPeopleContainer = new PeopleContainer();

myPeopleContainer.AddPerson(myPerson);
