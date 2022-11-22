using System.ComponentModel.DataAnnotations;
using System;

namespace AginteKuadroa.Models
{
    public class Salmenta
    {
        [Key]
        public string Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Zenbatekoa { get; set; }
        public string BezeroaId { get; set; }
        public virtual Bezeroa Bezeroa { get; set; }
    }
}
