
namespace ATM_MACHINE
{
    partial class frmAtm
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
            this.tbxGroupBox = new System.Windows.Forms.GroupBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnBalance = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnWithdrawR = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDeny = new System.Windows.Forms.Button();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnEEE = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnCcc = new System.Windows.Forms.Button();
            this.tbxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxGroupBox
            // 
            this.tbxGroupBox.Controls.Add(this.txtDisplay);
            this.tbxGroupBox.Controls.Add(this.lblHeading);
            this.tbxGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxGroupBox.Location = new System.Drawing.Point(136, 12);
            this.tbxGroupBox.Name = "tbxGroupBox";
            this.tbxGroupBox.Size = new System.Drawing.Size(426, 393);
            this.tbxGroupBox.TabIndex = 0;
            this.tbxGroupBox.TabStop = false;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(44, 66);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(359, 200);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.Text = "Please Enter Pin to Continue! :";
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(156, 34);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(101, 13);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Money Marketplace";
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(33, 64);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(107, 67);
            this.btnBalance.TabIndex = 1;
            this.btnBalance.Text = "Balance";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(33, 123);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(107, 71);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnWithdrawR
            // 
            this.btnWithdrawR.Location = new System.Drawing.Point(33, 193);
            this.btnWithdrawR.Name = "btnWithdrawR";
            this.btnWithdrawR.Size = new System.Drawing.Size(107, 57);
            this.btnWithdrawR.TabIndex = 3;
            this.btnWithdrawR.Text = "Withdraw with Receipt";
            this.btnWithdrawR.UseVisualStyleBackColor = true;
            this.btnWithdrawR.Click += new System.EventHandler(this.btnWithdrawR_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(33, 248);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(107, 53);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(33, 300);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(107, 55);
            this.btnDeny.TabIndex = 5;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // txtCard
            // 
            this.txtCard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCard.Location = new System.Drawing.Point(595, 109);
            this.txtCard.Multiline = true;
            this.txtCard.Name = "txtCard";
            this.txtCard.ReadOnly = true;
            this.txtCard.Size = new System.Drawing.Size(155, 22);
            this.txtCard.TabIndex = 6;
            this.txtCard.Text = "       Insert Your Card Here 🤖";
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(591, 161);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(54, 23);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(651, 161);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(53, 23);
            this.btnEight.TabIndex = 8;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(710, 161);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(49, 23);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(591, 194);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(54, 23);
            this.btnFour.TabIndex = 10;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(651, 193);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(54, 23);
            this.btnFive.TabIndex = 11;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(711, 193);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(48, 23);
            this.btnSix.TabIndex = 12;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(591, 227);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(53, 23);
            this.btnOne.TabIndex = 13;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(653, 227);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(52, 23);
            this.btnTwo.TabIndex = 14;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(711, 228);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(48, 23);
            this.btnThree.TabIndex = 15;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnEEE
            // 
            this.btnEEE.Location = new System.Drawing.Point(591, 264);
            this.btnEEE.Name = "btnEEE";
            this.btnEEE.Size = new System.Drawing.Size(53, 23);
            this.btnEEE.TabIndex = 16;
            this.btnEEE.Text = "A";
            this.btnEEE.UseVisualStyleBackColor = true;
            this.btnEEE.Click += new System.EventHandler(this.btnEEE_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(653, 263);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(53, 23);
            this.btnZero.TabIndex = 17;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnCcc
            // 
            this.btnCcc.Location = new System.Drawing.Point(712, 263);
            this.btnCcc.Name = "btnCcc";
            this.btnCcc.Size = new System.Drawing.Size(47, 23);
            this.btnCcc.TabIndex = 18;
            this.btnCcc.Text = "C";
            this.btnCcc.UseVisualStyleBackColor = true;
            this.btnCcc.Click += new System.EventHandler(this.btnCcc_Click);
            // 
            // frmAtm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCcc);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnEEE);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnWithdrawR);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.tbxGroupBox);
            this.Name = "frmAtm";
            this.Text = "Money Market Place";
            this.Load += new System.EventHandler(this.frmAtm_Load);
            this.tbxGroupBox.ResumeLayout(false);
            this.tbxGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox tbxGroupBox;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnWithdrawR;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnEEE;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnCcc;
    }
}

