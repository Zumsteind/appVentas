using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Clientes
    {

        // Propiedades
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        // Constructor
        public Clientes()
        {
        }

        public Clientes(int id, string cliente, string telefono, string correo)
        {
            Id = id;
            Cliente = cliente;
            Telefono = telefono;
            Correo = correo;
        }

    }
}
