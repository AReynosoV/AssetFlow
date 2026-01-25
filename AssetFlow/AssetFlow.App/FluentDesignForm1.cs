using AssetFlow.App.Controllers;
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
        public FluentDesignForm1()
        {
            InitializeComponent();
            // Instanciamos el servicio y cargamos los datos
            var service = new AssetService();
            gridControl1.DataSource = service.GetMockAssets();
        }

        private void FluentDesignForm1_Load(object sender, EventArgs e)
        {

        }

     
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            // 1. Obtenemos el objeto seleccionado en el Grid
            Asset selected = gridView1.GetFocusedRow() as Asset;

            if (selected != null)
            {
                // 2. Creamos una instancia del editor pasando el activo
                using (var editor = new XtraAssetEditor(selected))
                {
                    // 3. Mostramos como diálogo y verificamos si se guardó
                    if (editor.ShowDialog() == DialogResult.OK)
                    {
                        // Aquí refrescaremos el Grid más adelante
                        gridControl1.RefreshDataSource();
                    }
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
                    // 3. Obtenemos la lista actual del Grid y añadimos el nuevo
                    var lista = gridControl1.DataSource as List<Asset>;
                    lista?.Add(nuevoAsset);

                    // 4. Refrescamos para que aparezca en pantalla
                    gridControl1.RefreshDataSource();
                }
            }
        }
    }
}
