namespace Academy
{
	partial class StudentForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.cbStudentsGroup = new System.Windows.Forms.ComboBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancwl = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// label2BirthDate
			// 
			this.label2BirthDate.Location = new System.Drawing.Point(26, 149);
			// 
			// buttonPhoto
			// 
			this.buttonPhoto.Location = new System.Drawing.Point(453, 226);
			this.buttonPhoto.Margin = new System.Windows.Forms.Padding(2);
			this.buttonPhoto.Size = new System.Drawing.Size(155, 34);
			// 
			// pictureBoxPhoto
			// 
			this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBoxPhoto.Size = new System.Drawing.Size(156, 204);
			// 
			// rtbLastNAme
			// 
			this.rtbLastNAme.Location = new System.Drawing.Point(202, 43);
			this.rtbLastNAme.Margin = new System.Windows.Forms.Padding(2);
			this.rtbLastNAme.Size = new System.Drawing.Size(231, 18);
			// 
			// rtbFirstName
			// 
			this.rtbFirstName.Location = new System.Drawing.Point(202, 78);
			this.rtbFirstName.Margin = new System.Windows.Forms.Padding(2);
			this.rtbFirstName.Size = new System.Drawing.Size(231, 18);
			// 
			// rtbMiddleNAme
			// 
			this.rtbMiddleNAme.Location = new System.Drawing.Point(202, 113);
			this.rtbMiddleNAme.Margin = new System.Windows.Forms.Padding(2);
			this.rtbMiddleNAme.Size = new System.Drawing.Size(231, 18);
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Location = new System.Drawing.Point(202, 148);
			this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			// 
			// rtbEmail
			// 
			this.rtbEmail.Location = new System.Drawing.Point(202, 197);
			this.rtbEmail.Margin = new System.Windows.Forms.Padding(2);
			this.rtbEmail.Size = new System.Drawing.Size(231, 18);
			// 
			// rtbPhone
			// 
			this.rtbPhone.Location = new System.Drawing.Point(202, 232);
			this.rtbPhone.Margin = new System.Windows.Forms.Padding(2);
			this.rtbPhone.Size = new System.Drawing.Size(231, 18);
			// 
			// labelEmail
			// 
			this.labelEmail.Location = new System.Drawing.Point(131, 188);
			this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			// 
			// labelPhone
			// 
			this.labelPhone.Location = new System.Drawing.Point(92, 226);
			this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			// 
			// labelID
			// 
			this.labelID.Location = new System.Drawing.Point(23, 371);
			this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label1.Location = new System.Drawing.Point(113, 272);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 26);
			this.label1.TabIndex = 11;
			this.label1.Text = "Группа";
			// 
			// cbStudentsGroup
			// 
			this.cbStudentsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStudentsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.cbStudentsGroup.FormattingEnabled = true;
			this.cbStudentsGroup.Location = new System.Drawing.Point(202, 267);
			this.cbStudentsGroup.Name = "cbStudentsGroup";
			this.cbStudentsGroup.Size = new System.Drawing.Size(231, 33);
			this.cbStudentsGroup.TabIndex = 12;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.buttonOK.Location = new System.Drawing.Point(294, 364);
			this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(155, 31);
			this.buttonOK.TabIndex = 13;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancwl
			// 
			this.buttonCancwl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancwl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.buttonCancwl.Location = new System.Drawing.Point(454, 364);
			this.buttonCancwl.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCancwl.Name = "buttonCancwl";
			this.buttonCancwl.Size = new System.Drawing.Size(155, 31);
			this.buttonCancwl.TabIndex = 14;
			this.buttonCancwl.Text = "Cancel";
			this.buttonCancwl.UseVisualStyleBackColor = true;
			// 
			// StudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 413);
			this.Controls.Add(this.buttonCancwl);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.cbStudentsGroup);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "StudentForm";
			this.Text = "Student";
			this.Controls.SetChildIndex(this.labelID, 0);
			this.Controls.SetChildIndex(this.rtbEmail, 0);
			this.Controls.SetChildIndex(this.rtbPhone, 0);
			this.Controls.SetChildIndex(this.labelEmail, 0);
			this.Controls.SetChildIndex(this.labelPhone, 0);
			this.Controls.SetChildIndex(this.rtbLastNAme, 0);
			this.Controls.SetChildIndex(this.rtbFirstName, 0);
			this.Controls.SetChildIndex(this.rtbMiddleNAme, 0);
			this.Controls.SetChildIndex(this.dtpBirthDate, 0);
			this.Controls.SetChildIndex(this.label2BirthDate, 0);
			this.Controls.SetChildIndex(this.pictureBoxPhoto, 0);
			this.Controls.SetChildIndex(this.buttonPhoto, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.cbStudentsGroup, 0);
			this.Controls.SetChildIndex(this.buttonOK, 0);
			this.Controls.SetChildIndex(this.buttonCancwl, 0);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbStudentsGroup;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancwl;
	}
}