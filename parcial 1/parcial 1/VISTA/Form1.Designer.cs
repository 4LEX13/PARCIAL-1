
namespace parcial_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId_empleado = new System.Windows.Forms.Label();
            this.txtId_empleado = new System.Windows.Forms.TextBox();
            this.lblEmpl_nombre = new System.Windows.Forms.Label();
            this.txtEmpl_nombre = new System.Windows.Forms.TextBox();
            this.lblEmpl_apellido = new System.Windows.Forms.Label();
            this.txtEmpl_apellido = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId_empleado
            // 
            this.lblId_empleado.AutoSize = true;
            this.lblId_empleado.Location = new System.Drawing.Point(58, 40);
            this.lblId_empleado.Name = "lblId_empleado";
            this.lblId_empleado.Size = new System.Drawing.Size(68, 13);
            this.lblId_empleado.TabIndex = 0;
            this.lblId_empleado.Text = "Id_empleado";
            // 
            // txtId_empleado
            // 
            this.txtId_empleado.Location = new System.Drawing.Point(61, 70);
            this.txtId_empleado.Name = "txtId_empleado";
            this.txtId_empleado.Size = new System.Drawing.Size(138, 20);
            this.txtId_empleado.TabIndex = 1;
            // 
            // lblEmpl_nombre
            // 
            this.lblEmpl_nombre.AutoSize = true;
            this.lblEmpl_nombre.Location = new System.Drawing.Point(58, 128);
            this.lblEmpl_nombre.Name = "lblEmpl_nombre";
            this.lblEmpl_nombre.Size = new System.Drawing.Size(71, 13);
            this.lblEmpl_nombre.TabIndex = 2;
            this.lblEmpl_nombre.Text = "Empl_nombre";
            // 
            // txtEmpl_nombre
            // 
            this.txtEmpl_nombre.Location = new System.Drawing.Point(61, 174);
            this.txtEmpl_nombre.Name = "txtEmpl_nombre";
            this.txtEmpl_nombre.Size = new System.Drawing.Size(138, 20);
            this.txtEmpl_nombre.TabIndex = 3;
            // 
            // lblEmpl_apellido
            // 
            this.lblEmpl_apellido.AutoSize = true;
            this.lblEmpl_apellido.Location = new System.Drawing.Point(58, 240);
            this.lblEmpl_apellido.Name = "lblEmpl_apellido";
            this.lblEmpl_apellido.Size = new System.Drawing.Size(72, 13);
            this.lblEmpl_apellido.TabIndex = 4;
            this.lblEmpl_apellido.Text = "Empl_apellido";
            // 
            // txtEmpl_apellido
            // 
            this.txtEmpl_apellido.Location = new System.Drawing.Point(61, 285);
            this.txtEmpl_apellido.Name = "txtEmpl_apellido";
            this.txtEmpl_apellido.Size = new System.Drawing.Size(138, 20);
            this.txtEmpl_apellido.TabIndex = 5;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(337, 40);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(55, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Empl_DUI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Empl_direccion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(331, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Empl_tel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(331, 285);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Empl_email";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(608, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 20);
            this.textBox4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Empl_cargo";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(608, 174);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 20);
            this.textBox5.TabIndex = 15;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(61, 341);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(52, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 217);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id_empleado";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Empl_nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Empl_apellido";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Empl_DUI";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Empl_direccion";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Empl_direccion";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Empl_tel";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Empl_email";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Empl_cargo";
            this.Column9.Name = "Column9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtEmpl_apellido);
            this.Controls.Add(this.lblEmpl_apellido);
            this.Controls.Add(this.txtEmpl_nombre);
            this.Controls.Add(this.lblEmpl_nombre);
            this.Controls.Add(this.txtId_empleado);
            this.Controls.Add(this.lblId_empleado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId_empleado;
        private System.Windows.Forms.TextBox txtId_empleado;
        private System.Windows.Forms.Label lblEmpl_nombre;
        private System.Windows.Forms.TextBox txtEmpl_nombre;
        private System.Windows.Forms.Label lblEmpl_apellido;
        private System.Windows.Forms.TextBox txtEmpl_apellido;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}

