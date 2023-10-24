﻿using System;
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
    public partial class Eco : Form
    {
        Graph graph = new Graph();
        private bool isVisible = true;
        public Eco()
        {
            InitializeComponent();
        
            CheckForIllegalCrossThreadCalls = false;
            Graph graph = new Graph();
            graph.Chart = chart1;
            graph.FirstPrice = 420000;
            graph.ChangePrice = 8400;
            Graph.GraphReset(chart1);

            this.Text = "에코프로비엠 실시간 변동";
            chart1.Legends.Clear();

            timer1.Start();

            label11.Text = (graph.FirstPrice * 1.3).ToString() + ")";
            label12.Text = (graph.FirstPrice * 0.7).ToString() + ")";

            label13.Text += graph.FirstPrice.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            label10.Text = Graph.currentprice.ToString();
            label15.Text = Graph.minValue.ToString();
            label14.Text = Graph.maxValue.ToString();

            if (Graph.currentprice > graph.FirstPrice)
            {
                label10.ForeColor = Color.Red;
            }
            if (Graph.currentprice < graph.FirstPrice)
            {
                label10.ForeColor = Color.Blue;
            }

            pictureBox1.Visible = isVisible;
            isVisible = !isVisible;
        }
    }
}
