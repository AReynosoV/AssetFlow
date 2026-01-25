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
    }
}