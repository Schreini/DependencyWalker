using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DependencyWalker.Gui.Controller;
using DependencyWalker.Gui.Views;

namespace DependencyWalker.Gui
{
    public partial class MainForm : Form, IMainFormView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string RootAssemblyName
        {
            get { return TxtRootAssemblyName.Text; }
        }

        public string RootAssemblyPath { get { return txtFolder.Text; }}

        public MainFormController Controller { get; set; }

        public void SetDependencyTree(IList<string> dependencies)
        {
            var sb = new StringBuilder();
            foreach (var dependency in dependencies)
            {
                sb.AppendLine(dependency);
            }
            TxtOutput.Text = sb.ToString();
        }

        private void BtnLoadDependencies_Click(object sender, EventArgs e)
        {
            Controller.LoadDependencies();
        }
    }
}
