/*Student:Erika Ballering
 * Teacher: Michael Taylor
 * Class: ITSE 1430"Intro to C#" 
 * Program:Contact Manager*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public abstract class ContactDatabase : IContactDatabase
    {
        //contact storage
        public void Add(Contact contact)
        {
            if (contact == null)
                return;

            AddCore(contact);
        }

        //pulls get all  
        public IEnumerable<Contact> GetAll()
        {
            return GetAllCore();
        }

        //Finds and Edits contact by name
        public void Edit(string name, Contact contact)
        {
            if (String.IsNullOrEmpty(name))
                return;
            if (contact == null)
                return;

            var existingContact = FindByName(name);
            if (existingContact == null)
                return;

            EditCore(existingContact, contact);
        }

        //Deletes contact by name
        public void Remove(string name)
        {
            if (String.IsNullOrEmpty(name))
                return;

            RemoveCore(name);
        }

        
        protected abstract void AddCore(Contact contact);

        protected abstract void EditCore(Contact oldContact, Contact newContact);

        protected abstract Contact FindByName(string name);

        protected abstract IEnumerable<Contact> GetAllCore();

        protected abstract void RemoveCore(string name);
    }
  }
