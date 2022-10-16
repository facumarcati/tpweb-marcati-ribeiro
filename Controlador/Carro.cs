using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Controlador
{
    public class Carro
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Importe { get; set; }

        public int CantidadItems { get; set; }

        public List<ItemsCarro> ListaCarrito {get; set;}

        public Carro()
        {
            ListaCarrito = new List<ItemsCarro>();
            Importe = 0;
            CantidadItems = 0;
        }

        public int posicionDelItem(int ID)
        {
            int pos = ListaCarrito.FindIndex(x => x.ID == ID);
            return pos;
        }
        public void agregarItemsCarroAlCarrito(ItemsCarro item)
        {
            int pos = posicionDelItem(item.ID);
            if (pos == -1)
                ListaCarrito.Add(item);
            else ListaCarrito[pos].sumarCantidad();
        }
    }
}
