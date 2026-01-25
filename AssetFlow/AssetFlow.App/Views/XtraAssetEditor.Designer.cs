namespace AssetFlow.App.Views
{
    partial class XtraAssetEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CategoryIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PurchaseDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.StatusTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CostTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCategoryId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPurchaseDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCost = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.assetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPurchaseDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.DataSource = this.assetBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(298, 268);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(298, 268);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(278, 248);
            // 
            // assetBindingSource
            // 
            this.assetBindingSource.DataSource = typeof(AssetFlow.App.Models.Asset);
            // 
            // XtraAssetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "XtraAssetEditor";
            this.Text = "XtraAssetEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource assetBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    }
}