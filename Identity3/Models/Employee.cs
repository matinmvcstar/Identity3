using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Identity3.Models
{
    public class Employee
    {
        [Key]
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime DateJoin { get; set; }

        //one to many
        //public List<GraphicPost> GraphicPosts { get; set; }
        //public List<LearnPost> LearnPosts { get; set; }
        //public List<News> News { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
