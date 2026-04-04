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
			// buttonPhoto
			// 
			this.buttonPhoto.Location = new System.Drawing.Point(680, 348);
			this.buttonPhoto.Size = new System.Drawing.Size(233, 53);
			// 
			// pictureBoxPhoto
			// 
			this.pictureBoxPhoto.Size = new System.Drawing.Size(233, 313);
			// 
			// rtbEmail
			// 
			this.rtbEmail.Location = new System.Drawing.Point(298, 289);
			// 
			// rtbPhone
			// 
			this.rtbPhone.Location = new System.Drawing.Point(298, 401);
			// 
			// labelEmail
			// 
			this.labelEmail.Location = new System.Drawing.Point(191, 289);
			// 
			// labelPhone
			// 
			this.labelPhone.Location = new System.Drawing.Point(145, 402);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.label1.Location = new System.Drawing.Point(165, 350);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 37);
			this.label1.TabIndex = 11;
			this.label1.Text = "Группа";
			// 
			// cbStudentsGroup
			// 
			this.cbStudentsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStudentsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.cbStudentsGroup.FormattingEnabled = true;
			this.cbStudentsGroup.Location = new System.Drawing.Point(298, 346);
			this.cbStudentsGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbStudentsGroup.Name = "cbStudentsGroup";
			this.cbStudentsGroup.Size = new System.Drawing.Size(344, 45);
			this.cbStudentsGroup.TabIndex = 12;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.buttonOK.Location = new System.Drawing.Point(441, 560);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(233, 48);
			this.buttonOK.TabIndex = 13;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancwl
			// 
			this.buttonCancwl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancwl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.buttonCancwl.Location = new System.Drawing.Point(680, 560);
			this.buttonCancwl.Name = "buttonCancwl";
			this.buttonCancwl.Size = new System.Drawing.Size(233, 48);
			this.buttonCancwl.TabIndex = 14;
			this.buttonCancwl.Text = "Cancel";
			this.buttonCancwl.UseVisualStyleBackColor = true;
			// 
			// StudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 636);
			this.Controls.Add(this.buttonCancwl);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.cbStudentsGroup);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.Name = "StudentForm";
			this.Text = "Student";
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