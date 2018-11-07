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
    public class Contact
    {
        //Contact name
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }
        private string _name;

        //Contact email address
        public string Email
        {
            get { return _email ?? ""; }
            set { _email = value; }
        }
        private string _email;

        //Email Message
        public string Message
        {
            get { return _txtMessage ?? ""; }
            set { _txtMessage = value; }
        }
        private string _txtMessage;

        //Subject line
        public string Subject
        {
            get { return _txtSubject ?? ""; }
            set { _txtSubject = value; }
        }
        private string _txtSubject;
    }
}
