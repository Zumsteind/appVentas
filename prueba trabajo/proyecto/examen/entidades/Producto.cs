using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Producto
    {
        // Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public string Categoria { get; set; }

        // Constructor
        public Producto()
        {
        }

        public Producto(int id, string nombre, float precio, string categoria)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }
    }
}
