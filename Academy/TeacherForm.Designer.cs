namespace Academy
{
	partial class TeacherForm
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
			this.labelWork_start = new System.Windows.Forms.Label();
			this.dtpWork_start = new System.Windows.Forms.DateTimePicker();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// labelID
			// 
			this.labelID.Location = new System.Drawing.Point(23, 354);
			// 
			// labelWork_start
			// 
			this.labelWork_start.AutoSize = true;
			this.labelWork_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.labelWork_start.Location = new System.Drawing.Point(23, 236);
			this.labelWork_start.Name = "labelWork_start";
			this.labelWork_start.Size = new System.Drawing.Size(170, 26);
			this.labelWork_start.TabIndex = 15;
			this.labelWork_start.Text = "Начало работы";
			// 
			// dtpWork_start
			// 
			this.dtpWork_start.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.dtpWork_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.dtpWork_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpWork_start.Location = new System.Drawing.Point(202, 236);
			this.dtpWork_start.Name = "dtpWork_start";
			this.dtpWork_start.Size = new System.Drawing.Size(231, 32);
			this.dtpWork_start.TabIndex = 16;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.buttonOK.Location = new System.Drawing.Point(357, 354);
			this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(155, 31);
			this.buttonOK.TabIndex = 17;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.buttonCancel.Location = new System.Drawing.Point(516, 354);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(155, 31);
			this.buttonCancel.TabIndex = 18;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// TeacherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 412);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.dtpWork_start);
			this.Controls.Add(this.labelWork_start);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "TeacherForm";
			this.Text = "TeacherForm";
			this.Controls.SetChildIndex(this.labelID, 0);
			this.Controls.SetChildIndex(this.label2BirthDate, 0);
			this.Controls.SetChildIndex(this.rtbLastNAme, 0);
			this.Controls.SetChildIndex(this.rtbFirstName, 0);
			this.Controls.SetChildIndex(this.rtbMiddleNAme, 0);
			this.Controls.SetChildIndex(this.dtpBirthDate, 0);
			this.Controls.SetChildIndex(this.pictureBoxPhoto, 0);
			this.Controls.SetChildIndex(this.buttonPhoto, 0);
			this.Controls.SetChildIndex(this.rtbEmail, 0);
			this.Controls.SetChildIndex(this.rtbPhone, 0);
			this.Controls.SetChildIndex(this.labelEmail, 0);
			this.Controls.SetChildIndex(this.labelPhone, 0);
			this.Controls.SetChildIndex(this.labelWork_start, 0);
			this.Controls.SetChildIndex(this.dtpWork_start, 0);
			this.Controls.SetChildIndex(this.buttonOK, 0);
			this.Controls.SetChildIndex(this.buttonCancel, 0);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelWork_start;
		protected System.Windows.Forms.DateTimePicker dtpWork_start;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
	}
}