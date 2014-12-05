namespace TPRKForms2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxInputx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.inputx = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vvY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Win = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.labelAverage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInputx
            // 
            this.textBoxInputx.Location = new System.Drawing.Point(51, 238);
            this.textBoxInputx.Name = "textBoxInputx";
            this.textBoxInputx.Size = new System.Drawing.Size(100, 20);
            this.textBoxInputx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(48, 56);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(619, 120);
            this.info.TabIndex = 1;
            this.info.Text = resources.GetString("info.Text");
            // 
            // inputx
            // 
            this.inputx.AutoSize = true;
            this.inputx.Location = new System.Drawing.Point(48, 222);
            this.inputx.Name = "inputx";
            this.inputx.Size = new System.Drawing.Size(56, 13);
            this.inputx.TabIndex = 3;
            this.inputx.Text = "Введіть x:";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(157, 236);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Грати";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.AllowUserToAddRows = false;
            this.dataGridViewTable.AllowUserToDeleteRows = false;
            this.dataGridViewTable.AllowUserToOrderColumns = true;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.x,
            this.vvY,
            this.Win});
            this.dataGridViewTable.Location = new System.Drawing.Point(51, 284);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.ReadOnly = true;
            this.dataGridViewTable.Size = new System.Drawing.Size(441, 150);
            this.dataGridViewTable.TabIndex = 5;
            // 
            // N
            // 
            this.N.HeaderText = "№";
            this.N.Name = "N";
            this.N.ReadOnly = true;
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            // 
            // vvY
            // 
            this.vvY.HeaderText = "Значення в.в. Y";
            this.vvY.Name = "vvY";
            this.vvY.ReadOnly = true;
            // 
            // Win
            // 
            this.Win.HeaderText = "Виграш";
            this.Win.Name = "Win";
            this.Win.ReadOnly = true;
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(388, 470);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.Size = new System.Drawing.Size(100, 20);
            this.textBoxAverage.TabIndex = 6;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(388, 451);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(92, 13);
            this.labelAverage.TabIndex = 7;
            this.labelAverage.Text = "Середній виграш";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Будувати функцію корисності ->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.textBoxAverage);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.inputx);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInputx);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label inputx;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn vvY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Win;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Button button1;
    }
}

