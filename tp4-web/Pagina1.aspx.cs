using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;
using Dominio;

namespace tp_web
{
    public partial class Pagina1 : System.Web.UI.Page
    {
<<<<<<< HEAD
=======
        public Carro Carrito { get; set; }
>>>>>>> 4c6d320b831d6442ef433afb58009f272dc1eb8e
        public List<Articulos> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ControladorArticulos controlador = new ControladorArticulos();
            ListaArticulos = controlador.listar();

            if (!IsPostBack)
            {
                repRepetidor.DataSource = ListaArticulos;
                repRepetidor.DataBind();
            }
        }

        protected void btnCarrito_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Carro carro = new Carro();
            ControladorArticulos controlador = new ControladorArticulos();
            ListaArticulos = controlador.listar();
            
            int id = int.Parse(((Button)sender).CommandArgument);

            foreach (var item in ListaArticulos)
            {
                if (item.ID == id)
                {
                    carro.ID = item.ID;
                    carro.Nombre = item.Nombre;
                    carro.Precio = item.Precio;
                }
            }

            List<Carro> listaCarro = itemsCarro();
            listaCarro.Add(carro);
            Session.Add("listaCarrito", listaCarro);
            
            //Response.Redirect("Carrito.aspx", false);
        }

        private List<Carro> itemsCarro()
        {
            List<Carro> itemsCarro = Session["listaCarrito"] != null ? (List<Carro>)Session["listaCarrito"] : new List<Carro>();

            return itemsCarro;
=======
            //https://stackoverflow.com/questions/2389258/passing-multiple-argument-through-commandargument-of-button-in-asp-net
           
            String[] arg = new String[4];
            arg = ((Button)sender).CommandArgument.Split(new char[] { ';' });
            ItemsCarro nuevoCarrito = new ItemsCarro(int.Parse(arg[0]), arg[1], Convert.ToDecimal(arg[2]), arg[3]);
            Carrito = (Carro)Session["Carrito"];

            if (Carrito == null)
                Carrito = new Carro();
            Carrito.agregarItemsCarroAlCarrito(nuevoCarrito);

            Session.Add("Carrito", Carrito);
>>>>>>> 4c6d320b831d6442ef433afb58009f272dc1eb8e
        }

    }
}