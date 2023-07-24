using System;
using System.Windows.Forms;

namespace QueryBuildersSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void queryBuilder1_DataFetched(object sender, EventArgs e)
        {
            MessageBox.Show("data fetched");
        }

    }
}
