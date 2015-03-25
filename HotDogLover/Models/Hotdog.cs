using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HotDogLover.Models
{
    public class Hotdog
    {
        public int ID { get; set; }

        [StringLength(30, MinimumLength = 2)]
        public string Type { get; set; }


        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public class HotDogLoverContext : DbContext
        {
            public DbSet<Hotdog> Hotdogs { get; set; }
        }
    }
}