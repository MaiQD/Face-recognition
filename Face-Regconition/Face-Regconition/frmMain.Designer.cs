namespace Face_Regconition
{
	partial class frmMain
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.picBoxCapture = new System.Windows.Forms.PictureBox();
			this.btnCapture = new System.Windows.Forms.Button();
			this.btnDetectFace = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxCapture)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.picBoxCapture);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(600, 609);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Camera";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnDetectFace);
			this.groupBox2.Controls.Add(this.btnCapture);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(628, 7);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 609);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thao tác";
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(844, 7);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(237, 288);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			// 
			// picBoxCapture
			// 
			this.picBoxCapture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picBoxCapture.Location = new System.Drawing.Point(3, 22);
			this.picBoxCapture.Name = "picBoxCapture";
			this.picBoxCapture.Size = new System.Drawing.Size(594, 584);
			this.picBoxCapture.TabIndex = 0;
			this.picBoxCapture.TabStop = false;
			// 
			// btnCapture
			// 
			this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapture.Location = new System.Drawing.Point(7, 25);
			this.btnCapture.Name = "btnCapture";
			this.btnCapture.Size = new System.Drawing.Size(187, 54);
			this.btnCapture.TabIndex = 0;
			this.btnCapture.Text = "Capture";
			this.btnCapture.UseVisualStyleBackColor = true;
			this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
			// 
			// btnDetectFace
			// 
			this.btnDetectFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDetectFace.Location = new System.Drawing.Point(7, 99);
			this.btnDetectFace.Name = "btnDetectFace";
			this.btnDetectFace.Size = new System.Drawing.Size(187, 54);
			this.btnDetectFace.TabIndex = 0;
			this.btnDetectFace.Text = "Detect Face";
			this.btnDetectFace.UseVisualStyleBackColor = true;
			this.btnDetectFace.Click += new System.EventHandler(this.btnDetectFace_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1093, 628);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmMain";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picBoxCapture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox picBoxCapture;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnCapture;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnDetectFace;
	}
}

