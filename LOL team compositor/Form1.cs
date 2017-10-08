﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOL_team_compositor
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        List<Champion> Chars = new List<Champion>();        
        public Form1()
        {
            InitializeComponent();
            Chars.Add(new Champion(1, "Janna", LOL_team_compositor.Properties.Resources.Janna, true, true, false, true, false));
            Chars.Add(new Champion(2, "Mundo", LOL_team_compositor.Properties.Resources.DrMundo, true, true, false, true, false));
            Chars.Add(new Champion(3, "Yoric", LOL_team_compositor.Properties.Resources.Yorick, true, true, false, false, false));
            Chars.Add(new Champion(4, "Yosue", LOL_team_compositor.Properties.Resources.Yasuo, true, true, false, false, false));
            Chars.Add(new Champion(5, "Smark", LOL_team_compositor.Properties.Resources.Kayle, true, true, false, false, false));
            Chars.Add(new Champion(6, "Jinx", LOL_team_compositor.Properties.Resources.Jinx, false, false, false, true, false));
        }
        
        private void Reroll_Click(object sender, EventArgs e)
        {
            Top_losuj();
            Adc_losuj();
        }

        private void Top_Click(object sender, EventArgs e)
        {
            Top_losuj();
        }

        private void Top_losuj()        {

            List<Champion> Toplaners = new List<Champion>();
            for (int i = 0; i < Chars.Count; i++)
            {
                if (Chars[i].Toplane == true)
                {
                    Toplaners.Add(Chars[i]);
                }
            }
            int id = random.Next(0, Toplaners.Count);
            Top.Image = Toplaners[id].Img;
        }
        private void Adc_losuj()
        {

            List<Champion> Marksmans = new List<Champion>();
            for (int i = 0; i < Chars.Count; i++)
            {
                if (Chars[i].Marksman == true)
                {
                    Marksmans.Add(Chars[i]);
                }
            }
            int id = random.Next(0, Marksmans.Count);
            Adc.Image = Marksmans[id].Img;
        }
    }
}

