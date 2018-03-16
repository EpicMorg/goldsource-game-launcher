namespace ApocalypseLauncherServersManager.Shared
{
    partial class FrmSelectApi
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectApi));
            this.comboBoxApi = new System.Windows.Forms.ComboBox();
            this.buttonApi = new System.Windows.Forms.Button();
            this.labelApi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxApi
            // 
            this.comboBoxApi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApi.FormattingEnabled = true;
            this.comboBoxApi.Items.AddRange(new object[] {
            "API v1"});
            this.comboBoxApi.Location = new System.Drawing.Point(12, 25);
            this.comboBoxApi.Name = "comboBoxApi";
            this.comboBoxApi.Size = new System.Drawing.Size(298, 21);
            this.comboBoxApi.TabIndex = 0;
            this.comboBoxApi.SelectedIndexChanged += new System.EventHandler(this.comboBoxApi_SelectedIndexChanged);
            // 
            // buttonApi
            // 
            this.buttonApi.Location = new System.Drawing.Point(235, 52);
            this.buttonApi.Name = "buttonApi";
            this.buttonApi.Size = new System.Drawing.Size(75, 23);
            this.buttonApi.TabIndex = 1;
            this.buttonApi.Text = "Ok";
            this.buttonApi.UseVisualStyleBackColor = true;
            this.buttonApi.Click += new System.EventHandler(this.buttonApi_Click);
            // 
            // labelApi
            // 
            this.labelApi.AutoSize = true;
            this.labelApi.Location = new System.Drawing.Point(12, 9);
            this.labelApi.Name = "labelApi";
            this.labelApi.Size = new System.Drawing.Size(89, 13);
            this.labelApi.TabIndex = 2;
            this.labelApi.Text = "Select API Level:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 89);
            this.Controls.Add(this.labelApi);
            this.Controls.Add(this.buttonApi);
            this.Controls.Add(this.comboBoxApi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servers.json editor";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxApi;
        private System.Windows.Forms.Button buttonApi;
        private System.Windows.Forms.Label labelApi;
    }
}

