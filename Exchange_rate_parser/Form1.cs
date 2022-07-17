using Exchange_rate_parser.Core;
using Exchange_rate_parser.Core.Sber;
using Exchange_rate_parser.Core.Tinkoff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchange_rate_parser
{
    public partial class Form1 : Form
    {
        ParserWorker<string[]> parser;
        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                    new SberParser()
                );
            //parser = new ParserWorker<string[]>(
            // new TinkoffParser()
            //);

            parser.OnCompleted += Exchange_rate_parser_OnCompleted;
            parser.OnNewData += Exchange_rate_parser_OnNewData;
        }

        private void Exchange_rate_parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Items.AddRange(arg2);
        }

        private void Exchange_rate_parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parser.Settings = new SberSettings();
            //parser.Settings = new TinkoffSettings();
            parser.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
