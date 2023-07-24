using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QueryBuilder.DatabaseSchema;

namespace QueryBuilder
{
    public class StartTableConfig_back : UserControl
    {
        private System.Windows.Forms.Button btnSelectTable;
        private System.Windows.Forms.Button btnStartTable;
        private System.Windows.Forms.Button btnSelectedTable;
        private System.Windows.Forms.Button btnAddAlias;
        private System.Windows.Forms.Label lblAlias;
        private TableLayoutPanel tlpStartTableConfig;
        private System.Windows.Forms.ToolTip toolTipName;
        public string ConnectionString { get; set; } = "Password=ffc-pr-02;Persist Security Info=True;User ID=sa;Initial Catalog=SRU;Data Source=192.168.100.196";

        private void H_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Dock = DockStyle.Fill;
            e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds);
        }
        private void btnAddAliase_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            GetAliaseForm popupForm = new GetAliaseForm(lblAlias.Text);
            var screenCoordinates = button.PointToScreen(Point.Empty);
            popupForm.Location = new Point(screenCoordinates.X + button.Width, screenCoordinates.Y);
            if (popupForm.ShowDialog(button) == DialogResult.OK)
            {
                lblAlias.Text = popupForm.Alias;
            }
        }
        private void btnSelectTable_Click(object sender, EventArgs e)
        {
            IDataSchema dataSchema = new DataSchemaWithDatabaseSchemaReader();
            var tables = dataSchema.GetSchema(ConnectionString, null);

            var button = (Button)sender;
            SelectTableForm popupForm = new SelectTableForm(tables.ToList());
            var screenCoordinates = button.PointToScreen(Point.Empty);
            popupForm.Location = new Point(screenCoordinates.X + button.Width, screenCoordinates.Y);
            if (popupForm.ShowDialog(button) == DialogResult.OK)
            {
                btnSelectedTable.Visible = true;
                btnStartTable.Visible = false;

                //this.ToolTip.SetToolTip(this.btnSelectedTable, popupForm.SelectedTable.Name);

                btnSelectedTable.Text = popupForm.SelectedTable.Name.Substring(0, Math.Min(popupForm.SelectedTable.Name.Length, 12));
                btnSelectedTable.Tag = popupForm.SelectedTable;
            }
        }

        private void InitializeComponent()
        {
            this.tlpStartTableConfig = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlpStartTableConfig
            // 
            this.tlpStartTableConfig.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tlpStartTableConfig.ColumnCount = 2;
            this.tlpStartTableConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStartTableConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStartTableConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStartTableConfig.Location = new System.Drawing.Point(0, 0);
            this.tlpStartTableConfig.Name = "tlpStartTableConfig";
            this.tlpStartTableConfig.RowCount = 1;
            this.tlpStartTableConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStartTableConfig.Size = new System.Drawing.Size(150, 150);
            this.tlpStartTableConfig.TabIndex = 0;
            // 
            // StartTableConfig_back
            // 
            this.Controls.Add(this.tlpStartTableConfig);
            this.Name = "StartTableConfig_back";
            this.ResumeLayout(false);

        }
    }
}
