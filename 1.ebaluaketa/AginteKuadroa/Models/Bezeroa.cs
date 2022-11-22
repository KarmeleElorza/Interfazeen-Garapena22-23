using AginteKuadroa.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AginteKuadroa.Models
{
    public class Bezeroa
    {
        [Key]
        public string Id { get; set; }
        public string Izena { get; set; }
        public string Helbidea { get; set; }
        public string Telf { get; set; }
        public string Emaila { get; set; }
        public string SaltzaileaId { get; set; }
        public virtual Saltzailea Saltzailea { get; set; }
        public virtual List<Salmenta> Salmenta { get; set; }
    }
}