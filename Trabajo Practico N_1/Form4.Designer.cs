namespace Trabajo_Practico_N_1
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbfemen = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btmostrar = new System.Windows.Forms.Button();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbsoltera = new System.Windows.Forms.RadioButton();
            this.rbcasda = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbmasculino);
            this.groupBox1.Controls.Add(this.rbfemen);
            this.groupBox1.Location = new System.Drawing.Point(129, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbfemen
            // 
            this.rbfemen.AutoSize = true;
            this.rbfemen.Checked = true;
            this.rbfemen.Location = new System.Drawing.Point(30, 30);
            this.rbfemen.Name = "rbfemen";
            this.rbfemen.Size = new System.Drawing.Size(71, 17);
            this.rbfemen.TabIndex = 1;
            this.rbfemen.TabStop = true;
            this.rbfemen.Text = "Femenino";
            this.rbfemen.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Data entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.checkedListBox1.Location = new System.Drawing.Point(218, 156);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(242, 94);
            this.checkedListBox1.TabIndex = 1;
            // 
            // btmostrar
            // 
            this.btmostrar.Location = new System.Drawing.Point(237, 256);
            this.btmostrar.Name = "btmostrar";
            this.btmostrar.Size = new System.Drawing.Size(211, 32);
            this.btmostrar.TabIndex = 2;
            this.btmostrar.Text = "Mostrar lo que se selecciono";
            this.btmostrar.UseVisualStyleBackColor = true;
            this.btmostrar.Click += new System.EventHandler(this.btmostrar_Click);
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(30, 53);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(73, 17);
            this.rbmasculino.TabIndex = 2;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbsoltera);
            this.groupBox2.Controls.Add(this.rbcasda);
            this.groupBox2.Location = new System.Drawing.Point(379, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado civil";
            // 
            // rbsoltera
            // 
            this.rbsoltera.AutoSize = true;
            this.rbsoltera.Location = new System.Drawing.Point(30, 53);
            this.rbsoltera.Name = "rbsoltera";
            this.rbsoltera.Size = new System.Drawing.Size(58, 17);
            this.rbsoltera.TabIndex = 2;
            this.rbsoltera.Text = "Soltera";
            this.rbsoltera.UseVisualStyleBackColor = true;
            // 
            // rbcasda
            // 
            this.rbcasda.AutoSize = true;
            this.rbcasda.Checked = true;
            this.rbcasda.Location = new System.Drawing.Point(30, 30);
            this.rbcasda.Name = "rbcasda";
            this.rbcasda.Size = new System.Drawing.Size(61, 17);
            this.rbcasda.TabIndex = 1;
            this.rbcasda.TabStop = true;
            this.rbcasda.Text = "Casada";
            this.rbcasda.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(218, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 105);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btmostrar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbfemen;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btmostrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbsoltera;
        private System.Windows.Forms.RadioButton rbcasda;
        private System.Windows.Forms.Label label1;
    }
}