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

    //Interface for messages
    public interface IMessageServices
    {
        void Send(Message message);

        IEnumerable<Message> GetAll();
    }
}
