namespace GalacticConflict {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this._openGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this._openGlControl.AccumBits = ((byte)(0));
            this._openGlControl.AutoCheckErrors = false;
            this._openGlControl.AutoFinish = false;
            this._openGlControl.AutoMakeCurrent = true;
            this._openGlControl.AutoSwapBuffers = true;
            this._openGlControl.BackColor = System.Drawing.Color.Black;
            this._openGlControl.ColorBits = ((byte)(32));
            this._openGlControl.DepthBits = ((byte)(16));
            this._openGlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._openGlControl.Location = new System.Drawing.Point(0, 0);
            this._openGlControl.Name = "simpleOpenGlControl1";
            this._openGlControl.Size = new System.Drawing.Size(284, 261);
            this._openGlControl.StencilBits = ((byte)(0));
            this._openGlControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._openGlControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl _openGlControl;

    }
}

