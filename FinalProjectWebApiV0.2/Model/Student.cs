using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProjectWebApiV0._2.Model
{
    public class Student
    {
        [Key]
        public int Studenid { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Dob { get; set; }   // Easier binding
        public int Age { get; set; }
        public string Mail { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }

        public string Skills { get; set; }  

        public string Color { get; set; }

        // File paths stored in DB
        public string ImagePath { get; set; }
        public string AudioPath { get; set; }
        public string VideoPath { get; set; }
        public string DocumentPath { get; set; }

       
    }
}
