using AssetFlow.App.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static DevExpress.Utils.Filtering.ExcelFilterOptions;

namespace AssetFlow.App.Views
{
    public partial class XtraAssetEditor : DevExpress.XtraEditors.XtraForm
    {
        //Variable para mantener el objeto que editamos
        public Models.Asset SelectedAsset { get; set; }
        public XtraAssetEditor(Models.Asset asset)

        {
            InitializeComponent();
            this.SelectedAsset = asset;

            //Vinculamos el objeto al BindingSource
            assetBindingSource.DataSource = asset;
        }
        public Asset CurrentAsset { get; set; }
        private void simpleButtonGuardar_Click(object sender, EventArgs e)
        {
            // Antes de que el formulario se cierre por el DialogResult...
            // Mapeamos los datos de los cuadros de texto al objeto
            CurrentAsset = new Asset
            {
                Name = NameTextEdit.Text,
                CategoryId = int.Parse(CategoryIdTextEdit.Text),
                PurchaseDate = PurchaseDateDateEdit.DateTime,
                Status = StatusTextEdit.Text,
                Cost = decimal.Parse(CostTextEdit.Text)

                // ... el resto de tus campos ...
            };

            // El DialogResult = OK hará el resto
        }
    }
}