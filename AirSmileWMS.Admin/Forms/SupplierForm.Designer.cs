namespace AirSmileWMS.Admin.Forms
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.GroupBoxData = new System.Windows.Forms.GroupBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.GroupBoxSettings = new System.Windows.Forms.GroupBox();
            this.CheckBoxSKUsEnable = new System.Windows.Forms.CheckBox();
            this.CheckBoxLinksEnable = new System.Windows.Forms.CheckBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.GroupBoxData.SuspendLayout();
            this.GroupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxData
            // 
            this.GroupBoxData.Controls.Add(this.TextBoxName);
            this.GroupBoxData.Controls.Add(this.LabelName);
            this.GroupBoxData.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxData.Name = "GroupBoxData";
            this.GroupBoxData.Size = new System.Drawing.Size(286, 58);
            this.GroupBoxData.TabIndex = 0;
            this.GroupBoxData.TabStop = false;
            this.GroupBoxData.Text = "Данные о поставщике";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(6, 25);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(83, 13);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Наименование";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(95, 22);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(180, 20);
            this.TextBoxName.TabIndex = 2;
            // 
            // GroupBoxSettings
            // 
            this.GroupBoxSettings.Controls.Add(this.CheckBoxLinksEnable);
            this.GroupBoxSettings.Controls.Add(this.CheckBoxSKUsEnable);
            this.GroupBoxSettings.Location = new System.Drawing.Point(12, 76);
            this.GroupBoxSettings.Name = "GroupBoxSettings";
            this.GroupBoxSettings.Size = new System.Drawing.Size(286, 72);
            this.GroupBoxSettings.TabIndex = 1;
            this.GroupBoxSettings.TabStop = false;
            this.GroupBoxSettings.Text = "Настройки";
            // 
            // CheckBoxSKUsEnable
            // 
            this.CheckBoxSKUsEnable.AutoSize = true;
            this.CheckBoxSKUsEnable.Location = new System.Drawing.Point(9, 20);
            this.CheckBoxSKUsEnable.Name = "CheckBoxSKUsEnable";
            this.CheckBoxSKUsEnable.Size = new System.Drawing.Size(75, 17);
            this.CheckBoxSKUsEnable.TabIndex = 0;
            this.CheckBoxSKUsEnable.Text = "Артикулы";
            this.CheckBoxSKUsEnable.UseVisualStyleBackColor = true;
            // 
            // CheckBoxLinksEnable
            // 
            this.CheckBoxLinksEnable.AutoSize = true;
            this.CheckBoxLinksEnable.Location = new System.Drawing.Point(9, 43);
            this.CheckBoxLinksEnable.Name = "CheckBoxLinksEnable";
            this.CheckBoxLinksEnable.Size = new System.Drawing.Size(120, 17);
            this.CheckBoxLinksEnable.TabIndex = 1;
            this.CheckBoxLinksEnable.Text = "Ссылки на товары";
            this.CheckBoxLinksEnable.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(223, 154);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(142, 154);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 186);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.GroupBoxSettings);
            this.Controls.Add(this.GroupBoxData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierForm";
            this.Text = "Поставщик";
            this.GroupBoxData.ResumeLayout(false);
            this.GroupBoxData.PerformLayout();
            this.GroupBoxSettings.ResumeLayout(false);
            this.GroupBoxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxData;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.GroupBox GroupBoxSettings;
        private System.Windows.Forms.CheckBox CheckBoxLinksEnable;
        private System.Windows.Forms.CheckBox CheckBoxSKUsEnable;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
    }
}