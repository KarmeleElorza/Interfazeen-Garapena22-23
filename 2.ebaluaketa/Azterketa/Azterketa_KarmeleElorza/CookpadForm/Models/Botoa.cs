﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CookpadForm.Models
{
    public class Botoa
    {
        [Key]
        public int Id { get; set; }
        public string ErabiltzaileaId { get; set; }
        public int ErrezetaId { get; set; }
        public string Urtea { get; set; }
        public string Komentarioa { get; set; }

        public virtual Errezeta Errezeta { get; set; }
        //public virtual Erabiltzailea ErabiltzaileBat { get; set; }

    }
}
