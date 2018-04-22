namespace course
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
            this.add_node = new System.Windows.Forms.Button();
            this.add_5_node = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_FindKey = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nodeKey_txtBx = new System.Windows.Forms.TextBox();
            this.nodeData_txtBx = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.tvRB = new System.Windows.Forms.TreeView();
            this.lbl_pictureLabel = new System.Windows.Forms.Label();
            this.groupBoxOne = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxData1 = new System.Windows.Forms.TextBox();
            this.textBoxKey1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxMany = new System.Windows.Forms.GroupBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBoxHelp = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxOne.SuspendLayout();
            this.groupBoxMany.SuspendLayout();
            this.groupBoxHelp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // add_node
            // 
            this.add_node.Location = new System.Drawing.Point(43, 593);
            this.add_node.Name = "add_node";
            this.add_node.Size = new System.Drawing.Size(115, 42);
            this.add_node.TabIndex = 0;
            this.add_node.Text = "Добавить вершин";
            this.add_node.UseVisualStyleBackColor = true;
            this.add_node.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_5_node
            // 
            this.add_5_node.Location = new System.Drawing.Point(43, 657);
            this.add_5_node.Name = "add_5_node";
            this.add_5_node.Size = new System.Drawing.Size(115, 42);
            this.add_5_node.TabIndex = 1;
            this.add_5_node.Text = "Добавить 5 вершин";
            this.add_5_node.UseVisualStyleBackColor = true;
            this.add_5_node.Click += new System.EventHandler(this.add_5_node_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(17, 32);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(115, 42);
            this.del.TabIndex = 3;
            this.del.Text = "Удалить";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(17, 96);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(115, 42);
            this.find.TabIndex = 2;
            this.find.Text = "Найти";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(829, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 383);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Clr
            // 
            this.Clr.Location = new System.Drawing.Point(17, 148);
            this.Clr.Name = "Clr";
            this.Clr.Size = new System.Drawing.Size(115, 42);
            this.Clr.TabIndex = 5;
            this.Clr.Text = "Очистить";
            this.Clr.UseVisualStyleBackColor = true;
            this.Clr.Click += new System.EventHandler(this.Clr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 667);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data";
            // 
            // txtBx_FindKey
            // 
            this.txtBx_FindKey.AutoSize = true;
            this.txtBx_FindKey.Location = new System.Drawing.Point(143, 106);
            this.txtBx_FindKey.Name = "txtBx_FindKey";
            this.txtBx_FindKey.Size = new System.Drawing.Size(32, 17);
            this.txtBx_FindKey.TabIndex = 8;
            this.txtBx_FindKey.Text = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Key";
            // 
            // nodeKey_txtBx
            // 
            this.nodeKey_txtBx.Location = new System.Drawing.Point(222, 603);
            this.nodeKey_txtBx.Name = "nodeKey_txtBx";
            this.nodeKey_txtBx.Size = new System.Drawing.Size(100, 22);
            this.nodeKey_txtBx.TabIndex = 10;
            // 
            // nodeData_txtBx
            // 
            this.nodeData_txtBx.Location = new System.Drawing.Point(222, 667);
            this.nodeData_txtBx.Name = "nodeData_txtBx";
            this.nodeData_txtBx.Size = new System.Drawing.Size(100, 22);
            this.nodeData_txtBx.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(196, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 12;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(196, 40);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 22);
            this.txtKey.TabIndex = 13;
            // 
            // tvRB
            // 
            this.tvRB.Location = new System.Drawing.Point(386, 13);
            this.tvRB.Name = "tvRB";
            this.tvRB.Size = new System.Drawing.Size(386, 380);
            this.tvRB.TabIndex = 14;
            // 
            // lbl_pictureLabel
            // 
            this.lbl_pictureLabel.AutoSize = true;
            this.lbl_pictureLabel.Location = new System.Drawing.Point(418, 13);
            this.lbl_pictureLabel.Name = "lbl_pictureLabel";
            this.lbl_pictureLabel.Size = new System.Drawing.Size(0, 17);
            this.lbl_pictureLabel.TabIndex = 15;
            this.lbl_pictureLabel.Visible = false;
            // 
            // groupBoxOne
            // 
            this.groupBoxOne.Controls.Add(this.button1);
            this.groupBoxOne.Controls.Add(this.textBoxData1);
            this.groupBoxOne.Controls.Add(this.textBoxKey1);
            this.groupBoxOne.Controls.Add(this.label5);
            this.groupBoxOne.Controls.Add(this.label3);
            this.groupBoxOne.Enabled = false;
            this.groupBoxOne.Location = new System.Drawing.Point(35, 427);
            this.groupBoxOne.Name = "groupBoxOne";
            this.groupBoxOne.Size = new System.Drawing.Size(323, 141);
            this.groupBoxOne.TabIndex = 18;
            this.groupBoxOne.TabStop = false;
            this.groupBoxOne.Text = "Добавить элемент";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Добавить вершин";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxData1
            // 
            this.textBoxData1.Location = new System.Drawing.Point(204, 82);
            this.textBoxData1.Name = "textBoxData1";
            this.textBoxData1.Size = new System.Drawing.Size(100, 22);
            this.textBoxData1.TabIndex = 24;
            // 
            // textBoxKey1
            // 
            this.textBoxKey1.Location = new System.Drawing.Point(204, 35);
            this.textBoxKey1.Name = "textBoxKey1";
            this.textBoxKey1.Size = new System.Drawing.Size(100, 22);
            this.textBoxKey1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data";
            // 
            // groupBoxMany
            // 
            this.groupBoxMany.Controls.Add(this.textBoxNumber);
            this.groupBoxMany.Controls.Add(this.label8);
            this.groupBoxMany.Controls.Add(this.button2);
            this.groupBoxMany.Enabled = false;
            this.groupBoxMany.Location = new System.Drawing.Point(35, 593);
            this.groupBoxMany.Name = "groupBoxMany";
            this.groupBoxMany.Size = new System.Drawing.Size(323, 141);
            this.groupBoxMany.TabIndex = 19;
            this.groupBoxMany.TabStop = false;
            this.groupBoxMany.Text = "Добавить n элементов";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(98, 35);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumber.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 34);
            this.label8.TabIndex = 29;
            this.label8.Text = "Количество\r\n элементов";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить n вершин";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(188, 21);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Добавить один элемент";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(179, 21);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Добавить n элементов";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBoxHelp
            // 
            this.groupBoxHelp.Controls.Add(this.del);
            this.groupBoxHelp.Controls.Add(this.find);
            this.groupBoxHelp.Controls.Add(this.Clr);
            this.groupBoxHelp.Controls.Add(this.txtBx_FindKey);
            this.groupBoxHelp.Controls.Add(this.label4);
            this.groupBoxHelp.Controls.Add(this.textBox3);
            this.groupBoxHelp.Controls.Add(this.txtKey);
            this.groupBoxHelp.Enabled = false;
            this.groupBoxHelp.Location = new System.Drawing.Point(35, 222);
            this.groupBoxHelp.Name = "groupBoxHelp";
            this.groupBoxHelp.Size = new System.Drawing.Size(323, 199);
            this.groupBoxHelp.TabIndex = 31;
            this.groupBoxHelp.TabStop = false;
            this.groupBoxHelp.Text = "Работа с деревьями";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(35, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 94);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить элемент";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(35, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 94);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор дерева";
            this.groupBox2.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 21);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "RB";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(27, 52);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(49, 21);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "DD";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(35, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 94);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Количество деревьев";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(15, 52);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(37, 21);
            this.radioButton5.TabIndex = 22;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "2";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(78, 52);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(37, 21);
            this.radioButton6.TabIndex = 23;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "4";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(386, 448);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(386, 384);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(829, 448);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(386, 383);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 858);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxHelp);
            this.Controls.Add(this.groupBoxMany);
            this.Controls.Add(this.groupBoxOne);
            this.Controls.Add(this.lbl_pictureLabel);
            this.Controls.Add(this.tvRB);
            this.Controls.Add(this.nodeData_txtBx);
            this.Controls.Add(this.nodeKey_txtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.add_5_node);
            this.Controls.Add(this.add_node);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1288, 1102);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1288, 905);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxOne.ResumeLayout(false);
            this.groupBoxOne.PerformLayout();
            this.groupBoxMany.ResumeLayout(false);
            this.groupBoxMany.PerformLayout();
            this.groupBoxHelp.ResumeLayout(false);
            this.groupBoxHelp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_node;
        private System.Windows.Forms.Button add_5_node;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Clr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtBx_FindKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nodeKey_txtBx;
        private System.Windows.Forms.TextBox nodeData_txtBx;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TreeView tvRB;
        private System.Windows.Forms.Label lbl_pictureLabel;
        private System.Windows.Forms.GroupBox groupBoxOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxData1;
        private System.Windows.Forms.TextBox textBoxKey1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxMany;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBoxHelp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

