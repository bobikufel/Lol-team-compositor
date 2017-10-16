using System;
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
            //do sprawdzenia info z chamiopn.gg
            Chars.Add(new Champion("Aatrox", LOL_team_compositor.Properties.Resources.Aatrox, true, true, false, false, false));
            Chars.Add(new Champion("Ahri", LOL_team_compositor.Properties.Resources.Ahri, false, false, true, false, false));
            Chars.Add(new Champion("Akali", LOL_team_compositor.Properties.Resources.Akali, true, false, true, false, false));
            Chars.Add(new Champion("Alistar", LOL_team_compositor.Properties.Resources.Alistar, false, false, false, false, true));
            Chars.Add(new Champion("Amumu", LOL_team_compositor.Properties.Resources.Amumu, false, true, false, false, false));
            Chars.Add(new Champion("Anivia", LOL_team_compositor.Properties.Resources.Anivia, false, false, true, false, false));
            Chars.Add(new Champion("Annie", LOL_team_compositor.Properties.Resources.Annie, false, false, true, false, true));
            Chars.Add(new Champion("Ashe", LOL_team_compositor.Properties.Resources.Ashe, false, false, false, true, false));

            Chars.Add(new Champion("Aurelion Sol", LOL_team_compositor.Properties.Resources.AurelionSol, false, true, true, false, false));
            Chars.Add(new Champion("Azir", LOL_team_compositor.Properties.Resources.Azir, false, false, true, false, false));
            Chars.Add(new Champion("Bard", LOL_team_compositor.Properties.Resources.Bard, false, false, false, false, true));
            Chars.Add(new Champion("Blitzcrank", LOL_team_compositor.Properties.Resources.Blitzcrank, false, false, false, false, true));
            Chars.Add(new Champion("Brand", LOL_team_compositor.Properties.Resources.Brand, false, false, true, false, true));
            Chars.Add(new Champion("Braum", LOL_team_compositor.Properties.Resources.Braum, false, false, false, false, true));
            Chars.Add(new Champion("Caitlyn", LOL_team_compositor.Properties.Resources.Caitlyn, false, false, false, true, false));
            Chars.Add(new Champion("Camile", LOL_team_compositor.Properties.Resources.Camille, true, false, false, false, false));

            Chars.Add(new Champion("Cassiopeia", LOL_team_compositor.Properties.Resources.Cassiopeia, false, false, true, false, false));
            Chars.Add(new Champion("Cho'Gath", LOL_team_compositor.Properties.Resources.Chogath, true, true, false, false, false));
            Chars.Add(new Champion("Corki", LOL_team_compositor.Properties.Resources.Corki, false, false, true, false, false));
            Chars.Add(new Champion("Darius", LOL_team_compositor.Properties.Resources.Darius, true, false, false, false, false));
            Chars.Add(new Champion("Diana", LOL_team_compositor.Properties.Resources.Diana, false, true, true, false, false));
            Chars.Add(new Champion("Dr. Mundo", LOL_team_compositor.Properties.Resources.DrMundo, true, true, false, false, false));
            Chars.Add(new Champion("Ekko", LOL_team_compositor.Properties.Resources.Ekko, true, false, true, false, false));

            Chars.Add(new Champion("Elise", LOL_team_compositor.Properties.Resources.Elise, false, true, false, false, false));
            Chars.Add(new Champion("Evelynn", LOL_team_compositor.Properties.Resources.Evelynn, false, true, false, false, false));
            Chars.Add(new Champion("Ezreal", LOL_team_compositor.Properties.Resources.Ezreal, false, true, false, true, false));
            Chars.Add(new Champion("Fiddlesticks", LOL_team_compositor.Properties.Resources.FiddleSticks, false, true, true, false, true));
            Chars.Add(new Champion("Fiora", LOL_team_compositor.Properties.Resources.Fiora, true, false, false, false, false));
            Chars.Add(new Champion("Fizz", LOL_team_compositor.Properties.Resources.Fizz, false, false, true, false, false));
            Chars.Add(new Champion("Galio", LOL_team_compositor.Properties.Resources.Galio, true, false, true, false, false));
            Chars.Add(new Champion("Gangplank", LOL_team_compositor.Properties.Resources.Gangplank, true, false, true, false, false));

            Chars.Add(new Champion("Garen", LOL_team_compositor.Properties.Resources.Garen, true, false, false, false, false));
            Chars.Add(new Champion("Gnar", LOL_team_compositor.Properties.Resources.Gnar, true, false, false, false, false));
            Chars.Add(new Champion("Gragas", LOL_team_compositor.Properties.Resources.Gragas, false, true, false, false, false));
            Chars.Add(new Champion("Graves", LOL_team_compositor.Properties.Resources.Graves, false, true, false, false, false));
            Chars.Add(new Champion("Hecarim", LOL_team_compositor.Properties.Resources.Hecarim, false, true, false, false, false));
            Chars.Add(new Champion("Heimerdinger", LOL_team_compositor.Properties.Resources.Heimerdinger, true, false, true, false, false));
            Chars.Add(new Champion("Illaoi", LOL_team_compositor.Properties.Resources.Illaoi, true, false, false, false, false));
            Chars.Add(new Champion("Irelia", LOL_team_compositor.Properties.Resources.Irelia, true, false, false, false, false));

            Chars.Add(new Champion("Ivern", LOL_team_compositor.Properties.Resources.Ivern, false, true, false, false, false));
            Chars.Add(new Champion("Janna", LOL_team_compositor.Properties.Resources.Janna, false, false, false, false, true));
            Chars.Add(new Champion("Jarvan IV", LOL_team_compositor.Properties.Resources.JarvanIV, true, true, false, false, false));
            Chars.Add(new Champion("Jax", LOL_team_compositor.Properties.Resources.Jax, true, true, false, false, false));
            Chars.Add(new Champion("Jayce", LOL_team_compositor.Properties.Resources.Jayce, true, false, true, false, false));
            Chars.Add(new Champion("Jhin", LOL_team_compositor.Properties.Resources.Jhin, false, false, false, true, false));
            Chars.Add(new Champion("Jinx", LOL_team_compositor.Properties.Resources.Jinx, false, false, false, true, false));
            Chars.Add(new Champion("Kalista", LOL_team_compositor.Properties.Resources.Kalista, false, false, false, true, false));

            Chars.Add(new Champion("Karma", LOL_team_compositor.Properties.Resources.Karma, false, false, true, false, true));
            Chars.Add(new Champion("Karthus", LOL_team_compositor.Properties.Resources.Karthus, true, false, true, false, false));
            Chars.Add(new Champion("Kassadin", LOL_team_compositor.Properties.Resources.Kassadin, false, false, true, false, false));
            Chars.Add(new Champion("Katarina", LOL_team_compositor.Properties.Resources.Katarina, false, false, true, false, false));
            Chars.Add(new Champion("Kayle", LOL_team_compositor.Properties.Resources.Kayle, true, false, true, false, false));
            Chars.Add(new Champion("Kayn", LOL_team_compositor.Properties.Resources.Kayn, false, true, false, false, false));
            Chars.Add(new Champion("Kennen", LOL_team_compositor.Properties.Resources.Kennen, true, false, true, false, false));
            Chars.Add(new Champion("Kha'Zix", LOL_team_compositor.Properties.Resources.Khazix, false, true, false, false, false));

            Chars.Add(new Champion("Kindred", LOL_team_compositor.Properties.Resources.Kindred, false, true, false, false, false));
            Chars.Add(new Champion("Kled", LOL_team_compositor.Properties.Resources.Kled, true, false, false, false, false));
            Chars.Add(new Champion("Kog'Maw", LOL_team_compositor.Properties.Resources.KogMaw, false, false, false, true, false));
            Chars.Add(new Champion("LeBlanc", LOL_team_compositor.Properties.Resources.Leblanc, false, false, true, false, false));
            Chars.Add(new Champion("Lee Sin", LOL_team_compositor.Properties.Resources.LeeSin, false, true, false, false, false));
            Chars.Add(new Champion("Leona", LOL_team_compositor.Properties.Resources.Leona, false, false, false, false, true));
            Chars.Add(new Champion("Lissandra", LOL_team_compositor.Properties.Resources.Lissandra, true, false, true, false, false));
            Chars.Add(new Champion("Lucian", LOL_team_compositor.Properties.Resources.Kalista, false, false, true, true, false));

            Chars.Add(new Champion("Lulu", LOL_team_compositor.Properties.Resources.Lulu, false, false, false, false, true));
            Chars.Add(new Champion("Lux", LOL_team_compositor.Properties.Resources.Lux, false, false, true, false, true));
            Chars.Add(new Champion("Malphite", LOL_team_compositor.Properties.Resources.Malphite, true, false, false, false, false));
            Chars.Add(new Champion("Malzahar", LOL_team_compositor.Properties.Resources.Malzahar, false, false, true, false, false));
            Chars.Add(new Champion("Maokai", LOL_team_compositor.Properties.Resources.Maokai, true, true, false, false, false));
            Chars.Add(new Champion("Master Yi", LOL_team_compositor.Properties.Resources.MasterYi, false, true, false, false, false));
            Chars.Add(new Champion("Miss Fortune", LOL_team_compositor.Properties.Resources.MissFortune, false, false, false, true, false));
            Chars.Add(new Champion("Mordekaiser", LOL_team_compositor.Properties.Resources.Mordekaiser, true, false, false, false, false));

            Chars.Add(new Champion("Morgana", LOL_team_compositor.Properties.Resources.Morgana, false, false, true, false, true));
            Chars.Add(new Champion("Nami", LOL_team_compositor.Properties.Resources.Nami, false, false, false, false, true));
            Chars.Add(new Champion("Nasus", LOL_team_compositor.Properties.Resources.Nasus, true, false, false, false, false));
            Chars.Add(new Champion("Nautilus", LOL_team_compositor.Properties.Resources.Nautilus, true, true, false, false, true));
            Chars.Add(new Champion("Nidalee", LOL_team_compositor.Properties.Resources.Nidalee, false, true, false, false, false));
            Chars.Add(new Champion("Nocturne", LOL_team_compositor.Properties.Resources.Nocturne, false, true, false, false, false));
            Chars.Add(new Champion("Nunu", LOL_team_compositor.Properties.Resources.Nunu, false, true, false, false, false));
            Chars.Add(new Champion("Olaf", LOL_team_compositor.Properties.Resources.Olaf, true, true, false, false, false));

            Chars.Add(new Champion("Orianna", LOL_team_compositor.Properties.Resources.Orianna, false, false, true, false, false));
            Chars.Add(new Champion("Ornn", LOL_team_compositor.Properties.Resources.ornn, true, true, false, false, false));
            Chars.Add(new Champion("Pantheon", LOL_team_compositor.Properties.Resources.Pantheon, true, true, false, false, false));
            Chars.Add(new Champion("Poppy", LOL_team_compositor.Properties.Resources.Poppy, true, true, false, false, false));
            Chars.Add(new Champion("Quinn", LOL_team_compositor.Properties.Resources.Quinn, true, true, false, false, false));
            Chars.Add(new Champion("Rakan", LOL_team_compositor.Properties.Resources.Rakan, false, false, false, false, true));
            Chars.Add(new Champion("Rammus", LOL_team_compositor.Properties.Resources.Rammus, false, true, false, false, false));
            Chars.Add(new Champion("Rek'Sai", LOL_team_compositor.Properties.Resources.RekSai, false, true, false, false, false));

            Chars.Add(new Champion("Renekton", LOL_team_compositor.Properties.Resources.Renekton, true, false, false, false, false));
            Chars.Add(new Champion("Rengar", LOL_team_compositor.Properties.Resources.Rengar, true, true, false, false, false));
            Chars.Add(new Champion("Riven", LOL_team_compositor.Properties.Resources.Riven, true, false, false, false, false));
            Chars.Add(new Champion("Rumble", LOL_team_compositor.Properties.Resources.Rumble, true, true, false, false, false));
            Chars.Add(new Champion("Ryze", LOL_team_compositor.Properties.Resources.Ryze, true, false, true, false, false));
            Chars.Add(new Champion("Sejuani", LOL_team_compositor.Properties.Resources.Sejuani, false, true, false, false, false));
            Chars.Add(new Champion("Shaco", LOL_team_compositor.Properties.Resources.Shaco, false, true, false, false, false));
            Chars.Add(new Champion("Shen", LOL_team_compositor.Properties.Resources.Shen, true, false, false, false, false));

            Chars.Add(new Champion("Shyvana", LOL_team_compositor.Properties.Resources.Renekton, false, true, false, false, false));
            Chars.Add(new Champion("Singed", LOL_team_compositor.Properties.Resources.Singed, true, false, false, false, false));
            Chars.Add(new Champion("Sion", LOL_team_compositor.Properties.Resources.Sion, true, false, false, false, true));
            Chars.Add(new Champion("Sivir", LOL_team_compositor.Properties.Resources.Sivir, false, false, false, true, false));
            Chars.Add(new Champion("Skarner", LOL_team_compositor.Properties.Resources.Skarner, false, true, false, false, false));
            Chars.Add(new Champion("Sona", LOL_team_compositor.Properties.Resources.Sona, false, false, false, false, true));
            Chars.Add(new Champion("Soraka", LOL_team_compositor.Properties.Resources.Soraka, false, false, false, false, true));
            Chars.Add(new Champion("Swain", LOL_team_compositor.Properties.Resources.Swain, true, false, true, false, false));

            Chars.Add(new Champion("Syndra", LOL_team_compositor.Properties.Resources.Syndra, false, false, true, false, false));
            Chars.Add(new Champion("Tham Kench", LOL_team_compositor.Properties.Resources.TahmKench, true, false, false, false, true));
            Chars.Add(new Champion("Taliyah", LOL_team_compositor.Properties.Resources.Taliyah, false, false, true, false, false));
            Chars.Add(new Champion("Talon", LOL_team_compositor.Properties.Resources.Talon, true, false, true, false, false));
            Chars.Add(new Champion("Taric", LOL_team_compositor.Properties.Resources.Taric, false, false, false, false, true));
            Chars.Add(new Champion("Teemo", LOL_team_compositor.Properties.Resources.Teemo, true, false, false, false, false));
            Chars.Add(new Champion("Thresh", LOL_team_compositor.Properties.Resources.Thresh, false, false, false, false, true));
            Chars.Add(new Champion("Tristana", LOL_team_compositor.Properties.Resources.Tristana, false, false, false, true, false));

            Chars.Add(new Champion("Trundle", LOL_team_compositor.Properties.Resources.Trundle, true, true, false, false, false));
            Chars.Add(new Champion("Tryndamere", LOL_team_compositor.Properties.Resources.Tryndamere, true, true, false, false, false));
            Chars.Add(new Champion("Twisted Fate", LOL_team_compositor.Properties.Resources.TwistedFate, false, false, true, false, false));
            Chars.Add(new Champion("Twitch", LOL_team_compositor.Properties.Resources.Twitch, false, true, false, true, false));// dodałem jungle
            Chars.Add(new Champion("Udyr", LOL_team_compositor.Properties.Resources.Udyr, false, true, false, false, false));
            Chars.Add(new Champion("Urgot", LOL_team_compositor.Properties.Resources.Urgot, true, false, false, false, false));
            Chars.Add(new Champion("Varus", LOL_team_compositor.Properties.Resources.Varus, false, false, false, true, false));
            Chars.Add(new Champion("Vayne", LOL_team_compositor.Properties.Resources.Vayne, false, false, false, true, false));

            Chars.Add(new Champion("Veigar", LOL_team_compositor.Properties.Resources.Veigar, false, false, true, false, true));
            Chars.Add(new Champion("Vel'Koz", LOL_team_compositor.Properties.Resources.Velkoz, false, false, true, false, true));
            Chars.Add(new Champion("Vi", LOL_team_compositor.Properties.Resources.Vi, false, true, false, false, false));
            Chars.Add(new Champion("Viktor", LOL_team_compositor.Properties.Resources.Viktor, false, false, true, false, false));
            Chars.Add(new Champion("Vladimir", LOL_team_compositor.Properties.Resources.Vladimir, true, false, true, false, false));
            Chars.Add(new Champion("Volibear", LOL_team_compositor.Properties.Resources.Volibear, true, true, false, false, false));
            Chars.Add(new Champion("Warwick", LOL_team_compositor.Properties.Resources.Warwick, true, false, false, false, false));
            Chars.Add(new Champion("Wukong", LOL_team_compositor.Properties.Resources.Wukong, true, true, false, false, false));
            
            Chars.Add(new Champion("Xayah", LOL_team_compositor.Properties.Resources.Xayah, false, false, false, true, false));
            Chars.Add(new Champion("Xerath", LOL_team_compositor.Properties.Resources.Xerath, false, false, true, false, false));
            Chars.Add(new Champion("Xin Zhao", LOL_team_compositor.Properties.Resources.XinZhao, true, true, false, false, false));
            Chars.Add(new Champion("Yasuo", LOL_team_compositor.Properties.Resources.Yasuo, true, false, true, false, false));
            Chars.Add(new Champion("Yorick", LOL_team_compositor.Properties.Resources.Yorick, true, false, false, false, false));
            Chars.Add(new Champion("Zac", LOL_team_compositor.Properties.Resources.Zac, false, true, false, false, false));
            Chars.Add(new Champion("Zed", LOL_team_compositor.Properties.Resources.Zed, false, false, true, false, false));
            Chars.Add(new Champion("Ziggs", LOL_team_compositor.Properties.Resources.Ziggs, false, false, true, false, false));

            Chars.Add(new Champion("Zilean", LOL_team_compositor.Properties.Resources.Zilean, false, false, false, false, true));
            Chars.Add(new Champion("Zyra", LOL_team_compositor.Properties.Resources.Zyra, false, false, true, false, true));

        }
        
        private void Reroll_Click(object sender, EventArgs e)
        {
            Top_losuj();
            Jng_losuj();
            Mid_losuj();
            Adc_losuj();
            Sup_losuj();
            
        }

        private void Top_Click(object sender, EventArgs e)
        {
            Top_losuj();
        }
        private void Jng_Click(object sender, EventArgs e)
        {
            Jng_losuj();
        }
        private void Mid_Click(object sender, EventArgs e)
        {
            Mid_losuj();
        }
        private void Adc_Click(object sender, EventArgs e)
        {
            Adc_losuj();
        }
        private void Sup_Click(object sender, EventArgs e)
        {
            Sup_losuj();
        }

        private void Top_losuj()
        {

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
        private void Jng_losuj()
        {

            List<Champion> Jungles = new List<Champion>();
            for (int i = 0; i < Chars.Count; i++)
            {
                if (Chars[i].Jungle == true)
                {
                    Jungles.Add(Chars[i]);
                }
            }
            int id = random.Next(0, Jungles.Count);
            Jng.Image = Jungles[id].Img;
        }
        private void Mid_losuj()
        {

            List<Champion> Midlanes = new List<Champion>();
            for (int i = 0; i < Chars.Count; i++)
            {
                if (Chars[i].Midlane == true)
                {
                    Midlanes.Add(Chars[i]);
                }
            }
            int id = random.Next(0, Midlanes.Count);
            Mid.Image = Midlanes[id].Img;
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
        private void Sup_losuj()
        {

            List<Champion> Supports = new List<Champion>();
            for (int i = 0; i < Chars.Count; i++)
            {
                if (Chars[i].Support == true)
                {
                    Supports.Add(Chars[i]);
                }
            }
            int id = random.Next(0, Supports.Count);
            Sup.Image = Supports[id].Img;

        }
        

       
    }
}

