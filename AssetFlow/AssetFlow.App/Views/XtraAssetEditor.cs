using AssetFlow.App.Controllers;
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
        // 1. Estas son las variables que faltan (Corrige los errores CS0103)
        private Asset _currentAsset;
        private AssetService _service;
        public Asset CurrentAsset { get; set; } // Propiedad para devolver el resultado


        //Variable para mantener el objeto que editamos
        public Models.Asset SelectedAsset { get; set; }
        public XtraAssetEditor(Models.Asset asset, AssetService service)

        {
            InitializeComponent();
            this.SelectedAsset = asset;
            _currentAsset = asset;
            _service = service;

            CargarCatalogos();
            EnlazarDatos();
            //Vinculamos el objeto al BindingSource
            //assetBindingSource.DataSource = asset;
        }


        // private Asset _currentAsset;
        private AssetService _assetService; // Variable para guardar el servicio

        private void CargarCatalogos()
        {
            // 1. Asignar los datos desde el servicio (consulta a la VM)
            lookUpEditCategoria.Properties.DataSource = _service.GetCategories();
            lookUpEditEstado.Properties.DataSource = _service.GetStatuses();

            // 2. Definir qué propiedad se muestra y cuál es el ID oculto
            lookUpEditCategoria.Properties.DisplayMember = "Name"; // Lo que el usuario lee
            lookUpEditCategoria.Properties.ValueMember = "Id";     // El ID técnico

            lookUpEditEstado.Properties.DisplayMember = "Name";
            lookUpEditEstado.Properties.ValueMember = "Id";

            // 3. (Opcional) Limpiar el texto inicial si no hay selección
            lookUpEditCategoria.Properties.NullText = "[Seleccione Categoría]";
            lookUpEditEstado.Properties.NullText = "[Seleccione Estado]";
        }

        private void EnlazarDatos()
        {
            if (_currentAsset != null)
            {
                NameTextEdit.Text = _currentAsset.Name;
                // Asignamos el ID directamente al EditValue del combo
                lookUpEditCategoria.EditValue = _currentAsset.CategoryId;
                lookUpEditEstado.EditValue = _currentAsset.StatusId;

                // No olvides los campos nuevos si los tienes
                CostTextEdit.EditValue = _currentAsset.Cost;
                PurchaseDateDateEdit.DateTime = _currentAsset.PurchaseDate;
            }
        }

        private void simpleButtonGuardar_Click(object sender, EventArgs e)
        {
            // Validar todos los controles vinculados al DXValidationProvider
            if (!dxValidationProvider1.Validate())
            {
                return; // Si hay errores visuales, no hace nada y el usuario ve los iconos rojos
            }

            // Antes de que el formulario se cierre por el DialogResult...
            // Mapeamos los datos de los cuadros de texto al objeto
            CurrentAsset = new Asset
            {
                Name = NameTextEdit.Text,
                CategoryId = (int)lookUpEditCategoria.EditValue,
                StatusId = (int)lookUpEditEstado.EditValue,
                PurchaseDate = PurchaseDateDateEdit.DateTime,
                Cost = decimal.Parse(CostTextEdit.Text),
                IsDeleted = false
                
            };
            
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}