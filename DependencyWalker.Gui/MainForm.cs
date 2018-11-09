using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DependencyWalker.Gui.Controller;
using DependencyWalker.Gui.Services;
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

        public void SetDependencyTree2(IList<DependencyItem> dependencies)
        {
            TreeOutput.DataSource = dependencies;
            var distinct = dependencies.Distinct().ToList();
            List<DependencyItem> conflicts = new  List<DependencyItem>();
            foreach (var di in distinct)
            {
                if (distinct.Count(d => d.Name == di.Name) > 1)
                    conflicts.Add(di);
            }

            GrdConflicts.DataSource = conflicts;

            TreeOutput.ExpandAll();
        }

        public void SetResult(string result)
        {
            TxtResult.Text = result;
        }

        private void BtnLoadDependencies_Click(object sender, EventArgs e)
        {
            Controller.LoadDependencies();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Controller.LoadDependencies();
        }
    }
}
