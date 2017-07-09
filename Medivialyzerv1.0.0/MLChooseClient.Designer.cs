namespace Medivialyzerv1._0._0
{
    partial class MLChooseClient
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcessListBox = new System.Windows.Forms.ListBox();
            this.LockProcessButton = new System.Windows.Forms.Button();
            this.OpenGLcheck = new System.Windows.Forms.CheckBox();
            this.DirectXcheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ProcessListBox
            // 
            this.ProcessListBox.FormattingEnabled = true;
            this.ProcessListBox.Location = new System.Drawing.Point(12, 35);
            this.ProcessListBox.Name = "ProcessListBox";
            this.ProcessListBox.Size = new System.Drawing.Size(139, 134);
            this.ProcessListBox.TabIndex = 0;
            // 
            // LockProcessButton
            // 
            this.LockProcessButton.Location = new System.Drawing.Point(39, 175);
            this.LockProcessButton.Name = "LockProcessButton";
            this.LockProcessButton.Size = new System.Drawing.Size(75, 23);
            this.LockProcessButton.TabIndex = 1;
            this.LockProcessButton.Text = "Run";
            this.LockProcessButton.UseVisualStyleBackColor = true;
            this.LockProcessButton.Click += new System.EventHandler(this.LockProcessButton_Click);
            // 
            // OpenGLcheck
            // 
            this.OpenGLcheck.AutoSize = true;
            this.OpenGLcheck.Checked = true;
            this.OpenGLcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpenGLcheck.Location = new System.Drawing.Point(12, 12);
            this.OpenGLcheck.Name = "OpenGLcheck";
            this.OpenGLcheck.Size = new System.Drawing.Size(66, 17);
            this.OpenGLcheck.TabIndex = 2;
            this.OpenGLcheck.Text = "OpenGL";
            this.OpenGLcheck.UseVisualStyleBackColor = true;
            this.OpenGLcheck.CheckedChanged += new System.EventHandler(this.OpenGLcheck_CheckedChanged);
            // 
            // DirectXcheck
            // 
            this.DirectXcheck.AutoSize = true;
            this.DirectXcheck.Location = new System.Drawing.Point(97, 12);
            this.DirectXcheck.Name = "DirectXcheck";
            this.DirectXcheck.Size = new System.Drawing.Size(61, 17);
            this.DirectXcheck.TabIndex = 3;
            this.DirectXcheck.Text = "DirectX";
            this.DirectXcheck.UseVisualStyleBackColor = true;
            this.DirectXcheck.CheckedChanged += new System.EventHandler(this.DirectXcheck_CheckedChanged);
            // 
            // MLChooseClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 207);
            this.Controls.Add(this.DirectXcheck);
            this.Controls.Add(this.OpenGLcheck);
            this.Controls.Add(this.LockProcessButton);
            this.Controls.Add(this.ProcessListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MLChooseClient";
            this.Text = "MLChooselient";
            this.Load += new System.EventHandler(this.MLChooseClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProcessListBox;
        private System.Windows.Forms.Button LockProcessButton;
        private System.Windows.Forms.CheckBox OpenGLcheck;
        private System.Windows.Forms.CheckBox DirectXcheck;
    }
}

