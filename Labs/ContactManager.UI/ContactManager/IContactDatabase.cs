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
    //Interface contract for database 
    public interface IContactDatabase
    {
        void Add(Contact contact);

        void Edit(string name, Contact contact);

        IEnumerable<Contact> GetAll();

        void Remove(string name);
    }
}
