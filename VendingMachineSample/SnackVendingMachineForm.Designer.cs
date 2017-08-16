namespace VendingMachineSample
{
    partial class SnackVendingMachineForm
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
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntereMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblenteredMoney = new System.Windows.Forms.Label();
            this.lwShowSnacks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelectSnack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(93, 20);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(100, 20);
            this.txtProductCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Code:";
            // 
            // txtEntereMoney
            // 
            this.txtEntereMoney.Location = new System.Drawing.Point(94, 60);
            this.txtEntereMoney.Name = "txtEntereMoney";
            this.txtEntereMoney.Size = new System.Drawing.Size(100, 20);
            this.txtEntereMoney.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Money :";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(196, 144);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(158, 32);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(384, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Location = new System.Drawing.Point(120, 100);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(83, 19);
            this.btnAddMoney.TabIndex = 6;
            this.btnAddMoney.Text = "ADD MONEY";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lwShowSnacks);
            this.panel1.Location = new System.Drawing.Point(12, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 306);
            this.panel1.TabIndex = 7;
            // 
            // lblenteredMoney
            // 
            this.lblenteredMoney.AutoSize = true;
            this.lblenteredMoney.Location = new System.Drawing.Point(302, 66);
            this.lblenteredMoney.Name = "lblenteredMoney";
            this.lblenteredMoney.Size = new System.Drawing.Size(0, 13);
            this.lblenteredMoney.TabIndex = 8;
            // 
            // lwShowSnacks
            // 
            this.lwShowSnacks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lwShowSnacks.Location = new System.Drawing.Point(17, 22);
            this.lwShowSnacks.Name = "lwShowSnacks";
            this.lwShowSnacks.Size = new System.Drawing.Size(593, 281);
            this.lwShowSnacks.TabIndex = 0;
            this.lwShowSnacks.UseCompatibleStateImageBehavior = false;
            this.lwShowSnacks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Slot Code";
            this.columnHeader3.Width = 105;
            // 
            // btnSelectSnack
            // 
            this.btnSelectSnack.Location = new System.Drawing.Point(18, 144);
            this.btnSelectSnack.Name = "btnSelectSnack";
            this.btnSelectSnack.Size = new System.Drawing.Size(158, 32);
            this.btnSelectSnack.TabIndex = 9;
            this.btnSelectSnack.Text = "SELECT";
            this.btnSelectSnack.UseVisualStyleBackColor = true;
            this.btnSelectSnack.Click += new System.EventHandler(this.btnSelectSnack_Click);
            // 
            // SnackVendingMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 503);
            this.Controls.Add(this.btnSelectSnack);
            this.Controls.Add(this.lblenteredMoney);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEntereMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductCode);
            this.Name = "SnackVendingMachineForm";
            this.Text = "SnackVendingMachineForm";
            this.Load += new System.EventHandler(this.SnackVendingMachineForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntereMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblenteredMoney;
        private System.Windows.Forms.ListView lwShowSnacks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSelectSnack;
    }
}