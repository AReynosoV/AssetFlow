using AssetFlow.App.Models;
using AssetFlow.App.Controllers; // Asegúrate de que aquí estén tus servicios
using System;
using System.Windows.Forms;

namespace AssetFlow.App.Views
{
    public partial class XtraAssetEditor : DevExpress.XtraEditors.XtraForm
    {
        // 1. Únicas variables necesarias
        private readonly AssetService _service;
        public Asset CurrentAsset { get; set; }

        // 2. Un solo constructor maestro para Nuevo y Editar
        public XtraAssetEditor(AssetService service, Asset asset = null)
        {
            InitializeComponent();
            _service = service; // Recibimos el servicio del formulario principal

            CargarCatalogos();

            if (asset != null)
            {
                //CurrentAsset = asset;
                this.CurrentAsset = asset;
                MapearObjetoAControles();
            }
            else
            {
                // Si es nuevo, inicializamos un objeto vacío
                CurrentAsset = new Asset { PurchaseDate = DateTime.Now };
            }
        }

        private void CargarCatalogos()
        {
            var categorias = _service.GetCategories();
            var estados = _service.GetStatuses();

            // DEBUG: Si esto lanza un mensaje, la base de datos está vacía o desconectada
            if (categorias.Count == 0)
            {
                Console.WriteLine("ADVERTENCIA: No se recuperaron categorías de SQL Server.");
            }

            lookUpEditCategoria.Properties.DataSource = categorias;
            lookUpEditCategoria.Properties.DisplayMember = "Name"; // Debe coincidir con la clase Category
            lookUpEditCategoria.Properties.ValueMember = "Id";

            lookUpEditEstado.Properties.DataSource = estados;
            lookUpEditEstado.Properties.DisplayMember = "Name"; // Debe coincidir con la clase Status
            lookUpEditEstado.Properties.ValueMember = "Id";

            lookUpEditCategoria.Properties.ForceInitialize();
            lookUpEditEstado.Properties.ForceInitialize();
        }

        private void MapearObjetoAControles()
        {
            if (CurrentAsset == null) return;

            NameTextEdit.Text = CurrentAsset.Name;
            PurchaseDateDateEdit.DateTime = CurrentAsset.PurchaseDate;
            CostTextEdit.EditValue = CurrentAsset.Cost;

            // Para los combos, asignamos el ID al EditValue
            lookUpEditCategoria.EditValue = CurrentAsset.CategoryId;
            lookUpEditEstado.EditValue = CurrentAsset.StatusId;
        }

        private void simpleButtonGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validar reglas (Issue #13)
            if (!dxValidationProvider1.Validate()) return;

            // 2. Mapear de regreso al objeto
            CurrentAsset.Name = NameTextEdit.Text;
            CurrentAsset.CategoryId = (int)lookUpEditCategoria.EditValue;
            CurrentAsset.StatusId = (int)lookUpEditEstado.EditValue;
            CurrentAsset.PurchaseDate = PurchaseDateDateEdit.DateTime;
            CurrentAsset.Cost = Convert.ToDecimal(CostTextEdit.EditValue);
            CurrentAsset.IsDeleted = false;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}