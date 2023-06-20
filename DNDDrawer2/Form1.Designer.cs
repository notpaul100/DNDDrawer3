namespace DNDDrawer2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Paint = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PreviewPen = new System.Windows.Forms.Panel();
            this.Yvalue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Xvalue = new System.Windows.Forms.Label();
            this._PenSize = new System.Windows.Forms.NumericUpDown();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SaveMap = new System.Windows.Forms.SaveFileDialog();
            this.Place = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Brush = new System.Windows.Forms.GroupBox();
            this.BrushSquare = new System.Windows.Forms.RadioButton();
            this.PlaceBrush = new System.Windows.Forms.RadioButton();
            this.Pintbrush = new System.Windows.Forms.RadioButton();
            this.Chest = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.Erase = new System.Windows.Forms.PictureBox();
            this._CaveFloor = new System.Windows.Forms.PictureBox();
            this._CaveWall = new System.Windows.Forms.PictureBox();
            this._Water = new System.Windows.Forms.PictureBox();
            this.WoodFloor = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.Paint.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PenSize)).BeginInit();
            this.Place.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.Brush.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CaveFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CaveWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Water)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WoodFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(153, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 672);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // Paint
            // 
            this.Paint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Paint.Controls.Add(this.flowLayoutPanel1);
            this.Paint.Controls.Add(this.panel2);
            this.Paint.Location = new System.Drawing.Point(12, 207);
            this.Paint.Name = "Paint";
            this.Paint.Size = new System.Drawing.Size(134, 199);
            this.Paint.TabIndex = 9;
            this.Paint.TabStop = false;
            this.Paint.Text = "Paint";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.Erase);
            this.flowLayoutPanel1.Controls.Add(this._CaveFloor);
            this.flowLayoutPanel1.Controls.Add(this._CaveWall);
            this.flowLayoutPanel1.Controls.Add(this._Water);
            this.flowLayoutPanel1.Controls.Add(this.WoodFloor);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox8);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox9);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(129, 174);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(62, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 8);
            this.panel2.TabIndex = 7;
            // 
            // PreviewPen
            // 
            this.PreviewPen.BackColor = System.Drawing.Color.White;
            this.PreviewPen.Location = new System.Drawing.Point(12, 12);
            this.PreviewPen.Name = "PreviewPen";
            this.PreviewPen.Size = new System.Drawing.Size(134, 134);
            this.PreviewPen.TabIndex = 1;
            // 
            // Yvalue
            // 
            this.Yvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Yvalue.AutoSize = true;
            this.Yvalue.Location = new System.Drawing.Point(871, 687);
            this.Yvalue.Name = "Yvalue";
            this.Yvalue.Size = new System.Drawing.Size(35, 13);
            this.Yvalue.TabIndex = 10;
            this.Yvalue.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(848, 687);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Y:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(784, 687);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "X:";
            // 
            // Xvalue
            // 
            this.Xvalue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Xvalue.AutoSize = true;
            this.Xvalue.Location = new System.Drawing.Point(807, 687);
            this.Xvalue.Name = "Xvalue";
            this.Xvalue.Size = new System.Drawing.Size(35, 13);
            this.Xvalue.TabIndex = 13;
            this.Xvalue.Text = "label1";
            // 
            // _PenSize
            // 
            this._PenSize.Location = new System.Drawing.Point(15, 152);
            this._PenSize.Maximum = new decimal(new int[] {
            130,
            0,
            0,
            0});
            this._PenSize.Name = "_PenSize";
            this._PenSize.Size = new System.Drawing.Size(131, 20);
            this._PenSize.TabIndex = 14;
            this._PenSize.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(15, 178);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(65, 23);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(86, 178);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(55, 23);
            this.Save.TabIndex = 15;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Place
            // 
            this.Place.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Place.Controls.Add(this.flowLayoutPanel2);
            this.Place.Controls.Add(this.panel3);
            this.Place.Enabled = false;
            this.Place.Location = new System.Drawing.Point(12, 486);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(134, 199);
            this.Place.TabIndex = 16;
            this.Place.TabStop = false;
            this.Place.Text = "Place";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel2.Controls.Add(this.Chest);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox12);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox13);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox14);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox15);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(129, 174);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(62, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 8);
            this.panel3.TabIndex = 7;
            // 
            // Brush
            // 
            this.Brush.Controls.Add(this.BrushSquare);
            this.Brush.Controls.Add(this.PlaceBrush);
            this.Brush.Controls.Add(this.Pintbrush);
            this.Brush.Location = new System.Drawing.Point(6, 412);
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(135, 68);
            this.Brush.TabIndex = 17;
            this.Brush.TabStop = false;
            this.Brush.Text = "Brush";
            // 
            // BrushSquare
            // 
            this.BrushSquare.AutoSize = true;
            this.BrushSquare.Location = new System.Drawing.Point(6, 42);
            this.BrushSquare.Name = "BrushSquare";
            this.BrushSquare.Size = new System.Drawing.Size(59, 17);
            this.BrushSquare.TabIndex = 2;
            this.BrushSquare.TabStop = true;
            this.BrushSquare.Text = "Square";
            this.BrushSquare.UseVisualStyleBackColor = true;
            this.BrushSquare.CheckedChanged += new System.EventHandler(this.BrushLines_CheckedChanged);
            // 
            // PlaceBrush
            // 
            this.PlaceBrush.AutoSize = true;
            this.PlaceBrush.Location = new System.Drawing.Point(61, 19);
            this.PlaceBrush.Name = "PlaceBrush";
            this.PlaceBrush.Size = new System.Drawing.Size(52, 17);
            this.PlaceBrush.TabIndex = 1;
            this.PlaceBrush.TabStop = true;
            this.PlaceBrush.Text = "Place";
            this.PlaceBrush.UseVisualStyleBackColor = true;
            this.PlaceBrush.CheckedChanged += new System.EventHandler(this.PlaceBrush_CheckedChanged);
            // 
            // Pintbrush
            // 
            this.Pintbrush.AutoSize = true;
            this.Pintbrush.Checked = true;
            this.Pintbrush.Location = new System.Drawing.Point(6, 19);
            this.Pintbrush.Name = "Pintbrush";
            this.Pintbrush.Size = new System.Drawing.Size(49, 17);
            this.Pintbrush.TabIndex = 0;
            this.Pintbrush.TabStop = true;
            this.Pintbrush.Text = "Paint";
            this.Pintbrush.UseVisualStyleBackColor = true;
            this.Pintbrush.CheckedChanged += new System.EventHandler(this.Pintbrush_CheckedChanged);
            // 
            // Chest
            // 
            this.Chest.Image = global::DNDDrawer2.Properties.Resources.Chest;
            this.Chest.Location = new System.Drawing.Point(3, 3);
            this.Chest.Name = "Chest";
            this.Chest.Size = new System.Drawing.Size(37, 35);
            this.Chest.TabIndex = 3;
            this.Chest.TabStop = false;
            this.Chest.Click += new System.EventHandler(this.Chest_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::DNDDrawer2.Properties.Resources.Ladder;
            this.pictureBox12.Location = new System.Drawing.Point(46, 3);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(37, 35);
            this.pictureBox12.TabIndex = 4;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::DNDDrawer2.Properties.Resources.Rock1;
            this.pictureBox13.Location = new System.Drawing.Point(89, 3);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(37, 35);
            this.pictureBox13.TabIndex = 7;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(3, 44);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(37, 35);
            this.pictureBox14.TabIndex = 8;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(46, 44);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(37, 35);
            this.pictureBox15.TabIndex = 9;
            this.pictureBox15.TabStop = false;
            // 
            // Erase
            // 
            this.Erase.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Erase.Location = new System.Drawing.Point(3, 3);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(37, 35);
            this.Erase.TabIndex = 5;
            this.Erase.TabStop = false;
            this.Erase.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // _CaveFloor
            // 
            this._CaveFloor.ErrorImage = global::DNDDrawer2.Properties.Resources.CaveFloor;
            this._CaveFloor.Image = global::DNDDrawer2.Properties.Resources.CaveFloor;
            this._CaveFloor.InitialImage = global::DNDDrawer2.Properties.Resources.CaveFloor;
            this._CaveFloor.Location = new System.Drawing.Point(46, 3);
            this._CaveFloor.Name = "_CaveFloor";
            this._CaveFloor.Size = new System.Drawing.Size(37, 35);
            this._CaveFloor.TabIndex = 0;
            this._CaveFloor.TabStop = false;
            this._CaveFloor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // _CaveWall
            // 
            this._CaveWall.Image = global::DNDDrawer2.Properties.Resources.CaveWall;
            this._CaveWall.Location = new System.Drawing.Point(89, 3);
            this._CaveWall.Name = "_CaveWall";
            this._CaveWall.Size = new System.Drawing.Size(37, 35);
            this._CaveWall.TabIndex = 1;
            this._CaveWall.TabStop = false;
            this._CaveWall.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // _Water
            // 
            this._Water.Image = global::DNDDrawer2.Properties.Resources.Water;
            this._Water.Location = new System.Drawing.Point(3, 44);
            this._Water.Name = "_Water";
            this._Water.Size = new System.Drawing.Size(37, 35);
            this._Water.TabIndex = 6;
            this._Water.TabStop = false;
            this._Water.Click += new System.EventHandler(this._Water_Click);
            // 
            // WoodFloor
            // 
            this.WoodFloor.Image = ((System.Drawing.Image)(resources.GetObject("WoodFloor.Image")));
            this.WoodFloor.Location = new System.Drawing.Point(46, 44);
            this.WoodFloor.Name = "WoodFloor";
            this.WoodFloor.Size = new System.Drawing.Size(37, 35);
            this.WoodFloor.TabIndex = 2;
            this.WoodFloor.TabStop = false;
            this.WoodFloor.Click += new System.EventHandler(this.WoodFloor_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(89, 44);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 35);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(3, 85);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(37, 35);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(46, 85);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(37, 35);
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(89, 85);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(37, 35);
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 721);
            this.Controls.Add(this.Brush);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.Paint);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this._PenSize);
            this.Controls.Add(this.Xvalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yvalue);
            this.Controls.Add(this.PreviewPen);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._PenSize)).EndInit();
            this.Place.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.Brush.ResumeLayout(false);
            this.Brush.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CaveFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CaveWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Water)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WoodFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Paint;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox Erase;
        private System.Windows.Forms.PictureBox _CaveFloor;
        private System.Windows.Forms.PictureBox _CaveWall;
        private System.Windows.Forms.PictureBox _Water;
        private System.Windows.Forms.PictureBox WoodFloor;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PreviewPen;
        private System.Windows.Forms.Label Yvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Xvalue;
        private System.Windows.Forms.NumericUpDown _PenSize;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog SaveMap;
        private System.Windows.Forms.GroupBox Place;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox Chest;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox Brush;
        private System.Windows.Forms.RadioButton BrushSquare;
        private System.Windows.Forms.RadioButton PlaceBrush;
        private System.Windows.Forms.RadioButton Pintbrush;
    }
}

