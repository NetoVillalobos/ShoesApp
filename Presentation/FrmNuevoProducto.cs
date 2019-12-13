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
    public partial class FrmNuevoProducto : Form
    {
        //Párametro constructor
        public int? id;

        public FrmNuevoProducto(int? id = null)
        {
            InitializeComponent();

            this.id = id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guardo los parámetros
            int pIdType = int.Parse(cmbIdType.Text);
            int pIdColor = int.Parse(cmbIdColor.Text);
            int pIdBrand = int.Parse(cmbIdBrand.Text);
            int pIdProvider = int.Parse(cmbIdProvider.Text);
            int pIdCatalog = int.Parse(cmbIdCatalog.Text);
            string pTitle = txtTitle.Text;
            string pName = txtNombre.Text;
            string pDescription = txtDescription.Text;
            string pObservations = txtObservations.Text;
            decimal pPriceDistributor = decimal.Parse(txtPriceDistributor.Text);
            decimal pPriceClient = decimal.Parse(txtPriceClient.Text);
            decimal pPriceMember = decimal.Parse(txtPriceMember.Text);
            bool pIsEnabled = chbIsEnabled.Checked ? true : false;
            string pKeywords = txtKeywords.Text;
            DateTime pDateUpdate = dtpDateUpdate.Value;

            if (id == null)
            {
                //Llamo al método insert
                InsertProduct(pIdType, pIdColor, pIdBrand, pIdProvider, pIdCatalog, pTitle, pName, pDescription, pObservations, pPriceDistributor, pPriceClient, pPriceMember, pIsEnabled, pKeywords, pDateUpdate);
            }
            else
            {
                int pId = (int)id;
                UpdateProduct(pId, pIdType, pIdColor, pIdBrand, pIdProvider, pIdCatalog, pTitle, pName, pDescription, pObservations, pPriceDistributor, pPriceClient, pPriceMember, pIsEnabled, pKeywords, pDateUpdate);
            }
            
            
            

            
        }

        private void InsertProduct(int pIdType, int pIdColor, int pIdBrand, int pIdProvider, int pIdCatalog, string pTitle, string pName, string pDescription, string pObservations, decimal pPriceDistributor, decimal pPriceClient, decimal pPriceMember, bool pIsEnabled, string pKeywords, DateTime pDateUpdate)
        {
            ProductBL obj = new ProductBL();
            obj.InsertProduct(pIdType, pIdColor, pIdBrand, pIdProvider, pIdCatalog, pTitle, pName, pDescription, pObservations, pPriceDistributor, pPriceClient, pPriceMember, pIsEnabled, pKeywords, pDateUpdate);
        }


        private void UpdateProduct(int pId, int pIdType, int pIdColor, int pIdBrand, int pIdProvider, int pIdCatalog, string pTitle, string pName, string pDescription, string pObservations, decimal pPriceDistributor, decimal pPriceClient, decimal pPriceMember, bool pIsEnabled, string pKeywords, DateTime pDateUpdate)
        {
            ProductBL obj = new ProductBL();
            obj.UpdateProduct(pId, pIdType, pIdColor, pIdBrand, pIdProvider, pIdCatalog, pTitle, pName, pDescription, pObservations, pPriceDistributor, pPriceClient, pPriceMember, pIsEnabled, pKeywords, pDateUpdate);
        }

        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {
            //CARGA DE COMBO BOX
            //IdType
            using(DataProductsEntities db = new DataProductsEntities())
            {
                //Consultas los id's
                var idTypes = from t in db.CatTypeProducts
                              select t.IdType;

                //Los cargas al combo box
                foreach (var item in idTypes)
                {
                    cmbIdType.Items.Add(item);
                }
            }

            //IdColor
            using (DataProductsEntities db = new DataProductsEntities())
            {
                //Consultas los colores
                var idColors = from c in db.CatColors
                              select c.IdColor;

                //Los cargas al combo box
                foreach (var item in idColors)
                {
                    cmbIdColor.Items.Add(item);
                }
            }

            //IdBrand
            using (DataProductsEntities db = new DataProductsEntities())
            {
                //Consultas las brands
                var idBrands = from b in db.CatBrands
                              select b.IdBrand;

                //Los cargas al combo box
                foreach (var item in idBrands)
                {
                    cmbIdBrand.Items.Add(item);
                }
            }

            //IdProvider
            using (DataProductsEntities db = new DataProductsEntities())
            {
                //Consultas los providers
                var idProviders = from p in db.CatProviders
                              select p.IdProvider;

                //Los cargas al combo box
                foreach (var item in idProviders)
                {
                    cmbIdProvider.Items.Add(item);
                }
            }

            //IdCatalog
            using (DataProductsEntities db = new DataProductsEntities())
            {
                //Consultas los catalogos
                var idCatalogs = from c in db.CatCatalogs
                              select c.IdCatalog;

                //Los cargas al combo box
                foreach (var item in idCatalogs)
                {
                    cmbIdCatalog.Items.Add(item);
                }
            }


            //Editar
            if(id != null)
            {
                GetProductById((int)id);
            }
            
            
        }

        private void GetProductById(int pId)
        {
            List<JEVJ1_BuscaProductoPorID_Result> lst = ProductBL.GetProductsById(pId);
            foreach (var item in lst.ToList())
            {
                try
                {
                    cmbIdType.Text = item.IdType.ToString();
                    cmbIdColor.Text = item.IdColor.ToString();
                    cmbIdBrand.Text = item.IdBrand.ToString();
                    cmbIdProvider.Text = item.IdProvider.ToString();
                    cmbIdCatalog.Text = item.IdCatalog.ToString();
                    txtTitle.Text = item.Title;
                    txtNombre.Text = item.Nombre;
                    txtDescription.Text = item.Description;
                    txtObservations.Text = item.Observations;
                    txtPriceDistributor.Text = item.PriceDistributor.ToString();
                    txtPriceClient.Text = item.PriceClient.ToString();
                    txtPriceMember.Text = item.PriceMember.ToString();
                    chbIsEnabled.Checked = item.IsEnabled;
                    txtKeywords.Text = item.Keywords;
                    dtpDateUpdate.Value = item.DateUpdate.Value;
                }
                catch (Exception)
                {

                }
                
                
            }
        }
    }
}
