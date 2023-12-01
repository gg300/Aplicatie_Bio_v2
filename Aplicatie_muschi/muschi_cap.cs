using System;
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
    public partial class muschi_cap : Form
    {
        private Form1 main = null;
        public muschi_cap(Form callingForm)
        {
            main = callingForm as Form1;
            InitializeComponent();
        }
        private void verif_txt(TextBox tex, Label lab)
        {
            tex.BackColor = Color.Green;
            tex.ForeColor = Color.White;
            tex.ReadOnly = true;
            lab.ForeColor = Color.Green;

        }
        private void er_txt(TextBox tex, Label lab)
        {
            tex.BackColor = Color.Red;
            tex.ForeColor = Color.White;
            tex.ReadOnly = true;
            lab.ForeColor = Color.Red;
        }
        private void ver_mus()
        {
            if (t_buccinator.Text.ToLower() == l_buccinator.Text.ToLower())
            {
                verif_txt(t_buccinator, l_buccinator);
            }
            else
            {
                er_txt(t_buccinator, l_buccinator);
            }
            if (t_coborator_buza_inf.Text.ToLower() == l_coborator_buza_inf.Text.ToLower())
            {
                verif_txt(t_coborator_buza_inf, l_coborator_buza_inf);
            }
            else
            {
                er_txt(t_coborator_buza_inf, l_coborator_buza_inf);
            }
            if (t_coborator_gura.Text.ToLower() == l_coborator_gura.Text.ToLower())
            {
                verif_txt(t_coborator_gura, l_coborator_gura);
            }
            else
            {
                er_txt(t_coborator_gura, l_coborator_gura);
            }
            if (t_corugator_spranceana.Text.ToLower() == l_corugator_spranceana.Text.ToLower())
            {
                verif_txt(t_corugator_spranceana, l_corugator_spranceana);
            }
            else
            {
                er_txt(t_corugator_spranceana, l_corugator_spranceana);
            }
            if (t_masticator.Text.ToLower() == l_masticator.Text.ToLower())
            {
                verif_txt(t_masticator, l_masticator);
            }
            else
            {
                er_txt(t_masticator, l_masticator);
            }
            if (t_mentonier.Text.ToLower() == l_mentonier.Text.ToLower())
            {
                verif_txt(t_mentonier, l_mentonier);
            }
            else
            {
                er_txt(t_mentonier, l_mentonier);
            }
            if (t_nazal.Text.ToLower() == l_nazal.Text.ToLower())
            {
                verif_txt(t_nazal, l_nazal);
            }
            else
            {
                er_txt(t_nazal, l_nazal);
            }
            if (t_occipital.Text.ToLower() == l_occipital.Text.ToLower())
            {
                verif_txt(t_occipital, l_occipital);
            }
            else
            {
                er_txt(t_occipital, l_occipital);
            }
            if (t_orbicular_gura.Text.ToLower() == l_orbicular_gura.Text.ToLower())
            {
                verif_txt(t_orbicular_gura, l_orbicular_gura);
            }
            else
            {
                er_txt(t_orbicular_gura, l_orbicular_gura);
            }
            if (t_orbicular_ochi.Text.ToLower() == l_orbicular_ochi.Text.ToLower())
            {
                verif_txt(t_orbicular_ochi, l_orbicular_ochi);
            }
            else
            {
                er_txt(t_orbicular_ochi, l_orbicular_ochi);
            }
            if (t_platisma.Text.ToLower() == l_platisma.Text.ToLower())
            {
                verif_txt(t_platisma, l_platisma);
            }
            else
            {
                er_txt(t_platisma, l_platisma);
            }
            if (t_procerus.Text.ToLower() == l_procerus.Text.ToLower())
            {
                verif_txt(t_procerus, l_procerus);
            }
            else
            {
                er_txt(t_procerus, l_procerus);
            }
            if (t_ridicator_buza_inferioara.Text.ToLower() == l_ridicator_buza_inferioara.Text.ToLower())
            {
                verif_txt(t_ridicator_buza_inferioara, l_ridicator_buza_inferioara);
            }
            else
            {
                er_txt(t_ridicator_buza_inferioara, l_ridicator_buza_inferioara);
            }
            if (t_ridicator_buza_s.Text.ToLower() == l_ridicator_buza_s.Text.ToLower())
            {
                verif_txt(t_ridicator_buza_s, l_ridicator_buza_s);
            }
            else
            {
                er_txt(t_ridicator_buza_s, l_ridicator_buza_s);
            }
            if (t_ridicator_colt_gur.Text.ToLower() == l_ridicator_colt_gur.Text.ToLower())
            {
                verif_txt(t_ridicator_colt_gur, l_ridicator_colt_gur);
            }
            else
            {
                er_txt(t_ridicator_colt_gur, l_ridicator_colt_gur);
            }
            if (t_rizorius.Text.ToLower() == l_rizorius.Text.ToLower())
            {
                verif_txt(t_rizorius, l_rizorius);
            }
            else
            {
                er_txt(t_rizorius, l_rizorius);
            }
            if (t_temporali.Text.ToLower() == l_temporali.Text.ToLower())
            {
                verif_txt(t_temporali, l_temporali);
            }
            else
            {
                er_txt(t_temporali, l_temporali);
            }
            if (t_zig_mare.Text.ToLower() == l_zig_mare.Text.ToLower())
            {
                verif_txt(t_zig_mare, l_zig_mare);
            }
            else
            {
                er_txt(t_zig_mare, l_zig_mare);
            }
            if (t_zig_mic.Text.ToLower() == l_zig_mic.Text.ToLower())
            {
                verif_txt(t_zig_mic, l_zig_mic);
            }
            else
            {
                er_txt(t_zig_mic, l_zig_mic);
            }
        }
        private void L_hid()
        {
            l_buccinator.Visible = false;
            l_coborator_buza_inf.Visible = false;
            l_coborator_gura.Visible = false;
            l_corugator_spranceana.Visible = false;
            l_masticator.Visible = false;
            l_mentonier.Visible = false;
            l_nazal.Visible = false;
            l_occipital.Visible = false;
            l_orbicular_gura.Visible = false;
            l_orbicular_ochi.Visible = false;
            l_platisma.Visible = false;
            l_procerus.Visible = false;
            l_ridicator_buza_inferioara.Visible = false;
            l_ridicator_buza_s.Visible = false;
            l_ridicator_colt_gur.Visible = false;
            l_rizorius.Visible = false;
            l_temporali.Visible = false;
            l_zig_mare.Visible = false;
            l_zig_mic.Visible = false;
        }
        private void L_Show()
        {
            l_buccinator.Visible = true;
            l_coborator_buza_inf.Visible = true;
            l_coborator_gura.Visible = true;
            l_corugator_spranceana.Visible = true;
            l_masticator.Visible = true;
            l_mentonier.Visible = true;
            l_nazal.Visible = true;
            l_occipital.Visible = true;
            l_orbicular_gura.Visible = true;
            l_orbicular_ochi.Visible = true;
            l_platisma.Visible = true;
            l_procerus.Visible = true;
            l_ridicator_buza_inferioara.Visible = true;
            l_ridicator_buza_s.Visible = true;
            l_ridicator_colt_gur.Visible = true;
            l_rizorius.Visible = true;
            l_temporali.Visible = true;
            l_zig_mare.Visible = true;
            l_zig_mic.Visible = true;
        }
        
        private void muschi_cap_Load(object sender, EventArgs e)
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
