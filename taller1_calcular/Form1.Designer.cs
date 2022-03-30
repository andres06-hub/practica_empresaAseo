
namespace taller1_calcular
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtLectuAnte = new System.Windows.Forms.TextBox();
            this.txtLectuActua = new System.Windows.Forms.TextBox();
            this.txtEstrato = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblLectutaAnte = new System.Windows.Forms.Label();
            this.lblLecturaActual = new System.Windows.Forms.Label();
            this.lblEstrato = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegalo = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblMultaXconsumo = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblAseo = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblValorM3 = new System.Windows.Forms.Label();
            this.grupBxOutput = new System.Windows.Forms.GroupBox();
            this.grupBxInput = new System.Windows.Forms.GroupBox();
            this.txtMultaXconsumo = new System.Windows.Forms.TextBox();
            this.txtValorM3 = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtAseo = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtRegalo = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grupBxOutput.SuspendLayout();
            this.grupBxInput.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtCodigo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLectuAnte, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLectuActua, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEstrato, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCodigo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLectutaAnte, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLecturaActual, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEstrato, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(118, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 63);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(3, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(114, 20);
            this.txtCodigo.TabIndex = 0;
            //this.txtCodigo.
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLectuAnte
            // 
            this.txtLectuAnte.Location = new System.Drawing.Point(123, 34);
            this.txtLectuAnte.Name = "txtLectuAnte";
            this.txtLectuAnte.Size = new System.Drawing.Size(114, 20);
            this.txtLectuAnte.TabIndex = 1;
            this.txtLectuAnte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLectuActua
            // 
            this.txtLectuActua.Location = new System.Drawing.Point(243, 34);
            this.txtLectuActua.Name = "txtLectuActua";
            this.txtLectuActua.Size = new System.Drawing.Size(114, 20);
            this.txtLectuActua.TabIndex = 2;
            this.txtLectuActua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEstrato
            // 
            this.txtEstrato.Location = new System.Drawing.Point(363, 34);
            this.txtEstrato.Name = "txtEstrato";
            this.txtEstrato.Size = new System.Drawing.Size(116, 20);
            this.txtEstrato.TabIndex = 3;
            this.txtEstrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(30, 10);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(30, 10, 3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCodigo.Size = new System.Drawing.Size(56, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo";
            this.lblCodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLectutaAnte
            // 
            this.lblLectutaAnte.AutoSize = true;
            this.lblLectutaAnte.Location = new System.Drawing.Point(142, 10);
            this.lblLectutaAnte.Margin = new System.Windows.Forms.Padding(22, 10, 3, 0);
            this.lblLectutaAnte.Name = "lblLectutaAnte";
            this.lblLectutaAnte.Size = new System.Drawing.Size(82, 13);
            this.lblLectutaAnte.TabIndex = 5;
            this.lblLectutaAnte.Text = "Lectura Anterior";
            // 
            // lblLecturaActual
            // 
            this.lblLecturaActual.AutoSize = true;
            this.lblLecturaActual.Location = new System.Drawing.Point(262, 10);
            this.lblLecturaActual.Margin = new System.Windows.Forms.Padding(22, 10, 3, 0);
            this.lblLecturaActual.Name = "lblLecturaActual";
            this.lblLecturaActual.Size = new System.Drawing.Size(76, 13);
            this.lblLecturaActual.TabIndex = 6;
            this.lblLecturaActual.Text = "Lectura Actual";
            this.lblLecturaActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEstrato
            // 
            this.lblEstrato.AutoSize = true;
            this.lblEstrato.Location = new System.Drawing.Point(398, 10);
            this.lblEstrato.Margin = new System.Windows.Forms.Padding(38, 10, 3, 0);
            this.lblEstrato.Name = "lblEstrato";
            this.lblEstrato.Size = new System.Drawing.Size(40, 13);
            this.lblEstrato.TabIndex = 7;
            this.lblEstrato.Text = "Estrato";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(391, 34);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(0, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Controls.Add(this.txtTotalPagar, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtRegalo, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSubtotal, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtAseo, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtConsumo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtValorM3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMultaXconsumo, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRegalo, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalPagar, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblMultaXconsumo, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSubtotal, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAseo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblConsumo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblValorM3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(764, 58);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // lblRegalo
            // 
            this.lblRegalo.AutoSize = true;
            this.lblRegalo.Location = new System.Drawing.Point(687, 9);
            this.lblRegalo.Margin = new System.Windows.Forms.Padding(33, 9, 3, 0);
            this.lblRegalo.Name = "lblRegalo";
            this.lblRegalo.Size = new System.Drawing.Size(41, 13);
            this.lblRegalo.TabIndex = 6;
            this.lblRegalo.Text = "Regalo";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(565, 9);
            this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(20, 9, 3, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(71, 13);
            this.lblTotalPagar.TabIndex = 5;
            this.lblTotalPagar.Text = "Total a Pagar";
            // 
            // lblMultaXconsumo
            // 
            this.lblMultaXconsumo.AutoSize = true;
            this.lblMultaXconsumo.Location = new System.Drawing.Point(442, 9);
            this.lblMultaXconsumo.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblMultaXconsumo.Name = "lblMultaXconsumo";
            this.lblMultaXconsumo.Size = new System.Drawing.Size(98, 13);
            this.lblMultaXconsumo.TabIndex = 4;
            this.lblMultaXconsumo.Text = "Multa por Consumo";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(357, 9);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(30, 9, 3, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblAseo
            // 
            this.lblAseo.AutoSize = true;
            this.lblAseo.Location = new System.Drawing.Point(253, 9);
            this.lblAseo.Margin = new System.Windows.Forms.Padding(35, 9, 3, 0);
            this.lblAseo.Name = "lblAseo";
            this.lblAseo.Size = new System.Drawing.Size(31, 13);
            this.lblAseo.TabIndex = 2;
            this.lblAseo.Text = "Aseo";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(134, 9);
            this.lblConsumo.Margin = new System.Windows.Forms.Padding(25, 9, 3, 0);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(51, 13);
            this.lblConsumo.TabIndex = 1;
            this.lblConsumo.Text = "Consumo";
            // 
            // lblValorM3
            // 
            this.lblValorM3.AutoSize = true;
            this.lblValorM3.Location = new System.Drawing.Point(25, 9);
            this.lblValorM3.Margin = new System.Windows.Forms.Padding(25, 9, 3, 0);
            this.lblValorM3.Name = "lblValorM3";
            this.lblValorM3.Size = new System.Drawing.Size(55, 13);
            this.lblValorM3.TabIndex = 0;
            this.lblValorM3.Text = "Valor M^3";
            // 
            // grupBxOutput
            // 
            this.grupBxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupBxOutput.Controls.Add(this.tableLayoutPanel2);
            this.grupBxOutput.Location = new System.Drawing.Point(3, 139);
            this.grupBxOutput.Name = "grupBxOutput";
            this.grupBxOutput.Size = new System.Drawing.Size(776, 118);
            this.grupBxOutput.TabIndex = 3;
            this.grupBxOutput.TabStop = false;
            this.grupBxOutput.Text = "OUTPUT";
            // 
            // grupBxInput
            // 
            this.grupBxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupBxInput.Controls.Add(this.btnCalcular);
            this.grupBxInput.Controls.Add(this.tableLayoutPanel1);
            this.grupBxInput.Location = new System.Drawing.Point(3, 3);
            this.grupBxInput.Name = "grupBxInput";
            this.grupBxInput.Size = new System.Drawing.Size(776, 103);
            this.grupBxInput.TabIndex = 4;
            this.grupBxInput.TabStop = false;
            this.grupBxInput.Text = "INPUT";
            // 
            // txtMultaXconsumo
            // 
            this.txtMultaXconsumo.Enabled = false;
            this.txtMultaXconsumo.Location = new System.Drawing.Point(439, 32);
            this.txtMultaXconsumo.Name = "txtMultaXconsumo";
            this.txtMultaXconsumo.Size = new System.Drawing.Size(103, 20);
            this.txtMultaXconsumo.TabIndex = 11;
            this.txtMultaXconsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorM3
            // 
            this.txtValorM3.Enabled = false;
            this.txtValorM3.Location = new System.Drawing.Point(3, 32);
            this.txtValorM3.Name = "txtValorM3";
            this.txtValorM3.Size = new System.Drawing.Size(103, 20);
            this.txtValorM3.TabIndex = 14;
            this.txtValorM3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorM3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtConsumo
            // 
            this.txtConsumo.Enabled = false;
            this.txtConsumo.Location = new System.Drawing.Point(112, 32);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(103, 20);
            this.txtConsumo.TabIndex = 15;
            this.txtConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAseo
            // 
            this.txtAseo.Enabled = false;
            this.txtAseo.Location = new System.Drawing.Point(221, 32);
            this.txtAseo.Name = "txtAseo";
            this.txtAseo.Size = new System.Drawing.Size(103, 20);
            this.txtAseo.TabIndex = 16;
            this.txtAseo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(330, 32);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(103, 20);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRegalo
            // 
            this.txtRegalo.Enabled = false;
            this.txtRegalo.Location = new System.Drawing.Point(657, 32);
            this.txtRegalo.Name = "txtRegalo";
            this.txtRegalo.Size = new System.Drawing.Size(103, 20);
            this.txtRegalo.TabIndex = 18;
            this.txtRegalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(548, 32);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(103, 20);
            this.txtTotalPagar.TabIndex = 19;
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.Location = new System.Drawing.Point(659, 29);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 35);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.grupBxOutput, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.grupBxInput, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 34);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(792, 276);
            this.tableLayoutPanel3.TabIndex = 5;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 322);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.grupBxOutput.ResumeLayout(false);
            this.grupBxInput.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtLectuAnte;
        private System.Windows.Forms.TextBox txtLectuActua;
        private System.Windows.Forms.TextBox txtEstrato;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblLectutaAnte;
        private System.Windows.Forms.Label lblLecturaActual;
        private System.Windows.Forms.Label lblEstrato;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblRegalo;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblMultaXconsumo;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblAseo;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblValorM3;
        private System.Windows.Forms.GroupBox grupBxOutput;
        private System.Windows.Forms.GroupBox grupBxInput;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtRegalo;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtAseo;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtValorM3;
        private System.Windows.Forms.TextBox txtMultaXconsumo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

