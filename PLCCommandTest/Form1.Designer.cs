﻿namespace PLCCommandTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLC地址";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(80, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "生成读命令";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "串口";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(80, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "数据位";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "打开串口";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(496, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "关闭串口";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(183, 183);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(358, 26);
            this.textBox5.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(183, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "生成写命令";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "CIO地址";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(547, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "发送";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 256);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 16);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.Text = "0：停止";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(110, 256);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 16);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "1：启动";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(80, 447);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 24);
            this.comboBox2.TabIndex = 27;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(547, 448);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "发送";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "DM地址";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(183, 519);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "生成写命令";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(183, 446);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(358, 26);
            this.textBox4.TabIndex = 21;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(183, 479);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 23);
            this.button8.TabIndex = 20;
            this.button8.Text = "生成读命令";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(80, 516);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 26);
            this.textBox6.TabIndex = 28;
            this.textBox6.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "写入整数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "读取长度";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.Location = new System.Drawing.Point(80, 477);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 26);
            this.textBox7.TabIndex = 30;
            this.textBox7.Text = "1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(29, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "异或校验";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(107, 101);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 16);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "加*回车";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 34;
            this.label8.Text = "校验位";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(247, 12);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 26);
            this.textBox9.TabIndex = 37;
            this.textBox9.Text = "9600";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 36;
            this.label9.Text = "波特率";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 38;
            this.label10.Text = "停止位";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(80, 11);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 24);
            this.comboBox3.TabIndex = 40;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(247, 44);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 24);
            this.comboBox4.TabIndex = 41;
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(415, 11);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 24);
            this.comboBox5.TabIndex = 42;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(23, 575);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(618, 26);
            this.textBox2.TabIndex = 43;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(554, 546);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 23);
            this.button9.TabIndex = 44;
            this.button9.Text = "生成写命令";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.Location = new System.Drawing.Point(23, 617);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(618, 26);
            this.textBox8.TabIndex = 45;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(400, 368);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 23);
            this.button10.TabIndex = 46;
            this.button10.Text = "配置主电机100距离";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(61, 322);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(480, 21);
            this.textBox10.TabIndex = 47;
            this.textBox10.Text = "@00FA000000000010282006E000001003E842*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 669);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox10;
    }
}

