﻿namespace RepetierHost.view
{
    partial class SlicerPanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlicerPanel));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSlic3rConfigure = new System.Windows.Forms.Button();
            this.comboSlic3rPrinterSettings = new System.Windows.Forms.ComboBox();
            this.comboSlic3rFilamentSettings = new System.Windows.Forms.ComboBox();
            this.comboSlic3rPrintSettings = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSkeinConfigure = new System.Windows.Forms.Button();
            this.comboSkeinProfile = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStartSlicing = new System.Windows.Forms.Button();
            this.buttonSetupSlic3r = new System.Windows.Forms.Button();
            this.buttonSetupSkeinforge = new System.Windows.Forms.Button();
            this.buttonKillSlicing = new System.Windows.Forms.Button();
            this.switchSkeinforge = new RepetierHost.view.SwitchButton();
            this.switchSlic3rActive = new RepetierHost.view.SwitchButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonSetupSlic3r);
            this.groupBox2.Controls.Add(this.buttonSlic3rConfigure);
            this.groupBox2.Controls.Add(this.comboSlic3rPrinterSettings);
            this.groupBox2.Controls.Add(this.comboSlic3rFilamentSettings);
            this.groupBox2.Controls.Add(this.comboSlic3rPrintSettings);
            this.groupBox2.Controls.Add(this.switchSlic3rActive);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slic3r";
            // 
            // buttonSlic3rConfigure
            // 
            this.buttonSlic3rConfigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSlic3rConfigure.Image = ((System.Drawing.Image)(resources.GetObject("buttonSlic3rConfigure.Image")));
            this.buttonSlic3rConfigure.Location = new System.Drawing.Point(487, 20);
            this.buttonSlic3rConfigure.Name = "buttonSlic3rConfigure";
            this.buttonSlic3rConfigure.Size = new System.Drawing.Size(111, 23);
            this.buttonSlic3rConfigure.TabIndex = 2;
            this.buttonSlic3rConfigure.Text = "Configure";
            this.buttonSlic3rConfigure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSlic3rConfigure.UseVisualStyleBackColor = true;
            this.buttonSlic3rConfigure.Click += new System.EventHandler(this.buttonSlic3rConfigure_Click);
            // 
            // comboSlic3rPrinterSettings
            // 
            this.comboSlic3rPrinterSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSlic3rPrinterSettings.FormattingEnabled = true;
            this.comboSlic3rPrinterSettings.Location = new System.Drawing.Point(109, 100);
            this.comboSlic3rPrinterSettings.Name = "comboSlic3rPrinterSettings";
            this.comboSlic3rPrinterSettings.Size = new System.Drawing.Size(180, 21);
            this.comboSlic3rPrinterSettings.TabIndex = 1;
            this.comboSlic3rPrinterSettings.SelectedIndexChanged += new System.EventHandler(this.comboSlic3rPrinterSettings_SelectedIndexChanged);
            // 
            // comboSlic3rFilamentSettings
            // 
            this.comboSlic3rFilamentSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSlic3rFilamentSettings.FormattingEnabled = true;
            this.comboSlic3rFilamentSettings.Location = new System.Drawing.Point(109, 73);
            this.comboSlic3rFilamentSettings.Name = "comboSlic3rFilamentSettings";
            this.comboSlic3rFilamentSettings.Size = new System.Drawing.Size(180, 21);
            this.comboSlic3rFilamentSettings.TabIndex = 1;
            this.comboSlic3rFilamentSettings.SelectedIndexChanged += new System.EventHandler(this.comboSlic3rFilamentSettings_SelectedIndexChanged);
            // 
            // comboSlic3rPrintSettings
            // 
            this.comboSlic3rPrintSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSlic3rPrintSettings.FormattingEnabled = true;
            this.comboSlic3rPrintSettings.Location = new System.Drawing.Point(109, 46);
            this.comboSlic3rPrintSettings.Name = "comboSlic3rPrintSettings";
            this.comboSlic3rPrintSettings.Size = new System.Drawing.Size(180, 21);
            this.comboSlic3rPrintSettings.TabIndex = 1;
            this.comboSlic3rPrintSettings.SelectedIndexChanged += new System.EventHandler(this.comboSlic3rPrintSettings_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Printer settings:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Filament settings:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Print settings:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonSetupSkeinforge);
            this.groupBox3.Controls.Add(this.buttonSkeinConfigure);
            this.groupBox3.Controls.Add(this.comboSkeinProfile);
            this.groupBox3.Controls.Add(this.switchSkeinforge);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(3, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 86);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Skeinforge";
            // 
            // buttonSkeinConfigure
            // 
            this.buttonSkeinConfigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSkeinConfigure.Image = ((System.Drawing.Image)(resources.GetObject("buttonSkeinConfigure.Image")));
            this.buttonSkeinConfigure.Location = new System.Drawing.Point(487, 19);
            this.buttonSkeinConfigure.Name = "buttonSkeinConfigure";
            this.buttonSkeinConfigure.Size = new System.Drawing.Size(111, 23);
            this.buttonSkeinConfigure.TabIndex = 2;
            this.buttonSkeinConfigure.Text = "Configure";
            this.buttonSkeinConfigure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSkeinConfigure.UseVisualStyleBackColor = true;
            this.buttonSkeinConfigure.Click += new System.EventHandler(this.buttonSkeinConfigure_Click);
            // 
            // comboSkeinProfile
            // 
            this.comboSkeinProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSkeinProfile.FormattingEnabled = true;
            this.comboSkeinProfile.Location = new System.Drawing.Point(109, 50);
            this.comboSkeinProfile.Name = "comboSkeinProfile";
            this.comboSkeinProfile.Size = new System.Drawing.Size(180, 21);
            this.comboSkeinProfile.TabIndex = 1;
            this.comboSkeinProfile.SelectedIndexChanged += new System.EventHandler(this.comboSkeinProfile_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Profile:";
            // 
            // buttonStartSlicing
            // 
            this.buttonStartSlicing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartSlicing.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartSlicing.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartSlicing.Image")));
            this.buttonStartSlicing.Location = new System.Drawing.Point(9, 3);
            this.buttonStartSlicing.Name = "buttonStartSlicing";
            this.buttonStartSlicing.Size = new System.Drawing.Size(475, 67);
            this.buttonStartSlicing.TabIndex = 1;
            this.buttonStartSlicing.Text = "Slice with Skeinforge";
            this.buttonStartSlicing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStartSlicing.UseVisualStyleBackColor = true;
            this.buttonStartSlicing.Click += new System.EventHandler(this.buttonStartSlicing_Click);
            // 
            // buttonSetupSlic3r
            // 
            this.buttonSetupSlic3r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetupSlic3r.Image = ((System.Drawing.Image)(resources.GetObject("buttonSetupSlic3r.Image")));
            this.buttonSetupSlic3r.Location = new System.Drawing.Point(487, 98);
            this.buttonSetupSlic3r.Name = "buttonSetupSlic3r";
            this.buttonSetupSlic3r.Size = new System.Drawing.Size(111, 23);
            this.buttonSetupSlic3r.TabIndex = 3;
            this.buttonSetupSlic3r.Text = "Setup";
            this.buttonSetupSlic3r.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSetupSlic3r.UseVisualStyleBackColor = true;
            this.buttonSetupSlic3r.Click += new System.EventHandler(this.buttonSetupSlic3r_Click);
            // 
            // buttonSetupSkeinforge
            // 
            this.buttonSetupSkeinforge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetupSkeinforge.Image = ((System.Drawing.Image)(resources.GetObject("buttonSetupSkeinforge.Image")));
            this.buttonSetupSkeinforge.Location = new System.Drawing.Point(487, 48);
            this.buttonSetupSkeinforge.Name = "buttonSetupSkeinforge";
            this.buttonSetupSkeinforge.Size = new System.Drawing.Size(111, 23);
            this.buttonSetupSkeinforge.TabIndex = 3;
            this.buttonSetupSkeinforge.Text = "Setup";
            this.buttonSetupSkeinforge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSetupSkeinforge.UseVisualStyleBackColor = true;
            this.buttonSetupSkeinforge.Click += new System.EventHandler(this.buttonSetupSkeinforge_Click);
            // 
            // buttonKillSlicing
            // 
            this.buttonKillSlicing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKillSlicing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKillSlicing.Location = new System.Drawing.Point(490, 3);
            this.buttonKillSlicing.Name = "buttonKillSlicing";
            this.buttonKillSlicing.Size = new System.Drawing.Size(111, 67);
            this.buttonKillSlicing.TabIndex = 3;
            this.buttonKillSlicing.Text = "Kill slicing\r\nprocess";
            this.buttonKillSlicing.UseVisualStyleBackColor = true;
            this.buttonKillSlicing.Click += new System.EventHandler(this.buttonKillSlicing_Click);
            // 
            // switchSkeinforge
            // 
            this.switchSkeinforge.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchSkeinforge.ButtonFlatBorderSize = 1;
            this.switchSkeinforge.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.switchSkeinforge.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchSkeinforge.Location = new System.Drawing.Point(6, 19);
            this.switchSkeinforge.Name = "switchSkeinforge";
            this.switchSkeinforge.On = false;
            this.switchSkeinforge.Size = new System.Drawing.Size(100, 23);
            this.switchSkeinforge.TabIndex = 0;
            this.switchSkeinforge.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.switchSkeinforge.TextOff = "Active";
            this.switchSkeinforge.TextOn = "Active";
            this.switchSkeinforge.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchSkeinforge_OnChange);
            // 
            // switchSlic3rActive
            // 
            this.switchSlic3rActive.ButtonFlatBorderColor = System.Drawing.Color.Empty;
            this.switchSlic3rActive.ButtonFlatBorderSize = 1;
            this.switchSlic3rActive.ButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.switchSlic3rActive.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchSlic3rActive.Location = new System.Drawing.Point(10, 20);
            this.switchSlic3rActive.Name = "switchSlic3rActive";
            this.switchSlic3rActive.On = false;
            this.switchSlic3rActive.Size = new System.Drawing.Size(100, 23);
            this.switchSlic3rActive.TabIndex = 0;
            this.switchSlic3rActive.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.switchSlic3rActive.TextOff = "Active";
            this.switchSlic3rActive.TextOn = "Active";
            this.switchSlic3rActive.OnChange += new RepetierHost.view.SwitchEventHandler(this.switchSlic3rActive_OnChange);
            // 
            // SlicerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonKillSlicing);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonStartSlicing);
            this.Name = "SlicerPanel";
            this.Size = new System.Drawing.Size(610, 519);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonStartSlicing;
        private SwitchButton switchSlic3rActive;
        private System.Windows.Forms.ComboBox comboSlic3rPrinterSettings;
        private System.Windows.Forms.ComboBox comboSlic3rFilamentSettings;
        private System.Windows.Forms.ComboBox comboSlic3rPrintSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSlic3rConfigure;
        private System.Windows.Forms.Button buttonSkeinConfigure;
        private SwitchButton switchSkeinforge;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboSkeinProfile;
        private System.Windows.Forms.Button buttonSetupSlic3r;
        private System.Windows.Forms.Button buttonSetupSkeinforge;
        private System.Windows.Forms.Button buttonKillSlicing;
    }
}
