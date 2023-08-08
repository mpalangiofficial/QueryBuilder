using System;
using System.Windows.Forms;

namespace QueryBuilder
{
    public partial class GetAliasForm : Form
    {
        public string Alias { get; private set; }
        public GetAliasForm(string alias = "")
        {
            DialogResult = DialogResult.Cancel;
            InitializeComponent();
            txtAlias.Text = Alias = alias;
            txtAlias.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Alias = txtAlias.Text;
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetAliaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
