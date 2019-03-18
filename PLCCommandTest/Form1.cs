using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace PLCCommandTest
{
    public partial class Form1 : Form
    {
        private SerialPort port = new SerialPort();

        public Form1()
        {
            InitializeComponent();

            List<string> data = new List<string>() { "w10.00", "w11.00", "w11.09", "w11.01", "w11.03", "w11.05", "w11.07", "w11.11", "w11.13", "w12.00", "w12.01", "w12.02", "w12.03", "w12.04", "w12.05", "w12.06", "w20.00", "w20.01", "w20.04", "w20.05" };

            this.comboBox1.DataSource = data;

            List<string> data2 = new List<string>() { "D110", "D112", "D200", "D202" };

            this.comboBox2.DataSource = data2;

            comboBox3.DataSource = SerialPort.GetPortNames();

            foreach (var v in typeof(Parity).GetFields())
            {
                if (v.FieldType.IsEnum == true)
                {
                    this.comboBox4.Items.Add(v.Name);
                }
            }
            comboBox4.SelectedIndex = 2;

            foreach (var v in typeof(StopBits).GetFields())
            {
                if (v.FieldType.IsEnum == true)
                {
                    this.comboBox5.Items.Add(v.Name);
                }
            }
            comboBox5.SelectedIndex = 2;
        }

        /// <summary>
        /// 生成命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var asd = comboBox1.SelectedItem.ToString();
            textBox5.Text = Read(textBox1.Text, asd);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var asd = comboBox1.SelectedItem.ToString();
            textBox5.Text = Write(textBox1.Text, asd, this.radioButton2.Checked);
        }

        public string Read(string plcAddress, string value)
        {
            value = value.Trim().ToLower();
            if (plcAddress.Trim().Length > 2)
                return "";
            string address = plcAddress.Trim().PadLeft(2, '0');
            string rw = "0101";
            //if (!isRead)
            //    rw = "0102";
            string storage = "31";
            if (value[0] == 'w')
                storage = "31";
            value = value.Remove(0, 1);

            string _value = "";
            _value += BitConverter.ToString(tenTo16(int.Parse(value.Split('.')[0]))).Replace("-", "");
            _value += int.Parse(value.Split('.')[1]).ToString("X").PadLeft(2, '0');

            string command = $"@{address}FA000000000{rw}{storage}{_value}0001";

            if (checkBox1.Checked)
            {
                command += XOR(command);
            }

            if (checkBox2.Checked)
            {
                command += "*" + System.Environment.NewLine;
            }

            return command;
        }

        public string Write(string plcAddress, string value, bool mark)
        {
            value = value.Trim().ToLower();
            if (plcAddress.Trim().Length > 2)
                return "";
            string address = plcAddress.Trim().PadLeft(2, '0');
            string rw = "0102";
            string storage = "31";
            if (value[0] == 'w')
                storage = "31";
            value = value.Remove(0, 1);

            string _value = "";
            _value += BitConverter.ToString(tenTo16(int.Parse(value.Split('.')[0]))).Replace("-", "");
            _value += int.Parse(value.Split('.')[1]).ToString("X").PadLeft(2, '0');

            string _mark = mark ? "01" : "00";
            string command = $"@{address}FA000000000{rw}{storage}{_value}0001{_mark}";

            if (checkBox1.Checked)
            {
                command += XOR(command);
            }
            if (checkBox2.Checked)
            {
                command += "*" + System.Environment.NewLine;
            }

            return command;
        }

        public byte[] tenTo16(int str)
        {
            string hex = Convert.ToString(str, 16);
            byte[] hexinfo = new byte[2];
            string[] s = new string[2];
            if (hex.Length == 4)
            {
                s[0] = hex.Substring(0, 2);
                s[1] = hex.Substring(2, 2);
                hexinfo[0] = Convert.ToByte(s[0], 16);
                hexinfo[1] = Convert.ToByte(s[1], 16);
            }
            if (hex.Length == 3)
            {
                s[0] = hex.Substring(0, 1);
                s[1] = hex.Substring(1, 2); hexinfo[0] = Convert.ToByte(s[0], 16);
                hexinfo[1] = Convert.ToByte(s[1], 16);
            }
            if (hex.Length == 2 || hex.Length == 1)
            {
                s[1] = hex;
                hexinfo[0] = 0;
                hexinfo[1] = Convert.ToByte(s[1], 16);
            }
            return hexinfo;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox4.Text = ReadDM(textBox1.Text, comboBox2.SelectedItem.ToString(), textBox7.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox4.Text = WriteDM(textBox1.Text, comboBox2.SelectedItem.ToString(), textBox6.Text);
        }

        public string ReadDM(string plc, string address, string lenght)
        {
            address = address.Trim().ToLower();
            if (plc.Trim().Length > 2)
                return "";
            plc = plc.Trim().PadLeft(2, '0');

            address = address.Remove(0, 1).PadLeft(4, '0');
            string len = BitConverter.ToString(tenTo16(int.Parse(lenght))).Replace("-", "");
            string command = $"@{plc}RD{address}{len}";

            if (checkBox1.Checked)
            {
                command += XOR(command);
            }
            if (checkBox2.Checked)
            {
                command += "*" + System.Environment.NewLine;
            }

            return command;
        }

        public string WriteDM(string plc, string address, string value)
        {
            address = address.Trim().ToLower();
            if (plc.Trim().Length > 2)
                return "";
            plc = plc.Trim().PadLeft(2, '0');

            address = address.Remove(0, 1).PadLeft(4, '0');
            //string len = BitConverter.ToString(tenTo16(int.Parse(lenght))).Replace("-", "");

            string data = BitConverter.ToString(tenTo16(int.Parse(value))).Replace("-", "");

            string command = $"@{plc}WR{address}{data}";
            if (checkBox1.Checked)
            {
                command += XOR(command);
            }
            if (checkBox2.Checked)
            {
                command += "*" + System.Environment.NewLine;
            }
            return command;
        }

        private string XOR(string data)
        {
            // s是待校验数据（字符串）
            //获取s对应的字节数组
            byte[] b = Encoding.ASCII.GetBytes(data);
            // xorResult 存放校验结果。注意：初值去首元素值！
            byte xorResult = b[0];
            // 求xor校验和。注意：XOR运算从第二元素开始
            for (int i = 1; i < b.Length; i++)
            {
                xorResult ^= b[i];
            }
            var result = xorResult.ToString("X");

            return result.PadLeft(2, '0');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.Close();

            port.PortName = comboBox3.SelectedItem.ToString();
            port.BaudRate = int.Parse(textBox9.Text);
            port.DataBits = int.Parse(textBox3.Text);
            port.Parity = (Parity)comboBox4.SelectedIndex;
            port.StopBits = (StopBits)comboBox5.SelectedIndex;

            port.Open();
            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.Close();
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                if (textBox5.Text != "")
                {
                    port.Write(textBox5.Text);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                if (textBox4.Text != "")
                {
                    port.Write(textBox4.Text);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox8.Text = HexStringToASCII(textBox2.Text);
        }

        /// <summary>
        /// 将一条十六进制字符串转换为ASCII
        /// </summary>
        /// <param name="hexstring">一条十六进制字符串</param>
        /// <returns>返回一条ASCII码</returns>
        public static string HexStringToASCII(string hexstring)
        {
            byte[] bt = HexStringToBinary(hexstring);
            string lin = "";
            for (int i = 0; i < bt.Length; i++)
            {
                lin = lin + bt[i] + " ";
            }

            string[] ss = lin.Trim().Split(new char[] { ' ' });
            char[] c = new char[ss.Length];
            int a;
            for (int i = 0; i < c.Length; i++)
            {
                a = Convert.ToInt32(ss[i]);
                c[i] = Convert.ToChar(a);
            }

            string b = new string(c);
            return b;
        }

        /**/

        /// <summary>
        /// 16进制字符串转换为二进制数组
        /// </summary>
        /// <param name="hexstring">用空格切割字符串</param>
        /// <returns>返回一个二进制字符串</returns>
        public static byte[] HexStringToBinary(string hexstring)
        {
            string[] tmpary = hexstring.Trim().Split(' ');
            byte[] buff = new byte[tmpary.Length];
            for (int i = 0; i < buff.Length; i++)
            {
                buff[i] = Convert.ToByte(tmpary[i], 16);
            }
            return buff;
        }
    }
}