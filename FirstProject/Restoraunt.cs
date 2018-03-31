using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Restoraunt
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Human> Owner;
        public Kitchen Kitchen { get; set; }
        public List<Hall> Halls;
        public Bar Bar { get; set; }
    }

   
}
