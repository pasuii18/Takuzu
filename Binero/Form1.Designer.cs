using System.Drawing;

namespace Takuzu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label11 = new System.Windows.Forms.Label();
            this.ListBoxNumber = new System.Windows.Forms.ListBox();
            this.Solution = new System.Windows.Forms.Button();
            this.GameField = new System.Windows.Forms.Panel();
            this.Selection = new System.Windows.Forms.GroupBox();
            this.Grid14 = new System.Windows.Forms.CheckBox();
            this.Grid12 = new System.Windows.Forms.CheckBox();
            this.Grid10 = new System.Windows.Forms.CheckBox();
            this.Grid8 = new System.Windows.Forms.CheckBox();
            this.Grid6 = new System.Windows.Forms.CheckBox();
            this.Grid4 = new System.Windows.Forms.CheckBox();
            this.BackGround = new System.ComponentModel.BackgroundWorker();
            this.StepBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox6 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.PictureBox7 = new System.Windows.Forms.PictureBox();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.PictureBox8 = new System.Windows.Forms.PictureBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox8)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Pink;
            this.Label11.Location = new System.Drawing.Point(16, 839);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(530, 13);
            this.Label11.TabIndex = 47;
            this.Label11.Text = "Errors in rows or columns are only visible if the row or column is completely fil" +
    "led with 0 or 1.";
            // 
            // ListBoxNumber
            // 
            this.ListBoxNumber.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ListBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxNumber.FormattingEnabled = true;
            this.ListBoxNumber.ItemHeight = 20;
            this.ListBoxNumber.Items.AddRange(new object[] {
            "0",
            "1"});
            this.ListBoxNumber.Location = new System.Drawing.Point(1119, 686);
            this.ListBoxNumber.Name = "ListBoxNumber";
            this.ListBoxNumber.Size = new System.Drawing.Size(21, 44);
            this.ListBoxNumber.TabIndex = 35;
            this.ListBoxNumber.Click += new System.EventHandler(this.ListBoxNumber_Click);
            // 
            // Solution
            // 
            this.Solution.BackColor = System.Drawing.Color.Pink;
            this.Solution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Solution.FlatAppearance.BorderSize = 0;
            this.Solution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.Solution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.Solution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Solution.Font = new System.Drawing.Font("lazer84", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solution.ForeColor = System.Drawing.Color.BlueViolet;
            this.Solution.Image = ((System.Drawing.Image)(resources.GetObject("Solution.Image")));
            this.Solution.Location = new System.Drawing.Point(897, 796);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(224, 36);
            this.Solution.TabIndex = 34;
            this.Solution.Text = "Solution";
            this.Solution.UseVisualStyleBackColor = false;
            this.Solution.Click += new System.EventHandler(this.Solution_Click);
            // 
            // GameField
            // 
            this.GameField.BackColor = System.Drawing.Color.HotPink;
            this.GameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameField.Location = new System.Drawing.Point(18, 119);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(482, 425);
            this.GameField.TabIndex = 33;
            this.GameField.Visible = false;
            // 
            // Selection
            // 
            this.Selection.BackColor = System.Drawing.Color.Transparent;
            this.Selection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Selection.BackgroundImage")));
            this.Selection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Selection.Controls.Add(this.Grid14);
            this.Selection.Controls.Add(this.Grid12);
            this.Selection.Controls.Add(this.Grid10);
            this.Selection.Controls.Add(this.Grid8);
            this.Selection.Controls.Add(this.Grid6);
            this.Selection.Controls.Add(this.Grid4);
            this.Selection.Font = new System.Drawing.Font("lazer84", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selection.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Selection.Location = new System.Drawing.Point(938, 7);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(149, 155);
            this.Selection.TabIndex = 32;
            this.Selection.TabStop = false;
            this.Selection.Text = "Select size";
            // 
            // Grid14
            // 
            this.Grid14.AutoSize = true;
            this.Grid14.Font = new System.Drawing.Font("lazer84", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid14.ForeColor = System.Drawing.Color.BlueViolet;
            this.Grid14.Location = new System.Drawing.Point(6, 135);
            this.Grid14.Name = "Grid14";
            this.Grid14.Size = new System.Drawing.Size(99, 19);
            this.Grid14.TabIndex = 5;
            this.Grid14.Text = "Grid 14 x 14";
            this.Grid14.UseVisualStyleBackColor = true;
            this.Grid14.Click += new System.EventHandler(this.Grid4_Click);
            // 
            // Grid12
            // 
            this.Grid12.AutoSize = true;
            this.Grid12.Font = new System.Drawing.Font("lazer84", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid12.ForeColor = System.Drawing.Color.BlueViolet;
            this.Grid12.Location = new System.Drawing.Point(6, 112);
            this.Grid12.Name = "Grid12";
            this.Grid12.Size = new System.Drawing.Size(99, 19);
            this.Grid12.TabIndex = 4;
            this.Grid12.Text = "Grid 12 x 12";
            this.Grid12.UseVisualStyleBackColor = true;
            this.Grid12.Click += new System.EventHandler(this.Grid4_Click);
            // 
            // Grid10
            // 
            this.Grid10.AutoSize = true;
            this.Grid10.Font = new System.Drawing.Font("lazer84", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid10.ForeColor = System.Drawing.Color.BlueViolet;
            this.Grid10.Location = new System.Drawing.Point(6, 88);
            this.Grid10.Name = "Grid10";
            this.Grid10.Size = new System.Drawing.Size(99, 19);
            this.Grid10.TabIndex = 3;
            this.Grid10.Text = "Grid 10 x 10";
            this.Grid10.UseVisualStyleBackColor = true;
            this.Grid10.Click += new System.EventHandler(this.Grid4_Click);
            // 
            // Grid8
            // 
            this.Grid8.AutoSize = true;
            this.Grid8.Font = new System.Drawing.Font("lazer84", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid8.ForeColor = System.Drawing.Color.BlueViolet;
            this.Grid8.Location = new System.Drawing.Point(6, 65);
            this.Grid8.Name = "Grid8";
            this.Grid8.Size = new System.Drawing.Size(87, 19);
            this.Grid8.TabIndex = 2;
            this.Grid8.Text = "Grid 8 x 8";
            this.Grid8.UseVisualStyleBackColor = true;
            this.Grid8.Click += new System.EventHandler(this.Grid4_Click);
            // 
            // Grid6
            // 
            this.Grid6.AutoSize = true;
            this.Grid6.Font = new System.Drawing.Font("lazer84", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid6.ForeColor = System.Drawing.Color.BlueViolet;
            this.Grid6.Location = new System.Drawing.Point(6, 42);
            this.Grid6.Name = "Grid6";
            this.Grid6.Size = new System.Drawing.Size(87, 19);
            this.Grid6.TabIndex = 1;
            this.Grid6.Text = "Grid 6 x 6";
            this.Grid6.UseVisualStyleBackColor = true;
            this.Grid6.Click += new System.EventHandler(this.Grid4_Click);
            // 
            // Grid4
            // 
            this.Grid4.AutoSize = true;
            this.Grid4.Font = new System.Drawing.Font("lazer84", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid4.ForeColor = System.Drawing.Color.BlueViolet;
            this.Grid4.Location = new System.Drawing.Point(6, 19);
            this.Grid4.Name = "Grid4";
            this.Grid4.Size = new System.Drawing.Size(87, 19);
            this.Grid4.TabIndex = 0;
            this.Grid4.Text = "Grid 4 x 4";
            this.Grid4.UseVisualStyleBackColor = true;
            this.Grid4.Click += new System.EventHandler(this.Grid4_Click);
            // 
            // BackGround
            // 
            this.BackGround.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackGround_DoWork);
            this.BackGround.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackGround_RunWorkerCompleted);
            // 
            // StepBack
            // 
            this.StepBack.BackColor = System.Drawing.Color.Pink;
            this.StepBack.FlatAppearance.BorderSize = 0;
            this.StepBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StepBack.Font = new System.Drawing.Font("lazer84", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepBack.ForeColor = System.Drawing.Color.BlueViolet;
            this.StepBack.Image = ((System.Drawing.Image)(resources.GetObject("StepBack.Image")));
            this.StepBack.Location = new System.Drawing.Point(944, 686);
            this.StepBack.Name = "StepBack";
            this.StepBack.Size = new System.Drawing.Size(136, 44);
            this.StepBack.TabIndex = 50;
            this.StepBack.Text = "Step  back";
            this.StepBack.UseVisualStyleBackColor = false;
            this.StepBack.Visible = false;
            this.StepBack.Click += new System.EventHandler(this.StepBack_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 118550;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.Font = new System.Drawing.Font("lazer84", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.Label5.Image = ((System.Drawing.Image)(resources.GetObject("Label5.Image")));
            this.Label5.Location = new System.Drawing.Point(34, 352);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(184, 64);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "5. Rows  or  columns  should  not  be  duplicated  in  the  grid";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.LemonChiffon;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Font = new System.Drawing.Font("lazer84", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.Label4.Image = ((System.Drawing.Image)(resources.GetObject("Label4.Image")));
            this.Label4.Location = new System.Drawing.Point(34, 273);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(184, 64);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "4. Rows  and  columns  must  contain  the  same  number  of  digits  \"0\"  and  di" +
    "gits  \"1\"";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Font = new System.Drawing.Font("lazer84", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.Label3.Image = ((System.Drawing.Image)(resources.GetObject("Label3.Image")));
            this.Label3.Location = new System.Drawing.Point(34, 194);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(184, 64);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "3. Rows  and  columns  should  not  contain  3  or  more  identical  consecutive " +
    " numbers";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox6
            // 
            this.PictureBox6.BackColor = System.Drawing.Color.Orange;
            this.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox6.Location = new System.Drawing.Point(8, 219);
            this.PictureBox6.Name = "PictureBox6";
            this.PictureBox6.Size = new System.Drawing.Size(20, 20);
            this.PictureBox6.TabIndex = 29;
            this.PictureBox6.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Aqua;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Location = new System.Drawing.Point(8, 138);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.PictureBox1.TabIndex = 37;
            this.PictureBox1.TabStop = false;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.LemonChiffon;
            this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label6.Font = new System.Drawing.Font("lazer84", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.Label6.Image = ((System.Drawing.Image)(resources.GetObject("Label6.Image")));
            this.Label6.Location = new System.Drawing.Point(34, 115);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(184, 64);
            this.Label6.TabIndex = 38;
            this.Label6.Text = "2. Incomplete  row  or  column";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox7
            // 
            this.PictureBox7.BackColor = System.Drawing.Color.DarkViolet;
            this.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox7.Location = new System.Drawing.Point(8, 295);
            this.PictureBox7.Name = "PictureBox7";
            this.PictureBox7.Size = new System.Drawing.Size(20, 20);
            this.PictureBox7.TabIndex = 29;
            this.PictureBox7.TabStop = false;
            // 
            // PictureBox5
            // 
            this.PictureBox5.BackColor = System.Drawing.Color.Lime;
            this.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox5.Location = new System.Drawing.Point(8, 58);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(20, 20);
            this.PictureBox5.TabIndex = 45;
            this.PictureBox5.TabStop = false;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.LemonChiffon;
            this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label10.Font = new System.Drawing.Font("lazer84", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.BlueViolet;
            this.Label10.Image = ((System.Drawing.Image)(resources.GetObject("Label10.Image")));
            this.Label10.Location = new System.Drawing.Point(34, 36);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(184, 64);
            this.Label10.TabIndex = 46;
            this.Label10.Text = "1. Correct  and  complete  row  or  column";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox8
            // 
            this.PictureBox8.BackColor = System.Drawing.Color.Violet;
            this.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox8.Location = new System.Drawing.Point(8, 374);
            this.PictureBox8.Name = "PictureBox8";
            this.PictureBox8.Size = new System.Drawing.Size(20, 20);
            this.PictureBox8.TabIndex = 29;
            this.PictureBox8.TabStop = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GroupBox1.BackgroundImage")));
            this.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroupBox1.Controls.Add(this.PictureBox8);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.PictureBox5);
            this.GroupBox1.Controls.Add(this.PictureBox7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.PictureBox6);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox1.Font = new System.Drawing.Font("lazer84", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.GroupBox1.Location = new System.Drawing.Point(897, 211);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(224, 428);
            this.GroupBox1.TabIndex = 36;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Rules  of  the  game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 862);
            this.Controls.Add(this.StepBack);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ListBoxNumber);
            this.Controls.Add(this.Solution);
            this.Controls.Add(this.GameField);
            this.Controls.Add(this.Selection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takuzu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Selection.ResumeLayout(false);
            this.Selection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox8)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.ListBox ListBoxNumber;
        internal System.Windows.Forms.Button Solution;
        internal System.Windows.Forms.Panel GameField;
        internal System.Windows.Forms.GroupBox Selection;
        internal System.Windows.Forms.CheckBox Grid14;
        internal System.Windows.Forms.CheckBox Grid12;
        internal System.Windows.Forms.CheckBox Grid10;
        internal System.Windows.Forms.CheckBox Grid8;
        internal System.Windows.Forms.CheckBox Grid6;
        internal System.Windows.Forms.CheckBox Grid4;
        private System.ComponentModel.BackgroundWorker BackGround;
        internal System.Windows.Forms.Button StepBack;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.PictureBox PictureBox6;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.PictureBox PictureBox7;
        internal System.Windows.Forms.PictureBox PictureBox5;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.PictureBox PictureBox8;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}

