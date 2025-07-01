
//Display a Menu With the following options:

//1.Add Contact 
//2.View Contact
//3.Update Contact
//4.Delete Contact
//5.List All Contact
//6.Exit

///Objective:
///Create a CLI Application in C# to manage a 
///contact list using Dictionary<string,string>
///The Application will allow users to add, retrieve
///update, and delete contacts, where the key is the contact's name 
///and the value is their phone number
///
public class ContactManager
{
    
    public Dictionary<string,string> Contacts = new Dictionary<string,string>();
    public static void Main()
    {
        //creating a instance of ContactManager(non-static)
        ContactManager cm = new ContactManager();
        
        ///Add a CLI Menu Here
        ///

        cm.Contacts.Add("98776556778","Alice" );
        cm.AddContact();

        cm.ViewContact();
        
        ////Update Contact of a Existing Person
        ///
        cm.UpdateContact();
    
        ////Delete Contact
        ///
        cm.DeleteContact();
        
        ////List All contacts
        ///
        cm.ListAllContacts();
        
        //Exit 

    }

    //AddContact Function
    public void AddContact()
    {

        Console.WriteLine("Adding a Contact:-");
        Console.WriteLine("Enter a Contact Name:");

        string ContactName=Console.ReadLine();
        string ContactNumber;
        bool isNotUnique;
        do
        {
            Console.WriteLine("Enter a Contact Number:");
             ContactNumber = Console.ReadLine().Trim();
            isNotUnique=Contacts.ContainsKey(ContactNumber);
        
        } while ((!isNotUnique) && (string.IsNullOrWhiteSpace(ContactNumber)) &&  ContactNumber=="");

        Contacts.Add(ContactNumber,ContactName);
        Console.WriteLine("Contact Added Successfully.");
    }

    //ViewContact Function

    public void ViewContact()
    {

        //Console.WriteLine("Enter a Contact Name:");
        //string ContactName = Console.ReadLine();

        Console.WriteLine("Enter a Contact Number:");
        string ContactNumber = Console.ReadLine();
        //string ContactNumber;
        //bool isNotUnique;
        //do
        //{
        //    Console.WriteLine("Enter a Contact Number:");
        //    ContactNumber = Console.ReadLine().Trim();
        //    isNotUnique = Contacts.ContainsKey(ContactNumber);

        //} while ((!isNotUnique) && (string.IsNullOrWhiteSpace(ContactNumber)) && ContactNumber == "");

        if (Contacts.TryGetValue(ContactNumber, out string Name))
        {
            Console.WriteLine($"{Name} Contacts");
        }
        else { Console.WriteLine("Contact Not Found"); } 

        //Contacts.Add(ContactNumber, ContactName);
        //Console.WriteLine("Contact Added Successfully.");

    }

    //DeleteContact Function
    public void DeleteContact()
    {
        Console.WriteLine("Enter a Contact Number to Delete:");

        //string ContactName = Console.ReadLine();
        string ContactNumber;
        bool isNotPresent;
        do
        {
            Console.WriteLine("Enter a Contact Number:");
            ContactNumber = Console.ReadLine().Trim();
            isNotPresent = Contacts.ContainsKey(ContactNumber);

        } while (!isNotPresent);

        Contacts.Remove(ContactNumber);
        Console.WriteLine("Contact Removed Successfully.");
    }

    //UpdateContact Function
    public void UpdateContact()
    {
        Console.WriteLine("Enter a Contact Number to Update:");

        string ContactNumber;
        bool isNotPresent;
        do
        {
            Console.WriteLine("Enter a Contact Number:");
            ContactNumber = Console.ReadLine().Trim();
            isNotPresent = Contacts.ContainsKey(ContactNumber);

        } while (!isNotPresent);
        string ContactName = Console.ReadLine();

        Contacts[ContactNumber] = ContactName;
        //    Console.WriteLine( "Updated contact for {0} "+"Alice",Contacts["Alice"]);
        //Contacts.Remove(ContactNumber);
        Console.WriteLine("Contact Updated Successfully.");
    }

    //ListAllContact Function
    public void ListAllContacts()
    {
        if (Contacts.Count > 0)
        {
            Console.WriteLine("ALL CONTACTS: ");
            foreach (var entry in Contacts)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
        }
        else { Console.WriteLine("No Contacts Found"); };
    }


}