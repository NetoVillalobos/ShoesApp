using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Business;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProducts_SP();
        }

        private void GetProducts()
        {
            List<Products> lst = ProductBL.GetProducts();
            dgvProducts.DataSource = lst.ToList();
        }

        private void GetProducts_SP()
        {
            List<JEVJ1_MuestraProductos_Result> lst = ProductBL.GetProducts_SP();
            dgvProducts.DataSource = lst.ToList();
        }

        private void GetProductById(int pId)
        {
            List<JEVJ1_BuscaProductoPorID_Result> lst = ProductBL.GetProductsById(pId);
            dgvProducts.DataSource = lst.ToList();
        }

        private void GetProductByName(string pName)
        {
            List<JEVJ1_BuscaProductoPorNombre_Result> lst = ProductBL.GetProductsByName(pName);
            dgvProducts.DataSource = lst.ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBusqueda.Text))
                {
                    MessageBox.Show("Ingresa un parámetro de búsqueda");
                }
                else
                {
                    switch (rdbId.Checked)
                    {
                        case true:
                            int id = int.Parse(txtBusqueda.Text);
                            GetProductById(id);
                            break;

                        case false:
                            string name = txtBusqueda.Text;
                            GetProductByName(name);
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingresa un parámetro numérico");
            }
            


            


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto frmNuevoProducto = new FrmNuevoProducto();
            frmNuevoProducto.ShowDialog();
        }
    }
}
