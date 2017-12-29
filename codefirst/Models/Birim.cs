using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codefirst.Models
{
    public class Birim
    {
        public int Id { get; set; }
        public string name { get; set; }
        public List<Doktorlar> Doktorlar { get; set; }
        
    }
}