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
            this.TxtRootAssemblyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.BtnLoadDependencies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtRootAssemblyName
            // 
            this.TxtRootAssemblyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRootAssemblyName.Location = new System.Drawing.Point(98, 13);
            this.TxtRootAssemblyName.Name = "TxtRootAssemblyName";
            this.TxtRootAssemblyName.Size = new System.Drawing.Size(704, 20);
            this.TxtRootAssemblyName.TabIndex = 0;
            this.TxtRootAssemblyName.Text = "D:\\development\\DependencyWalker\\DependencyWalker.Gui\\bin\\Debug\\DependencyWalker.G" +
    "ui.exe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Root Assembly:";
            // 
            // TxtOutput
            // 
            this.TxtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOutput.Location = new System.Drawing.Point(12, 39);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.Size = new System.Drawing.Size(938, 300);
            this.TxtOutput.TabIndex = 2;
            // 
            // BtnLoadDependencies
            // 
            this.BtnLoadDependencies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadDependencies.Location = new System.Drawing.Point(808, 11);
            this.BtnLoadDependencies.Name = "BtnLoadDependencies";
            this.BtnLoadDependencies.Size = new System.Drawing.Size(142, 23);
            this.BtnLoadDependencies.TabIndex = 3;
            this.BtnLoadDependencies.Text = "Load Dependencies";
            this.BtnLoadDependencies.UseVisualStyleBackColor = true;
            this.BtnLoadDependencies.Click += new System.EventHandler(this.BtnLoadDependencies_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 351);
            this.Controls.Add(this.BtnLoadDependencies);
            this.Controls.Add(this.TxtOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRootAssemblyName);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRootAssemblyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOutput;
        private System.Windows.Forms.Button BtnLoadDependencies;

    }
}

