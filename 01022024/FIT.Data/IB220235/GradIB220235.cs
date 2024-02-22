﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220235
{
    public class GradIB220235
    {
        public int Id { get; set; }
        public string Naziv {  get; set; }
        public bool Status { get; set; }

        public int DrzavaId { get; set; }
        public DrzavaIB220235 Drzava { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
