namespace DependencyWalker.Gui
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.TxtRootAssemblyName = new System.Windows.Forms.TextBox();
            this.BtnLoadDependencies = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.TreeOutput = new DevExpress.XtraTreeList.TreeList();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciTreeOutput = new DevExpress.XtraLayout.LayoutControlItem();
            this.LciTxtResult = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtResult = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GrdConflicts = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LciGrdConflicts = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.TreeOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciTreeOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciTxtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdConflicts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciGrdConflicts)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRootAssemblyName
            // 
            this.TxtRootAssemblyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRootAssemblyName.Location = new System.Drawing.Point(60, 36);
            this.TxtRootAssemblyName.Name = "TxtRootAssemblyName";
            this.TxtRootAssemblyName.Size = new System.Drawing.Size(813, 20);
            this.TxtRootAssemblyName.TabIndex = 1;
            this.TxtRootAssemblyName.Text = "Cluster.dll";
            // 
            // BtnLoadDependencies
            // 
            this.BtnLoadDependencies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadDependencies.Location = new System.Drawing.Point(877, 12);
            this.BtnLoadDependencies.Name = "BtnLoadDependencies";
            this.BtnLoadDependencies.Size = new System.Drawing.Size(66, 20);
            this.BtnLoadDependencies.TabIndex = 4;
            this.BtnLoadDependencies.Text = "Load Dependencies";
            this.BtnLoadDependencies.UseVisualStyleBackColor = true;
            this.BtnLoadDependencies.Click += new System.EventHandler(this.BtnLoadDependencies_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Location = new System.Drawing.Point(60, 12);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(813, 20);
            this.txtFolder.TabIndex = 0;
            this.txtFolder.Text = "G:\\Qualifood\\Cluster\\bin";
            // 
            // TreeOutput
            // 
            this.TreeOutput.Appearance.Row.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeOutput.Appearance.Row.Options.UseFont = true;
            this.TreeOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeOutput.KeyFieldName = "Id";
            this.TreeOutput.Location = new System.Drawing.Point(12, 60);
            this.TreeOutput.Name = "TreeOutput";
            this.TreeOutput.OptionsBehavior.ReadOnly = true;
            this.TreeOutput.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraTreeList.ColumnFilterPopupMode.Excel;
            this.TreeOutput.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.TreeOutput.ParentFieldName = "ParentId";
            this.TreeOutput.Size = new System.Drawing.Size(931, 187);
            this.TreeOutput.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.LciTreeOutput,
            this.LciTxtResult,
            this.LciGrdConflicts});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition2.Width = 70D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition3.Height = 50D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition4.Height = 50D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition5.Height = 100D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.layoutControlGroup1.Size = new System.Drawing.Size(955, 551);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtFolder;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(865, 24);
            this.layoutControlItem1.Text = "Path";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.BtnLoadDependencies;
            this.layoutControlItem3.Location = new System.Drawing.Point(865, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(70, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TxtRootAssemblyName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(865, 24);
            this.layoutControlItem2.Text = "Assembly";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // LciTreeOutput
            // 
            this.LciTreeOutput.Control = this.TreeOutput;
            this.LciTreeOutput.Location = new System.Drawing.Point(0, 48);
            this.LciTreeOutput.Name = "LciTreeOutput";
            this.LciTreeOutput.OptionsTableLayoutItem.ColumnSpan = 2;
            this.LciTreeOutput.OptionsTableLayoutItem.RowIndex = 2;
            this.LciTreeOutput.Size = new System.Drawing.Size(935, 191);
            this.LciTreeOutput.TextSize = new System.Drawing.Size(0, 0);
            this.LciTreeOutput.TextVisible = false;
            // 
            // LciTxtResult
            // 
            this.LciTxtResult.Control = this.TxtResult;
            this.LciTxtResult.Location = new System.Drawing.Point(0, 431);
            this.LciTxtResult.Name = "LciTxtResult";
            this.LciTxtResult.OptionsTableLayoutItem.ColumnSpan = 2;
            this.LciTxtResult.OptionsTableLayoutItem.RowIndex = 4;
            this.LciTxtResult.Size = new System.Drawing.Size(935, 100);
            this.LciTxtResult.TextSize = new System.Drawing.Size(0, 0);
            this.LciTxtResult.TextVisible = false;
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(12, 443);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(931, 96);
            this.TxtResult.StyleController = this.layoutControl1;
            this.TxtResult.TabIndex = 5;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GrdConflicts);
            this.layoutControl1.Controls.Add(this.TxtResult);
            this.layoutControl1.Controls.Add(this.TreeOutput);
            this.layoutControl1.Controls.Add(this.txtFolder);
            this.layoutControl1.Controls.Add(this.BtnLoadDependencies);
            this.layoutControl1.Controls.Add(this.TxtRootAssemblyName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1209, 180, 811, 645);
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(955, 551);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GrdConflicts
            // 
            this.GrdConflicts.Location = new System.Drawing.Point(12, 251);
            this.GrdConflicts.MainView = this.gridView1;
            this.GrdConflicts.Name = "GrdConflicts";
            this.GrdConflicts.Size = new System.Drawing.Size(931, 188);
            this.GrdConflicts.TabIndex = 6;
            this.GrdConflicts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GrdConflicts;
            this.gridView1.Name = "gridView1";
            // 
            // LciGrdConflicts
            // 
            this.LciGrdConflicts.Control = this.GrdConflicts;
            this.LciGrdConflicts.Location = new System.Drawing.Point(0, 239);
            this.LciGrdConflicts.Name = "LciGrdConflicts";
            this.LciGrdConflicts.OptionsTableLayoutItem.ColumnSpan = 2;
            this.LciGrdConflicts.OptionsTableLayoutItem.RowIndex = 3;
            this.LciGrdConflicts.Size = new System.Drawing.Size(935, 192);
            this.LciGrdConflicts.TextSize = new System.Drawing.Size(0, 0);
            this.LciGrdConflicts.TextVisible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filter:";
            // 
            // TxtFilter
            // 
            this.TxtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFilter.Location = new System.Drawing.Point(98, 65);
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(704, 20);
            this.TxtFilter.TabIndex = 6;
            this.TxtFilter.Text = "^(mscorlib|System\\\\..*)$";
            // 
            // MainForm
            // 
            this.AcceptButton = this.BtnLoadDependencies;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 551);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TreeOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciTreeOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciTxtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdConflicts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LciGrdConflicts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRootAssemblyName;
        private System.Windows.Forms.Button BtnLoadDependencies;
        private System.Windows.Forms.TextBox txtFolder;
        private DevExpress.XtraTreeList.TreeList TreeOutput;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem LciTreeOutput;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlItem LciTxtResult;
        private DevExpress.XtraEditors.MemoEdit TxtResult;
        private DevExpress.XtraGrid.GridControl GrdConflicts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem LciGrdConflicts;
    }
}

