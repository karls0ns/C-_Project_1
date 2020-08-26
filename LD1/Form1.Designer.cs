namespace LD1
{
    partial class LD1
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
            this.btnAddPupil = new System.Windows.Forms.Button();
            this.btnViewData = new System.Windows.Forms.Button();
            this.btnGetBest = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.comboMark1 = new System.Windows.Forms.ComboBox();
            this.labelMark1 = new System.Windows.Forms.Label();
            this.comboMark2 = new System.Windows.Forms.ComboBox();
            this.comboMark3 = new System.Windows.Forms.ComboBox();
            this.labelMark2 = new System.Windows.Forms.Label();
            this.labelMark3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.tbSKOLNIEKI = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.labelHost = new System.Windows.Forms.Label();
            this.textHost = new System.Windows.Forms.TextBox();
            this.labelSID = new System.Windows.Forms.Label();
            this.textSID = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.labelPwd = new System.Windows.Forms.Label();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCloseSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbSKOLNIEKI)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPupil
            // 
            this.btnAddPupil.Location = new System.Drawing.Point(12, 29);
            this.btnAddPupil.Name = "btnAddPupil";
            this.btnAddPupil.Size = new System.Drawing.Size(102, 44);
            this.btnAddPupil.TabIndex = 0;
            this.btnAddPupil.Text = "Pievienot Skolnieku";
            this.btnAddPupil.UseVisualStyleBackColor = true;
            this.btnAddPupil.Click += new System.EventHandler(this.btnAddPupil_Click);
            // 
            // btnViewData
            // 
            this.btnViewData.Location = new System.Drawing.Point(12, 93);
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Size = new System.Drawing.Size(102, 44);
            this.btnViewData.TabIndex = 1;
            this.btnViewData.Text = "Apskatīt Datus";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // btnGetBest
            // 
            this.btnGetBest.Location = new System.Drawing.Point(12, 163);
            this.btnGetBest.Name = "btnGetBest";
            this.btnGetBest.Size = new System.Drawing.Size(102, 44);
            this.btnGetBest.TabIndex = 2;
            this.btnGetBest.Text = "Teicamnieki";
            this.btnGetBest.UseVisualStyleBackColor = true;
            this.btnGetBest.Click += new System.EventHandler(this.btnGetBest_Click);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textName.Location = new System.Drawing.Point(276, 29);
            this.textName.MaxLength = 25;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(243, 26);
            this.textName.TabIndex = 3;
            this.textName.Visible = false;
            this.textName.Leave += new System.EventHandler(this.textName_Leave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelName.Location = new System.Drawing.Point(215, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Vārds:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Visible = false;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelSurname.Location = new System.Drawing.Point(199, 72);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(71, 20);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Uzvārds:";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSurname.Visible = false;
            // 
            // textSurname
            // 
            this.textSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textSurname.Location = new System.Drawing.Point(276, 72);
            this.textSurname.MaxLength = 25;
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(243, 26);
            this.textSurname.TabIndex = 6;
            this.textSurname.Visible = false;
            this.textSurname.Leave += new System.EventHandler(this.textSurname_Leave);
            // 
            // comboMark1
            // 
            this.comboMark1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMark1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.comboMark1.FormattingEnabled = true;
            this.comboMark1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboMark1.Location = new System.Drawing.Point(644, 21);
            this.comboMark1.Name = "comboMark1";
            this.comboMark1.Size = new System.Drawing.Size(47, 28);
            this.comboMark1.TabIndex = 7;
            this.comboMark1.Visible = false;
            // 
            // labelMark1
            // 
            this.labelMark1.AutoSize = true;
            this.labelMark1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelMark1.Location = new System.Drawing.Point(563, 25);
            this.labelMark1.Name = "labelMark1";
            this.labelMark1.Size = new System.Drawing.Size(75, 20);
            this.labelMark1.TabIndex = 8;
            this.labelMark1.Text = "Atzīme 1:";
            this.labelMark1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMark1.Visible = false;
            // 
            // comboMark2
            // 
            this.comboMark2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMark2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.comboMark2.FormattingEnabled = true;
            this.comboMark2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboMark2.Location = new System.Drawing.Point(644, 64);
            this.comboMark2.Name = "comboMark2";
            this.comboMark2.Size = new System.Drawing.Size(47, 28);
            this.comboMark2.TabIndex = 9;
            this.comboMark2.Visible = false;
            // 
            // comboMark3
            // 
            this.comboMark3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMark3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.comboMark3.FormattingEnabled = true;
            this.comboMark3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboMark3.Location = new System.Drawing.Point(644, 104);
            this.comboMark3.Name = "comboMark3";
            this.comboMark3.Size = new System.Drawing.Size(47, 28);
            this.comboMark3.TabIndex = 10;
            this.comboMark3.Visible = false;
            // 
            // labelMark2
            // 
            this.labelMark2.AutoSize = true;
            this.labelMark2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelMark2.Location = new System.Drawing.Point(563, 67);
            this.labelMark2.Name = "labelMark2";
            this.labelMark2.Size = new System.Drawing.Size(75, 20);
            this.labelMark2.TabIndex = 11;
            this.labelMark2.Text = "Atzīme 2:";
            this.labelMark2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMark2.Visible = false;
            // 
            // labelMark3
            // 
            this.labelMark3.AutoSize = true;
            this.labelMark3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelMark3.Location = new System.Drawing.Point(563, 107);
            this.labelMark3.Name = "labelMark3";
            this.labelMark3.Size = new System.Drawing.Size(75, 20);
            this.labelMark3.TabIndex = 12;
            this.labelMark3.Text = "Atzīme 3:";
            this.labelMark3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMark3.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 44);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Pievienot";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(12, 93);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(102, 44);
            this.btnCancelAdd.TabIndex = 14;
            this.btnCancelAdd.Text = "Atcelt";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Visible = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // tbSKOLNIEKI
            // 
            this.tbSKOLNIEKI.AllowUserToAddRows = false;
            this.tbSKOLNIEKI.AllowUserToDeleteRows = false;
            this.tbSKOLNIEKI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbSKOLNIEKI.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tbSKOLNIEKI.Location = new System.Drawing.Point(161, 29);
            this.tbSKOLNIEKI.MultiSelect = false;
            this.tbSKOLNIEKI.Name = "tbSKOLNIEKI";
            this.tbSKOLNIEKI.ReadOnly = true;
            this.tbSKOLNIEKI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSKOLNIEKI.ShowCellErrors = false;
            this.tbSKOLNIEKI.ShowCellToolTips = false;
            this.tbSKOLNIEKI.ShowEditingIcon = false;
            this.tbSKOLNIEKI.ShowRowErrors = false;
            this.tbSKOLNIEKI.Size = new System.Drawing.Size(545, 419);
            this.tbSKOLNIEKI.TabIndex = 15;
            this.tbSKOLNIEKI.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 29);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 44);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Atpakaļ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::LD1.Properties.Resources.lejupielāde;
            this.btnSettings.Location = new System.Drawing.Point(749, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(39, 43);
            this.btnSettings.TabIndex = 17;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelHost.Location = new System.Drawing.Point(223, 29);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(47, 20);
            this.labelHost.TabIndex = 18;
            this.labelHost.Text = "Host:";
            this.labelHost.Visible = false;
            // 
            // textHost
            // 
            this.textHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textHost.Location = new System.Drawing.Point(276, 29);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(243, 26);
            this.textHost.TabIndex = 19;
            this.textHost.Text = "localhost";
            this.textHost.Visible = false;
            // 
            // labelSID
            // 
            this.labelSID.AutoSize = true;
            this.labelSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelSID.Location = new System.Drawing.Point(229, 75);
            this.labelSID.Name = "labelSID";
            this.labelSID.Size = new System.Drawing.Size(41, 20);
            this.labelSID.TabIndex = 20;
            this.labelSID.Text = "SID:";
            this.labelSID.Visible = false;
            // 
            // textSID
            // 
            this.textSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textSID.Location = new System.Drawing.Point(276, 72);
            this.textSID.Name = "textSID";
            this.textSID.Size = new System.Drawing.Size(243, 26);
            this.textSID.TabIndex = 21;
            this.textSID.Text = "ASPnet";
            this.textSID.Visible = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelLogin.Location = new System.Drawing.Point(218, 124);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(52, 20);
            this.labelLogin.TabIndex = 22;
            this.labelLogin.Text = "Login:";
            this.labelLogin.Visible = false;
            // 
            // textLogin
            // 
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textLogin.Location = new System.Drawing.Point(276, 121);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(243, 26);
            this.textLogin.TabIndex = 23;
            this.textLogin.Text = "system";
            this.textLogin.Visible = false;
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelPwd.Location = new System.Drawing.Point(227, 179);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(43, 20);
            this.labelPwd.TabIndex = 24;
            this.labelPwd.Text = "Pwd:";
            this.labelPwd.Visible = false;
            // 
            // textPwd
            // 
            this.textPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textPwd.Location = new System.Drawing.Point(276, 176);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(243, 26);
            this.textPwd.TabIndex = 25;
            this.textPwd.Text = "aspnet";
            this.textPwd.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(233, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 44);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Saglabāt";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCloseSettings
            // 
            this.btnCloseSettings.Location = new System.Drawing.Point(448, 237);
            this.btnCloseSettings.Name = "btnCloseSettings";
            this.btnCloseSettings.Size = new System.Drawing.Size(102, 44);
            this.btnCloseSettings.TabIndex = 27;
            this.btnCloseSettings.Text = "Aizvērt";
            this.btnCloseSettings.UseVisualStyleBackColor = true;
            this.btnCloseSettings.Visible = false;
            this.btnCloseSettings.Click += new System.EventHandler(this.btnCloseSettings_Click);
            // 
            // LD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseSettings);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textSID);
            this.Controls.Add(this.labelSID);
            this.Controls.Add(this.textHost);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGetBest);
            this.Controls.Add(this.btnAddPupil);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.labelMark3);
            this.Controls.Add(this.labelMark2);
            this.Controls.Add(this.comboMark3);
            this.Controls.Add(this.comboMark2);
            this.Controls.Add(this.labelMark1);
            this.Controls.Add(this.comboMark1);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.tbSKOLNIEKI);
            this.Name = "LD1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LD1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSKOLNIEKI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPupil;
        private System.Windows.Forms.Button btnViewData;
        private System.Windows.Forms.Button btnGetBest;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.ComboBox comboMark1;
        private System.Windows.Forms.Label labelMark1;
        private System.Windows.Forms.ComboBox comboMark2;
        private System.Windows.Forms.ComboBox comboMark3;
        private System.Windows.Forms.Label labelMark2;
        private System.Windows.Forms.Label labelMark3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.DataGridView tbSKOLNIEKI;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.Label labelSID;
        private System.Windows.Forms.TextBox textSID;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCloseSettings;
    }
}

