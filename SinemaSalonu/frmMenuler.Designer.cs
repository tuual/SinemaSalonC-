namespace SinemaSalonu
{
    partial class frmMenuler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seanslarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmSeansıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmSeanslarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "İşlemlerinizi buradan yapabilirsiniz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin paneline hoşgeldiniz.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seanslarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            // 
            // seanslarToolStripMenuItem
            // 
            this.seanslarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmSeansıEkleToolStripMenuItem,
            this.filmSeanslarıToolStripMenuItem});
            this.seanslarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seanslarToolStripMenuItem.Image = global::SinemaSalonu.Properties.Resources.camera;
            this.seanslarToolStripMenuItem.Name = "seanslarToolStripMenuItem";
            this.seanslarToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.seanslarToolStripMenuItem.Text = "Seanslar";
            // 
            // filmSeansıEkleToolStripMenuItem
            // 
            this.filmSeansıEkleToolStripMenuItem.Image = global::SinemaSalonu.Properties.Resources.add_video;
            this.filmSeansıEkleToolStripMenuItem.Name = "filmSeansıEkleToolStripMenuItem";
            this.filmSeansıEkleToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.filmSeansıEkleToolStripMenuItem.Text = "Film Seansı Ekle";
            this.filmSeansıEkleToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.filmSeansıEkleToolStripMenuItem.Click += new System.EventHandler(this.filmSeansıEkleToolStripMenuItem_Click);
            // 
            // filmSeanslarıToolStripMenuItem
            // 
            this.filmSeanslarıToolStripMenuItem.Image = global::SinemaSalonu.Properties.Resources.film_strip;
            this.filmSeanslarıToolStripMenuItem.Name = "filmSeanslarıToolStripMenuItem";
            this.filmSeanslarıToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.filmSeanslarıToolStripMenuItem.Text = "Film Seansları";
            this.filmSeanslarıToolStripMenuItem.Click += new System.EventHandler(this.filmSeanslarıToolStripMenuItem_Click);
            // 
            // frmMenuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMenuler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seanslarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmSeansıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmSeanslarıToolStripMenuItem;
    }
}