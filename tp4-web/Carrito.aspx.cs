using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;
using Dominio;

namespace tp_web
{
    public partial class Carrito : System.Web.UI.Page
    {
<<<<<<< HEAD
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Carro> listaArticulos = itemsCarro();
            if (!IsPostBack)
            {
                repCarrito.DataSource = listaArticulos;
                repCarrito.DataBind();
            }
        }

        private List<Carro> itemsCarro()
=======
        public List<Articulos> ListaArticulos { get; set; }
        public Carro aux { get; set; }
        public string TituloVacio = "Tu carrito está vacío";
        public string TituloConContenido = "Añadiste al carrito: ";
        //public List<Carro> ListaCarrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ControladorArticulos controlador = new ControladorArticulos();
            ListaArticulos = controlador.listar();
            //ListaCarro();
            aux = (Carro)Session["Carrito"];
            Titulo.Text = TituloVacio;
            if (aux != null)
            {
                Titulo.Text = TituloConContenido;
                if (!IsPostBack)
                {
                    repRepetidor.DataSource = aux.ListaCarrito;
                    repRepetidor.DataBind();
                }
            }    
        }

        protected void Agregar_Click(object sender, ImageClickEventArgs e)
        {
            int ID = int.Parse(((ImageButton)sender).CommandArgument);
            aux.agregarCantidadItem(ID);
            aux.calcularImporte();
            Session.Add("Carrito", aux);
            repRepetidor.DataSource = aux.ListaCarrito;
            repRepetidor.DataBind();
        }

        protected void Restar_Click(object sender, ImageClickEventArgs e)
        {
            int ID = int.Parse(((ImageButton)sender).CommandArgument);
            aux.restarItemsCarroAlCarrito(ID);
            aux.calcularImporte();
            Session.Add("Carrito", aux);
            repRepetidor.DataSource = aux.ListaCarrito;
            repRepetidor.DataBind();
        }

        protected void Eliminar_Click(object sender, ImageClickEventArgs e)
        {
            int ID = int.Parse(((ImageButton)sender).CommandArgument);
            aux.eliminarItemDelCarrito(ID);
            aux.calcularImporte();
            Session.Add("Carrito", aux);
            repRepetidor.DataSource = aux.ListaCarrito;
            repRepetidor.DataBind();
        }
    }
}
/*protected void ListaCarro()
>>>>>>> 4c6d320b831d6442ef433afb58009f272dc1eb8e
        {
            List<Carro> itemsCarro = Session["listaCarrito"] != null ? (List<Carro>)Session["listaCarrito"] : new List<Carro>();

<<<<<<< HEAD
            return itemsCarro;
        }
=======
            carro.ID = Request.QueryString["id"] != null ? int.Parse(Request.QueryString["id"].ToString()) : 0;
            //carro.ID = int.Parse(Session["id"].ToString());
>>>>>>> 4c6d320b831d6442ef433afb58009f272dc1eb8e

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = new int();

            int id = int.Parse(((Button)sender).CommandArgument);
            List<Carro> listaCarro = itemsCarro();

            foreach (var item in listaCarro)
            {
                if (item.ID == id)
                {
                    index = listaCarro.IndexOf(item);
                }
            }
<<<<<<< HEAD

            listaCarro.RemoveAt(index);
            repCarrito.DataSource = listaCarro;
            repCarrito.DataBind();
        }
    }
}
=======
            ListaCarrito = lista;
        }*/
>>>>>>> 4c6d320b831d6442ef433afb58009f272dc1eb8e
