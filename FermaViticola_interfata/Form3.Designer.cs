
namespace FermaViticola_interfata
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
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.culoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitatesticlaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ferma_ViticolaDataSet1 = new FermaViticola_interfata.Ferma_ViticolaDataSet1();
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
            this.produsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.produsTableAdapter = new FermaViticola_interfata.Ferma_ViticolaDataSet1TableAdapters.ProdusTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferma_ViticolaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Delete.BackColor = System.Drawing.Color.Transparent;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.ForeColor = System.Drawing.Color.Gainsboro;
            this.Delete.Location = new System.Drawing.Point(205, 390);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 33);
            this.Delete.TabIndex = 34;
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
            this.Update.Location = new System.Drawing.Point(107, 390);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(92, 33);
            this.Update.TabIndex = 33;
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
            this.Insert.Location = new System.Drawing.Point(9, 390);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(92, 33);
            this.Insert.TabIndex = 32;
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
            this.groupBox1.Location = new System.Drawing.Point(312, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 394);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProdusDataGridViewTextBoxColumn,
            this.numeprodusDataGridViewTextBoxColumn,
            this.culoareDataGridViewTextBoxColumn,
            this.stilDataGridViewTextBoxColumn,
            this.cantitatesticlaDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.iDTipProdusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(24, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(371, 343);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDProdusDataGridViewTextBoxColumn
            // 
            this.iDProdusDataGridViewTextBoxColumn.DataPropertyName = "ID_Produs";
            this.iDProdusDataGridViewTextBoxColumn.HeaderText = "ID_Produs";
            this.iDProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProdusDataGridViewTextBoxColumn.Name = "iDProdusDataGridViewTextBoxColumn";
            this.iDProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProdusDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeprodusDataGridViewTextBoxColumn
            // 
            this.numeprodusDataGridViewTextBoxColumn.DataPropertyName = "Nume_produs";
            this.numeprodusDataGridViewTextBoxColumn.HeaderText = "Nume_produs";
            this.numeprodusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeprodusDataGridViewTextBoxColumn.Name = "numeprodusDataGridViewTextBoxColumn";
            this.numeprodusDataGridViewTextBoxColumn.Width = 125;
            // 
            // culoareDataGridViewTextBoxColumn
            // 
            this.culoareDataGridViewTextBoxColumn.DataPropertyName = "Culoare";
            this.culoareDataGridViewTextBoxColumn.HeaderText = "Culoare";
            this.culoareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.culoareDataGridViewTextBoxColumn.Name = "culoareDataGridViewTextBoxColumn";
            this.culoareDataGridViewTextBoxColumn.Width = 125;
            // 
            // stilDataGridViewTextBoxColumn
            // 
            this.stilDataGridViewTextBoxColumn.DataPropertyName = "Stil";
            this.stilDataGridViewTextBoxColumn.HeaderText = "Stil";
            this.stilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stilDataGridViewTextBoxColumn.Name = "stilDataGridViewTextBoxColumn";
            this.stilDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantitatesticlaDataGridViewTextBoxColumn
            // 
            this.cantitatesticlaDataGridViewTextBoxColumn.DataPropertyName = "Cantitate_sticla";
            this.cantitatesticlaDataGridViewTextBoxColumn.HeaderText = "Cantitate_sticla";
            this.cantitatesticlaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantitatesticlaDataGridViewTextBoxColumn.Name = "cantitatesticlaDataGridViewTextBoxColumn";
            this.cantitatesticlaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDTipProdusDataGridViewTextBoxColumn
            // 
            this.iDTipProdusDataGridViewTextBoxColumn.DataPropertyName = "ID_TipProdus";
            this.iDTipProdusDataGridViewTextBoxColumn.HeaderText = "ID_TipProdus";
            this.iDTipProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDTipProdusDataGridViewTextBoxColumn.Name = "iDTipProdusDataGridViewTextBoxColumn";
            this.iDTipProdusDataGridViewTextBoxColumn.Width = 125;
            // 
            // produsBindingSource
            // 
            this.produsBindingSource.DataMember = "Produs";
            this.produsBindingSource.DataSource = this.ferma_ViticolaDataSet1;
            // 
            // ferma_ViticolaDataSet1
            // 
            this.ferma_ViticolaDataSet1.DataSetName = "Ferma_ViticolaDataSet1";
            this.ferma_ViticolaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(33, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID_TipProdus";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(33, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cantitate_Sticla";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(33, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Pret";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(33, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Stil";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(33, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Culoare";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(33, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nume_produs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "ID_TipProdus", true));
            this.textBox7.Location = new System.Drawing.Point(149, 341);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 24;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "Pret", true));
            this.textBox6.Location = new System.Drawing.Point(149, 287);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 23;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "Cantitate_sticla", true));
            this.textBox5.Location = new System.Drawing.Point(149, 234);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 22;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "Stil", true));
            this.textBox4.Location = new System.Drawing.Point(149, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 21;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource1, "Culoare", true));
            this.textBox3.Location = new System.Drawing.Point(149, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 20;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // produsBindingSource1
            // 
            this.produsBindingSource1.DataMember = "Produs";
            this.produsBindingSource1.DataSource = this.ferma_ViticolaDataSet1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produsBindingSource, "Nume_produs", true));
            this.textBox2.Location = new System.Drawing.Point(149, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(638, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // produsTableAdapter
            // 
            this.produsTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(725, 506);
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
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferma_ViticolaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button button1;
        private Ferma_ViticolaDataSet1 ferma_ViticolaDataSet1;
        private System.Windows.Forms.BindingSource produsBindingSource;
        private Ferma_ViticolaDataSet1TableAdapters.ProdusTableAdapter produsTableAdapter;
        private System.Windows.Forms.BindingSource produsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn culoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitatesticlaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipProdusDataGridViewTextBoxColumn;
    }
}