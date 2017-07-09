namespace Medivialyzerv1._0._0
{
    partial class MLMainWindow
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
            this.MonstersChooseButton = new System.Windows.Forms.Button();
            this.AddEditValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonstersChooseButton
            // 
            this.MonstersChooseButton.Location = new System.Drawing.Point(12, 12);
            this.MonstersChooseButton.Name = "MonstersChooseButton";
            this.MonstersChooseButton.Size = new System.Drawing.Size(260, 23);
            this.MonstersChooseButton.TabIndex = 1;
            this.MonstersChooseButton.Text = "LootHUD - options";
            this.MonstersChooseButton.UseVisualStyleBackColor = true;
            this.MonstersChooseButton.Click += new System.EventHandler(this.MonstersChooseButton_Click);
            // 
            // AddEditValue
            // 
            this.AddEditValue.Location = new System.Drawing.Point(12, 41);
            this.AddEditValue.Name = "AddEditValue";
            this.AddEditValue.Size = new System.Drawing.Size(260, 23);
            this.AddEditValue.TabIndex = 2;
            this.AddEditValue.Text = "Add/edit item value";
            this.AddEditValue.UseVisualStyleBackColor = true;
            this.AddEditValue.Click += new System.EventHandler(this.AddEditValue_Click);
            // 
            // MLMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 83);
            this.Controls.Add(this.AddEditValue);
            this.Controls.Add(this.MonstersChooseButton);
            this.MaximizeBox = false;
            this.Name = "MLMainWindow";
            this.Text = "MediviaLyzer";
            this.Load += new System.EventHandler(this.MLMainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MonstersChooseButton;
        private System.Windows.Forms.Button AddEditValue;
    }
}