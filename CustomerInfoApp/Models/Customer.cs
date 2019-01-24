using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerInfoApp.Models
{
    public class Customer
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Phone]
        [Required]
        public string PhoneNumber { get; set; }
        
        [Required]
        public string Address { get; set; }

        public int Area { get; set; }

        public List<Area> Areas { get; set; }


    }
}