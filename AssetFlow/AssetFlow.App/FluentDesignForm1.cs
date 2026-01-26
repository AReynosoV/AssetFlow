using AssetFlow.App.Controllers;
using AssetFlow.App.Data;
using AssetFlow.App.Models;
using AssetFlow.App.Views;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace AssetFlow.App
{

    public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private AssetService _assetService;
        private AssetDbContext _context;
        public FluentDesignForm1()
        {
            InitializeComponent();
            //// Instanciamos el servicio y cargamos los datos
            //var service = new AssetService();
            //gridControl1.DataSource = service.GetMockAssets();

            // 1. Instanciamos el contexto (usará la configuración que pusimos en OnConfiguring)
            // Nota: Para EF 3.1 en WinForms, esto es suficiente por ahora.
            _context = new AssetDbContext(new Microsoft.EntityFrameworkCore.DbContextOptions<AssetDbContext>());

            // 2. Pasamos el contexto al servicio
            _assetService = new AssetService(_context);

            LoadData();

        }

        private void FluentDesignForm1_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                // Llamamos al servicio que ahora consulta a SQL Server
                var assets = _assetService.GetAllAssets();

                // Asignamos la lista al GridControl de DevExpress
                gridControl1.DataSource = assets;
            }
            catch (Exception ex)
            {
                // Si hay un error de red con la VM, lo sabremos aquí
                MessageBox.Show($"Error al conectar con SQL Server: {ex.Message}",
                                "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            // 1. Obtenemos el objeto seleccionado en el Grid
            //Asset selected = gridView1.GetFocusedRow() as Asset;
            var selectedAsset = gridView1.GetFocusedRow() as Asset;

            if (selectedAsset != null)
            {
                // 2. Creamos una instancia del editor pasando el activo
                using (var editor = new XtraAssetEditor(selectedAsset))
                {
                    // 3. Mostramos como diálogo y verificamos si se guardó
                    if (editor.ShowDialog() == DialogResult.OK)
                    {
                        // 3. LLAMADA AL SERVICIO PARA ACTUALIZAR (El paso faltante)
                        _assetService.UpdateAsset(selectedAsset);

                        // Aquí refrescaremos el Grid más adelante
                        gridControl1.RefreshDataSource();

                        LoadData();
                    }
                }
            }
        }

        private void PerformDelete()
        {
            var selectedAsset = gridView1.GetFocusedRow() as Asset;

            if (selectedAsset != null)
            {
                var result = MessageBox.Show($"¿Está seguro que desea eliminar el activo: {selectedAsset.Name}?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _assetService.SoftDeleteAsset(selectedAsset);
                    LoadData(); // Recargamos el grid, el registro "desaparecerá"
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // 1. Creamos un objeto Asset nuevo (vacío)
            var nuevoAsset = new Asset
            {
                PurchaseDate = DateTime.Now,
                Status = "Nuevo"
            };

            // 2. Abrimos el editor (pasando el objeto vacío)
            using (var editor = new XtraAssetEditor(nuevoAsset))
            {
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    // 1. Obtenemos el objeto que el usuario llenó en el editor
                    var newAsset = editor.CurrentAsset;

                    // 2. LLAMADA REAL AL SERVICIO (Esto es lo que faltaba)
                    _assetService.AddAsset(newAsset);

                    // 3. Refrescar el Grid para ver el nuevo ID generado por la VM
                    LoadData();

                    //// 3. Obtenemos la lista actual del Grid y añadimos el nuevo
                    //var lista = gridControl1.DataSource as List<Asset>;
                    //lista?.Add(nuevoAsset);

                    //// 4. Refrescamos para que aparezca en pantalla
                    //gridControl1.RefreshDataSource();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PerformDelete();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                PerformDelete();
            }
        }
    }
}
