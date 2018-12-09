using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventPlanner.Mvc.Models
{
    public class Model
    {
            //The runtime requires a default constructor
            public Model()
            {
            }

            //Using simple mapping layer using a constructor
            public Model(EventPlanner.ScheduledEvent item)
            {
                if (item != null)
                {
                    Id = item.Id;
                    Name = item.Name;
                    Description = item.Description;
                    StartDate = item.StartDate;
                    EndDate = item.EndDate;
                    IsPublic = item.IsPublic;
                };
            }

            //Using a simple mapping layer using a method
            public EventPlanner.ScheduledEvent ToDomain()
            {
                return new EventPlanner.ScheduledEvent()
                {
                    Name = Name,
                    Description = Description,
                    StartDate = StartDate,
                    EndDate = EndDate,
                    IsPublic = IsPublic,
                };
            }

            //Exposing public auto properties (with validation) for
            //data needed by view
            [Required(AllowEmptyStrings = false)]
            public string Name { get; set; }

            public string Description { get; set; }

            [Display(Name = "Start Date")]
            public DateTime StartDate
            {
            get => _startDate;
            set { _startDate = (value >= EndDate) ? value : EndDate; }
            }
            private DateTime _startDate;

            [Display(Name = "End Date")]
            public DateTime EndDate
            {
            get => _endDate;
            set { _endDate = (value >= StartDate) ? value : StartDate; }
            }
            private DateTime _endDate;

            public int Id { get; set; }

            [Display(Name = "Public")]
            public bool IsPublic { get; set; }
    }
}