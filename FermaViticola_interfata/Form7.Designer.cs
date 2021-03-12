
namespace FermaViticola_interfata
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ferma_ViticolaDataSet3 = new FermaViticola_interfata.Ferma_ViticolaDataSet3();
            this.adresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adresaTableAdapter = new FermaViticola_interfata.Ferma_ViticolaDataSet3TableAdapters.AdresaTableAdapter();
            this.adresaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adresaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.adresaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.adresaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.adresaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.adresaBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferma_ViticolaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "ID_Tip";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresaBindingSource, "ID_Tip", true));
            this.textBox1.Location = new System.Drawing.Point(141, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 83;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(630, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 82;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Delete.BackColor = System.Drawing.Color.Transparent;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.ForeColor = System.Drawing.Color.Gainsboro;
            this.Delete.Location = new System.Drawing.Point(197, 397);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 33);
            this.Delete.TabIndex = 81;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Update.BackColor = System.Drawing.Color.Transparent;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.ForeColor = System.Drawing.Color.Gainsboro;
            this.Update.Location = new System.Drawing.Point(99, 397);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(92, 33);
            this.Update.TabIndex = 80;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Insert.BackColor = System.Drawing.Color.Transparent;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert.ForeColor = System.Drawing.Color.Gainsboro;
            this.Insert.Location = new System.Drawing.Point(1, 397);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(92, 33);
            this.Insert.TabIndex = 79;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(304, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 405);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 363);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(25, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 77;
            this.label7.Text = "Numar";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(25, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "Cod_postal";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(25, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Strada";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(25, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Oras";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Judet";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Tara";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresaBindingSource6, "Numar", true));
            this.textBox7.Location = new System.Drawing.Point(141, 348);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 71;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresaBindingSource5, "Strada", true));
            this.textBox6.Location = new System.Drawing.Point(141, 294);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 70;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresaBindingSource4, "Cod_postal", true));
            this.textBox5.Location = new System.Drawing.Point(141, 241);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 69;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresaBindingSource3, "Oras", true));
            this.textBox4.Location = new System.Drawing.Point(141, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 68;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresaBindingSource2, "Judet", true));
            this.textBox3.Location = new System.Drawing.Point(141, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 67;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adresaBindingSource1, "Tara", true));
            this.textBox2.Location = new System.Drawing.Point(141, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 66;
            // 
            // ferma_ViticolaDataSet3
            // 
            this.ferma_ViticolaDataSet3.DataSetName = "Ferma_ViticolaDataSet3";
            this.ferma_ViticolaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adresaBindingSource
            // 
            this.adresaBindingSource.DataMember = "Adresa";
            this.adresaBindingSource.DataSource = this.ferma_ViticolaDataSet3;
            // 
            // adresaTableAdapter
            // 
            this.adresaTableAdapter.ClearBeforeFill = true;
            // 
            // adresaBindingSource1
            // 
            this.adresaBindingSource1.DataMember = "Adresa";
            this.adresaBindingSource1.DataSource = this.ferma_ViticolaDataSet3;
            // 
            // adresaBindingSource2
            // 
            this.adresaBindingSource2.DataMember = "Adresa";
            this.adresaBindingSource2.DataSource = this.ferma_ViticolaDataSet3;
            // 
            // adresaBindingSource3
            // 
            this.adresaBindingSource3.DataMember = "Adresa";
            this.adresaBindingSource3.DataSource = this.ferma_ViticolaDataSet3;
            // 
            // adresaBindingSource4
            // 
            this.adresaBindingSource4.DataMember = "Adresa";
            this.adresaBindingSource4.DataSource = this.ferma_ViticolaDataSet3;
            // 
            // adresaBindingSource5
            // 
            this.adresaBindingSource5.DataMember = "Adresa";
            this.adresaBindingSource5.DataSource = this.ferma_ViticolaDataSet3;
            // 
            // adresaBindingSource6
            // 
            this.adresaBindingSource6.DataMember = "Adresa";
            this.adresaBindingSource6.DataSource = this.ferma_ViticolaDataSet3;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(707, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferma_ViticolaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresaBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private Ferma_ViticolaDataSet3 ferma_ViticolaDataSet3;
        private System.Windows.Forms.BindingSource adresaBindingSource;
        private Ferma_ViticolaDataSet3TableAdapters.AdresaTableAdapter adresaTableAdapter;
        private System.Windows.Forms.BindingSource adresaBindingSource6;
        private System.Windows.Forms.BindingSource adresaBindingSource5;
        private System.Windows.Forms.BindingSource adresaBindingSource4;
        private System.Windows.Forms.BindingSource adresaBindingSource3;
        private System.Windows.Forms.BindingSource adresaBindingSource2;
        private System.Windows.Forms.BindingSource adresaBindingSource1;
    }
}