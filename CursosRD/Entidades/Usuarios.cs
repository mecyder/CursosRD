using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Usuarios
    {
        public string Name { get; set; }
        public string Pass { get; set; }
        public string User { get; set; }
        public DateTime Created { get; set; }
        public Boolean? State { get; set; }

    }
}
