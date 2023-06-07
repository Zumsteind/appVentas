using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Ventas
    {


        public int id { get; set; }
        public Clientes idcliente { get; set; }
        public DateTime fecha { get; set; }
        public float total { get; set; }

        public  Ventas() { }

        public Ventas(int id, Clientes idcliente, DateTime fecha, float total)
        {
            this.id = id;
            this.idcliente = idcliente;
            this.fecha = fecha;
            this.total = total;
        }
    }
}
