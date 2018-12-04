 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSE1430.MovieLib
{
    [Description("A movie.")]
    public class Movie : IValidatableObject
        {
        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            //var results = new List<ValidationResult>();

            //if (String.IsNullOrEmpty(Name))
            //  yield return new ValidationResult("Name is required", new[] { nameof(Name) });

            //if (ReleaseYear < 1900)
            //  yield return new ValidationResult("Release year must be >= 1900", new[] { nameof(ReleaseYear) });

            //if (RunLength < 0)
            //  yield return new ValidationResult("Run Length must be >= 0", new[] { nameof(RunLength) });

            //name, releaseyear and runlength now have attribues which enforce the validation
            yield return null;
        }

        //Property to back the name field
        //[Required]  //when calling default contructor you can leave off ()
        [Required(AllowEmptyStrings = false)]

        [StringLength(100, MinimumLength = 1)]
        public string Name
        {
            //change these to Lambdas

            //get { return _name ?? ""; } //has implicit syntax of -->string get ()
            get => _name ?? "";

            //set { _name = value; } // void set ( string value ) 
            set => _name = value; //lmabda or exspression bodies
        }
        private string _name;
                                                  //this maps to ->  public System.String Name;

            public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        private string _description;


        [Range(1900, 2100, ErrorMessage = "Release year must be >= 1900.")] //can be condensed down to this
        //[Required]this does not do anything on value tyoes because they cannot b e"false"
        //[RangeAttribute(1900, 2100)]
        //[RequiredAttribute()]
        //also can be written as --> [RangeAttribute(1900, 2100), RequiredAttribute()]
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

            
        [Range(0, Int32.MaxValue, ErrorMessage = "Run length must be >= 0.")]
        public int RunLength { get; set; } //auto property syntax
        //private int _runLength; no longer needed due to the auto property

        /*void Foo()
        {
            var x = RunLength;

            var isLong = x > 100;

        }*/

            //showing mixed accessibilty
        public int Id { get; set; }

        public bool IsColor => ReleaseYear > 1940;
        //{
        //    //get { return releaseYear > 1940;}
        //    get => ReleaseYear > 1940;
        //}

        public bool IsOwned { get;set; }
    }
}
