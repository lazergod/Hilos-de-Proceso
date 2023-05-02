namespace Hilos_de_Proceso
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
            components = new System.ComponentModel.Container();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            tmr2 = new System.Windows.Forms.Timer(components);
            tmr3 = new System.Windows.Forms.Timer(components);
            tmr1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(196, 48);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(17, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "0";
            lbl1.Click += lbl1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(196, 150);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(17, 20);
            lbl2.TabIndex = 1;
            lbl2.Text = "0";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(196, 269);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(17, 20);
            lbl3.TabIndex = 2;
            lbl3.Text = "0";
            // 
            // tmr2
            // 
            tmr2.Enabled = true;
            tmr2.Tick += tmr2_Tick;
            // 
            // tmr3
            // 
            tmr3.Enabled = true;
            tmr3.Tick += tmr3_Tick;
            // 
            // tmr1
            // 
            tmr1.Enabled = true;
            tmr1.Tick += tmr1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            ClientSize = new Size(435, 357);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private System.Windows.Forms.Timer tmr2;
        private System.Windows.Forms.Timer tmr3;
        private System.Windows.Forms.Timer tmr1;
    }
}