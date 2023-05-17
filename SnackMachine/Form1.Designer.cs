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
            title = new Label();
            snackBtn = new Button();
            coldDrinkBtn = new Button();
            hotDrinkBtn = new Button();
            slogen = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = SystemColors.Control;
            title.Location = new Point(373, 77);
            title.Name = "title";
            title.Size = new Size(111, 20);
            title.TabIndex = 0;
            title.Text = "?מה בא לך היום";
            // 
            // snackBtn
            // 
            snackBtn.Location = new Point(525, 160);
            snackBtn.Name = "snackBtn";
            snackBtn.Size = new Size(152, 29);
            snackBtn.TabIndex = 1;
            snackBtn.Text = "חטיפים";
            snackBtn.UseVisualStyleBackColor = true;
            snackBtn.Click += snackBtn_Click_1;
            // 
            // coldDrinkBtn
            // 
            coldDrinkBtn.Location = new Point(325, 160);
            coldDrinkBtn.Name = "coldDrinkBtn";
            coldDrinkBtn.Size = new Size(159, 29);
            coldDrinkBtn.TabIndex = 2;
            coldDrinkBtn.Text = "שתיה קרה מרעננת";
            coldDrinkBtn.UseVisualStyleBackColor = true;
            coldDrinkBtn.Click += coldDrinkBtn_Click;
            // 
            // hotDrinkBtn
            // 
            hotDrinkBtn.Location = new Point(138, 160);
            hotDrinkBtn.Name = "hotDrinkBtn";
            hotDrinkBtn.Size = new Size(152, 29);
            hotDrinkBtn.TabIndex = 3;
            hotDrinkBtn.Text = "שתיה חמה לנפש";
            hotDrinkBtn.UseVisualStyleBackColor = true;
            hotDrinkBtn.Click += hotDrinkBtn_Click;
            // 
            // slogen
            // 
            slogen.AutoSize = true;
            slogen.Location = new Point(347, 373);
            slogen.Name = "slogen";
            slogen.Size = new Size(163, 20);
            slogen.TabIndex = 4;
            slogen.Text = "אכול ושתה כי מחר נמות";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(slogen);
            Controls.Add(hotDrinkBtn);
            Controls.Add(coldDrinkBtn);
            Controls.Add(snackBtn);
            Controls.Add(title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button snackBtn;
        private Button coldDrinkBtn;
        private Button hotDrinkBtn;
        private Label slogen;
    }
}