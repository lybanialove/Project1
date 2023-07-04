namespace курсач__ооп_
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.akcieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Organization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Divident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Organization,
            this.Column2,
            this.Divident,
            this.Price_in,
            this.Price_out,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // akcieBindingSource
            // 
            this.akcieBindingSource.DataSource = typeof(Лаба_3_наследованиеООП_.Akcie);
            // 
            // Organization
            // 
            this.Organization.DataPropertyName = "Organization";
            this.Organization.HeaderText = "Организация";
            this.Organization.Name = "Organization";
            this.Organization.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Срок выплат(кол-во месяцев)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Divident
            // 
            this.Divident.DataPropertyName = "Divident";
            this.Divident.HeaderText = "Дивиденты(%)";
            this.Divident.Name = "Divident";
            this.Divident.ReadOnly = true;
            // 
            // Price_in
            // 
            this.Price_in.DataPropertyName = "Price_in";
            this.Price_in.HeaderText = "Покупка($)";
            this.Price_in.Name = "Price_in";
            this.Price_in.ReadOnly = true;
            // 
            // Price_out
            // 
            this.Price_out.DataPropertyName = "Price_out";
            this.Price_out.HeaderText = "Продажа($)";
            this.Price_out.Name = "Price_out";
            this.Price_out.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Кол-во";
            this.Column1.Name = "Column1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(665, 378);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akcieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource akcieBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Divident;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}