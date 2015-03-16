namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtTrack = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArtista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlbum = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnTrack);
            this.splitContainer1.Panel1.Controls.Add(this.btnAlbum);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnArtista);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtTrack);
            this.splitContainer1.Panel1.Controls.Add(this.txtAlbum);
            this.splitContainer1.Panel1.Controls.Add(this.txtArtista);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(557, 415);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(368, 415);
            this.webBrowser1.TabIndex = 0;
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(12, 25);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(153, 20);
            this.txtArtista.TabIndex = 0;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(12, 136);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(153, 20);
            this.txtAlbum.TabIndex = 1;
            // 
            // txtTrack
            // 
            this.txtTrack.Location = new System.Drawing.Point(12, 235);
            this.txtTrack.Name = "txtTrack";
            this.txtTrack.Size = new System.Drawing.Size(153, 20);
            this.txtTrack.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Artista";
            // 
            // btnArtista
            // 
            this.btnArtista.Location = new System.Drawing.Point(46, 51);
            this.btnArtista.Name = "btnArtista";
            this.btnArtista.Size = new System.Drawing.Size(75, 23);
            this.btnArtista.TabIndex = 4;
            this.btnArtista.Text = "buscar";
            this.btnArtista.UseVisualStyleBackColor = true;
            this.btnArtista.Click += new System.EventHandler(this.btnArtista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Track";
            // 
            // btnAlbum
            // 
            this.btnAlbum.Location = new System.Drawing.Point(46, 162);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnAlbum.TabIndex = 7;
            this.btnAlbum.Text = "buscar";
            this.btnAlbum.UseVisualStyleBackColor = true;
            this.btnAlbum.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(46, 261);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(75, 23);
            this.btnTrack.TabIndex = 8;
            this.btnTrack.Text = "buscar";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 415);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnArtista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrack;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

