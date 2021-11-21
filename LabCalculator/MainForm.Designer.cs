using System.Windows.Forms;


namespace LabCalculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.solveButton = new System.Windows.Forms.Button();
            this.expressionTextBox = new System.Windows.Forms.TextBox();
            this.expressionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minValueTextBox = new System.Windows.Forms.TextBox();
            this.stepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxValueTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.functionCartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.functionDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNumericUpDown)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.functionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // solveButton
            // 
            this.solveButton.BackColor = System.Drawing.Color.Black;
            this.solveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solveButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.solveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.solveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.solveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.solveButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.solveButton.Location = new System.Drawing.Point(93, 3);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(201, 65);
            this.solveButton.TabIndex = 5;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = false;
            this.solveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // expressionTextBox
            // 
            this.expressionTextBox.BackColor = System.Drawing.Color.Black;
            this.expressionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expressionTextBox.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.expressionTextBox.ForeColor = System.Drawing.Color.White;
            this.expressionTextBox.Location = new System.Drawing.Point(3, 126);
            this.expressionTextBox.Name = "expressionTextBox";
            this.expressionTextBox.Size = new System.Drawing.Size(388, 43);
            this.expressionTextBox.TabIndex = 1;
            this.expressionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExpressionTextBox_KeyPress);
            // 
            // expressionLabel
            // 
            this.expressionLabel.AutoSize = true;
            this.expressionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expressionLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.expressionLabel.Location = new System.Drawing.Point(3, 66);
            this.expressionLabel.Name = "expressionLabel";
            this.expressionLabel.Size = new System.Drawing.Size(388, 57);
            this.expressionLabel.TabIndex = 3;
            this.expressionLabel.Text = "Expression";
            this.expressionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.expressionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.expressionTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 444);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.solveButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 303);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 71);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.72362F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.27638F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.minValueTextBox, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.stepsNumericUpDown, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.maxValueTextBox, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 179);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(388, 93);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(211, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Steps";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minValueTextBox
            // 
            this.minValueTextBox.BackColor = System.Drawing.Color.Black;
            this.minValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minValueTextBox.ForeColor = System.Drawing.Color.White;
            this.minValueTextBox.Location = new System.Drawing.Point(88, 3);
            this.minValueTextBox.Name = "minValueTextBox";
            this.minValueTextBox.Size = new System.Drawing.Size(99, 31);
            this.minValueTextBox.TabIndex = 2;
            this.minValueTextBox.Text = "0.0";
            this.minValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinValueTextBox_KeyPress);
            // 
            // stepsNumericUpDown
            // 
            this.stepsNumericUpDown.BackColor = System.Drawing.Color.Black;
            this.stepsNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepsNumericUpDown.ForeColor = System.Drawing.Color.White;
            this.stepsNumericUpDown.Location = new System.Drawing.Point(305, 3);
            this.stepsNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stepsNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.stepsNumericUpDown.Name = "stepsNumericUpDown";
            this.stepsNumericUpDown.Size = new System.Drawing.Size(80, 31);
            this.stepsNumericUpDown.TabIndex = 4;
            this.stepsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.stepsNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stepsNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StepsNumericUpDown_KeyPress);
            // 
            // maxValueTextBox
            // 
            this.maxValueTextBox.BackColor = System.Drawing.Color.Black;
            this.maxValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxValueTextBox.ForeColor = System.Drawing.Color.White;
            this.maxValueTextBox.Location = new System.Drawing.Point(88, 49);
            this.maxValueTextBox.Name = "maxValueTextBox";
            this.maxValueTextBox.Size = new System.Drawing.Size(99, 31);
            this.maxValueTextBox.TabIndex = 3;
            this.maxValueTextBox.Text = "1.0";
            this.maxValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maxValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxValueTextBox_KeyPress);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.functionCartesianChart, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.functionDataGridView, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1344, 450);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // functionCartesianChart
            // 
            this.functionCartesianChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.functionCartesianChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.functionCartesianChart.Location = new System.Drawing.Point(875, 3);
            this.functionCartesianChart.Name = "functionCartesianChart";
            this.functionCartesianChart.Size = new System.Drawing.Size(466, 444);
            this.functionCartesianChart.TabIndex = 7;
            this.functionCartesianChart.TabStop = false;
            this.functionCartesianChart.Text = "cartesianChart1";
            // 
            // functionDataGridView
            // 
            this.functionDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.functionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.functionDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.functionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.functionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.functionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.functionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.functionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.functionDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.functionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.functionDataGridView.EnableHeadersVisualStyles = false;
            this.functionDataGridView.GridColor = System.Drawing.Color.Black;
            this.functionDataGridView.Location = new System.Drawing.Point(403, 3);
            this.functionDataGridView.Name = "functionDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.functionDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.functionDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.functionDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.functionDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.functionDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.functionDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.functionDataGridView.Size = new System.Drawing.Size(466, 444);
            this.functionDataGridView.TabIndex = 5;
            this.functionDataGridView.TabStop = false;
            // 
            // ColumnX
            // 
            this.ColumnX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnX.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            // 
            // ColumnY
            // 
            this.ColumnY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.ColumnY.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1344, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.MinimumSize = new System.Drawing.Size(379, 335);
            this.Name = "MainForm";
            this.Text = "Lab Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNumericUpDown)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.functionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button solveButton;
        private TextBox expressionTextBox;
        private Label expressionLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private LiveCharts.WinForms.CartesianChart functionCartesianChart;
        private DataGridView functionDataGridView;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnY;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox minValueTextBox;
        private NumericUpDown stepsNumericUpDown;
        private TextBox maxValueTextBox;
    }
}
