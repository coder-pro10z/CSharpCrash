using ClassesAndObjects;

Person FirstPerson=new Person(); //Initializing a object from the Person Class - FirstPerson
Person SecondPerson=new Person();

//Setting the FirstName of the Instance FirstPerson as "Anam"
FirstPerson.SetFirstName("Anam");
FirstPerson.SetSecondName("Ansari");


//Getting the FirstName of the Instance FirstPerson as "Anam" and Printing it 
Console.WriteLine($"The First Name of the FirstPerson is {FirstPerson.GetFirstName()} {FirstPerson.GetSecondName()}.");
