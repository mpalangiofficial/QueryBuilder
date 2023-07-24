namespace QueryBuilder
{
    partial class QueryBuilder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpQueryBuilder = new System.Windows.Forms.TableLayoutPanel();
            this.tlpQueryBuilderFlow = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.joinTableConfig = new JoinTableConfig();
            this.toolTipName = new System.Windows.Forms.ToolTip(this.components);
            this.startTableConfig = new StartTableConfig();
            this.button4 = new System.Windows.Forms.Button();
            this.filterConfigTable = new FilterConfigTable();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.tlpQueryBuilder.SuspendLayout();
            this.tlpQueryBuilderFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpQueryBuilder
            // 
            this.tlpQueryBuilder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpQueryBuilder.ColumnCount = 3;
            this.tlpQueryBuilder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpQueryBuilder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpQueryBuilder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpQueryBuilder.Controls.Add(this.tlpQueryBuilderFlow, 0, 0);
            this.tlpQueryBuilder.Controls.Add(this.txtScript, 1, 0);
            this.tlpQueryBuilder.Controls.Add(this.button1, 2, 0);
            this.tlpQueryBuilder.Controls.Add(this.dgResult, 1, 1);
            this.tlpQueryBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQueryBuilder.Location = new System.Drawing.Point(0, 0);
            this.tlpQueryBuilder.Name = "tlpQueryBuilder";
            this.tlpQueryBuilder.RowCount = 3;
            this.tlpQueryBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpQueryBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQueryBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQueryBuilder.Size = new System.Drawing.Size(1051, 554);
            this.tlpQueryBuilder.TabIndex = 0;
            this.toolTipName.SetToolTip(this.tlpQueryBuilder, "rrrrr");
            this.tlpQueryBuilder.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpQueryBuilder_CellPaint);
            // 
            // tlpQueryBuilderFlow
            // 
            this.tlpQueryBuilderFlow.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tlpQueryBuilderFlow.ColumnCount = 2;
            this.tlpQueryBuilderFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpQueryBuilderFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQueryBuilderFlow.Controls.Add(this.button2, 0, 0);
            this.tlpQueryBuilderFlow.Controls.Add(this.button3, 0, 2);
            this.tlpQueryBuilderFlow.Controls.Add(this.joinTableConfig, 1, 1);
            this.tlpQueryBuilderFlow.Controls.Add(this.startTableConfig, 1, 0);
            this.tlpQueryBuilderFlow.Controls.Add(this.button4, 0, 1);
            this.tlpQueryBuilderFlow.Controls.Add(this.filterConfigTable, 1, 2);
            this.tlpQueryBuilderFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQueryBuilderFlow.Location = new System.Drawing.Point(3, 3);
            this.tlpQueryBuilderFlow.Name = "tlpQueryBuilderFlow";
            this.tlpQueryBuilderFlow.RowCount = 4;
            this.tlpQueryBuilder.SetRowSpan(this.tlpQueryBuilderFlow, 3);
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQueryBuilderFlow.Size = new System.Drawing.Size(361, 548);
            this.tlpQueryBuilderFlow.TabIndex = 1;
            this.tlpQueryBuilderFlow.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpQueryBuilderFlow_CellPaint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(8, 20);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 20, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 26);
            this.button2.TabIndex = 0;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(8, 160);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 20, 3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // joinTableConfig
            // 
            this.joinTableConfig.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.joinTableConfig.DbTables = null;
            this.joinTableConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinTableConfig.Location = new System.Drawing.Point(48, 73);
            this.joinTableConfig.Name = "joinTableConfig";
            this.joinTableConfig.Size = new System.Drawing.Size(310, 64);
            this.joinTableConfig.TabIndex = 6;
            this.joinTableConfig.ToolTip = this.toolTipName;
            this.joinTableConfig.UsedTables = null;
            this.joinTableConfig.AddedJoin += new System.EventHandler(this.joinTableConfig_AddedJoin);
            this.joinTableConfig.RemovingJoin += new System.EventHandler(this.joinTableConfig_RemovingJoin);
            // 
            // startTableConfig
            // 
            this.startTableConfig.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startTableConfig.ConnectionString = "Password=ffc-pr-02;Persist Security Info=True;User ID=sa;Initial Catalog=northwin" +
    "d;Data Source=.";
            this.startTableConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startTableConfig.Location = new System.Drawing.Point(48, 3);
            this.startTableConfig.Name = "startTableConfig";
            this.startTableConfig.Size = new System.Drawing.Size(310, 64);
            this.startTableConfig.TabIndex = 7;
            this.startTableConfig.ToolTipName = null;
            this.startTableConfig.Changed += new System.EventHandler(this.startTableConfig_Changed);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(8, 90);
            this.button4.Margin = new System.Windows.Forms.Padding(8, 20, 3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 26);
            this.button4.TabIndex = 8;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // filterConfigTable
            // 
            this.filterConfigTable.DbTables = null;
            this.filterConfigTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterConfigTable.Location = new System.Drawing.Point(48, 143);
            this.filterConfigTable.Name = "filterConfigTable";
            this.filterConfigTable.Size = new System.Drawing.Size(310, 64);
            this.filterConfigTable.TabIndex = 9;
            this.filterConfigTable.UsedTables = null;
            this.filterConfigTable.Where = null;
            this.filterConfigTable.Changed += new System.EventHandler(this.filterConfigTable_Changed);
            // 
            // txtScript
            // 
            this.txtScript.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtScript.Location = new System.Drawing.Point(370, 3);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(572, 70);
            this.txtScript.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(948, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgResult
            // 
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpQueryBuilder.SetColumnSpan(this.dgResult, 2);
            this.dgResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResult.Location = new System.Drawing.Point(370, 79);
            this.dgResult.Name = "dgResult";
            this.tlpQueryBuilder.SetRowSpan(this.dgResult, 2);
            this.dgResult.Size = new System.Drawing.Size(678, 472);
            this.dgResult.TabIndex = 4;
            // 
            // QueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpQueryBuilder);
            this.Name = "QueryBuilder";
            this.Size = new System.Drawing.Size(1051, 554);
            this.tlpQueryBuilder.ResumeLayout(false);
            this.tlpQueryBuilder.PerformLayout();
            this.tlpQueryBuilderFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpQueryBuilder;
        private System.Windows.Forms.TableLayoutPanel tlpQueryBuilderFlow;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTipName;
        private JoinTableConfig joinTableConfig;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgResult;
        private StartTableConfig startTableConfig;
        private System.Windows.Forms.Button button4;
        private FilterConfigTable filterConfigTable;
    }
}
