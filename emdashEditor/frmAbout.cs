using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emdashEditor
{
    public partial class frmAbout : Form
    {

        string version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown";
        T? GetAssemblyAttribute<T>() where T : Attribute => (T?)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(T));


        // Helper method
        public frmAbout()
        {
            string product = GetAssemblyAttribute<AssemblyProductAttribute>()?.Product ?? "Unknown Product";
            string company = GetAssemblyAttribute<AssemblyCompanyAttribute>()?.Company ?? "Unknown Company";
            string copyright = GetAssemblyAttribute<AssemblyCopyrightAttribute>()?.Copyright ?? "";
            string version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "Unknown Version";
            string description = GetAssemblyAttribute<AssemblyDescriptionAttribute>()?.Description ?? "No description available.";

            InitializeComponent();
            labelVersion.Text = $"Version: {version}";
            labelProduct.Text = product;
            labelCompany.Text = company;
            labelCopyright.Text = copyright;
            labelDescription.Text = description;
        }

        private void buttonClose_Click(object sender, EventArgs e) => this.Close();
    }
}
