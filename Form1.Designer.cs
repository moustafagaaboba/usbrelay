namespace usbrelay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.buttonLight1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonLight2 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonLight4 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonLight3 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.buttonLight8 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.buttonLight7 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonLight6 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.buttonLight5 = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.ItemHeight = 37;
            this.listBoxDevices.Location = new System.Drawing.Point(12, 14);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(312, 670);
            this.listBoxDevices.TabIndex = 0;
            this.listBoxDevices.SelectedIndexChanged += new System.EventHandler(this.ListBoxDevices_SelectedIndexChanged);
            // 
            // buttonLight1
            // 
            this.buttonLight1.Location = new System.Drawing.Point(372, 14);
            this.buttonLight1.Name = "buttonLight1";
            this.buttonLight1.Size = new System.Drawing.Size(188, 58);
            this.buttonLight1.TabIndex = 1;
            this.buttonLight1.Text = "Light 1";
            this.buttonLight1.UseVisualStyleBackColor = true;
            this.buttonLight1.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(913, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::usbrelay.Properties.Resources.bulb;
            this.pictureBox1.Location = new System.Drawing.Point(424, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(670, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // buttonLight2
            // 
            this.buttonLight2.Location = new System.Drawing.Point(618, 14);
            this.buttonLight2.Name = "buttonLight2";
            this.buttonLight2.Size = new System.Drawing.Size(188, 58);
            this.buttonLight2.TabIndex = 4;
            this.buttonLight2.Text = "Light 2";
            this.buttonLight2.UseVisualStyleBackColor = true;
            this.buttonLight2.Click += new System.EventHandler(this.Button_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1159, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // buttonLight4
            // 
            this.buttonLight4.Location = new System.Drawing.Point(1107, 14);
            this.buttonLight4.Name = "buttonLight4";
            this.buttonLight4.Size = new System.Drawing.Size(188, 58);
            this.buttonLight4.TabIndex = 8;
            this.buttonLight4.Text = "Light 4";
            this.buttonLight4.UseVisualStyleBackColor = true;
            this.buttonLight4.Click += new System.EventHandler(this.Button_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(913, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // buttonLight3
            // 
            this.buttonLight3.Location = new System.Drawing.Point(861, 14);
            this.buttonLight3.Name = "buttonLight3";
            this.buttonLight3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLight3.Size = new System.Drawing.Size(188, 58);
            this.buttonLight3.TabIndex = 6;
            this.buttonLight3.Text = "Light 3";
            this.buttonLight3.UseVisualStyleBackColor = true;
            this.buttonLight3.Click += new System.EventHandler(this.Button_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(1159, 578);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(76, 100);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // buttonLight8
            // 
            this.buttonLight8.Location = new System.Drawing.Point(1107, 483);
            this.buttonLight8.Name = "buttonLight8";
            this.buttonLight8.Size = new System.Drawing.Size(188, 58);
            this.buttonLight8.TabIndex = 16;
            this.buttonLight8.Text = "Light 8";
            this.buttonLight8.UseVisualStyleBackColor = true;
            this.buttonLight8.Click += new System.EventHandler(this.Button_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(913, 578);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(76, 100);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // buttonLight7
            // 
            this.buttonLight7.Location = new System.Drawing.Point(861, 483);
            this.buttonLight7.Name = "buttonLight7";
            this.buttonLight7.Size = new System.Drawing.Size(188, 58);
            this.buttonLight7.TabIndex = 14;
            this.buttonLight7.Text = "Light 7";
            this.buttonLight7.UseVisualStyleBackColor = true;
            this.buttonLight7.Click += new System.EventHandler(this.Button_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(670, 578);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(76, 100);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // buttonLight6
            // 
            this.buttonLight6.Location = new System.Drawing.Point(618, 483);
            this.buttonLight6.Name = "buttonLight6";
            this.buttonLight6.Size = new System.Drawing.Size(188, 58);
            this.buttonLight6.TabIndex = 12;
            this.buttonLight6.Text = "Light 6";
            this.buttonLight6.UseVisualStyleBackColor = true;
            this.buttonLight6.Click += new System.EventHandler(this.Button_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(424, 578);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(76, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // buttonLight5
            // 
            this.buttonLight5.Location = new System.Drawing.Point(372, 483);
            this.buttonLight5.Name = "buttonLight5";
            this.buttonLight5.Size = new System.Drawing.Size(188, 58);
            this.buttonLight5.TabIndex = 10;
            this.buttonLight5.Text = "Light 5";
            this.buttonLight5.UseVisualStyleBackColor = true;
            this.buttonLight5.Click += new System.EventHandler(this.Button_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(618, 312);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(431, 59);
            this.buttonRefresh.TabIndex = 18;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 701);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.buttonLight8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.buttonLight7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.buttonLight6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.buttonLight5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonLight4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonLight3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonLight2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonLight1);
            this.Controls.Add(this.listBoxDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = resources.GetString("$this.Text");
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxDevices;
        private Button buttonLight1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonLight2;
        private PictureBox pictureBox4;
        private Button buttonLight4;
        private PictureBox pictureBox3;
        private Button buttonLight3;
        private PictureBox pictureBox8;
        private Button buttonLight8;
        private PictureBox pictureBox7;
        private Button buttonLight7;
        private PictureBox pictureBox6;
        private Button buttonLight6;
        private PictureBox pictureBox5;
        private Button buttonLight5;
        private Button buttonRefresh;
    }
}