namespace Pizzeria_Koe3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            cmbValitsePizza = new ComboBox();
            label2 = new Label();
            numPizzaMaara = new NumericUpDown();
            label3 = new Label();
            numTayte = new NumericUpDown();
            label4 = new Label();
            cmbJuoma = new ComboBox();
            listboxPizza = new ListBox();
            btnOK = new Button();
            checkBoxAlennus = new CheckBox();
            button1 = new Button();
            txtUusiHinta = new TextBox();
            lblKassa = new Label();
            btnTyhjenna = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numPizzaMaara).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTayte).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(508, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 0;
            label1.Text = "Pizzeria";
            // 
            // cmbValitsePizza
            // 
            cmbValitsePizza.FormattingEnabled = true;
            cmbValitsePizza.Items.AddRange(new object[] { "Pizza1", "Pizza2", "Pizza3", "Pizza4", "Pizza5", "Pizza6", "Pizza7", "Pizza8", "Pizza9", "Pizza10" });
            cmbValitsePizza.Location = new Point(368, 141);
            cmbValitsePizza.Margin = new Padding(4);
            cmbValitsePizza.Name = "cmbValitsePizza";
            cmbValitsePizza.Size = new Size(188, 33);
            cmbValitsePizza.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 151);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(263, 25);
            label2.TabIndex = 2;
            label2.Text = "Valitse haluamasi pizza ja määrä";
            // 
            // numPizzaMaara
            // 
            numPizzaMaara.Location = new Point(564, 142);
            numPizzaMaara.Margin = new Padding(4);
            numPizzaMaara.Name = "numPizzaMaara";
            numPizzaMaara.Size = new Size(65, 31);
            numPizzaMaara.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 195);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(297, 25);
            label3.TabIndex = 4;
            label3.Text = "Jos haluat lisä täytteitä valitse määrä";
            // 
            // numTayte
            // 
            numTayte.Location = new Point(368, 186);
            numTayte.Margin = new Padding(4);
            numTayte.Name = "numTayte";
            numTayte.Size = new Size(261, 31);
            numTayte.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 234);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 7;
            label4.Text = "Valitse juoma";
            // 
            // cmbJuoma
            // 
            cmbJuoma.FormattingEnabled = true;
            cmbJuoma.Items.AddRange(new object[] { "Kokis 0.5l", "Kokis 1.5l" });
            cmbJuoma.Location = new Point(368, 224);
            cmbJuoma.Margin = new Padding(4);
            cmbJuoma.Name = "cmbJuoma";
            cmbJuoma.Size = new Size(188, 33);
            cmbJuoma.TabIndex = 8;
            // 
            // listboxPizza
            // 
            listboxPizza.FormattingEnabled = true;
            listboxPizza.ItemHeight = 25;
            listboxPizza.Location = new Point(701, 46);
            listboxPizza.Margin = new Padding(4);
            listboxPizza.Name = "listboxPizza";
            listboxPizza.SelectionMode = SelectionMode.MultiExtended;
            listboxPizza.Size = new Size(316, 404);
            listboxPizza.TabIndex = 9;
            // 
            // btnOK
            // 
            btnOK.ForeColor = Color.Lime;
            btnOK.Location = new Point(368, 286);
            btnOK.Margin = new Padding(4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(118, 36);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // checkBoxAlennus
            // 
            checkBoxAlennus.AutoSize = true;
            checkBoxAlennus.Location = new Point(508, 292);
            checkBoxAlennus.Margin = new Padding(4);
            checkBoxAlennus.Name = "checkBoxAlennus";
            checkBoxAlennus.Size = new Size(145, 29);
            checkBoxAlennus.TabIndex = 11;
            checkBoxAlennus.Text = "Alennus Pizza";
            checkBoxAlennus.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.SpringGreen;
            button1.Location = new Point(41, 286);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(151, 36);
            button1.TabIndex = 12;
            button1.Text = "Muuta hintoja";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtUusiHinta
            // 
            txtUusiHinta.ForeColor = Color.Lime;
            txtUusiHinta.Location = new Point(41, 329);
            txtUusiHinta.Name = "txtUusiHinta";
            txtUusiHinta.Size = new Size(150, 31);
            txtUusiHinta.TabIndex = 13;
            txtUusiHinta.Text = "       Uusi hinta";
            // 
            // lblKassa
            // 
            lblKassa.AutoSize = true;
            lblKassa.Location = new Point(508, 325);
            lblKassa.Name = "lblKassa";
            lblKassa.Size = new Size(133, 25);
            lblKassa.TabIndex = 14;
            lblKassa.Text = "Kassassa rahaa:";
            // 
            // btnTyhjenna
            // 
            btnTyhjenna.ForeColor = Color.Lime;
            btnTyhjenna.Location = new Point(701, 457);
            btnTyhjenna.Name = "btnTyhjenna";
            btnTyhjenna.Size = new Size(183, 36);
            btnTyhjenna.TabIndex = 15;
            btnTyhjenna.Text = "Tyhjennä valinnat";
            btnTyhjenna.UseVisualStyleBackColor = true;
            btnTyhjenna.Click += btnTyhjenna_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1024, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(480, 351);
            textBox1.TabIndex = 16;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1502, 636);
            Controls.Add(textBox1);
            Controls.Add(btnTyhjenna);
            Controls.Add(lblKassa);
            Controls.Add(txtUusiHinta);
            Controls.Add(button1);
            Controls.Add(checkBoxAlennus);
            Controls.Add(btnOK);
            Controls.Add(listboxPizza);
            Controls.Add(cmbJuoma);
            Controls.Add(label4);
            Controls.Add(numTayte);
            Controls.Add(label3);
            Controls.Add(numPizzaMaara);
            Controls.Add(label2);
            Controls.Add(cmbValitsePizza);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Pizzeria";
            ((System.ComponentModel.ISupportInitialize)numPizzaMaara).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTayte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbValitsePizza;
        private Label label2;
        private NumericUpDown numPizzaMaara;
        private Label label3;
        private NumericUpDown numTayte;
        private Label label4;
        private ComboBox cmbJuoma;
        private ListBox listboxPizza;
        private Button btnOK;
        private CheckBox checkBoxAlennus;
        private Button button1;
        private TextBox txtUusiHinta;
        private Label lblKassa;
        private Button btnTyhjenna;
        private TextBox textBox1;
    }
}
