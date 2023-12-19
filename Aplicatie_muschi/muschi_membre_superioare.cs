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
    public partial class muschi_membre_superioare : Form
    {
        private Form1 main = null;
        public muschi_membre_superioare(Form callingForm)
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
            if (t_abd_l_pol.Text.ToLower() == l_abd_l_pol.Text.ToLower())
            {
                verif_txt(t_abd_l_pol, l_abd_l_pol);
            }
            else
            {
                er_txt(t_abd_l_pol, l_abd_l_pol);
            }
            if (t_anconeu.Text.ToLower() == l_anconeu.Text.ToLower())
            {
                verif_txt(t_anconeu, l_anconeu);
            }
            else
            {
                er_txt(t_anconeu, l_anconeu);
            }
            if (t_apo_pal.Text.ToLower() == "aponevroza palmara")
            {
                verif_txt(t_apo_pal, l_apo_pal);
            }
            else
            {
                er_txt(t_apo_pal, l_apo_pal);
            }
            
            if (t_brah.Text.ToLower() == l_brah.Text.ToLower())
            {
                verif_txt(t_brah, l_brah);
            }
            else
            {
                er_txt(t_brah, l_brah);
            }
            if (t_brahr.Text.ToLower() == l_brahr.Text.ToLower())
            {
                verif_txt(t_brahr, l_brahr);
            }
            else
            {
                er_txt(t_brahr, l_brahr);
            }
            if (t_brahr_2.Text.ToLower() == l_brahr_2.Text.ToLower())
            {
                verif_txt(t_brahr_2, l_brahr_2);
            }
            else
            {
                er_txt(t_brahr_2, l_brahr_2);
            }
            if (t_coco.Text.ToLower() == "coracobrahial" || t_coco.Text.ToLower() == "muschiul coracobrahial")
            {
                verif_txt(t_coco, l_coco);
            }
            else
            {
                er_txt(t_coco, l_coco);
            }
            if (t_epic.Text.ToLower() == "epicondil" || t_epic.Text.ToLower() == "muschiul epicondil")
            {
                verif_txt(t_epic, l_epic);
            }
            else
            {
                er_txt(t_epic, l_epic);
            }
            if (t_ext_deg_m.Text.ToLower() == l_ext_deg_m.Text.ToLower())
            {
                verif_txt(t_ext_deg_m, l_ext_deg_m);
            }
            else
            {
                er_txt(t_ext_deg_m, l_ext_deg_m);
            }
            if (t_ext_in.Text.ToLower() == l_ext_in.Text.ToLower())
            {
                verif_txt(t_ext_in, l_ext_in);
            }
            else
            {
                er_txt(t_ext_in, l_ext_in);
            }
            if (t_ext_l_deg.Text.ToLower() == l_ext_l_deg.Text.ToLower())
            {
                verif_txt(t_ext_l_deg, l_ext_l_deg);
            }
            else
            {
                er_txt(t_ext_l_deg, l_ext_l_deg);
            }
            if (t_ext_l_r_c.Text.ToLower() == l_ext_l_r_c.Text.ToLower())
            {
                verif_txt(t_ext_l_r_c, l_ext_l_r_c);
            }
            else
            {
                er_txt(t_ext_l_r_c, l_ext_l_r_c);
            }
            if (t_ext_s_p.Text.ToLower() == l_ext_s_p.Text.ToLower())
            {
                verif_txt(t_ext_s_p, l_ext_s_p);
            }
            else
            {
                er_txt(t_ext_s_p, l_ext_s_p);
            }
            if (t_flex_l_p.Text.ToLower() == l_flex_l_p.Text.ToLower())
            {
                verif_txt(t_flex_l_p, l_flex_l_p);
            }
            else
            {
                er_txt(t_flex_l_p, l_flex_l_p);
            }
            if (t_flex_rad_carp.Text.ToLower() == "flexor radial al carpului" || t_flex_rad_carp.Text.ToLower() == "flexorul radial al carpului" || t_flex_rad_carp.Text.ToLower() == "muschiul flexor radial al carpului")
            {
                verif_txt(t_flex_rad_carp, l_flex_rad_carp);
            }
            else
            {
                er_txt(t_flex_rad_carp, l_flex_rad_carp);
            }
            if (t_flex_sup_deg.Text.ToLower() == "flexor superficial al degetelor" || t_flex_sup_deg.Text.ToLower() == "flexorul superficial al degetelor" || t_flex_sup_deg.Text.ToLower() == "muschiul flexor superficial al degetelor")
            {
                verif_txt(t_flex_sup_deg, l_flex_sup_deg);
            }
            else
            {
                er_txt(t_flex_sup_deg, l_flex_sup_deg);
            }
            if (t_flex_u_c.Text.ToLower() == l_flex_u_c.Text.ToLower())
            {
                verif_txt(t_flex_u_c, l_flex_u_c);
            }
            else
            {
                er_txt(t_flex_u_c, l_flex_u_c);
            }
            if (t_pal.Text.ToLower() == "palmar" || t_pal.Text.ToLower() == "muschiul palmar")
            {
                verif_txt(t_pal, l_pal);
            }
            else
            {
                er_txt(t_pal, l_pal);
            }
            if (t_pal_l.Text.ToLower() == l_pal_l.Text.ToLower())
            {
                verif_txt(t_pal_l, l_pal_l);
            }
            else
            {
                er_txt(t_pal_l, l_pal_l);
            }
            if (t_pat_pron.Text.ToLower() == "patrat pronator" || t_pat_pron.Text.ToLower() == "muschiul patrat pronator")
            {
                verif_txt(t_pat_pron, l_pat_pron);
            }
            else
            {
                er_txt(t_pat_pron, l_pat_pron);
            }
            if (t_retc_flex.Text.ToLower() == l_retc_flex.Text.ToLower())
            {
                verif_txt(t_retc_flex, l_retc_flex);
            }
            else
            {
                er_txt(t_retc_flex, l_retc_flex);
            }
            if (t_retin_flex.Text.ToLower() == l_retin_flex.Text.ToLower())
            {
                verif_txt(t_retin_flex, l_retin_flex);
            }
            else
            {
                er_txt(t_retin_flex, l_retin_flex);
            }
            if (t_rotund_pron.Text.ToLower() == "rotund pronator" || t_rotund_pron.Text.ToLower() == "muschiul rotund pronator")
            {
                verif_txt(t_rotund_pron, l_rotund_pron);
            }
            else
            {
                er_txt(t_rotund_pron, l_rotund_pron);
            }
            if (t_s_ext_rad_c.Text.ToLower() == l_s_ext_rad_c.Text.ToLower())
            {
                verif_txt(t_s_ext_rad_c, l_s_ext_rad_c);
            }
            else
            {
                er_txt(t_s_ext_rad_c, l_s_ext_rad_c);
            }
            if (t_triceps.Text.ToLower() == l_triceps.Text.ToLower())
            {
                verif_txt(t_triceps, l_triceps);
            }
            else
            {
                er_txt(t_triceps, l_triceps);
            }
            if (t_triceps_2.Text.ToLower() == l_triceps_2.Text.ToLower())
            {
                verif_txt(t_triceps_2, l_triceps_2);
            }
            else
            {
                er_txt(t_triceps_2, l_triceps_2);
            }
            if (t_biceps.Text.ToLower() == l_biceps.Text.ToLower())
            {
                verif_txt(t_biceps, l_biceps);
            }
            else
            {
                er_txt(t_biceps, l_biceps);
            }

        }
        private void L_hid()
        {
            l_abd_l_pol.Visible = false;
            l_anconeu.Visible = false;
            l_apo_pal.Visible = false;
            l_brah.Visible = false;
            l_brahr.Visible = false;
            l_brahr_2.Visible = false;
            l_coco.Visible = false;
            l_epic.Visible = false;
            l_ext_deg_m.Visible = false;
            l_ext_in.Visible = false;
            l_ext_l_deg.Visible = false;
            l_ext_l_r_c.Visible = false;
            l_ext_s_p.Visible = false;
            l_flex_l_p.Visible = false;
            l_flex_rad_carp.Visible = false;
            l_flex_sup_deg.Visible=false;
            l_flex_u_c.Visible=false;
            l_pal.Visible = false;
            l_pal_l.Visible = false;
            l_pat_pron.Visible = false;
            l_retc_flex.Visible = false;
            l_retin_flex.Visible = false;
            l_rotund_pron.Visible = false;
            l_s_ext_rad_c.Visible = false;
            l_triceps.Visible = false;
            l_triceps_2.Visible = false;
            l_biceps.Visible = false;

        }
        private void L_Show()
        {
            l_abd_l_pol.Visible = true;
            l_anconeu.Visible = true;
            l_apo_pal.Visible = true;

            l_brah.Visible = true;
            l_brahr.Visible = true;
            l_brahr_2.Visible = true;
            l_coco.Visible = true;
            l_epic.Visible = true;
            l_ext_deg_m.Visible = true;
            l_ext_in.Visible = true;
            l_ext_l_deg.Visible = true;
            l_ext_l_r_c.Visible = true;
            l_ext_s_p.Visible = true;
            l_flex_l_p.Visible = true;
            l_flex_rad_carp.Visible = true;
            l_flex_sup_deg.Visible = true;
            l_flex_u_c.Visible = true;
            l_pal.Visible = true;
            l_pal_l.Visible = true;
            l_pat_pron.Visible = true;
            l_retc_flex.Visible = true;
            l_retin_flex.Visible = true;
            l_rotund_pron.Visible = true;
            l_s_ext_rad_c.Visible = true;
            l_triceps.Visible = true;
            l_triceps_2.Visible = true;
            l_biceps.Visible = true;

        }

        private void muschi_membre_superioare_Load_1(object sender, EventArgs e)
        {
            b_raspunsuri.Enabled = false;
            L_hid();
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
