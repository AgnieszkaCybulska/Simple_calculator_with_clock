
namespace Calculator_clock
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        char previousChar = ' ';
        string text_result;
        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.Label();
            this.digital_clock = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setButtonsColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(117, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.numbers_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(178, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.numbers_Click);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(239, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.numbers_Click);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Linen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(117, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.numbers_Click);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Linen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(178, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.numbers_Click);
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Linen;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Location = new System.Drawing.Point(239, 383);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 55);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.numbers_Click);
            this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Linen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(117, 444);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 55);
            this.button7.TabIndex = 6;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.numbers_Click);
            this.button7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Linen;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button8.Location = new System.Drawing.Point(178, 444);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 55);
            this.button8.TabIndex = 7;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.numbers_Click);
            this.button8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Linen;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button9.Location = new System.Drawing.Point(239, 444);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 55);
            this.button9.TabIndex = 8;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.numbers_Click);
            this.button9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Linen;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.Location = new System.Drawing.Point(117, 505);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 55);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.numbers_Click);
            this.button10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Linen;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button11.Location = new System.Drawing.Point(178, 505);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 55);
            this.button11.TabIndex = 10;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.arithmetic_operations_Click);
            this.button11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(239, 505);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 55);
            this.button12.TabIndex = 11;
            this.button12.Text = "=";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.calculate_result_Click);
            this.button12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(300, 505);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 55);
            this.button13.TabIndex = 12;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.arithmetic_operations_Click);
            this.button13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(300, 444);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 55);
            this.button14.TabIndex = 13;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.arithmetic_operations_Click);
            this.button14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(300, 383);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(55, 55);
            this.button15.TabIndex = 14;
            this.button15.Text = "*";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.arithmetic_operations_Click);
            this.button15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(300, 322);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(55, 55);
            this.button16.TabIndex = 15;
            this.button16.Text = "/";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.arithmetic_operations_Click);
            this.button16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(117, 261);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(86, 55);
            this.button17.TabIndex = 16;
            this.button17.Text = "(";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.numbers_Click);
            this.button17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(208, 261);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(86, 55);
            this.button18.TabIndex = 17;
            this.button18.Text = ")";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.numbers_Click);
            this.button18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(300, 261);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(55, 55);
            this.button19.TabIndex = 18;
            this.button19.Text = "%";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.arithmetic_operations_Click);
            this.button19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Beige;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(117, 200);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(116, 55);
            this.button20.TabIndex = 19;
            this.button20.Text = "CE";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.delete_Click);
            this.button20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Beige;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(239, 200);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(115, 55);
            this.button21.TabIndex = 20;
            this.button21.Text = "C";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.delete_Click);
            this.button21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbers_KeyPress);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.SystemColors.ControlText;
            this.console.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.console.ForeColor = System.Drawing.Color.White;
            this.console.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.console.Location = new System.Drawing.Point(103, 114);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(268, 83);
            this.console.TabIndex = 21;
            this.console.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // digital_clock
            // 
            this.digital_clock.BackColor = System.Drawing.SystemColors.ControlText;
            this.digital_clock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digital_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.digital_clock.ForeColor = System.Drawing.Color.White;
            this.digital_clock.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.digital_clock.Location = new System.Drawing.Point(190, 44);
            this.digital_clock.Name = "digital_clock";
            this.digital_clock.Size = new System.Drawing.Size(115, 34);
            this.digital_clock.TabIndex = 22;
            this.digital_clock.Text = "00:00:00";
            this.digital_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 30);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBackgroundToolStripMenuItem,
            this.setButtonsColorToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // changeBackgroundToolStripMenuItem
            // 
            this.changeBackgroundToolStripMenuItem.Name = "changeBackgroundToolStripMenuItem";
            this.changeBackgroundToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.changeBackgroundToolStripMenuItem.Text = "Change background";
            this.changeBackgroundToolStripMenuItem.Click += new System.EventHandler(this.changeBackgroundToolStripMenuItem_Click);
            // 
            // setButtonsColorToolStripMenuItem
            // 
            this.setButtonsColorToolStripMenuItem.Name = "setButtonsColorToolStripMenuItem";
            this.setButtonsColorToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.setButtonsColorToolStripMenuItem.Text = "Set buttons color";
            this.setButtonsColorToolStripMenuItem.Click += new System.EventHandler(this.setButtonsColorToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.informationToolStripMenuItem.Text = "&Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(70, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 479);
            this.label1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 594);
            this.Controls.Add(this.digital_clock);
            this.Controls.Add(this.console);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label console;
        private System.Windows.Forms.Label digital_clock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setButtonsColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}

