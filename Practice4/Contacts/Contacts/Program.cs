//name, lastname, email, phone number, address, age, gender, is favorite
//List<string> names = new List<string>();
//List<string> lastnames = new List<string>();
//List<string> emails = new List<string>();
//List<string> phoneNumbers = new List<string>();
//List<string> addresses = new List<string>();
//List<int> ages = new List<int>();
//List<string> genders = new List<string>();
//List<bool> isFavorites = new List<bool>();
Dictionary<int, string> names = new Dictionary<int, string>();

static int NewMethod(List<int> ids)
{
    return ids.Count + 1;
}

Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, string> phoneNumbers = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, string> genders = new Dictionary<int, string>();
Dictionary<int, bool> isFavorites = new Dictionary<int, bool>();

List<int> ids = new List<int>();
int typeOption;
bool exitApp = false;

Console.WriteLine("Welcome to the Contacts App!");

while (!exitApp)
{
    Console.WriteLine("Please type the option you want to do:");
    Console.WriteLine("1. Add a contact");
    Console.WriteLine("2. View all contacts");
    Console.WriteLine("3. Search for a contact");
    Console.WriteLine("4. Edit a contact");
    Console.WriteLine("5. Delete a contact");
    Console.WriteLine("6. Exit");

    //typeOption = int.Parse(Console.ReadLine());

    //typeOption = Convert.ToInt32(Console.ReadLine());

    int.TryParse(Console.ReadLine(), out typeOption);

    switch (typeOption)
    {
        case 1:
            {
                AddNewContact(names, lastnames, emails, phoneNumbers, addresses, ages, genders, isFavorites, ids);

                break;
            }
        case 2:
            {
                ShowAllContacts(names, lastnames, emails, phoneNumbers, addresses, ages, isFavorites, ids);

                break;
            }
        case 3:
            Console.WriteLine("You chose to search for a contact.");
            break;
        case 4:
            {
                Console.WriteLine("You chose to edit a contact.");

                Console.WriteLine("Please enter the ID of the contact you want to edit:");
                int editId = int.Parse(Console.ReadLine());

                EditContact(names, lastnames, emails, phoneNumbers, addresses, ages, genders, isFavorites, editId);

                break;
            }
        case 5:
            {
                Console.WriteLine("You chose to delete a contact.");
                Console.WriteLine("Please enter the ID of the contact you want to delete:");
                int deleteId = int.Parse(Console.ReadLine());

                DeleteContact(names, lastnames, emails, phoneNumbers, addresses, ages, genders, isFavorites, deleteId);

                break;
            }
        case 6:
            Console.WriteLine("Exiting the app. Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

}

Console.WriteLine("Thank you for using the Contacts App!");
Console.ReadKey();

static int GetNewContactId(List<int> ids)
{
    if (ids.Count == 0)
    {
        return 1;
    }
    else
    {
        return ids.Max() + 1;
    }
}

static void AddNewContact(Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> emails, Dictionary<int, string> phoneNumbers, Dictionary<int, string> addresses, Dictionary<int, int> ages, Dictionary<int, string> genders, Dictionary<int, bool> isFavorites, List<int> ids)
{
    Console.WriteLine("You chose to add a contact.");

    var id = GetNewContactId(ids);

    ids.Add(id);

    Console.WriteLine("Please enter the contact's name:");
    string name = Console.ReadLine();
    //names.Add(name);
    names.Add(id, name);

    Console.WriteLine("Please enter the contact's lastname:");
    string lastname = Console.ReadLine();
    //lastnames.Add(lastname);
    lastnames.Add(id, lastname);

    Console.WriteLine("Please enter the contact's email:");
    string email = Console.ReadLine();
    emails.Add(id, email);

    Console.WriteLine("Please enter the contact's phone number:");
    phoneNumbers.Add(id, Console.ReadLine());

    Console.WriteLine("Please enter the contact's address:");
    addresses.Add(id, Console.ReadLine());

    Console.WriteLine("Please enter the contact's age:");
    int age;
    while (!int.TryParse(Console.ReadLine(), out age))
    {
        Console.WriteLine("Invalid input. Please enter a valid age:");
    }
    ages.Add(id, age);

    Console.WriteLine("Please enter the gender of the contact");
    genders.Add(id, Console.ReadLine());

    Console.WriteLine("Is this contact a favorite? (1. yes, 2. no)");
    //int isFavoriteOption;
    //while (!int.TryParse(Console.ReadLine(), out isFavoriteOption) || (isFavoriteOption != 1 && isFavoriteOption != 2))
    //{
    //    Console.WriteLine("Invalid input. Please enter 1 for yes or 2 for no:");
    //}
    //bool isFavorite;
    //if (isFavoriteOption == 1)
    //{
    //    isFavorite = true;
    //}
    ////else if (isFavoriteOption == 2)
    ////{
    ////    isFavorite = false;
    ////}
    //else
    //{
    //    isFavorite = false;
    //}

    //isFavorite = (isFavoriteOption == 1) ? true : false;
    //isFavorite = (isFavoriteOption != 1) ? false : true;
    //isFavorite = !(isFavoriteOption == 1) ? false : true;

    //isFavorite = isFavoriteOption == 1;

    // isFavorites.Add(isFavorite);
    //isFavorites.Add(isFavoriteOption == 1? true: false);
    //isFavorites.Add(isFavoriteOption == 1);
    isFavorites.Add(id, Console.ReadLine() == "1");
}

static void ShowAllContacts(Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> emails, Dictionary<int, string> phoneNumbers, Dictionary<int, string> addresses, Dictionary<int, int> ages, Dictionary<int, bool> isFavorites, List<int> ids)
{
    Console.WriteLine("You chose to view all contacts.");

    Console.WriteLine("ID\tNAME\tLASTNAME\tEMAIL\tPHONE NUMBER\tADDRESS\tAGE\tGENDER\tIS FAVORITE");
    //foreach (var name in names)
    //{
    //    Console.Write(name);
    //    int index = names.IndexOf(name);
    //    Console.Write("\t" + lastnames[index]);
    //    Console.Write("\t" + emails[index]);
    //    Console.Write("\t" + phoneNumbers[index]);
    //    Console.Write("\t" + addresses[index]);
    //    Console.Write("\t" + ages[index]);
    //    Console.Write("\t" + (isFavorites[index]==true ? "Yes" : "No")); 
    //}
    //for (int i = 0; i < names.Count; i++)
    //{
    //    Console.Write(ids[i]);
    //    Console.Write(names[i]);
    //    Console.Write("\t" + lastnames[i]);
    //    Console.Write("\t" + emails[i]);
    //    Console.Write("\t" + phoneNumbers[i]);
    //    Console.Write("\t" + addresses[i]);
    //    Console.Write("\t" + ages[i]);
    //    Console.Write("\t" + (isFavorites[i] == true ? "Yes" : "No"));
    //    Console.WriteLine(); 
    //}

    //foreach (var id in ids)
    //{
    //    Console.Write(id);
    //    int index = ids.IndexOf(id);
    //    Console.Write(names[index]);
    //    Console.Write("\t" + lastnames[index]);
    //    Console.Write("\t" + emails[index]);
    //    Console.Write("\t" + phoneNumbers[index]);
    //    Console.Write("\t" + addresses[index]);
    //    Console.Write("\t" + ages[index]);
    //    Console.Write("\t" + (isFavorites[index] == true ? "Yes" : "No"));
    //    Console.WriteLine();
    //}
    foreach (var id in ids)
    {
        Console.Write(id);
        Console.Write(names[id]);
        Console.Write("\t" + lastnames[id]);
        Console.Write("\t" + emails[id]);
        Console.Write("\t" + phoneNumbers[id]);
        Console.Write("\t" + addresses[id]);
        Console.Write("\t" + ages[id]);
        Console.Write("\t" + (isFavorites[id] == true ? "Yes" : "No"));
        Console.WriteLine();
    }
}

static void EditContact(Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> emails, Dictionary<int, string> phoneNumbers, Dictionary<int, string> addresses, Dictionary<int, int> ages, Dictionary<int, string> genders, Dictionary<int, bool> isFavorites, int editId)
{
    //var index = ids.IndexOf(editId);

    //var contactName = names[index];
    //var contactName = names[editId - 1];
    var contactName = names[editId];
    Console.WriteLine($"Please type a new name for: {contactName}.");

    //names[index] = Console.ReadLine();
    //names[editId - 1] = Console.ReadLine();
    names[editId] = Console.ReadLine();

    Console.WriteLine("Please enter a new lastname:");
    lastnames[editId] = Console.ReadLine();

    Console.WriteLine("Please enter a new email:");
    emails[editId] = Console.ReadLine();

    Console.WriteLine("Please enter a new phone number:");
    phoneNumbers[editId] = Console.ReadLine();

    Console.WriteLine("Please enter a new address:");
    addresses[editId] = Console.ReadLine();

    Console.WriteLine("Please enter a new age:");
    int newAge;
    while (!int.TryParse(Console.ReadLine(), out newAge))
    {
        Console.WriteLine("Invalid input. Please enter a valid age:");
    }
    ages[editId] = newAge;

    Console.WriteLine("Please enter a new gender");
    genders[editId] = Console.ReadLine();

    Console.WriteLine("Please enter if is a favorite contact (1. yes, 2. no):");

    isFavorites[editId] = Console.ReadLine() == "1";
}

static void DeleteContact(Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> emails, Dictionary<int, string> phoneNumbers, Dictionary<int, string> addresses, Dictionary<int, int> ages, Dictionary<int, string> genders, Dictionary<int, bool> isFavorites, int deleteId)
{
    //foreach (var id in ids)
    //{
    //    if (id == deleteId)
    //    {
    //        int index = ids.IndexOf(id);
    //        names.RemoveAt(index);
    //        lastnames.RemoveAt(index);
    //        emails.RemoveAt(index);
    //        phoneNumbers.RemoveAt(index);
    //        addresses.RemoveAt(index);
    //        ages.RemoveAt(index);
    //    }
    //}
    //names.RemoveAt(deleteId - 1);
    //lastnames.RemoveAt(deleteId - 1);
    //emails.RemoveAt(deleteId - 1);
    //phoneNumbers.RemoveAt(deleteId - 1);
    //addresses.RemoveAt(deleteId - 1);
    //ages.RemoveAt(deleteId - 1);
    names.Remove(deleteId);
    lastnames.Remove(deleteId);
    emails.Remove(deleteId);
    phoneNumbers.Remove(deleteId);
    addresses.Remove(deleteId);
    ages.Remove(deleteId);
    genders.Remove(deleteId);
    isFavorites.Remove(deleteId);
}