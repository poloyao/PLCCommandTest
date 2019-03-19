using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wisdom.Utils.Driver;
using Wisdom.Utils.Driver.Arg;
using System.IO.Ports;
using Wisdom.Utils.Driver.HostLink;

namespace PLCCommandTest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            Wisdom.Utils.Driver.HostLink.HostLinkDriver hh = new Wisdom.Utils.Driver.HostLink.HostLinkDriver();
            Wisdom.Utils.Driver.HostLink.HostLinkProtocol hp = new Wisdom.Utils.Driver.HostLink.HostLinkProtocol();
            Wisdom.Utils.Driver.Arg.ComArg com = new ComArg("com10", 9600, System.IO.Ports.Parity.Even, 7, System.IO.Ports.StopBits.Two);
            //hh.Connect(com);
            //var data = hh.WriteData(Wisdom.Utils.Driver.HostLink.HostLinkDriver.PlcConstant.AreaCio, 10, 0, "1");

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
            comboBox3.DataSource = SerialPort.GetPortNames();

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

        private HostLinkDriver hd = new HostLinkDriver();
        private bool EntLink;

        private void button2_Click(object sender, EventArgs e)
        {
            ComArg com = new ComArg(comboBox3.SelectedItem.ToString(), int.Parse(textBox9.Text), (Parity)(comboBox4.SelectedIndex), int.Parse(textBox3.Text), (StopBits)comboBox5.SelectedIndex);
            hd.Connect(com);
            if (hd.Connected)
            {
                MessageBox.Show("连接正常");
                button2.Enabled = false;
                button3.Enabled = true;
                EntLink = true;
            }
            else
            {
                MessageBox.Show("连接失败");
                button2.Enabled = true;
                button3.Enabled = false;
                EntLink = false;
            }
        }

        public class MyCommand
        {
            public string Address { get; set; }
            public string Name { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!EntLink)
            {
                MessageBox.Show("还未与PLC建立联接！");
                return;
            }
            var value = (comboBox1.SelectedItem as MyCommand).Address;
            value = value.Trim().ToLower();
            value = value.Remove(0, 1);
            var address = int.Parse(value.Split('.')[0]);
            var bit = int.Parse(value.Split('.')[1]);

            var data = radioButton2.Checked ? "1" : "0";
            var data1 = int.Parse(data).ToString("X").Replace("-", "").PadLeft(2, '0');

            var response = hd.WriteData(HostLinkDriver.PlcConstant.AreaCio, address, bit, data1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!EntLink)
            {
                MessageBox.Show("还未与PLC建立联接！");
                return;
            }
            var value = (comboBox2.SelectedItem as MyCommand).Address;
            value = value.Trim().ToLower();
            value = value.Remove(0, 1);
            var address = int.Parse(value.Split('.')[0]);
            var data = int.Parse(textBox6.Text).ToString("X").Replace("-", "");
            var response = hd.WriteData(HostLinkDriver.PlcConstant.AreaDm, address, 0, data);
            //var response = hd.ReadData(HostLinkDriver.PlcConstant.AreaDm, address, 0, "1");
        }
    }
}