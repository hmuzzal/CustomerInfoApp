using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerInfoApp.Models
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer Customer { get; set; }
    }
}