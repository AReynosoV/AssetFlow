namespace AssetFlow.App.Views
{
    partial class XtraAssetEditor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.CategoryIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCategoryId = new DevExpress.XtraLayout.LayoutControlItem();
            this.PurchaseDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForPurchaseDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.StatusTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForStatus = new DevExpress.XtraLayout.LayoutControlItem();
            this.CostTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCost = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.assetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPurchaseDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CategoryIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PurchaseDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.StatusTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CostTextEdit);
            this.dataLayoutControl1.Controls.Add(this.simpleButtonGuardar);
            this.dataLayoutControl1.Controls.Add(this.simpleButtonCancelar);
            this.dataLayoutControl1.DataSource = this.assetBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2542, 232, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(298, 268);
            this.dataLayoutControl1.TabIndex = 0;
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
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForId,
            this.ItemForName,
            this.ItemForCategoryId,
            this.ItemForPurchaseDate,
            this.ItemForStatus,
            this.ItemForCost,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(278, 248);
            // 
            // IdTextEdit
            // 
            this.IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetBindingSource, "Id", true));
            this.IdTextEdit.Location = new System.Drawing.Point(111, 12);
            this.IdTextEdit.Name = "IdTextEdit";
            this.IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdTextEdit.Properties.Mask.EditMask = "N0";
            this.IdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.IdTextEdit.Properties.MaskSettings.Set("mask", "N0");
            this.IdTextEdit.Size = new System.Drawing.Size(175, 20);
            this.IdTextEdit.StyleController = this.dataLayoutControl1;
            this.IdTextEdit.TabIndex = 4;
            // 
            // ItemForId
            // 
            this.ItemForId.Control = this.IdTextEdit;
            this.ItemForId.Location = new System.Drawing.Point(0, 0);
            this.ItemForId.Name = "ItemForId";
            this.ItemForId.Size = new System.Drawing.Size(278, 24);
            this.ItemForId.Text = "Id";
            this.ItemForId.TextSize = new System.Drawing.Size(87, 13);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(111, 36);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.NameTextEdit.Size = new System.Drawing.Size(175, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 5;
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(278, 24);
            this.ItemForName.Text = "Nombre del Activo";
            this.ItemForName.TextSize = new System.Drawing.Size(87, 13);
            // 
            // CategoryIdTextEdit
            // 
            this.CategoryIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetBindingSource, "CategoryId", true));
            this.CategoryIdTextEdit.Location = new System.Drawing.Point(111, 60);
            this.CategoryIdTextEdit.Name = "CategoryIdTextEdit";
            this.CategoryIdTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.CategoryIdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CategoryIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CategoryIdTextEdit.Properties.Mask.EditMask = "N0";
            this.CategoryIdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CategoryIdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CategoryIdTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CategoryIdTextEdit.Properties.MaskSettings.Set("mask", "N0");
            this.CategoryIdTextEdit.Size = new System.Drawing.Size(175, 20);
            this.CategoryIdTextEdit.StyleController = this.dataLayoutControl1;
            this.CategoryIdTextEdit.TabIndex = 6;
            // 
            // ItemForCategoryId
            // 
            this.ItemForCategoryId.Control = this.CategoryIdTextEdit;
            this.ItemForCategoryId.Location = new System.Drawing.Point(0, 48);
            this.ItemForCategoryId.Name = "ItemForCategoryId";
            this.ItemForCategoryId.Size = new System.Drawing.Size(278, 24);
            this.ItemForCategoryId.Text = "Categoria";
            this.ItemForCategoryId.TextSize = new System.Drawing.Size(87, 13);
            // 
            // PurchaseDateDateEdit
            // 
            this.PurchaseDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetBindingSource, "PurchaseDate", true));
            this.PurchaseDateDateEdit.EditValue = null;
            this.PurchaseDateDateEdit.Location = new System.Drawing.Point(111, 84);
            this.PurchaseDateDateEdit.Name = "PurchaseDateDateEdit";
            this.PurchaseDateDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.PurchaseDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PurchaseDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PurchaseDateDateEdit.Size = new System.Drawing.Size(175, 20);
            this.PurchaseDateDateEdit.StyleController = this.dataLayoutControl1;
            this.PurchaseDateDateEdit.TabIndex = 7;
            // 
            // ItemForPurchaseDate
            // 
            this.ItemForPurchaseDate.Control = this.PurchaseDateDateEdit;
            this.ItemForPurchaseDate.Location = new System.Drawing.Point(0, 72);
            this.ItemForPurchaseDate.Name = "ItemForPurchaseDate";
            this.ItemForPurchaseDate.Size = new System.Drawing.Size(278, 24);
            this.ItemForPurchaseDate.Text = "Fecha de Compra";
            this.ItemForPurchaseDate.TextSize = new System.Drawing.Size(87, 13);
            // 
            // StatusTextEdit
            // 
            this.StatusTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetBindingSource, "Status", true));
            this.StatusTextEdit.Location = new System.Drawing.Point(111, 108);
            this.StatusTextEdit.Name = "StatusTextEdit";
            this.StatusTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.StatusTextEdit.Size = new System.Drawing.Size(175, 20);
            this.StatusTextEdit.StyleController = this.dataLayoutControl1;
            this.StatusTextEdit.TabIndex = 8;
            // 
            // ItemForStatus
            // 
            this.ItemForStatus.Control = this.StatusTextEdit;
            this.ItemForStatus.Location = new System.Drawing.Point(0, 96);
            this.ItemForStatus.Name = "ItemForStatus";
            this.ItemForStatus.Size = new System.Drawing.Size(278, 24);
            this.ItemForStatus.Text = "Estado";
            this.ItemForStatus.TextSize = new System.Drawing.Size(87, 13);
            // 
            // CostTextEdit
            // 
            this.CostTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetBindingSource, "Cost", true));
            this.CostTextEdit.Location = new System.Drawing.Point(111, 132);
            this.CostTextEdit.Name = "CostTextEdit";
            this.CostTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.CostTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.CostTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.CostTextEdit.Properties.Mask.EditMask = "G";
            this.CostTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CostTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CostTextEdit.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.CostTextEdit.Properties.MaskSettings.Set("mask", "G");
            this.CostTextEdit.Size = new System.Drawing.Size(175, 20);
            this.CostTextEdit.StyleController = this.dataLayoutControl1;
            this.CostTextEdit.TabIndex = 9;
            // 
            // ItemForCost
            // 
            this.ItemForCost.Control = this.CostTextEdit;
            this.ItemForCost.Location = new System.Drawing.Point(0, 120);
            this.ItemForCost.Name = "ItemForCost";
            this.ItemForCost.Size = new System.Drawing.Size(278, 24);
            this.ItemForCost.Text = "Costo";
            this.ItemForCost.TextSize = new System.Drawing.Size(87, 13);
            // 
            // simpleButtonGuardar
            // 
            this.simpleButtonGuardar.Location = new System.Drawing.Point(12, 156);
            this.simpleButtonGuardar.Name = "simpleButtonGuardar";
            this.simpleButtonGuardar.Size = new System.Drawing.Size(274, 22);
            this.simpleButtonGuardar.StyleController = this.dataLayoutControl1;
            this.simpleButtonGuardar.TabIndex = 10;
            this.simpleButtonGuardar.Text = "Guardar";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButtonGuardar;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(278, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // simpleButtonCancelar
            // 
            this.simpleButtonCancelar.Location = new System.Drawing.Point(12, 182);
            this.simpleButtonCancelar.Name = "simpleButtonCancelar";
            this.simpleButtonCancelar.Size = new System.Drawing.Size(274, 22);
            this.simpleButtonCancelar.StyleController = this.dataLayoutControl1;
            this.simpleButtonCancelar.TabIndex = 11;
            this.simpleButtonCancelar.Text = "Cancelar";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButtonCancelar;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 170);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(278, 78);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
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
            this.Text = "Editor de Activos";
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPurchaseDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource assetBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit IdTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit CategoryIdTextEdit;
        private DevExpress.XtraEditors.DateEdit PurchaseDateDateEdit;
        private DevExpress.XtraEditors.TextEdit StatusTextEdit;
        private DevExpress.XtraEditors.TextEdit CostTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuardar;
        private DevExpress.XtraLayout.LayoutControlItem ItemForId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategoryId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPurchaseDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStatus;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCost;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancelar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}