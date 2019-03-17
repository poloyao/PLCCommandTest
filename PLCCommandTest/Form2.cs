using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PLCCommandTest
{
    public partial class Form2 : Form
    {
        private HostLink.PlcCom PLC = new HostLink.PlcCom();
        private SerialPort port = new SerialPort();

        public Form2()
        {
            InitializeComponent();

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

            //List<string> data = new List<string>() { "w10.00", "w11.00", "w11.09", "w11.01", "w11.03", "w11.05", "w11.07", "w11.11", "w11.13", "w12.00", "w12.01", "w12.02", "w12.03", "w12.04", "w12.05", "w12.06", "w20.00", "w20.01", "w20.04", "w20.05" };

            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("w10.00", "w10.00");

            List<MyCommand> data = new List<MyCommand>();
            data.Add(new MyCommand() { Address = "w10.00", Name = "0：停止 1：启动" });
            data.Add(new MyCommand() { Address = "w11.00", Name = "0：找原点动作未完成 1：找原点动作完成" });
            data.Add(new MyCommand() { Address = "w11.09", Name = "0：找原点动作未完成 1：找原点动作完成" });
            data.Add(new MyCommand() { Address = "w11.01", Name = "0:正方向 1：反方向" });
            data.Add(new MyCommand() { Address = "w11.03", Name = "0:正方向 1：反方向" });
            data.Add(new MyCommand() { Address = "w11.05", Name = "0:直线电机不动 1：电机运动" });
            data.Add(new MyCommand() { Address = "w11.07", Name = "0:副电机不动 1：电机运动" });
            data.Add(new MyCommand() { Address = "w11.11", Name = "0:直线电机行走未完成 1：已完成" });
            data.Add(new MyCommand() { Address = "w11.13", Name = "0:副电机行走未完成 1：已完成" });

            this.comboBox1.DataSource = data;
            this.comboBox1.DisplayMember = "Name";

            List<MyCommand> data2 = new List<MyCommand>();
            data2.Add(new MyCommand() { Address = "D110", Name = "直线电机需要行走的距离(整数)" });
            data2.Add(new MyCommand() { Address = "D112", Name = "副电机需要行走的距离(整数)" });
            data2.Add(new MyCommand() { Address = "D200", Name = "直线电机速度设置" });
            data2.Add(new MyCommand() { Address = "D202", Name = "副电机速度设置" });

            this.comboBox2.DataSource = data2;
            this.comboBox2.DisplayMember = "Name";
        }

        public class MyCommand
        {
            public string Address { get; set; }
            public string Name { get; set; }
        }

        private bool EntLink;

        private void button2_Click(object sender, EventArgs e)
        {
            var ComPort = comboBox3.SelectedItem.ToString();
            var ComRate = int.Parse(textBox9.Text);
            var DataBit = int.Parse(textBox3.Text);
            var Parity = (Parity)comboBox4.SelectedIndex;
            var StopBit = (StopBits)comboBox5.SelectedIndex;
            short re = 0;
            re = PLC.ComLink(Convert.ToUInt16(textBox1.Text), Convert.ToUInt16(ComPort.Replace("COM", "")),
                Convert.ToUInt32(ComRate), 7, 2, HostLink.PlcCom.ParityType.Even, 200, "DEMO");
            label5.Text = re.ToString();
            if (re == 0)
            {
                EntLink = true;
                MessageBox.Show("PLC联接成功: ");
            }
            else
            {
                EntLink = false;
                MessageBox.Show("PLC联接失败: ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            short re = 0;
            re = PLC.DeLink();
            label5.Text = re.ToString();
            EntLink = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var value = (comboBox1.SelectedItem as MyCommand).Address;
            value = value.Trim().ToLower();
            value = value.Remove(0, 1);
            var address = int.Parse(value.Split('.')[0]);
            var bit = int.Parse(value.Split('.')[1]);
            bool rd = false;
            var re = PLC.Bit_Test(Convert.ToUInt16(textBox1.Text), HostLink.PlcCom.PlcMemory.CIO,
                Convert.ToUInt16(address), Convert.ToUInt16(bit), ref rd);

            textBox2.Text = System.Convert.ToString(rd);
            label7.Text = re.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (!EntLink)
            //{
            //    MessageBox.Show("还未与PLC建立联接！");
            //    return;
            //}
            var value = (comboBox1.SelectedItem as MyCommand).Address;
            value = value.Trim().ToLower();
            value = value.Remove(0, 1);
            var address = int.Parse(value.Split('.')[0]);
            var bit = int.Parse(value.Split('.')[1]);

            short re;
            if (radioButton2.Checked)
                re = PLC.Bit_Set(Convert.ToUInt16(textBox1.Text), HostLink.PlcCom.PlcMemory.CIO,
                   Convert.ToUInt16(address), Convert.ToUInt16(bit));
            else
                re = PLC.Bit_Reset(Convert.ToUInt16(textBox1.Text), HostLink.PlcCom.PlcMemory.CIO,
               Convert.ToUInt16(address), Convert.ToUInt16(bit));

            label7.Text = re.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var value = (comboBox1.SelectedItem as MyCommand).Address;
            value = value.Trim().ToLower();
            value = value.Remove(0, 1);
            var address = int.Parse(value.Split('.')[0]);

            short i = 0;
            short re = 0;
            string[] temp = null;
            object[] WD = null;
            if (!EntLink)
            {
                MessageBox.Show("还未与PLC建立联接！");
                return;
            }
            WD = new object[1];
            WD[i] = textBox6.Text;
            HostLink.PlcCom.DataType typ = HostLink.PlcCom.DataType.INT16;
            re = PLC.CmdWrite(Convert.ToUInt16(textBox1.Text), HostLink.PlcCom.PlcMemory.DR,
                typ, Convert.ToUInt16(address), Convert.ToUInt16(1), ref WD);

            label11.Text = re.ToString();
        }
    }
}