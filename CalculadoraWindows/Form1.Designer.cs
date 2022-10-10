namespace CalculadoraWindows
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
            this.textBoxHistorial = new System.Windows.Forms.TextBox();
            this.textBoxNumeros = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonSumar = new System.Windows.Forms.Button();
            this.buttonRestar = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonDivi = new System.Windows.Forms.Button();
            this.buttonIgual = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.buttonBorrarUno = new System.Windows.Forms.Button();
            this.buttonBorrarTodo = new System.Windows.Forms.Button();
            this.buttonPuntoDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxHistorial
            // 
            this.textBoxHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHistorial.Enabled = false;
            this.textBoxHistorial.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHistorial.Location = new System.Drawing.Point(14, 13);
            this.textBoxHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHistorial.MaxLength = 30;
            this.textBoxHistorial.Multiline = true;
            this.textBoxHistorial.Name = "textBoxHistorial";
            this.textBoxHistorial.ReadOnly = true;
            this.textBoxHistorial.Size = new System.Drawing.Size(213, 25);
            this.textBoxHistorial.TabIndex = 0;
            this.textBoxHistorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNumeros
            // 
            this.textBoxNumeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumeros.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeros.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxNumeros.Location = new System.Drawing.Point(14, 42);
            this.textBoxNumeros.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumeros.Multiline = true;
            this.textBoxNumeros.Name = "textBoxNumeros";
            this.textBoxNumeros.ReadOnly = true;
            this.textBoxNumeros.Size = new System.Drawing.Size(213, 40);
            this.textBoxNumeros.TabIndex = 1;
            this.textBoxNumeros.Text = "0";
            this.textBoxNumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(14, 388);
            this.button0.Margin = new System.Windows.Forms.Padding(2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(54, 54);
            this.button0.TabIndex = 2;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(72, 330);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(130, 330);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 54);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(14, 272);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 54);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(72, 272);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 54);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(130, 272);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 54);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(14, 214);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 54);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(72, 214);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 54);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(130, 214);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 54);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // buttonSumar
            // 
            this.buttonSumar.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSumar.Location = new System.Drawing.Point(188, 330);
            this.buttonSumar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSumar.Name = "buttonSumar";
            this.buttonSumar.Size = new System.Drawing.Size(54, 54);
            this.buttonSumar.TabIndex = 12;
            this.buttonSumar.Text = "+";
            this.buttonSumar.UseVisualStyleBackColor = true;
            this.buttonSumar.Click += new System.EventHandler(this.AgregarOperador);
            // 
            // buttonRestar
            // 
            this.buttonRestar.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestar.Location = new System.Drawing.Point(188, 272);
            this.buttonRestar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRestar.Name = "buttonRestar";
            this.buttonRestar.Size = new System.Drawing.Size(54, 54);
            this.buttonRestar.TabIndex = 13;
            this.buttonRestar.Text = "-";
            this.buttonRestar.UseVisualStyleBackColor = true;
            this.buttonRestar.Click += new System.EventHandler(this.AgregarOperador);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMulti.Location = new System.Drawing.Point(188, 214);
            this.buttonMulti.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(54, 54);
            this.buttonMulti.TabIndex = 14;
            this.buttonMulti.Text = "*";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.AgregarOperador);
            // 
            // buttonDivi
            // 
            this.buttonDivi.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivi.Location = new System.Drawing.Point(188, 156);
            this.buttonDivi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDivi.Name = "buttonDivi";
            this.buttonDivi.Size = new System.Drawing.Size(54, 54);
            this.buttonDivi.TabIndex = 15;
            this.buttonDivi.Text = "/";
            this.buttonDivi.UseVisualStyleBackColor = true;
            this.buttonDivi.Click += new System.EventHandler(this.AgregarOperador);
            // 
            // buttonIgual
            // 
            this.buttonIgual.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIgual.Location = new System.Drawing.Point(130, 388);
            this.buttonIgual.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIgual.Name = "buttonIgual";
            this.buttonIgual.Size = new System.Drawing.Size(112, 54);
            this.buttonIgual.TabIndex = 16;
            this.buttonIgual.Text = "=";
            this.buttonIgual.UseVisualStyleBackColor = true;
            this.buttonIgual.Click += new System.EventHandler(this.buttonIgual_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(130, 156);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(54, 54);
            this.button10.TabIndex = 17;
            this.button10.Text = "√";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.AgregarOperador);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(72, 156);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(54, 54);
            this.button11.TabIndex = 18;
            this.button11.Text = "x²";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.AgregarOperador);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(14, 156);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(54, 54);
            this.button12.TabIndex = 19;
            this.button12.Text = "%";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // buttonBorrarUno
            // 
            this.buttonBorrarUno.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarUno.Location = new System.Drawing.Point(188, 98);
            this.buttonBorrarUno.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBorrarUno.Name = "buttonBorrarUno";
            this.buttonBorrarUno.Size = new System.Drawing.Size(54, 54);
            this.buttonBorrarUno.TabIndex = 20;
            this.buttonBorrarUno.Text = "<-";
            this.buttonBorrarUno.UseVisualStyleBackColor = true;
            this.buttonBorrarUno.Click += new System.EventHandler(this.buttonBorrarUno_Click);
            // 
            // buttonBorrarTodo
            // 
            this.buttonBorrarTodo.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarTodo.Location = new System.Drawing.Point(130, 98);
            this.buttonBorrarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBorrarTodo.Name = "buttonBorrarTodo";
            this.buttonBorrarTodo.Size = new System.Drawing.Size(54, 54);
            this.buttonBorrarTodo.TabIndex = 21;
            this.buttonBorrarTodo.Text = "C";
            this.buttonBorrarTodo.UseVisualStyleBackColor = true;
            this.buttonBorrarTodo.Click += new System.EventHandler(this.buttonBorrarTodo_Click);
            // 
            // buttonPuntoDecimal
            // 
            this.buttonPuntoDecimal.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPuntoDecimal.Location = new System.Drawing.Point(72, 388);
            this.buttonPuntoDecimal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPuntoDecimal.Name = "buttonPuntoDecimal";
            this.buttonPuntoDecimal.Size = new System.Drawing.Size(54, 54);
            this.buttonPuntoDecimal.TabIndex = 22;
            this.buttonPuntoDecimal.Text = ",";
            this.buttonPuntoDecimal.UseVisualStyleBackColor = true;
            this.buttonPuntoDecimal.Click += new System.EventHandler(this.buttonPuntoDecimal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 459);
            this.Controls.Add(this.buttonPuntoDecimal);
            this.Controls.Add(this.buttonBorrarTodo);
            this.Controls.Add(this.buttonBorrarUno);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonIgual);
            this.Controls.Add(this.buttonDivi);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonRestar);
            this.Controls.Add(this.buttonSumar);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.textBoxNumeros);
            this.Controls.Add(this.textBoxHistorial);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHistorial;
        private System.Windows.Forms.TextBox textBoxNumeros;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonSumar;
        private System.Windows.Forms.Button buttonRestar;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonDivi;
        private System.Windows.Forms.Button buttonIgual;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button buttonBorrarUno;
        private System.Windows.Forms.Button buttonBorrarTodo;
        private System.Windows.Forms.Button buttonPuntoDecimal;
    }
}

