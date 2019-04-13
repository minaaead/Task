using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Entity
{
    public class Product
    {
        public int ID  { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public float Price { get; set; }
        public DateTime LastUpdated { get; set; }

    }
}
