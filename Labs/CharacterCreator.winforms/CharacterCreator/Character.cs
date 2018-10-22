/*Student:Erika Ballering
 * Teacher: Michael Taylor
 * Class: ITSE 1430"Intro to C#" 
 * Program:Character Creator*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        //Name
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }
        private string _name;

        //description
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description;

       //Combo boxes
        public string Race;
        public string Class;

        //All attributes
        public int AttributeStrength { get; set; }
        public int AttributeIntelligence { get; set; }
        public int AttributeAgility { get; set; }
        public int AttributeConstitution { get; set; }
        public int AttributeCharisma { get; set; }
    }
}
