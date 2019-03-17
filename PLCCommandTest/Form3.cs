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

namespace PLCCommandTest
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            Wisdom.Utils.Driver.HostLink.HostLinkDriver hh = new Wisdom.Utils.Driver.HostLink.HostLinkDriver();
            Wisdom.Utils.Driver.HostLink.HostLinkProtocol hp = new Wisdom.Utils.Driver.HostLink.HostLinkProtocol();
            Wisdom.Utils.Driver.Arg.ComArg com = new ComArg("com1", 9600, System.IO.Ports.Parity.Even, 7, System.IO.Ports.StopBits.Two);
            hh.Connect(com);
            hh.ReadData(Wisdom.Utils.Driver.HostLink.HostLinkDriver.PlcConstant.AreaCio, "", "", "");
        }
    }
}