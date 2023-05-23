namespace BeetleCaf
{
    partial class Order
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbCoffee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTea = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPastry = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSandwich = new System.Windows.Forms.ComboBox();
            this.btnStage = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 314);
            this.dataGridView1.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(47, 359);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(541, 147);
            this.listBox1.TabIndex = 27;
            // 
            // cmbCoffee
            // 
            this.cmbCoffee.FormattingEnabled = true;
            this.cmbCoffee.Location = new System.Drawing.Point(598, 74);
            this.cmbCoffee.Name = "cmbCoffee";
            this.cmbCoffee.Size = new System.Drawing.Size(131, 21);
            this.cmbCoffee.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Category";
            // 
            // cmbTea
            // 
            this.cmbTea.FormattingEnabled = true;
            this.cmbTea.Location = new System.Drawing.Point(597, 133);
            this.cmbTea.Name = "cmbTea";
            this.cmbTea.Size = new System.Drawing.Size(132, 21);
            this.cmbTea.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Name";
            // 
            // cmbPastry
            // 
            this.cmbPastry.FormattingEnabled = true;
            this.cmbPastry.Location = new System.Drawing.Point(598, 190);
            this.cmbPastry.Name = "cmbPastry";
            this.cmbPastry.Size = new System.Drawing.Size(131, 21);
            this.cmbPastry.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Quantity";
            // 
            // cmbSandwich
            // 
            this.cmbSandwich.FormattingEnabled = true;
            this.cmbSandwich.Location = new System.Drawing.Point(601, 248);
            this.cmbSandwich.Name = "cmbSandwich";
            this.cmbSandwich.Size = new System.Drawing.Size(128, 21);
            this.cmbSandwich.TabIndex = 24;
            // 
            // btnStage
            // 
            this.btnStage.Location = new System.Drawing.Point(598, 312);
            this.btnStage.Name = "btnStage";
            this.btnStage.Size = new System.Drawing.Size(132, 26);
            this.btnStage.TabIndex = 25;
            this.btnStage.Text = "Stage Order";
            this.btnStage.UseVisualStyleBackColor = true;
            this.btnStage.Click += new System.EventHandler(this.btnStage_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(257, 512);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 26);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 565);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnStage);
            this.Controls.Add(this.cmbSandwich);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbPastry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCoffee);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbCoffee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPastry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSandwich;
        private System.Windows.Forms.Button btnStage;
        private System.Windows.Forms.Button btnSubmit;
    }
}