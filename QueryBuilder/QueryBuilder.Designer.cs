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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tlpQueryBuilder = new System.Windows.Forms.TableLayoutPanel();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.tlpQueryBuilderFlow = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.joinTableConfig = new JoinTableConfig();
            this.toolTipName = new System.Windows.Forms.ToolTip(this.components);
            this.startTableConfig = new StartTableConfig();
            this.button4 = new System.Windows.Forms.Button();
            this.filterConfigTable = new FilterConfigTable();
            this.selectConfig = new SelectConfig();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.sortConfig = new SortConfig();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblChartType = new System.Windows.Forms.Label();
            this.lblXValueMember = new System.Windows.Forms.Label();
            this.lblYValueMember = new System.Windows.Forms.Label();
            this.cmbChartTypes = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbXValueMember = new System.Windows.Forms.ComboBox();
            this.cmbYValueMember = new System.Windows.Forms.ComboBox();
            this.btnRefreshChart = new System.Windows.Forms.Button();
            this.tlpQueryBuilder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.scrollPanel.SuspendLayout();
            this.tlpQueryBuilderFlow.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpQueryBuilder
            // 
            this.tlpQueryBuilder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpQueryBuilder.ColumnCount = 3;
            this.tlpQueryBuilder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpQueryBuilder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlpQueryBuilder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpQueryBuilder.Controls.Add(this.txtScript, 1, 0);
            this.tlpQueryBuilder.Controls.Add(this.btnRun, 2, 0);
            this.tlpQueryBuilder.Controls.Add(this.dgResult, 1, 1);
            this.tlpQueryBuilder.Controls.Add(this.scrollPanel, 0, 0);
            this.tlpQueryBuilder.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tlpQueryBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQueryBuilder.Location = new System.Drawing.Point(0, 0);
            this.tlpQueryBuilder.Name = "tlpQueryBuilder";
            this.tlpQueryBuilder.RowCount = 3;
            this.tlpQueryBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpQueryBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQueryBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpQueryBuilder.Size = new System.Drawing.Size(1442, 554);
            this.tlpQueryBuilder.TabIndex = 0;
            this.toolTipName.SetToolTip(this.tlpQueryBuilder, "rrrrr");
            this.tlpQueryBuilder.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpQueryBuilder_CellPaint);
            // 
            // txtScript
            // 
            this.txtScript.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtScript.Location = new System.Drawing.Point(466, 3);
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(921, 70);
            this.txtScript.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRun.Location = new System.Drawing.Point(1393, 14);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 14, 3, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(45, 45);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // dgResult
            // 
            this.dgResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpQueryBuilder.SetColumnSpan(this.dgResult, 2);
            this.dgResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResult.Location = new System.Drawing.Point(466, 79);
            this.dgResult.Name = "dgResult";
            this.dgResult.Size = new System.Drawing.Size(973, 233);
            this.dgResult.TabIndex = 4;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scrollPanel.Controls.Add(this.tlpQueryBuilderFlow);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(3, 3);
            this.scrollPanel.Name = "scrollPanel";
            this.tlpQueryBuilder.SetRowSpan(this.scrollPanel, 3);
            this.scrollPanel.Size = new System.Drawing.Size(457, 548);
            this.scrollPanel.TabIndex = 5;
            // 
            // tlpQueryBuilderFlow
            // 
            this.tlpQueryBuilderFlow.AutoSize = true;
            this.tlpQueryBuilderFlow.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tlpQueryBuilderFlow.ColumnCount = 2;
            this.tlpQueryBuilderFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpQueryBuilderFlow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQueryBuilderFlow.Controls.Add(this.button1, 0, 3);
            this.tlpQueryBuilderFlow.Controls.Add(this.button2, 0, 0);
            this.tlpQueryBuilderFlow.Controls.Add(this.button3, 0, 2);
            this.tlpQueryBuilderFlow.Controls.Add(this.joinTableConfig, 1, 1);
            this.tlpQueryBuilderFlow.Controls.Add(this.startTableConfig, 1, 0);
            this.tlpQueryBuilderFlow.Controls.Add(this.button4, 0, 1);
            this.tlpQueryBuilderFlow.Controls.Add(this.filterConfigTable, 1, 2);
            this.tlpQueryBuilderFlow.Controls.Add(this.selectConfig, 1, 3);
            this.tlpQueryBuilderFlow.Controls.Add(this.button5, 0, 4);
            this.tlpQueryBuilderFlow.Controls.Add(this.button6, 0, 5);
            this.tlpQueryBuilderFlow.Controls.Add(this.button7, 0, 6);
            this.tlpQueryBuilderFlow.Controls.Add(this.button8, 0, 7);
            this.tlpQueryBuilderFlow.Controls.Add(this.sortConfig, 1, 4);
            this.tlpQueryBuilderFlow.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpQueryBuilderFlow.Location = new System.Drawing.Point(0, 0);
            this.tlpQueryBuilderFlow.Name = "tlpQueryBuilderFlow";
            this.tlpQueryBuilderFlow.RowCount = 9;
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpQueryBuilderFlow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQueryBuilderFlow.Size = new System.Drawing.Size(457, 440);
            this.tlpQueryBuilderFlow.TabIndex = 1;
            this.tlpQueryBuilderFlow.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpQueryBuilderFlow_CellPaint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 20, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "4";
            this.button1.UseVisualStyleBackColor = false;
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
            this.button3.Location = new System.Drawing.Point(8, 130);
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
            this.joinTableConfig.Location = new System.Drawing.Point(48, 58);
            this.joinTableConfig.Name = "joinTableConfig";
            this.joinTableConfig.Size = new System.Drawing.Size(406, 49);
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
            this.startTableConfig.Size = new System.Drawing.Size(406, 49);
            this.startTableConfig.TabIndex = 7;
            this.startTableConfig.ToolTipName = null;
            this.startTableConfig.Changed += new System.EventHandler(this.startTableConfig_Changed);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(8, 75);
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
            this.filterConfigTable.Location = new System.Drawing.Point(48, 113);
            this.filterConfigTable.Name = "filterConfigTable";
            this.filterConfigTable.Size = new System.Drawing.Size(406, 49);
            this.filterConfigTable.TabIndex = 9;
            this.filterConfigTable.UsedTables = null;
            this.filterConfigTable.Where = null;
            this.filterConfigTable.Changed += new System.EventHandler(this.filterConfigTable_Changed);
            // 
            // selectConfig
            // 
            this.selectConfig.DbTables = null;
            this.selectConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectConfig.Location = new System.Drawing.Point(48, 168);
            this.selectConfig.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.selectConfig.Name = "selectConfig";
            this.selectConfig.SelectedFields = null;
            this.selectConfig.Size = new System.Drawing.Size(399, 49);
            this.selectConfig.TabIndex = 10;
            this.selectConfig.ToolTip = null;
            this.selectConfig.UsedTables = null;
            this.selectConfig.Changed += new System.EventHandler(this.selectConfig_Changed);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(8, 240);
            this.button5.Margin = new System.Windows.Forms.Padding(8, 20, 3, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 26);
            this.button5.TabIndex = 11;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(8, 295);
            this.button6.Margin = new System.Windows.Forms.Padding(8, 20, 3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 26);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(8, 350);
            this.button7.Margin = new System.Windows.Forms.Padding(8, 20, 3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 26);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(8, 405);
            this.button8.Margin = new System.Windows.Forms.Padding(8, 20, 3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(27, 26);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // sortConfig
            // 
            this.sortConfig.DbTables = null;
            this.sortConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortConfig.Location = new System.Drawing.Point(48, 223);
            this.sortConfig.Name = "sortConfig";
            this.sortConfig.SelectedFields = null;
            this.sortConfig.Size = new System.Drawing.Size(406, 49);
            this.sortConfig.TabIndex = 12;
            this.sortConfig.ToolTip = null;
            this.sortConfig.UsedTables = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblChartType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblXValueMember, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYValueMember, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbChartTypes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbXValueMember, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbYValueMember, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRefreshChart, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(466, 318);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(921, 233);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblChartType
            // 
            this.lblChartType.AutoSize = true;
            this.lblChartType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChartType.Location = new System.Drawing.Point(3, 0);
            this.lblChartType.Name = "lblChartType";
            this.lblChartType.Size = new System.Drawing.Size(58, 27);
            this.lblChartType.TabIndex = 0;
            this.lblChartType.Text = "Chart type:";
            this.lblChartType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblXValueMember
            // 
            this.lblXValueMember.AutoSize = true;
            this.lblXValueMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblXValueMember.Location = new System.Drawing.Point(3, 27);
            this.lblXValueMember.Name = "lblXValueMember";
            this.lblXValueMember.Size = new System.Drawing.Size(58, 27);
            this.lblXValueMember.TabIndex = 1;
            this.lblXValueMember.Text = "X Value:";
            this.lblXValueMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYValueMember
            // 
            this.lblYValueMember.AutoSize = true;
            this.lblYValueMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYValueMember.Location = new System.Drawing.Point(3, 54);
            this.lblYValueMember.Name = "lblYValueMember";
            this.lblYValueMember.Size = new System.Drawing.Size(58, 27);
            this.lblYValueMember.TabIndex = 2;
            this.lblYValueMember.Text = "Y Value:";
            this.lblYValueMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbChartTypes
            // 
            this.cmbChartTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChartTypes.FormattingEnabled = true;
            this.cmbChartTypes.Location = new System.Drawing.Point(67, 3);
            this.cmbChartTypes.Name = "cmbChartTypes";
            this.cmbChartTypes.Size = new System.Drawing.Size(178, 21);
            this.cmbChartTypes.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(251, 3);
            this.chart1.Name = "chart1";
            this.tableLayoutPanel1.SetRowSpan(this.chart1, 5);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(667, 227);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // cmbXValueMember
            // 
            this.cmbXValueMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXValueMember.FormattingEnabled = true;
            this.cmbXValueMember.Location = new System.Drawing.Point(67, 30);
            this.cmbXValueMember.Name = "cmbXValueMember";
            this.cmbXValueMember.Size = new System.Drawing.Size(178, 21);
            this.cmbXValueMember.TabIndex = 3;
            // 
            // cmbYValueMember
            // 
            this.cmbYValueMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYValueMember.FormattingEnabled = true;
            this.cmbYValueMember.Location = new System.Drawing.Point(67, 57);
            this.cmbYValueMember.Name = "cmbYValueMember";
            this.cmbYValueMember.Size = new System.Drawing.Size(178, 21);
            this.cmbYValueMember.TabIndex = 3;
            // 
            // btnRefreshChart
            // 
            this.btnRefreshChart.Location = new System.Drawing.Point(67, 84);
            this.btnRefreshChart.Name = "btnRefreshChart";
            this.btnRefreshChart.Size = new System.Drawing.Size(91, 23);
            this.btnRefreshChart.TabIndex = 7;
            this.btnRefreshChart.Text = "Refresh Chart";
            this.btnRefreshChart.UseVisualStyleBackColor = true;
            this.btnRefreshChart.Click += new System.EventHandler(this.btnRefreshChart_Click);
            // 
            // QueryBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpQueryBuilder);
            this.Name = "QueryBuilder";
            this.Size = new System.Drawing.Size(1442, 554);
            this.tlpQueryBuilder.ResumeLayout(false);
            this.tlpQueryBuilder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.tlpQueryBuilderFlow.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridView dgResult;
        private StartTableConfig startTableConfig;
        private System.Windows.Forms.Button button4;
        private FilterConfigTable filterConfigTable;
        private System.Windows.Forms.Button button1;
        private SelectConfig selectConfig;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private SortConfig sortConfig;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblChartType;
        private System.Windows.Forms.Label lblXValueMember;
        private System.Windows.Forms.Label lblYValueMember;
        private System.Windows.Forms.ComboBox cmbChartTypes;
        private System.Windows.Forms.ComboBox cmbXValueMember;
        private System.Windows.Forms.ComboBox cmbYValueMember;
        private System.Windows.Forms.Button btnRefreshChart;
    }
}
