namespace Catalog
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
            label1 = new Label();
            materiaTextBox = new TextBox();
            notaTextBox = new TextBox();
            numetextBox = new TextBox();
            panel1 = new Panel();
            afisajText = new Label();
            buttonTextBox = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 42);
            label1.Name = "label1";
            label1.Size = new Size(339, 60);
            label1.TabIndex = 0;
            label1.Text = "CATALOG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // materiaTextBox
            // 
            materiaTextBox.Location = new Point(275, 169);
            materiaTextBox.Multiline = true;
            materiaTextBox.Name = "materiaTextBox";
            materiaTextBox.Size = new Size(212, 34);
            materiaTextBox.TabIndex = 1;
            // 
            // notaTextBox
            // 
            notaTextBox.Location = new Point(275, 224);
            notaTextBox.Multiline = true;
            notaTextBox.Name = "notaTextBox";
            notaTextBox.Size = new Size(212, 29);
            notaTextBox.TabIndex = 2;
            // 
            // numetextBox
            // 
            numetextBox.Location = new Point(275, 115);
            numetextBox.Multiline = true;
            numetextBox.Name = "numetextBox";
            numetextBox.Size = new Size(212, 32);
            numetextBox.TabIndex = 3;
            numetextBox.TextChanged += numetextBox_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(afisajText);
            panel1.Location = new Point(173, 324);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 114);
            panel1.TabIndex = 4;
            // 
            // afisajText
            // 
            afisajText.AutoSize = true;
            afisajText.Location = new Point(153, 0);
            afisajText.Name = "afisajText";
            afisajText.Size = new Size(0, 15);
            afisajText.TabIndex = 0;
            // 
            // buttonTextBox
            // 
            buttonTextBox.Location = new Point(475, 282);
            buttonTextBox.Name = "buttonTextBox";
            buttonTextBox.Size = new Size(104, 23);
            buttonTextBox.TabIndex = 5;
            buttonTextBox.Text = "media finala";
            buttonTextBox.UseVisualStyleBackColor = true;
            buttonTextBox.Click += buttonTextBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTextBox);
            Controls.Add(panel1);
            Controls.Add(numetextBox);
            Controls.Add(notaTextBox);
            Controls.Add(materiaTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox materiaTextBox;
        private TextBox notaTextBox;
        private TextBox numetextBox;
        private Panel panel1;
        private Label afisajText;
        private Button buttonTextBox;
    }
}
