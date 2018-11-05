using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class ContactDatabase
    {

        public void Add(Contact contact)
        {
            _items.Add(contact);
        }

        private Contact FindContact(string name)
        {
            foreach (var contact in _items)
            {
                if (String.Compare(name, contact.Name, true) == 0)
                    return contact;
            };
            return null;
        }

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
