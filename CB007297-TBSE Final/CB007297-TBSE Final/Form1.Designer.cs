namespace CB007297_TBSE_Final
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Rotate_Left = new System.Windows.Forms.Button();
            this.Rotate_Right = new System.Windows.Forms.Button();
            this.Vertical_Flip = new System.Windows.Forms.Button();
            this.Horizontal_Flip = new System.Windows.Forms.Button();
            this.negativefilter = new System.Windows.Forms.Button();
            this.sepia_filter = new System.Windows.Forms.Button();
            this.dark_mode = new System.Windows.Forms.Button();
            this.greyscale = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reset = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reset2 = new System.Windows.Forms.Button();
            this.save2 = new System.Windows.Forms.Button();
            this.remove2 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.redtrackbar = new System.Windows.Forms.TrackBar();
            this.greentrackbar = new System.Windows.Forms.TrackBar();
            this.bluetrackbar = new System.Windows.Forms.TrackBar();
            this.redbarvalue = new System.Windows.Forms.Label();
            this.greenbarvalue = new System.Windows.Forms.Label();
            this.bluebarvalue = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redtrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greentrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluetrackbar)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(160, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 608);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Rotate_Left);
            this.panel1.Controls.Add(this.Rotate_Right);
            this.panel1.Controls.Add(this.Vertical_Flip);
            this.panel1.Controls.Add(this.Horizontal_Flip);
            this.panel1.Controls.Add(this.negativefilter);
            this.panel1.Controls.Add(this.sepia_filter);
            this.panel1.Controls.Add(this.dark_mode);
            this.panel1.Controls.Add(this.greyscale);
            this.panel1.Location = new System.Drawing.Point(25, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 516);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Editing Options";
            // 
            // Rotate_Left
            // 
            this.Rotate_Left.Location = new System.Drawing.Point(4, 451);
            this.Rotate_Left.Name = "Rotate_Left";
            this.Rotate_Left.Size = new System.Drawing.Size(88, 49);
            this.Rotate_Left.TabIndex = 7;
            this.Rotate_Left.Text = "Rotate Left";
            this.Rotate_Left.UseVisualStyleBackColor = true;
            this.Rotate_Left.Click += new System.EventHandler(this.Rotate_Left_Click);
            // 
            // Rotate_Right
            // 
            this.Rotate_Right.Location = new System.Drawing.Point(4, 395);
            this.Rotate_Right.Name = "Rotate_Right";
            this.Rotate_Right.Size = new System.Drawing.Size(88, 50);
            this.Rotate_Right.TabIndex = 6;
            this.Rotate_Right.Text = "Rotate Right";
            this.Rotate_Right.UseVisualStyleBackColor = true;
            this.Rotate_Right.Click += new System.EventHandler(this.Rotate_Right_Click);
            // 
            // Vertical_Flip
            // 
            this.Vertical_Flip.Location = new System.Drawing.Point(4, 337);
            this.Vertical_Flip.Name = "Vertical_Flip";
            this.Vertical_Flip.Size = new System.Drawing.Size(88, 52);
            this.Vertical_Flip.TabIndex = 5;
            this.Vertical_Flip.Text = "Vertical Flip";
            this.Vertical_Flip.UseVisualStyleBackColor = true;
            this.Vertical_Flip.Click += new System.EventHandler(this.Vertical_Flip_Click);
            // 
            // Horizontal_Flip
            // 
            this.Horizontal_Flip.Location = new System.Drawing.Point(4, 278);
            this.Horizontal_Flip.Name = "Horizontal_Flip";
            this.Horizontal_Flip.Size = new System.Drawing.Size(88, 53);
            this.Horizontal_Flip.TabIndex = 4;
            this.Horizontal_Flip.Text = "Horizontal Flip";
            this.Horizontal_Flip.UseVisualStyleBackColor = true;
            this.Horizontal_Flip.Click += new System.EventHandler(this.Horizontal_Flip_Click);
            // 
            // negativefilter
            // 
            this.negativefilter.Location = new System.Drawing.Point(4, 220);
            this.negativefilter.Name = "negativefilter";
            this.negativefilter.Size = new System.Drawing.Size(88, 38);
            this.negativefilter.TabIndex = 3;
            this.negativefilter.Text = "Negative";
            this.negativefilter.UseVisualStyleBackColor = true;
            this.negativefilter.Click += new System.EventHandler(this.negativefilter_Click);
            // 
            // sepia_filter
            // 
            this.sepia_filter.Location = new System.Drawing.Point(4, 164);
            this.sepia_filter.Name = "sepia_filter";
            this.sepia_filter.Size = new System.Drawing.Size(88, 40);
            this.sepia_filter.TabIndex = 2;
            this.sepia_filter.Text = "Sepia";
            this.sepia_filter.UseVisualStyleBackColor = true;
            this.sepia_filter.Click += new System.EventHandler(this.sepia_filter_Click);
            // 
            // dark_mode
            // 
            this.dark_mode.Location = new System.Drawing.Point(4, 106);
            this.dark_mode.Name = "dark_mode";
            this.dark_mode.Size = new System.Drawing.Size(88, 42);
            this.dark_mode.TabIndex = 1;
            this.dark_mode.Text = "Dark Mode";
            this.dark_mode.UseVisualStyleBackColor = true;
            this.dark_mode.Click += new System.EventHandler(this.dark_mode_Click);
            // 
            // greyscale
            // 
            this.greyscale.Location = new System.Drawing.Point(4, 45);
            this.greyscale.Name = "greyscale";
            this.greyscale.Size = new System.Drawing.Size(88, 40);
            this.greyscale.TabIndex = 0;
            this.greyscale.Text = "Greyscale";
            this.greyscale.UseVisualStyleBackColor = true;
            this.greyscale.Click += new System.EventHandler(this.greyscale_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.reset);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.remove);
            this.panel2.Controls.Add(this.add);
            this.panel2.Location = new System.Drawing.Point(214, 642);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 62);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(382, 13);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(88, 40);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(266, 13);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(86, 40);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(137, 13);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(86, 40);
            this.remove.TabIndex = 1;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(18, 13);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(79, 40);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(784, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(599, 608);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.reset2);
            this.panel3.Controls.Add(this.save2);
            this.panel3.Controls.Add(this.remove2);
            this.panel3.Controls.Add(this.add2);
            this.panel3.Location = new System.Drawing.Point(865, 642);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 62);
            this.panel3.TabIndex = 4;
            // 
            // reset2
            // 
            this.reset2.Location = new System.Drawing.Point(352, 13);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(87, 40);
            this.reset2.TabIndex = 3;
            this.reset2.Text = "Reset";
            this.reset2.UseVisualStyleBackColor = true;
            this.reset2.Click += new System.EventHandler(this.reset2_Click);
            // 
            // save2
            // 
            this.save2.Location = new System.Drawing.Point(241, 13);
            this.save2.Name = "save2";
            this.save2.Size = new System.Drawing.Size(85, 40);
            this.save2.TabIndex = 2;
            this.save2.Text = "Save";
            this.save2.UseVisualStyleBackColor = true;
            this.save2.Click += new System.EventHandler(this.save2_Click);
            // 
            // remove2
            // 
            this.remove2.Location = new System.Drawing.Point(128, 13);
            this.remove2.Name = "remove2";
            this.remove2.Size = new System.Drawing.Size(85, 40);
            this.remove2.TabIndex = 1;
            this.remove2.Text = "Remove";
            this.remove2.UseVisualStyleBackColor = true;
            this.remove2.Click += new System.EventHandler(this.remove2_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(16, 13);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(82, 40);
            this.add2.TabIndex = 0;
            this.add2.Text = "Add";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Red";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Green";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 43);
            this.label4.TabIndex = 7;
            this.label4.Text = "Blue";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redtrackbar
            // 
            this.redtrackbar.Location = new System.Drawing.Point(215, 19);
            this.redtrackbar.Name = "redtrackbar";
            this.redtrackbar.Size = new System.Drawing.Size(324, 56);
            this.redtrackbar.TabIndex = 8;
            this.redtrackbar.Scroll += new System.EventHandler(this.redtrackbar_Scroll);
            // 
            // greentrackbar
            // 
            this.greentrackbar.Location = new System.Drawing.Point(215, 81);
            this.greentrackbar.Name = "greentrackbar";
            this.greentrackbar.Size = new System.Drawing.Size(324, 56);
            this.greentrackbar.TabIndex = 9;
            this.greentrackbar.Scroll += new System.EventHandler(this.greentrackbar_Scroll);
            // 
            // bluetrackbar
            // 
            this.bluetrackbar.Location = new System.Drawing.Point(210, 143);
            this.bluetrackbar.Name = "bluetrackbar";
            this.bluetrackbar.Size = new System.Drawing.Size(324, 56);
            this.bluetrackbar.TabIndex = 10;
            this.bluetrackbar.Scroll += new System.EventHandler(this.bluetrackbar_Scroll);
            // 
            // redbarvalue
            // 
            this.redbarvalue.Location = new System.Drawing.Point(125, 19);
            this.redbarvalue.Name = "redbarvalue";
            this.redbarvalue.Size = new System.Drawing.Size(69, 56);
            this.redbarvalue.TabIndex = 11;
            this.redbarvalue.Text = "0.0";
            this.redbarvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenbarvalue
            // 
            this.greenbarvalue.Location = new System.Drawing.Point(125, 86);
            this.greenbarvalue.Name = "greenbarvalue";
            this.greenbarvalue.Size = new System.Drawing.Size(69, 41);
            this.greenbarvalue.TabIndex = 12;
            this.greenbarvalue.Text = "0.0";
            this.greenbarvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bluebarvalue
            // 
            this.bluebarvalue.Location = new System.Drawing.Point(119, 143);
            this.bluebarvalue.Name = "bluebarvalue";
            this.bluebarvalue.Size = new System.Drawing.Size(66, 43);
            this.bluebarvalue.TabIndex = 13;
            this.bluebarvalue.Text = "0.0";
            this.bluebarvalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.redtrackbar);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.bluebarvalue);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.greentrackbar);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.greenbarvalue);
            this.panel4.Controls.Add(this.bluetrackbar);
            this.panel4.Controls.Add(this.redbarvalue);
            this.panel4.Location = new System.Drawing.Point(462, 784);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(541, 188);
            this.panel4.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1427, 1055);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.redtrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greentrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluetrackbar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rotate_Left;
        private System.Windows.Forms.Button Rotate_Right;
        private System.Windows.Forms.Button Vertical_Flip;
        private System.Windows.Forms.Button Horizontal_Flip;
        private System.Windows.Forms.Button negativefilter;
        private System.Windows.Forms.Button sepia_filter;
        private System.Windows.Forms.Button dark_mode;
        private System.Windows.Forms.Button greyscale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button reset2;
        private System.Windows.Forms.Button save2;
        private System.Windows.Forms.Button remove2;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar redtrackbar;
        private System.Windows.Forms.TrackBar greentrackbar;
        private System.Windows.Forms.TrackBar bluetrackbar;
        private System.Windows.Forms.Label redbarvalue;
        private System.Windows.Forms.Label greenbarvalue;
        private System.Windows.Forms.Label bluebarvalue;
        private System.Windows.Forms.Panel panel4;
    }
}

