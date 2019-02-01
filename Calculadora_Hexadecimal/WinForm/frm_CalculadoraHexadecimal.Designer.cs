namespace WinForm
{
    partial class frm_CalculadoraHexadecimal
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
            this.txb_visor = new System.Windows.Forms.TextBox();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_multiplicacion = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_reestablece = new System.Windows.Forms.Button();
            this.lbl_terminoUno = new System.Windows.Forms.Label();
            this.lbl_operador = new System.Windows.Forms.Label();
            this.lbl_terminoDos = new System.Windows.Forms.Label();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_E = new System.Windows.Forms.Button();
            this.btn_F = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_visor
            // 
            this.txb_visor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txb_visor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_visor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_visor.Location = new System.Drawing.Point(5, 67);
            this.txb_visor.MaximumSize = new System.Drawing.Size(500, 500);
            this.txb_visor.MaxLength = 8;
            this.txb_visor.Multiline = true;
            this.txb_visor.Name = "txb_visor";
            this.txb_visor.Size = new System.Drawing.Size(451, 30);
            this.txb_visor.TabIndex = 1;
            this.txb_visor.TextChanged += new System.EventHandler(this.txb_visor_TextChanged);
            this.txb_visor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_visor_KeyDown);
            this.txb_visor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_visor_KeyPress);
            // 
            // btn_suma
            // 
            this.btn_suma.BackColor = System.Drawing.Color.DimGray;
            this.btn_suma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_suma.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suma.Location = new System.Drawing.Point(139, 157);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(40, 40);
            this.btn_suma.TabIndex = 31;
            this.btn_suma.Text = "+";
            this.btn_suma.UseVisualStyleBackColor = false;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.BackColor = System.Drawing.Color.DimGray;
            this.btn_resta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_resta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_resta.Location = new System.Drawing.Point(139, 201);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(40, 40);
            this.btn_resta.TabIndex = 32;
            this.btn_resta.Text = "-";
            this.btn_resta.UseVisualStyleBackColor = false;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_multiplicacion
            // 
            this.btn_multiplicacion.BackColor = System.Drawing.Color.DimGray;
            this.btn_multiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_multiplicacion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicacion.Location = new System.Drawing.Point(139, 245);
            this.btn_multiplicacion.Name = "btn_multiplicacion";
            this.btn_multiplicacion.Size = new System.Drawing.Size(40, 40);
            this.btn_multiplicacion.TabIndex = 33;
            this.btn_multiplicacion.Text = "X";
            this.btn_multiplicacion.UseVisualStyleBackColor = false;
            this.btn_multiplicacion.Click += new System.EventHandler(this.btn_multiplicacion_Click);
            // 
            // btn_division
            // 
            this.btn_division.BackColor = System.Drawing.Color.DimGray;
            this.btn_division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_division.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.Location = new System.Drawing.Point(139, 289);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(40, 40);
            this.btn_division.TabIndex = 34;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = false;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_reestablece
            // 
            this.btn_reestablece.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reestablece.Location = new System.Drawing.Point(138, 114);
            this.btn_reestablece.Name = "btn_reestablece";
            this.btn_reestablece.Size = new System.Drawing.Size(40, 40);
            this.btn_reestablece.TabIndex = 35;
            this.btn_reestablece.Text = "C";
            this.btn_reestablece.UseVisualStyleBackColor = true;
            this.btn_reestablece.Click += new System.EventHandler(this.btn_reestablece_Click);
            // 
            // lbl_terminoUno
            // 
            this.lbl_terminoUno.Location = new System.Drawing.Point(2, 9);
            this.lbl_terminoUno.Name = "lbl_terminoUno";
            this.lbl_terminoUno.Size = new System.Drawing.Size(117, 19);
            this.lbl_terminoUno.TabIndex = 37;
            this.lbl_terminoUno.Text = "lbl_terminoUno";
            // 
            // lbl_operador
            // 
            this.lbl_operador.Location = new System.Drawing.Point(2, 34);
            this.lbl_operador.Name = "lbl_operador";
            this.lbl_operador.Size = new System.Drawing.Size(58, 19);
            this.lbl_operador.TabIndex = 38;
            this.lbl_operador.Text = "lbl_operador";
            // 
            // lbl_terminoDos
            // 
            this.lbl_terminoDos.Location = new System.Drawing.Point(177, 9);
            this.lbl_terminoDos.Name = "lbl_terminoDos";
            this.lbl_terminoDos.Size = new System.Drawing.Size(117, 19);
            this.lbl_terminoDos.TabIndex = 39;
            this.lbl_terminoDos.Text = "lbl_terminoDos";
            this.lbl_terminoDos.Visible = false;
            // 
            // btn_igual
            // 
            this.btn_igual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_igual.Location = new System.Drawing.Point(139, 332);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(40, 40);
            this.btn_igual.TabIndex = 40;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_1
            // 
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1.Location = new System.Drawing.Point(182, 114);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(40, 40);
            this.btn_1.TabIndex = 41;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_2.Location = new System.Drawing.Point(225, 114);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(40, 40);
            this.btn_2.TabIndex = 42;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_3.Location = new System.Drawing.Point(268, 114);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(40, 40);
            this.btn_3.TabIndex = 43;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_4.Location = new System.Drawing.Point(182, 157);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(40, 40);
            this.btn_4.TabIndex = 44;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_5.Location = new System.Drawing.Point(224, 157);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(40, 40);
            this.btn_5.TabIndex = 45;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_6.Location = new System.Drawing.Point(268, 157);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(40, 40);
            this.btn_6.TabIndex = 46;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_7.Location = new System.Drawing.Point(183, 201);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(40, 40);
            this.btn_7.TabIndex = 47;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_8.Location = new System.Drawing.Point(225, 201);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(40, 40);
            this.btn_8.TabIndex = 48;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_9.Location = new System.Drawing.Point(268, 201);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(40, 40);
            this.btn_9.TabIndex = 49;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_A
            // 
            this.btn_A.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_A.Location = new System.Drawing.Point(183, 245);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(40, 40);
            this.btn_A.TabIndex = 50;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_B
            // 
            this.btn_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_B.Location = new System.Drawing.Point(226, 245);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(40, 40);
            this.btn_B.TabIndex = 51;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_C
            // 
            this.btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_C.Location = new System.Drawing.Point(269, 245);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(40, 40);
            this.btn_C.TabIndex = 52;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_D
            // 
            this.btn_D.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_D.Location = new System.Drawing.Point(183, 289);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(40, 40);
            this.btn_D.TabIndex = 53;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // btn_E
            // 
            this.btn_E.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_E.Location = new System.Drawing.Point(226, 289);
            this.btn_E.Name = "btn_E";
            this.btn_E.Size = new System.Drawing.Size(40, 40);
            this.btn_E.TabIndex = 54;
            this.btn_E.Text = "E";
            this.btn_E.UseVisualStyleBackColor = true;
            this.btn_E.Click += new System.EventHandler(this.btn_E_Click);
            // 
            // btn_F
            // 
            this.btn_F.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_F.Location = new System.Drawing.Point(269, 289);
            this.btn_F.Name = "btn_F";
            this.btn_F.Size = new System.Drawing.Size(40, 40);
            this.btn_F.TabIndex = 55;
            this.btn_F.Text = "F";
            this.btn_F.UseVisualStyleBackColor = true;
            this.btn_F.Click += new System.EventHandler(this.btn_F_Click);
            // 
            // btn_0
            // 
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_0.Location = new System.Drawing.Point(182, 332);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(40, 40);
            this.btn_0.TabIndex = 56;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // frm_CalculadoraHexadecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(468, 401);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_F);
            this.Controls.Add(this.btn_E);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.lbl_terminoDos);
            this.Controls.Add(this.lbl_operador);
            this.Controls.Add(this.lbl_terminoUno);
            this.Controls.Add(this.btn_reestablece);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiplicacion);
            this.Controls.Add(this.btn_resta);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.txb_visor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_CalculadoraHexadecimal";
            this.Text = "Calculadora Hexadecimal";
            this.Load += new System.EventHandler(this.frm_CalculadoraHexadecimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_visor;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_multiplicacion;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_reestablece;
        private System.Windows.Forms.Label lbl_terminoUno;
        private System.Windows.Forms.Label lbl_operador;
        private System.Windows.Forms.Label lbl_terminoDos;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_E;
        private System.Windows.Forms.Button btn_F;
        private System.Windows.Forms.Button btn_0;
    }
}

