
namespace Siyosyus_V3._0
{
    partial class Entrance
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
            this.buttonPriestForm = new System.Windows.Forms.Button();
            this.buttonArcherForm = new System.Windows.Forms.Button();
            this.buttonPedalForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPriestForm
            // 
            this.buttonPriestForm.Location = new System.Drawing.Point(3, 35);
            this.buttonPriestForm.Name = "buttonPriestForm";
            this.buttonPriestForm.Size = new System.Drawing.Size(75, 23);
            this.buttonPriestForm.TabIndex = 0;
            this.buttonPriestForm.Text = "Priest";
            this.buttonPriestForm.UseVisualStyleBackColor = true;
            this.buttonPriestForm.Click += new System.EventHandler(this.buttonPriestForm_Click);
            // 
            // buttonArcherForm
            // 
            this.buttonArcherForm.Location = new System.Drawing.Point(161, 35);
            this.buttonArcherForm.Name = "buttonArcherForm";
            this.buttonArcherForm.Size = new System.Drawing.Size(75, 23);
            this.buttonArcherForm.TabIndex = 1;
            this.buttonArcherForm.Text = "Archer";
            this.buttonArcherForm.UseVisualStyleBackColor = true;
            this.buttonArcherForm.Click += new System.EventHandler(this.buttonArcherForm_Click);
            // 
            // buttonPedalForm
            // 
            this.buttonPedalForm.Location = new System.Drawing.Point(82, 74);
            this.buttonPedalForm.Name = "buttonPedalForm";
            this.buttonPedalForm.Size = new System.Drawing.Size(75, 23);
            this.buttonPedalForm.TabIndex = 2;
            this.buttonPedalForm.Text = "Utility";
            this.buttonPedalForm.UseVisualStyleBackColor = true;
            this.buttonPedalForm.Click += new System.EventHandler(this.buttonPedalForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "NumPad1 to start, NumPad0 to stop";
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(257, 109);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPedalForm);
            this.Controls.Add(this.buttonArcherForm);
            this.Controls.Add(this.buttonPriestForm);
            this.Name = "Entrance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPriestForm;
        private System.Windows.Forms.Button buttonArcherForm;
        private System.Windows.Forms.Button buttonPedalForm;
        private System.Windows.Forms.Label label1;
    }
}