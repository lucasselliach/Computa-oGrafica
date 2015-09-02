namespace AppCG
{
    partial class Form1
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
            this.pictureBoxVisualizaImagem = new System.Windows.Forms.PictureBox();
            this.textBoxOpenFile = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonTonsCinza = new System.Windows.Forms.Button();
            this.buttonPalette = new System.Windows.Forms.Button();
            this.buttonKhromaKey = new System.Windows.Forms.Button();
            this.buttonFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisualizaImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVisualizaImagem
            // 
            this.pictureBoxVisualizaImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxVisualizaImagem.Location = new System.Drawing.Point(12, 69);
            this.pictureBoxVisualizaImagem.Name = "pictureBoxVisualizaImagem";
            this.pictureBoxVisualizaImagem.Size = new System.Drawing.Size(523, 363);
            this.pictureBoxVisualizaImagem.TabIndex = 0;
            this.pictureBoxVisualizaImagem.TabStop = false;
            // 
            // textBoxOpenFile
            // 
            this.textBoxOpenFile.Location = new System.Drawing.Point(12, 12);
            this.textBoxOpenFile.Name = "textBoxOpenFile";
            this.textBoxOpenFile.Size = new System.Drawing.Size(500, 20);
            this.textBoxOpenFile.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(508, 11);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(27, 21);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonTonsCinza
            // 
            this.buttonTonsCinza.Location = new System.Drawing.Point(12, 38);
            this.buttonTonsCinza.Name = "buttonTonsCinza";
            this.buttonTonsCinza.Size = new System.Drawing.Size(122, 23);
            this.buttonTonsCinza.TabIndex = 3;
            this.buttonTonsCinza.Text = "Tons de Cinzas";
            this.buttonTonsCinza.UseVisualStyleBackColor = true;
            this.buttonTonsCinza.Click += new System.EventHandler(this.buttonTonsCinza_Click);
            // 
            // buttonPalette
            // 
            this.buttonPalette.Location = new System.Drawing.Point(140, 38);
            this.buttonPalette.Name = "buttonPalette";
            this.buttonPalette.Size = new System.Drawing.Size(127, 23);
            this.buttonPalette.TabIndex = 4;
            this.buttonPalette.Text = "Redução de Cores";
            this.buttonPalette.UseVisualStyleBackColor = true;
            this.buttonPalette.Click += new System.EventHandler(this.buttonPalette_Click);
            // 
            // buttonKhromaKey
            // 
            this.buttonKhromaKey.Location = new System.Drawing.Point(273, 38);
            this.buttonKhromaKey.Name = "buttonKhromaKey";
            this.buttonKhromaKey.Size = new System.Drawing.Size(125, 23);
            this.buttonKhromaKey.TabIndex = 5;
            this.buttonKhromaKey.Text = "Khroma Key";
            this.buttonKhromaKey.UseVisualStyleBackColor = true;
            this.buttonKhromaKey.Click += new System.EventHandler(this.buttonKhromaKey_Click);
            // 
            // buttonFiltros
            // 
            this.buttonFiltros.Location = new System.Drawing.Point(404, 38);
            this.buttonFiltros.Name = "buttonFiltros";
            this.buttonFiltros.Size = new System.Drawing.Size(131, 23);
            this.buttonFiltros.TabIndex = 6;
            this.buttonFiltros.Text = "Filtros";
            this.buttonFiltros.UseVisualStyleBackColor = true;
            this.buttonFiltros.Click += new System.EventHandler(this.buttonFiltros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 444);
            this.Controls.Add(this.buttonFiltros);
            this.Controls.Add(this.buttonKhromaKey);
            this.Controls.Add(this.buttonPalette);
            this.Controls.Add(this.buttonTonsCinza);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxOpenFile);
            this.Controls.Add(this.pictureBoxVisualizaImagem);
            this.Name = "Form1";
            this.Text = "Trabalho CG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisualizaImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVisualizaImagem;
        private System.Windows.Forms.TextBox textBoxOpenFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonTonsCinza;
        private System.Windows.Forms.Button buttonPalette;
        private System.Windows.Forms.Button buttonKhromaKey;
        private System.Windows.Forms.Button buttonFiltros;
    }
}

