using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookpadForm.Models
{
    public class Errezeta
    {
        [Key]
        public int Id { get; set; }
        public string Izena { get; set; }
        public string Deskribapena { get; set; }
    }
}
