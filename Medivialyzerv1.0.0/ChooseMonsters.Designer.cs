namespace Medivialyzerv1._0._0
{
    partial class ChooseMonsters
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Monster1combobox = new System.Windows.Forms.ComboBox();
            this.Monster2combobox = new System.Windows.Forms.ComboBox();
            this.Monster3combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ValueHigherTXT = new System.Windows.Forms.TextBox();
            this.ApplyButtonCM = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ExtraSumUpCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monster 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monster 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monster 3:";
            // 
            // Monster1combobox
            // 
            this.Monster1combobox.FormattingEnabled = true;
            this.Monster1combobox.Location = new System.Drawing.Point(75, 32);
            this.Monster1combobox.Name = "Monster1combobox";
            this.Monster1combobox.Size = new System.Drawing.Size(121, 21);
            this.Monster1combobox.TabIndex = 3;
            this.Monster1combobox.Text = "None";
            // 
            // Monster2combobox
            // 
            this.Monster2combobox.FormattingEnabled = true;
            this.Monster2combobox.Location = new System.Drawing.Point(75, 59);
            this.Monster2combobox.Name = "Monster2combobox";
            this.Monster2combobox.Size = new System.Drawing.Size(121, 21);
            this.Monster2combobox.TabIndex = 4;
            this.Monster2combobox.Text = "None";
            // 
            // Monster3combobox
            // 
            this.Monster3combobox.FormattingEnabled = true;
            this.Monster3combobox.Location = new System.Drawing.Point(75, 86);
            this.Monster3combobox.Name = "Monster3combobox";
            this.Monster3combobox.Size = new System.Drawing.Size(121, 21);
            this.Monster3combobox.TabIndex = 5;
            this.Monster3combobox.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Only if value higher than: ";
            // 
            // ValueHigherTXT
            // 
            this.ValueHigherTXT.Location = new System.Drawing.Point(145, 116);
            this.ValueHigherTXT.Name = "ValueHigherTXT";
            this.ValueHigherTXT.Size = new System.Drawing.Size(100, 20);
            this.ValueHigherTXT.TabIndex = 7;
            this.ValueHigherTXT.Text = "0";
            // 
            // ApplyButtonCM
            // 
            this.ApplyButtonCM.Location = new System.Drawing.Point(12, 165);
            this.ApplyButtonCM.Name = "ApplyButtonCM";
            this.ApplyButtonCM.Size = new System.Drawing.Size(260, 23);
            this.ApplyButtonCM.TabIndex = 8;
            this.ApplyButtonCM.Text = "START";
            this.ApplyButtonCM.UseVisualStyleBackColor = true;
            this.ApplyButtonCM.Click += new System.EventHandler(this.ApplyButtonCM_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enable extra SumUP HUD";
            // 
            // ExtraSumUpCheck
            // 
            this.ExtraSumUpCheck.AutoSize = true;
            this.ExtraSumUpCheck.Location = new System.Drawing.Point(145, 142);
            this.ExtraSumUpCheck.Name = "ExtraSumUpCheck";
            this.ExtraSumUpCheck.Size = new System.Drawing.Size(15, 14);
            this.ExtraSumUpCheck.TabIndex = 10;
            this.ExtraSumUpCheck.UseVisualStyleBackColor = true;
            // 
            // ChooseMonsters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.ExtraSumUpCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ApplyButtonCM);
            this.Controls.Add(this.ValueHigherTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Monster3combobox);
            this.Controls.Add(this.Monster2combobox);
            this.Controls.Add(this.Monster1combobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseMonsters";
            this.Text = "Loot HUD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseMonsters_FormClosing);
            this.Load += new System.EventHandler(this.ChooseMonsters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Monster1combobox;
        private System.Windows.Forms.ComboBox Monster2combobox;
        private System.Windows.Forms.ComboBox Monster3combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ValueHigherTXT;
        private System.Windows.Forms.Button ApplyButtonCM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ExtraSumUpCheck;
    }
}