using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoPractico.MVC.Models
{
    public class CharactersView
    {
        public string Name { get; set; }
        public string species { get; set; }
        public string gender { get; set; }
        public string house { get; set; }
        public string dateOfBirth { get; set; }
        public int? yearOfBirth { get; set; }
        public string ancestry { get; set; }
        public string eyeColour { get; set; }
        public string hairColour { get; set; }
        public WandView wand { get; set; }
               
        public string patronus { get; set; }
        public bool? hogwartsStudent { get; set; }
        public bool? hogwartsStaff { get; set; }
        public string actor { get; set; }
        public bool? alive { get; set; }
        public string image { get; set; }
    }
}