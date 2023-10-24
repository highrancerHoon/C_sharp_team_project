using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        private SamsungUY fm2; private LGCY fm3; private SDSIY fm4; private HCarY fm5; private EcoY fm6;
        //fm2.Show();

        // string[] str = { "삼성전자우량주", "LG화학", "삼성SDI", "현대차", "에코프로비엠" };

        public Form1()
        {
            InitializeComponent();
            this.Text = "Application";
            listView1.Items.Add(new ListViewItem(new String[] { "삼성전자우량주", "57,400", "1,148", "74,620" ,"40,180"}));
            listView1.Items.Add(new ListViewItem(new String[] { "LG화학", "648,000", "12,960", "842,400","453,600" }));
            listView1.Items.Add(new ListViewItem(new String[] { "삼성SDI", "665,000", "13,300", "864,500","465,500" }));
            listView1.Items.Add(new ListViewItem(new String[] { "현대차", "196,000", "3,920", "254,800","137,200" }));
            listView1.Items.Add(new ListViewItem(new String[] { "에코프로비엠", "420,000", "8,400", "546,000" ,"294,000"}));
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.FocusedItem.Text == "삼성전자우량주")
            {
                fm2 = new SamsungUY();
                fm2.ShowDialog();

            }
            else if (listView1.FocusedItem.Text == "LG화학")
            {
                fm3 = new LGCY();
                fm3.ShowDialog();
            }
            else  if (listView1.FocusedItem.Text == "삼성SDI")
            {
                fm4 = new SDSIY();
                fm4.ShowDialog();
            }
            else if (listView1.FocusedItem.Text == "현대차")
            {
                fm5 = new HCarY();
                fm5.ShowDialog();
            }
            else if (listView1.FocusedItem.Text == "에코프로비엠")
            {
                fm6 = new EcoY();
                fm6.ShowDialog();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < imageList1.Images.Count; i++)
            {
                
                if (i>=imageList1.Images.Count)
                {
                    i = 0;
                }else
                {
                    pictureBox1.Image = imageList1.Images[i];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;// 밀리 초 단위 
            timer1.Start();
        }
    }
}
