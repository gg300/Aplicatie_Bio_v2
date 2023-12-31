﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_muschi
{
    public partial class muschi_gat : Form
    {
        private Form1 main = null;
        public muschi_gat(Form callingForm)
        {
            main = callingForm as Form1;
            InitializeComponent();
        }
        private void verif_txt(TextBox tex)
        {
            tex.BackColor = Color.Green;
            tex.ForeColor = Color.White;
            tex.ReadOnly = true;

        }
        private void er_txt(TextBox tex)
        {
            tex.BackColor = Color.Red;
            tex.ForeColor = Color.White;
            tex.ReadOnly = true;
        }
        private void ver_mus()
        {
            if(t_digast_ant.Text.ToLower() == "digastric anterior" || t_digast_ant.Text.ToLower() == "muschi digastric anterior") {
                verif_txt(t_digast_ant);
                l_digast_ant.ForeColor = Color.Green;
            }
            else
            {
                er_txt(t_digast_ant);
                l_digast_ant.ForeColor = Color.Red;
            }
            if (t_digast_post.Text.ToLower() == "digastric posterior" || t_digast_post.Text.ToLower() == "muschi digastric posterior")
            {
                verif_txt(t_digast_post);
                l_digast_post.ForeColor = Color.Green;
            }
            else
            {
                er_txt(t_digast_post);
                l_digast_post.ForeColor = Color.Red;
            }
            if (t_omohioid_ant.Text.ToLower() == "omohioid anterior" || t_omohioid_ant.Text.ToLower() == "muschi omohioid anterior")
            {
                verif_txt(t_omohioid_ant);
                l_omohioid_ant.ForeColor = Color.Green;
            }
            else
            {
                er_txt(t_omohioid_ant);
                l_omohioid_ant.ForeColor = Color.Red;
            }
            if (t_omohioid_post.Text.ToLower() == "omohioid posterior" || t_omohioid_post.Text.ToLower() == "muschi omohioid posterior")
            {
                verif_txt(t_omohioid_post);
                l_omohioid_post.ForeColor = Color.Green;
            }
            else
            {
                er_txt(t_omohioid_post);
                l_omohioid_post.ForeColor = Color.Red;
            }
            if (t_os_hioid.Text.ToLower() == "osul hioid" || t_os_hioid.Text.ToLower() == "osul lingual" || t_os_hioid.Text.ToLower() == "osul lingual (hioid)" || t_os_hioid.Text.ToLower() == "osul hioid (lingual)" || t_os_hioid.Text.ToLower() == "os hioid" || t_os_hioid.Text.ToLower() == "os lingual" || t_os_hioid.Text.ToLower() == "os lingual (hioid)" || t_os_hioid.Text.ToLower() == "os hioid (lingual)")
            {
                verif_txt(t_os_hioid);
                l_os_hioid.ForeColor = Color.Green;
            }
            else
            {
                er_txt(t_os_hioid);
                l_os_hioid.ForeColor = Color.Red;
            }
            if (t_sterno.Text.ToLower() == l_sterno.Text.ToLower())
            {
                verif_txt(t_sterno);
                l_sterno.ForeColor = Color.Green;
            }
            else
            {
                er_txt(t_sterno);
                l_sterno.ForeColor = Color.Red;
            }
            if (t_trapez.Text.ToLower() == l_trapez.Text.ToLower())
            {
                verif_txt(t_trapez);
                l_trapez.ForeColor = Color.Green;
            }
            else
            {
                er_txt(t_trapez);
                l_trapez.ForeColor = Color.Red;
            }

        }
        private void L_hid()
        {
            l_digast_ant.Visible = false;
            l_digast_post.Visible = false;
            l_omohioid_ant.Visible = false;
            l_omohioid_post.Visible = false;
            l_os_hioid.Visible = false;
            l_sterno.Visible = false;
            l_trapez.Visible = false;
        }
        private void L_Show()
        {
            l_digast_ant.Visible = true;
            l_digast_post.Visible = true;
            l_omohioid_ant.Visible = true;
            l_omohioid_post.Visible = true;
            l_os_hioid.Visible = true;
            l_sterno.Visible = true;
            l_trapez.Visible = true;
        }
        private void muschi_gat_Load(object sender, EventArgs e)
        {

        }

        private void muschi_gat_Load_1(object sender, EventArgs e)
        {
            L_hid();
            b_raspunsuri.Enabled = false;
        }

        private void b_incearca_Click(object sender, EventArgs e)
        {
            ver_mus();
            b_raspunsuri.Enabled = true;
        }

        private void b_raspunsuri_Click(object sender, EventArgs e)
        {
            L_Show();
        }
    }
}
