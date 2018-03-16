namespace ApocalypseLauncherServersManager.API_v0
{
    partial class FrmEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditor));
            this.textBoxServName = new System.Windows.Forms.TextBox();
            this.textBoxServIP = new System.Windows.Forms.TextBox();
            this.textBoxServApi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownServPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownServPort)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxServName
            // 
            this.textBoxServName.Location = new System.Drawing.Point(12, 12);
            this.textBoxServName.Name = "textBoxServName";
            this.textBoxServName.Size = new System.Drawing.Size(498, 20);
            this.textBoxServName.TabIndex = 0;
            // 
            // textBoxServIP
            // 
            this.textBoxServIP.Location = new System.Drawing.Point(12, 68);
            this.textBoxServIP.Name = "textBoxServIP";
            this.textBoxServIP.Size = new System.Drawing.Size(372, 20);
            this.textBoxServIP.TabIndex = 0;
            // 
            // textBoxServApi
            // 
            this.textBoxServApi.Location = new System.Drawing.Point(12, 125);
            this.textBoxServApi.Name = "textBoxServApi";
            this.textBoxServApi.Size = new System.Drawing.Size(498, 20);
            this.textBoxServApi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(498, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownServPort
            // 
            this.numericUpDownServPort.Location = new System.Drawing.Point(390, 68);
            this.numericUpDownServPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownServPort.Name = "numericUpDownServPort";
            this.numericUpDownServPort.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownServPort.TabIndex = 1;
            // 
            // FrmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownServPort);
            this.Controls.Add(this.textBoxServApi);
            this.Controls.Add(this.textBoxServIP);
            this.Controls.Add(this.textBoxServName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownServPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxServName;
        private System.Windows.Forms.TextBox textBoxServIP;
        private System.Windows.Forms.TextBox textBoxServApi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownServPort;
    }
}