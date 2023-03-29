
namespace text_editor
{
    partial class Form_secret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_secret));
            this.pcb_briefcase = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_briefcase)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_briefcase
            // 
            this.pcb_briefcase.BackgroundImage = global::text_editor.Properties.Resources.briefcase;
            this.pcb_briefcase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_briefcase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcb_briefcase.Image = global::text_editor.Properties.Resources.briefcase;
            this.pcb_briefcase.Location = new System.Drawing.Point(84, 62);
            this.pcb_briefcase.Name = "pcb_briefcase";
            this.pcb_briefcase.Size = new System.Drawing.Size(181, 166);
            this.pcb_briefcase.TabIndex = 0;
            this.pcb_briefcase.TabStop = false;
            this.pcb_briefcase.Click += new System.EventHandler(this.pcb_briefcase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oh look, you found a briefcase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(128, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Take it";
            // 
            // Form_secret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_briefcase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_secret";
            this.Text = "What\'s that";
            ((System.ComponentModel.ISupportInitialize)(this.pcb_briefcase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_briefcase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}