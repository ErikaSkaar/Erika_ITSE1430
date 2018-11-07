using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class ContactDatabase
    {
        //Adds contact to database
        public void Add(Contact contact)
        {
            _items.Add(contact);
        }

        //If contact requested is valid will return
        private Contact FindContact(string name)
        {
            foreach (var contact in _items)
            {
                if (String.Compare(name, contact.Name, true) == 0)
                    return contact;
            };
            return null;
        }

        //Edits Contact in database
        public void Edit(string name, Contact contact)
        {
            Remove(name);
            Add(contact);
        }

        //Removes Contact in database
        public void Remove(string name)
        {
            var contact = FindContact(name);
            if (contact != null)
                _items.Remove(contact);
        }

        //Rolls through index to find contact
        public Contact[] GetAll()
        {
            var count = _items.Count;

            var temp = new Contact[count];
            var index = 0;
            foreach (var contact in _items)
            {
                temp[index++] = contact;
            };
            return temp;
        }

        private List<Contact> _items = new List<Contact>();
    }
}
