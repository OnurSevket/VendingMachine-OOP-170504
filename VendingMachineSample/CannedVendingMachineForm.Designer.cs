namespace VendingMachineSample
{
    partial class CannedVendingMachineForm
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
            this.lwCanned = new System.Windows.Forms.ListView();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtEnteredMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnterMoney = new System.Windows.Forms.Button();
            this.btnOKCanned = new System.Windows.Forms.Button();
            this.btnCancelCanned = new System.Windows.Forms.Button();
            this.btnSelectCanned = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lwCanned
            // 
            this.lwCanned.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lwCanned.Location = new System.Drawing.Point(3, 215);
            this.lwCanned.Name = "lwCanned";
            this.lwCanned.Size = new System.Drawing.Size(530, 210);
            this.lwCanned.TabIndex = 0;
            this.lwCanned.UseCompatibleStateImageBehavior = false;
            this.lwCanned.View = System.Windows.Forms.View.Details;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(84, 28);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(100, 20);
            this.txtProductCode.TabIndex = 1;
            // 
            // txtEnteredMoney
            // 
            this.txtEnteredMoney.Location = new System.Drawing.Point(84, 65);
            this.txtEnteredMoney.Name = "txtEnteredMoney";
            this.txtEnteredMoney.Size = new System.Drawing.Size(100, 20);
            this.txtEnteredMoney.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Slot Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Money:";
            // 
            // btnEnterMoney
            // 
            this.btnEnterMoney.Location = new System.Drawing.Point(264, 61);
            this.btnEnterMoney.Name = "btnEnterMoney";
            this.btnEnterMoney.Size = new System.Drawing.Size(110, 23);
            this.btnEnterMoney.TabIndex = 5;
            this.btnEnterMoney.Text = "Enter Money";
            this.btnEnterMoney.UseVisualStyleBackColor = true;
            // 
            // btnOKCanned
            // 
            this.btnOKCanned.Location = new System.Drawing.Point(180, 147);
            this.btnOKCanned.Name = "btnOKCanned";
            this.btnOKCanned.Size = new System.Drawing.Size(140, 32);
            this.btnOKCanned.TabIndex = 6;
            this.btnOKCanned.Text = "OK";
            this.btnOKCanned.UseVisualStyleBackColor = true;
            // 
            // btnCancelCanned
            // 
            this.btnCancelCanned.Location = new System.Drawing.Point(355, 147);
            this.btnCancelCanned.Name = "btnCancelCanned";
            this.btnCancelCanned.Size = new System.Drawing.Size(142, 32);
            this.btnCancelCanned.TabIndex = 7;
            this.btnCancelCanned.Text = "CANCEL";
            this.btnCancelCanned.UseVisualStyleBackColor = true;
            // 
            // btnSelectCanned
            // 
            this.btnSelectCanned.Location = new System.Drawing.Point(13, 147);
            this.btnSelectCanned.Name = "btnSelectCanned";
            this.btnSelectCanned.Size = new System.Drawing.Size(139, 32);
            this.btnSelectCanned.TabIndex = 8;
            this.btnSelectCanned.Text = "SELECT";
            this.btnSelectCanned.UseVisualStyleBackColor = true;
            this.btnSelectCanned.Click += new System.EventHandler(this.btnSelectCanned_Click);
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
            // 
            // CannedVendingMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 427);
            this.Controls.Add(this.btnSelectCanned);
            this.Controls.Add(this.btnCancelCanned);
            this.Controls.Add(this.btnOKCanned);
            this.Controls.Add(this.btnEnterMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnteredMoney);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lwCanned);
            this.Name = "CannedVendingMachineForm";
            this.Text = "CannedVendingMachineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwCanned;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtEnteredMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnterMoney;
        private System.Windows.Forms.Button btnOKCanned;
        private System.Windows.Forms.Button btnCancelCanned;
        private System.Windows.Forms.Button btnSelectCanned;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}