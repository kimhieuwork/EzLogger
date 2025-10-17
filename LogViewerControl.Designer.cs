
namespace EzLogger
{
    partial class LogViewerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _rtb
            // 
            this._rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtb.Location = new System.Drawing.Point(0, 0);
            this._rtb.Name = "_rtb";
            this._rtb.Size = new System.Drawing.Size(700, 300);
            this._rtb.TabIndex = 0;
            this._rtb.Text = "";
            // 
            // LogViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._rtb);
            this.Name = "LogViewerControl";
            this.Size = new System.Drawing.Size(700, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox _rtb;
    }
}
