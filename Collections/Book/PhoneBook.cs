
namespace Book
{
    internal class PhoneBook
    {
        private Dictionary<string, string> Contacts  = new Dictionary<string, string>();

    
        public void AddContact(string name, string phoneNumber)
        {
            Contacts[name] = phoneNumber;
        }
        public void RemoveContact(string name)
        {
            Contacts.Remove(name);
        }  
        public Dictionary<string, string> GetAllContacts()
        {
            return Contacts;
        }  
        public string FindContactByName(string name)
        {
            return Contacts.TryGetValue(name, out string phoneNumber) ? phoneNumber : "Axtarilan contact tapilmadi.";
        }
    }
}
