using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace entidades
{
     public  class Ventasitems

    {
        public int id { get; set; }
        public Ventas idventas { get; set; }
        public Producto idproducto { get; set; }
        public float preciounitario { get; set; }
        public float cantidad { get; set; }
        public float preciototal
        {
            get { return preciounitario * cantidad; }
        }

        public Ventasitems() { }

        public Ventasitems(int id, Ventas idventas, Producto idproducto, float preciounitario, float cantidad)
        {
            this.id = id;
            this.idventas = idventas;
            this.idproducto = idproducto;
            this.preciounitario = preciounitario;
            this.cantidad = cantidad;
        }



    }
}
