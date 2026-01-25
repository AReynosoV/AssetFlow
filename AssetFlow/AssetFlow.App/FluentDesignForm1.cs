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
    }
}
