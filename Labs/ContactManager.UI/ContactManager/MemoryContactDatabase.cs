using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class MemoryContactDatabase : ContactDatabase
    {
        //working with Lambda because thats the reference from the MovieDatabase notes
        protected override void AddCore(Contact contact)
        => _items.Add(contact);

        //Finds the contact, if any, by name and returns it
        protected override Contact FindByName(string name)
        {
            return (from m in _items
                    where String.Compare(name, m.Name, true) == 0
                    select m).FirstOrDefault();
        }

        //Finds old contact and replaces with "new" contact
        protected override void EditCore(Contact oldContact, Contact newContact)
        {
            _items.Remove(oldContact);

            _items.Add(newContact);
        }

        //Removes contact by name
        protected override void RemoveCore(string name)
        {
            var contact = FindByName(name);
            if (contact != null)
                _items.Remove(contact);
        }

        //Gets all contacts and returns list of contacts
        protected override IEnumerable<Contact> GetAllCore()
        {
            return from item in _items
                   select new Contact()
                   {
                       Name = item.Name,
                       Email = item.Email,
                   };
        }

        private List<Contact> _items = new List<Contact>();
    }
}

