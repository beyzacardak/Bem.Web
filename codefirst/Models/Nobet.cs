﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codefirst.Models
{
    public class Nobet
    {
        public int Id { get; set; }
        public List<Doktorlar> doktor { get; set; }

    }
}