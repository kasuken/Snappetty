namespace Snappetty.App
{
    partial class FrmCapture
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
            this.panelDrag = new System.Windows.Forms.Panel();
            this.btnCaptureNow = new System.Windows.Forms.Button();
            this.panelDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDrag
            // 
            this.panelDrag.Controls.Add(this.btnCaptureNow);
            this.panelDrag.Location = new System.Drawing.Point(12, 12);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(753, 453);
            this.panelDrag.TabIndex = 0;
            this.panelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseDown_1);
            // 
            // btnCaptureNow
            // 
            this.btnCaptureNow.Location = new System.Drawing.Point(3, 3);
            this.btnCaptureNow.Name = "btnCaptureNow";
            this.btnCaptureNow.Size = new System.Drawing.Size(119, 25);
            this.btnCaptureNow.TabIndex = 0;
            this.btnCaptureNow.Text = "Capture Now!";
            this.btnCaptureNow.UseVisualStyleBackColor = true;
            this.btnCaptureNow.Click += new System.EventHandler(this.btnCaptureNow_Click);
            // 
            // FrmCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 477);
            this.Controls.Add(this.panelDrag);
            this.Name = "FrmCapture";
            this.Text = "FrmCapture";
            this.panelDrag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelDrag;
        private Button btnCaptureNow;
    }
}