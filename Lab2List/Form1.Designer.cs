namespace Lab2List
{
    partial class frmMain
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
            lbxMain = new ListBox();
            btnCreate = new Button();
            lbxList = new ListBox();
            lblSize = new Label();
            lblMin = new Label();
            lblMax = new Label();
            btnCleanse = new Button();
            btnDivide = new Button();
            btnClean = new Button();
            numSize = new NumericUpDown();
            numMin = new NumericUpDown();
            numMax = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMax).BeginInit();
            SuspendLayout();
            // 
            // lbxMain
            // 
            lbxMain.FormattingEnabled = true;
            lbxMain.ItemHeight = 15;
            lbxMain.Location = new Point(561, 12);
            lbxMain.Name = "lbxMain";
            lbxMain.Size = new Size(347, 544);
            lbxMain.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(310, 23);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Создать лист";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lbxList
            // 
            lbxList.FormattingEnabled = true;
            lbxList.ItemHeight = 15;
            lbxList.Location = new Point(328, 12);
            lbxList.Name = "lbxList";
            lbxList.Size = new Size(227, 544);
            lbxList.TabIndex = 2;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(77, 44);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(87, 15);
            lblSize.TabIndex = 6;
            lblSize.Text = "Размер листа:";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(12, 73);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(152, 15);
            lblMin.TabIndex = 7;
            lblMin.Text = "Минимальное значение:";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(8, 102);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(156, 15);
            lblMax.TabIndex = 8;
            lblMax.Text = "Максимальное значение:";
            // 
            // btnCleanse
            // 
            btnCleanse.Location = new Point(12, 128);
            btnCleanse.Name = "btnCleanse";
            btnCleanse.Size = new Size(310, 23);
            btnCleanse.TabIndex = 9;
            btnCleanse.Text = "Убрать некратные значения";
            btnCleanse.UseVisualStyleBackColor = true;
            btnCleanse.Click += btnCleanse_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(12, 157);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(310, 23);
            btnDivide.TabIndex = 10;
            btnDivide.Text = "Разделить нулями числа одной чётности";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(12, 529);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(310, 23);
            btnClean.TabIndex = 11;
            btnClean.Text = "Очистить вывод";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // numSize
            // 
            numSize.Location = new Point(170, 41);
            numSize.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numSize.Name = "numSize";
            numSize.Size = new Size(152, 23);
            numSize.TabIndex = 12;
            numSize.ThousandsSeparator = true;
            numSize.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // numMin
            // 
            numMin.Location = new Point(170, 70);
            numMin.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numMin.Minimum = new decimal(new int[] { 100000, 0, 0, int.MinValue });
            numMin.Name = "numMin";
            numMin.Size = new Size(152, 23);
            numMin.TabIndex = 13;
            numMin.Value = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            // 
            // numMax
            // 
            numMax.Location = new Point(170, 99);
            numMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numMax.Minimum = new decimal(new int[] { 99999, 0, 0, int.MinValue });
            numMax.Name = "numMax";
            numMax.Size = new Size(152, 23);
            numMax.TabIndex = 14;
            numMax.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 564);
            Controls.Add(numMax);
            Controls.Add(numMin);
            Controls.Add(numSize);
            Controls.Add(btnClean);
            Controls.Add(btnDivide);
            Controls.Add(btnCleanse);
            Controls.Add(lblMax);
            Controls.Add(lblMin);
            Controls.Add(lblSize);
            Controls.Add(lbxList);
            Controls.Add(btnCreate);
            Controls.Add(lbxMain);
            Name = "frmMain";
            Text = "LinkedList operations";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxMain;
        private Button btnCreate;
        private ListBox lbxList;
        private Label lblSize;
        private Label lblMin;
        private Label lblMax;
        private Button btnCleanse;
        private Button btnDivide;
        private Button btnClean;
        private NumericUpDown numSize;
        private NumericUpDown numMin;
        private NumericUpDown numMax;
    }
}
