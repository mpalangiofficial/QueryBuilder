using System;
using System.Windows.Forms;

namespace QueryBuilder
{
    public class FarineLayout : UserControl
    {
        private TableLayoutPanel tableLayoutPanel1;

        public FarineLayout()
        {
            InitializeComponent();
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.ColumnCount = 1;
            Button btn = new Button();
            btn.Click += new EventHandler((sender,e) =>
            {
                btn.Text = "End to end";
            });
            this.tableLayoutPanel1.RowStyles.Clear();
            this.tableLayoutPanel1.ColumnStyles.Clear();
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            btn.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Controls.Add(btn,0,0);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(389, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FarineLayout
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FarineLayout";
            this.Size = new System.Drawing.Size(389, 150);
            this.ResumeLayout(false);

        }
    }
}
