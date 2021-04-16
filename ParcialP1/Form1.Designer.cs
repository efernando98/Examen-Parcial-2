
namespace ParcialP1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFile = new System.Windows.Forms.Button();
            this.textFile = new System.Windows.Forms.TextBox();
            this.listParcial = new System.Windows.Forms.ListBox();
            this.listFile = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.Button();
            this.btnP1 = new System.Windows.Forms.Button();
            this.btnP2 = new System.Windows.Forms.Button();
            this.btnP3 = new System.Windows.Forms.Button();
            this.btnP3A = new System.Windows.Forms.Button();
            this.btnP2A = new System.Windows.Forms.Button();
            this.btnP1A = new System.Windows.Forms.Button();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.textSecc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClasif = new System.Windows.Forms.Button();
            this.btnP3G = new System.Windows.Forms.Button();
            this.btnP2G = new System.Windows.Forms.Button();
            this.btnP1G = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFile.Location = new System.Drawing.Point(12, 6);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(172, 46);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Mostrar Archivo";
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(223, 6);
            this.textFile.Multiline = true;
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(537, 46);
            this.textFile.TabIndex = 1;
            // 
            // listParcial
            // 
            this.listParcial.FormattingEnabled = true;
            this.listParcial.ItemHeight = 20;
            this.listParcial.Location = new System.Drawing.Point(12, 406);
            this.listParcial.Name = "listParcial";
            this.listParcial.Size = new System.Drawing.Size(748, 244);
            this.listParcial.TabIndex = 2;
            // 
            // listFile
            // 
            this.listFile.FormattingEnabled = true;
            this.listFile.HorizontalScrollbar = true;
            this.listFile.ItemHeight = 20;
            this.listFile.Location = new System.Drawing.Point(821, 6);
            this.listFile.MultiColumn = true;
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(391, 644);
            this.listFile.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkViolet;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Promedios por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkViolet;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite una Sección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkViolet;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ordenar por:";
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnName.Location = new System.Drawing.Point(16, 352);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(102, 40);
            this.btnName.TabIndex = 7;
            this.btnName.Text = "Nombre";
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnP1
            // 
            this.btnP1.Location = new System.Drawing.Point(174, 352);
            this.btnP1.Name = "btnP1";
            this.btnP1.Size = new System.Drawing.Size(109, 40);
            this.btnP1.TabIndex = 8;
            this.btnP1.Text = "Parcial Uno";
            this.btnP1.UseVisualStyleBackColor = true;
            this.btnP1.Click += new System.EventHandler(this.btnP1_Click);
            // 
            // btnP2
            // 
            this.btnP2.Location = new System.Drawing.Point(339, 352);
            this.btnP2.Name = "btnP2";
            this.btnP2.Size = new System.Drawing.Size(105, 39);
            this.btnP2.TabIndex = 9;
            this.btnP2.Text = "Parcial Dos";
            this.btnP2.UseVisualStyleBackColor = true;
            this.btnP2.Click += new System.EventHandler(this.btnP2_Click);
            // 
            // btnP3
            // 
            this.btnP3.Location = new System.Drawing.Point(504, 353);
            this.btnP3.Name = "btnP3";
            this.btnP3.Size = new System.Drawing.Size(109, 39);
            this.btnP3.TabIndex = 10;
            this.btnP3.Text = "Parcial Tres";
            this.btnP3.UseVisualStyleBackColor = true;
            this.btnP3.Click += new System.EventHandler(this.btnP3_Click);
            // 
            // btnP3A
            // 
            this.btnP3A.Location = new System.Drawing.Point(504, 91);
            this.btnP3A.Name = "btnP3A";
            this.btnP3A.Size = new System.Drawing.Size(109, 40);
            this.btnP3A.TabIndex = 14;
            this.btnP3A.Text = "Parcial Tres";
            this.btnP3A.UseVisualStyleBackColor = true;
            this.btnP3A.Click += new System.EventHandler(this.btnP3A_Click);
            // 
            // btnP2A
            // 
            this.btnP2A.Location = new System.Drawing.Point(339, 91);
            this.btnP2A.Name = "btnP2A";
            this.btnP2A.Size = new System.Drawing.Size(105, 40);
            this.btnP2A.TabIndex = 13;
            this.btnP2A.Text = "Parcial Dos";
            this.btnP2A.UseVisualStyleBackColor = true;
            this.btnP2A.Click += new System.EventHandler(this.btnP2A_Click);
            // 
            // btnP1A
            // 
            this.btnP1A.Location = new System.Drawing.Point(174, 91);
            this.btnP1A.Name = "btnP1A";
            this.btnP1A.Size = new System.Drawing.Size(109, 40);
            this.btnP1A.TabIndex = 12;
            this.btnP1A.Text = "Parcial Uno";
            this.btnP1A.UseVisualStyleBackColor = true;
            this.btnP1A.Click += new System.EventHandler(this.btnP1A_Click);
            // 
            // btnAlumno
            // 
            this.btnAlumno.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAlumno.Location = new System.Drawing.Point(16, 91);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(102, 40);
            this.btnAlumno.TabIndex = 11;
            this.btnAlumno.Text = "Alumnos";
            this.btnAlumno.UseVisualStyleBackColor = false;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.SystemColors.Info;
            this.btnSuma.Location = new System.Drawing.Point(654, 91);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(106, 40);
            this.btnSuma.TabIndex = 15;
            this.btnSuma.Text = "Sumatoria";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // textSecc
            // 
            this.textSecc.Location = new System.Drawing.Point(12, 190);
            this.textSecc.Name = "textSecc";
            this.textSecc.Size = new System.Drawing.Size(322, 26);
            this.textSecc.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkViolet;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Promedios por Sección:";
            // 
            // btnClasif
            // 
            this.btnClasif.BackColor = System.Drawing.SystemColors.Info;
            this.btnClasif.Location = new System.Drawing.Point(654, 265);
            this.btnClasif.Name = "btnClasif";
            this.btnClasif.Size = new System.Drawing.Size(106, 40);
            this.btnClasif.TabIndex = 22;
            this.btnClasif.Text = "Clasificar";
            this.btnClasif.UseVisualStyleBackColor = false;
            this.btnClasif.Click += new System.EventHandler(this.btnClasif_Click);
            // 
            // btnP3G
            // 
            this.btnP3G.Location = new System.Drawing.Point(504, 265);
            this.btnP3G.Name = "btnP3G";
            this.btnP3G.Size = new System.Drawing.Size(109, 40);
            this.btnP3G.TabIndex = 21;
            this.btnP3G.Text = "Parcial Tres";
            this.btnP3G.UseVisualStyleBackColor = true;
            this.btnP3G.Click += new System.EventHandler(this.btnP3G_Click);
            // 
            // btnP2G
            // 
            this.btnP2G.Location = new System.Drawing.Point(339, 265);
            this.btnP2G.Name = "btnP2G";
            this.btnP2G.Size = new System.Drawing.Size(105, 40);
            this.btnP2G.TabIndex = 20;
            this.btnP2G.Text = "Parcial Dos";
            this.btnP2G.UseVisualStyleBackColor = true;
            this.btnP2G.Click += new System.EventHandler(this.btnP2G_Click);
            // 
            // btnP1G
            // 
            this.btnP1G.Location = new System.Drawing.Point(174, 265);
            this.btnP1G.Name = "btnP1G";
            this.btnP1G.Size = new System.Drawing.Size(109, 40);
            this.btnP1G.TabIndex = 19;
            this.btnP1G.Text = "Parcial Uno";
            this.btnP1G.UseVisualStyleBackColor = true;
            this.btnP1G.Click += new System.EventHandler(this.btnP1G_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGeneral.Location = new System.Drawing.Point(16, 265);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(102, 40);
            this.btnGeneral.TabIndex = 18;
            this.btnGeneral.Text = "General";
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 661);
            this.Controls.Add(this.btnClasif);
            this.Controls.Add(this.btnP3G);
            this.Controls.Add(this.btnP2G);
            this.Controls.Add(this.btnP1G);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSecc);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnP3A);
            this.Controls.Add(this.btnP2A);
            this.Controls.Add(this.btnP1A);
            this.Controls.Add(this.btnAlumno);
            this.Controls.Add(this.btnP3);
            this.Controls.Add(this.btnP2);
            this.Controls.Add(this.btnP1);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.listParcial);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.btnFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PARCIAL DOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.ListBox listParcial;
        private System.Windows.Forms.ListBox listFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnP1;
        private System.Windows.Forms.Button btnP2;
        private System.Windows.Forms.Button btnP3;
        private System.Windows.Forms.Button btnP3A;
        private System.Windows.Forms.Button btnP2A;
        private System.Windows.Forms.Button btnP1A;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox textSecc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClasif;
        private System.Windows.Forms.Button btnP3G;
        private System.Windows.Forms.Button btnP2G;
        private System.Windows.Forms.Button btnP1G;
        private System.Windows.Forms.Button btnGeneral;
    }
}

