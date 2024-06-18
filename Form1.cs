using Herencia.Clases;
using Herencia.Gestion_BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLlamarClase_Click(object sender, EventArgs e)
        {
            Animal llamaAnimal = new Animal("Oreo", 2,"N");
            MessageBox.Show("Animalito: " + llamaAnimal.nombre + " Edad: " + llamaAnimal.Edad);
            llamaAnimal.Defenderse();
            llamaAnimal.Alimentarse(1);
        }

        private void Llamar_clase_perro_Click(object sender, EventArgs e)
        {
            //manera facil cuando existe el get/set
            //Perro p = new Perro("Oreo", 2, "Pastor Aleman");
            //p.Defenderse();
            //p.Alimentarse(3);

            //agregar de manera individual los datos
            Perro p = new Perro();
            p.nombre = "Oreo";
            p.SetEdad(1); // en este caso porque la edad esta privada se llama al metodo que me agrega la edad
            p.Raza = "Pupy";
            p.Sexo = "M";
            p.Defenderse();
            p.Alimentarse(3);


            p.HacerSonido();
        }

        private void LlamarCaballo_Click(object sender, EventArgs e)
        {
            Caballo C = new Caballo("Teo", 2, "M", true);

            C.HacerSonido();


        }

        // Métodos para conectarse a la base de datos
        private void Conectar_Click(object sender, EventArgs e)
        {
            //Conexion con = new Conexion();
            //con.AbrirConexion(con.EstableceConexion());

            //con.EjecutarConsulta($"INSERT INTO CATEGORIES VALUES ({ID_Categories.Text}, '{NameCategories.Text}');");

            //MessageBox.Show("Registro exitoso!!");

            
            //dtCategorias_productos.DataSource = con.ImprimirConsulta("SELECT * FROM CATEGORIES;");
            //con.CerrarConexion(con.EstableceConexion());

            //ID_Categories.Text = "";
            //NameCategories.Text = "";


            GestionCategoria bdCategoria = new GestionCategoria();
            bdCategoria.AbrirConexion(bdCategoria.EstableceConexion());

            Categorias categoria = new Categorias();
            categoria.NombreCategory = NameCategories.Text;

            bdCategoria.RegistrarCategoria(NameCategories.Text);

            bdCategoria.CerrarConexion(bdCategoria.EstableceConexion());

            GestionCategoria gestionCat = new GestionCategoria();
            dtCategorias_productos.DataSource = gestionCat.ListaTodasCategorias();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           GestionCategoria gestionCat = new GestionCategoria();
            dtCategorias_productos.DataSource = gestionCat.ListaTodasCategorias();
        }

        private void buscarCategory_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.AbrirConexion(con.EstableceConexion());
            dtCategorias_productos.DataSource = con.ObtenerListaCategorias(ID_Categories.Text);
            con.CerrarConexion(con.EstableceConexion());

        }
    }
}
