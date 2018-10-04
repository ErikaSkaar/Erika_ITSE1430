using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSE1430.MovieLib
{
    public class Movie
    {
        public string Name
        {
            get { return _name ?? ""; } //has implicit syntax of -->string get ()
            set { _name = value; } // void set ( string value ) 
        }
        private string _name;
                                                  //this maps to ->  public System.String Name;

            public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description;

        public int ReleaseYear { get; set; } = 1900;
        //{
        //    get { return _releaseYear; }
        //    set
        //    {   
        //        if (value >= 1900)
        //        _releaseYear = value;
        //    }
        //}
        //private int _releaseYear = 1900;

        public int RunLength { get; set; } //auto property syntax
        //private int _runLength; no longer needed due to the auto property

        /*void Foo()
        {
            var x = RunLength;

            var isLong = x > 100;

        }*/

            //showing mixed accessibilty
        public int Id { get; private set; }

        public bool IsColor //calculated property
        {
            get { return ReleaseYear > 1940; }
        }

        public bool IsOwned { get;set; }
    }
}
