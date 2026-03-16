
namespace OIM.PS.SyncProject.Common.CommonForms
{
	partial class PropertyForm
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
            components = new System.ComponentModel.Container();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            chkIsUniqueKey = new System.Windows.Forms.CheckBox();
            chkIsDisplay = new System.Windows.Forms.CheckBox();
            chkIsMandatory = new System.Windows.Forms.CheckBox();
            chkIsAutoFill = new System.Windows.Forms.CheckBox();
            chkIsPrimaryKey = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            cmbDataType = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            txtPropertyName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            chkIsMultiValue = new System.Windows.Forms.CheckBox();
            chkIsRevision = new System.Windows.Forms.CheckBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblManyToMany = new System.Windows.Forms.Label();
            chkIncludeInPrimary = new System.Windows.Forms.CheckBox();
            chkCombinedPrimary = new System.Windows.Forms.CheckBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            groupBox2 = new System.Windows.Forms.GroupBox();
            chkGet = new System.Windows.Forms.CheckBox();
            chkGetAll = new System.Windows.Forms.CheckBox();
            chkUpdate = new System.Windows.Forms.CheckBox();
            chkInsert = new System.Windows.Forms.CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(438, 106);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(358, 106);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkIsUniqueKey
            // 
            chkIsUniqueKey.AutoSize = true;
            chkIsUniqueKey.Location = new System.Drawing.Point(226, 211);
            chkIsUniqueKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkIsUniqueKey.Name = "chkIsUniqueKey";
            chkIsUniqueKey.Size = new System.Drawing.Size(91, 19);
            chkIsUniqueKey.TabIndex = 36;
            chkIsUniqueKey.Text = "IsUniqueKey";
            chkIsUniqueKey.UseVisualStyleBackColor = true;
            // 
            // chkIsDisplay
            // 
            chkIsDisplay.AutoSize = true;
            chkIsDisplay.Location = new System.Drawing.Point(118, 188);
            chkIsDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkIsDisplay.Name = "chkIsDisplay";
            chkIsDisplay.Size = new System.Drawing.Size(72, 19);
            chkIsDisplay.TabIndex = 35;
            chkIsDisplay.Text = "IsDisplay";
            chkIsDisplay.UseVisualStyleBackColor = true;
            // 
            // chkIsMandatory
            // 
            chkIsMandatory.AutoSize = true;
            chkIsMandatory.Location = new System.Drawing.Point(118, 211);
            chkIsMandatory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkIsMandatory.Name = "chkIsMandatory";
            chkIsMandatory.Size = new System.Drawing.Size(92, 19);
            chkIsMandatory.TabIndex = 34;
            chkIsMandatory.Text = "IsMandatory";
            chkIsMandatory.UseVisualStyleBackColor = true;
            // 
            // chkIsAutoFill
            // 
            chkIsAutoFill.AutoSize = true;
            chkIsAutoFill.Location = new System.Drawing.Point(16, 211);
            chkIsAutoFill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkIsAutoFill.Name = "chkIsAutoFill";
            chkIsAutoFill.Size = new System.Drawing.Size(75, 19);
            chkIsAutoFill.TabIndex = 33;
            chkIsAutoFill.Text = "IsAutoFill";
            chkIsAutoFill.UseVisualStyleBackColor = true;
            // 
            // chkIsPrimaryKey
            // 
            chkIsPrimaryKey.AutoSize = true;
            chkIsPrimaryKey.Location = new System.Drawing.Point(16, 188);
            chkIsPrimaryKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkIsPrimaryKey.Name = "chkIsPrimaryKey";
            chkIsPrimaryKey.Size = new System.Drawing.Size(94, 19);
            chkIsPrimaryKey.TabIndex = 32;
            chkIsPrimaryKey.Text = "IsPrimaryKey";
            chkIsPrimaryKey.UseVisualStyleBackColor = true;
            chkIsPrimaryKey.CheckedChanged += chkIsPrimaryKey_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(358, 50);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 15);
            label4.TabIndex = 31;
            label4.Text = "Data Type";
            // 
            // cmbDataType
            // 
            cmbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbDataType.FormattingEnabled = true;
            cmbDataType.Items.AddRange(new object[] { "String", "Bool", "DateTime", "Int" });
            cmbDataType.Location = new System.Drawing.Point(358, 68);
            cmbDataType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmbDataType.Name = "cmbDataType";
            cmbDataType.Size = new System.Drawing.Size(156, 23);
            cmbDataType.TabIndex = 30;
            cmbDataType.SelectedIndexChanged += cmbDataType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 50);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 15);
            label3.TabIndex = 29;
            label3.Text = "Property Name";
            // 
            // txtPropertyName
            // 
            txtPropertyName.Location = new System.Drawing.Point(14, 69);
            txtPropertyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPropertyName.Name = "txtPropertyName";
            txtPropertyName.Size = new System.Drawing.Size(333, 23);
            txtPropertyName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            label1.Location = new System.Drawing.Point(161, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(143, 30);
            label1.TabIndex = 37;
            label1.Text = "Add Property";
            // 
            // chkIsMultiValue
            // 
            chkIsMultiValue.AutoSize = true;
            chkIsMultiValue.Location = new System.Drawing.Point(227, 188);
            chkIsMultiValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkIsMultiValue.Name = "chkIsMultiValue";
            chkIsMultiValue.Size = new System.Drawing.Size(90, 19);
            chkIsMultiValue.TabIndex = 38;
            chkIsMultiValue.Text = "IsMultiValue";
            chkIsMultiValue.UseVisualStyleBackColor = true;
            // 
            // chkIsRevision
            // 
            chkIsRevision.AutoSize = true;
            chkIsRevision.Location = new System.Drawing.Point(329, 211);
            chkIsRevision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkIsRevision.Name = "chkIsRevision";
            chkIsRevision.Size = new System.Drawing.Size(78, 19);
            chkIsRevision.TabIndex = 39;
            chkIsRevision.Text = "IsRevision";
            chkIsRevision.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblManyToMany);
            groupBox1.Controls.Add(chkIncludeInPrimary);
            groupBox1.Controls.Add(chkCombinedPrimary);
            groupBox1.Location = new System.Drawing.Point(18, 105);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(335, 66);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Many-To-Many (Membership)";
            // 
            // lblManyToMany
            // 
            lblManyToMany.AutoSize = true;
            lblManyToMany.BackColor = System.Drawing.Color.DeepSkyBlue;
            lblManyToMany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblManyToMany.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblManyToMany.ForeColor = System.Drawing.Color.Red;
            lblManyToMany.Location = new System.Drawing.Point(312, 17);
            lblManyToMany.Name = "lblManyToMany";
            lblManyToMany.Size = new System.Drawing.Size(16, 22);
            lblManyToMany.TabIndex = 2;
            lblManyToMany.Text = "!";
            toolTip1.SetToolTip(lblManyToMany, "Many-to-Many record configuration");
            lblManyToMany.Click += lblManyToMany_Click;
            // 
            // chkIncludeInPrimary
            // 
            chkIncludeInPrimary.Location = new System.Drawing.Point(144, 20);
            chkIncludeInPrimary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkIncludeInPrimary.Name = "chkIncludeInPrimary";
            chkIncludeInPrimary.Size = new System.Drawing.Size(163, 45);
            chkIncludeInPrimary.TabIndex = 1;
            chkIncludeInPrimary.Text = "Field to Include in Combined Primary Key\r\n";
            chkIncludeInPrimary.UseVisualStyleBackColor = true;
            chkIncludeInPrimary.CheckedChanged += chkIncludeInPrimary_CheckedChanged;
            // 
            // chkCombinedPrimary
            // 
            chkCombinedPrimary.Location = new System.Drawing.Point(10, 20);
            chkCombinedPrimary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkCombinedPrimary.Name = "chkCombinedPrimary";
            chkCombinedPrimary.Size = new System.Drawing.Size(138, 45);
            chkCombinedPrimary.TabIndex = 0;
            chkCombinedPrimary.Text = "Combined (virtual) Primary Key";
            chkCombinedPrimary.UseVisualStyleBackColor = true;
            chkCombinedPrimary.CheckedChanged += chkCombinedPrimary_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkInsert);
            groupBox2.Controls.Add(chkUpdate);
            groupBox2.Controls.Add(chkGet);
            groupBox2.Controls.Add(chkGetAll);
            groupBox2.Location = new System.Drawing.Point(18, 234);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Size = new System.Drawing.Size(299, 66);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operations";
            // 
            // chkGet
            // 
            chkGet.Location = new System.Drawing.Point(79, 20);
            chkGet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkGet.Name = "chkGet";
            chkGet.Size = new System.Drawing.Size(72, 45);
            chkGet.TabIndex = 1;
            chkGet.Text = "Get";
            chkGet.UseVisualStyleBackColor = true;
            // 
            // chkGetAll
            // 
            chkGetAll.Location = new System.Drawing.Point(10, 20);
            chkGetAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkGetAll.Name = "chkGetAll";
            chkGetAll.Size = new System.Drawing.Size(63, 45);
            chkGetAll.TabIndex = 0;
            chkGetAll.Text = "GetAll";
            chkGetAll.UseVisualStyleBackColor = true;
            // 
            // chkUpdate
            // 
            chkUpdate.Location = new System.Drawing.Point(144, 20);
            chkUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkUpdate.Name = "chkUpdate";
            chkUpdate.Size = new System.Drawing.Size(72, 45);
            chkUpdate.TabIndex = 2;
            chkUpdate.Text = "Update";
            chkUpdate.UseVisualStyleBackColor = true;
            // 
            // chkInsert
            // 
            chkInsert.Location = new System.Drawing.Point(222, 21);
            chkInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chkInsert.Name = "chkInsert";
            chkInsert.Size = new System.Drawing.Size(72, 45);
            chkInsert.TabIndex = 3;
            chkInsert.Text = "Insert";
            chkInsert.UseVisualStyleBackColor = true;
            // 
            // PropertyForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(535, 308);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(chkIsRevision);
            Controls.Add(chkIsMultiValue);
            Controls.Add(label1);
            Controls.Add(chkIsUniqueKey);
            Controls.Add(chkIsDisplay);
            Controls.Add(chkIsMandatory);
            Controls.Add(chkIsAutoFill);
            Controls.Add(chkIsPrimaryKey);
            Controls.Add(label4);
            Controls.Add(cmbDataType);
            Controls.Add(label3);
            Controls.Add(txtPropertyName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PropertyForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Property";
            Load += PropertyForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox chkIsUniqueKey;
		private System.Windows.Forms.CheckBox chkIsDisplay;
		private System.Windows.Forms.CheckBox chkIsMandatory;
		private System.Windows.Forms.CheckBox chkIsAutoFill;
		private System.Windows.Forms.CheckBox chkIsPrimaryKey;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbDataType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPropertyName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkIsMultiValue;
		private System.Windows.Forms.CheckBox chkIsRevision;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkCombinedPrimary;
		private System.Windows.Forms.CheckBox chkIncludeInPrimary;
		private System.Windows.Forms.Label lblManyToMany;
		private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkGet;
        private System.Windows.Forms.CheckBox chkGetAll;
        private System.Windows.Forms.CheckBox chkInsert;
        private System.Windows.Forms.CheckBox chkUpdate;
    }
}