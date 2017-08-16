namespace VendingMachineSample
{
    partial class MDIMaintenance
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msiAddPRoduct = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAddProdduct = new System.Windows.Forms.ToolStripMenuItem();
            this.urunAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miBuySnack = new System.Windows.Forms.ToolStripMenuItem();
            this.miCannedDrinks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAddPRoduct,
            this.urunAlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msiAddPRoduct
            // 
            this.msiAddPRoduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAddProdduct});
            this.msiAddPRoduct.Name = "msiAddPRoduct";
            this.msiAddPRoduct.Size = new System.Drawing.Size(99, 20);
            this.msiAddPRoduct.Text = "Bakim Islemleri";
            // 
            // msiAddProdduct
            // 
            this.msiAddProdduct.Name = "msiAddProdduct";
            this.msiAddProdduct.Size = new System.Drawing.Size(175, 22);
            this.msiAddProdduct.Text = "Urun Ekleme/Silme";
            this.msiAddProdduct.Click += new System.EventHandler(this.msiAddProdduct_Click);
            // 
            // urunAlToolStripMenuItem
            // 
            this.urunAlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBuySnack,
            this.miCannedDrinks});
            this.urunAlToolStripMenuItem.Name = "urunAlToolStripMenuItem";
            this.urunAlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.urunAlToolStripMenuItem.Text = "Urun Al";
            // 
            // miBuySnack
            // 
            this.miBuySnack.Name = "miBuySnack";
            this.miBuySnack.Size = new System.Drawing.Size(159, 22);
            this.miBuySnack.Text = "Atistirmalik al";
            this.miBuySnack.Click += new System.EventHandler(this.miBuySnack_Click);
            // 
            // miCannedDrinks
            // 
            this.miCannedDrinks.Name = "miCannedDrinks";
            this.miCannedDrinks.Size = new System.Drawing.Size(159, 22);
            this.miCannedDrinks.Text = "Kutulu Icecek Al";
            this.miCannedDrinks.Click += new System.EventHandler(this.miCannedDrinks_Click);
            // 
            // MDIMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 323);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIMaintenance";
            this.Text = "MDIMaintenance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msiAddPRoduct;
        private System.Windows.Forms.ToolStripMenuItem msiAddProdduct;
        private System.Windows.Forms.ToolStripMenuItem urunAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miBuySnack;
        private System.Windows.Forms.ToolStripMenuItem miCannedDrinks;
    }
}