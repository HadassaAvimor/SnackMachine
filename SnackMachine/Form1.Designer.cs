namespace SnackMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.snackBtn = new System.Windows.Forms.Button();
            this.coldDrinkBtn = new System.Windows.Forms.Button();
            this.hotDrinkBtn = new System.Windows.Forms.Button();
            this.slogen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(326, 58);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(88, 15);
            this.title.TabIndex = 0;
            this.title.Text = "?מה בא לך היום";
            // 
            // snackBtn
            // 
            this.snackBtn.Location = new System.Drawing.Point(459, 120);
            this.snackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.snackBtn.Name = "snackBtn";
            this.snackBtn.Size = new System.Drawing.Size(133, 22);
            this.snackBtn.TabIndex = 1;
            this.snackBtn.Text = "חטיפים";
            this.snackBtn.UseVisualStyleBackColor = true;
            this.snackBtn.Click += new System.EventHandler(this.snackBtn_Click_1);
            // 
            // coldDrinkBtn
            // 
            this.coldDrinkBtn.Location = new System.Drawing.Point(284, 120);
            this.coldDrinkBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coldDrinkBtn.Name = "coldDrinkBtn";
            this.coldDrinkBtn.Size = new System.Drawing.Size(139, 22);
            this.coldDrinkBtn.TabIndex = 2;
            this.coldDrinkBtn.Text = "שתיה קרה מרעננת";
            this.coldDrinkBtn.UseVisualStyleBackColor = true;
            this.coldDrinkBtn.Click += new System.EventHandler(this.coldDrinkBtn_Click);
            // 
            // hotDrinkBtn
            // 
            this.hotDrinkBtn.Location = new System.Drawing.Point(121, 120);
            this.hotDrinkBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hotDrinkBtn.Name = "hotDrinkBtn";
            this.hotDrinkBtn.Size = new System.Drawing.Size(133, 22);
            this.hotDrinkBtn.TabIndex = 3;
            this.hotDrinkBtn.Text = "שתיה חמה לנפש";
            this.hotDrinkBtn.UseVisualStyleBackColor = true;
            // 
            // slogen
            // 
            this.slogen.AutoSize = true;
            this.slogen.Location = new System.Drawing.Point(304, 280);
            this.slogen.Name = "slogen";
            this.slogen.Size = new System.Drawing.Size(131, 15);
            this.slogen.TabIndex = 4;
            this.slogen.Text = "אכול ושתה כי מחר נמות";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.slogen);
            this.Controls.Add(this.hotDrinkBtn);
            this.Controls.Add(this.coldDrinkBtn);
            this.Controls.Add(this.snackBtn);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title;
        private Button snackBtn;
        private Button coldDrinkBtn;
        private Button hotDrinkBtn;
        private Label slogen;
    }
}