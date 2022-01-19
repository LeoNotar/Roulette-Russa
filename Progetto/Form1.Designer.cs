namespace Progetto
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spara = new System.Windows.Forms.Button();
            this.turno = new System.Windows.Forms.TextBox();
            this.carica = new System.Windows.Forms.Button();
            this.ris = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatore = new System.Windows.Forms.ToolStripMenuItem();
            this.oPZIONIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spara
            // 
            this.spara.BackColor = System.Drawing.Color.White;
            this.spara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spara.Location = new System.Drawing.Point(43, 112);
            this.spara.Name = "spara";
            this.spara.Size = new System.Drawing.Size(172, 84);
            this.spara.TabIndex = 0;
            this.spara.Text = "SPARA";
            this.spara.UseVisualStyleBackColor = false;
            this.spara.Click += new System.EventHandler(this.spara_Click);
            // 
            // turno
            // 
            this.turno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.turno.Enabled = false;
            this.turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.turno.ForeColor = System.Drawing.Color.Black;
            this.turno.Location = new System.Drawing.Point(120, 476);
            this.turno.Multiline = true;
            this.turno.Name = "turno";
            this.turno.Size = new System.Drawing.Size(226, 41);
            this.turno.TabIndex = 1;
            this.turno.Text = "Turno giocatore 1";
            this.turno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // carica
            // 
            this.carica.BackColor = System.Drawing.Color.White;
            this.carica.Location = new System.Drawing.Point(43, 216);
            this.carica.Name = "carica";
            this.carica.Size = new System.Drawing.Size(131, 37);
            this.carica.TabIndex = 3;
            this.carica.Text = "carica pistola";
            this.carica.UseVisualStyleBackColor = false;
            this.carica.Click += new System.EventHandler(this.carica_Click);
            // 
            // ris
            // 
            this.ris.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ris.Enabled = false;
            this.ris.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.ris.Location = new System.Drawing.Point(616, 123);
            this.ris.Multiline = true;
            this.ris.Name = "ris";
            this.ris.Size = new System.Drawing.Size(40, 73);
            this.ris.TabIndex = 4;
            // 
            // res
            // 
            this.res.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.res.Enabled = false;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.res.ForeColor = System.Drawing.Color.Black;
            this.res.Location = new System.Drawing.Point(363, 476);
            this.res.Multiline = true;
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(255, 41);
            this.res.TabIndex = 5;
            this.res.Text = "Proiettili restanti : 6";
            this.res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNFOToolStripMenuItem,
            this.oPZIONIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNFOToolStripMenuItem
            // 
            this.iNFOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatore});
            this.iNFOToolStripMenuItem.Name = "iNFOToolStripMenuItem";
            this.iNFOToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.iNFOToolStripMenuItem.Text = "INFO";
            // 
            // creatore
            // 
            this.creatore.Name = "creatore";
            this.creatore.Size = new System.Drawing.Size(181, 34);
            this.creatore.Text = "Creatore";
            this.creatore.Click += new System.EventHandler(this.creatore_Click);
            // 
            // oPZIONIToolStripMenuItem
            // 
            this.oPZIONIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSCIToolStripMenuItem});
            this.oPZIONIToolStripMenuItem.Name = "oPZIONIToolStripMenuItem";
            this.oPZIONIToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.oPZIONIToolStripMenuItem.Text = "OPZIONI";
            // 
            // eSCIToolStripMenuItem
            // 
            this.eSCIToolStripMenuItem.Name = "eSCIToolStripMenuItem";
            this.eSCIToolStripMenuItem.Size = new System.Drawing.Size(149, 34);
            this.eSCIToolStripMenuItem.Text = "ESCI";
            this.eSCIToolStripMenuItem.Click += new System.EventHandler(this.eSCIToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(766, 529);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.ris);
            this.Controls.Add(this.carica);
            this.Controls.Add(this.turno);
            this.Controls.Add(this.spara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roulette Russa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spara;
        private System.Windows.Forms.TextBox turno;
        private System.Windows.Forms.Button carica;
        private System.Windows.Forms.TextBox ris;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatore;
        private System.Windows.Forms.ToolStripMenuItem oPZIONIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSCIToolStripMenuItem;
    }
}

