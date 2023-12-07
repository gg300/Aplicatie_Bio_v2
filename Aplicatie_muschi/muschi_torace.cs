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
    public partial class muschi_torace : Form
    {
        private Form1 main = null;
        public muschi_torace(Form callingForm)
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
            if(t_biceps_b.Text.ToLower() == l_biceps_b.Text.ToLower())
            {
                verif_txt(t_biceps_b, l_biceps_b);
            }
            else
            {
                er_txt(t_biceps_b, l_biceps_b);
            }
            if (t_coaste.Text.ToLower() == l_coaste.Text.ToLower())
            {
                verif_txt(t_coaste, l_coaste);
            }
            else
            {
                er_txt(t_coaste, l_coaste);
            }
            if (t_cocob.Text.ToLower() == "coracobrahial" || t_cocob.Text.ToLower() == "muschi coracobrahial")
            {
                verif_txt(t_cocob, l_cocob);
            }
            else
            {
                er_txt(t_cocob, l_cocob);
            }
            if (t_deltoid.Text.ToLower() == l_deltoid.Text.ToLower())
            {
                verif_txt(t_deltoid, l_deltoid);
            }
            else
            {
                er_txt(t_deltoid, l_deltoid);
            }
            if (t_dorsal_mare.Text.ToLower() == "dorsalul mare" || t_dorsal_mare.Text.ToLower() == "dorsal mare")
            {
                verif_txt(t_dorsal_mare, l_dorsal_mare);
            }
            else
            {
                er_txt(t_dorsal_mare, l_dorsal_mare);
            }
            if (t_ext_ab.Text.ToLower() == "extensor abdominal oblic" || t_ext_ab.Text.ToLower() == "extensori abdominali oblici")
            {
                verif_txt(t_ext_ab, l_ext_ab);
            }
            else
            {
                er_txt(t_ext_ab, l_ext_ab);
            }
            if (t_mare_dintat.Text.ToLower() == "marele dintat" || t_mare_dintat.Text.ToLower() == "muschiul marele dintat")
            {
                verif_txt(t_mare_dintat, l_mare_dintat);
            }
            else
            {
                er_txt(t_mare_dintat, l_mare_dintat);
            }
            if (t_pectoral_m.Text.ToLower() == "pectoralul major" || t_pectoral_m.Text.ToLower() == "pectoral major" || t_pectoral_m.Text.ToLower() == "muschiul pectoral major")
            {
                verif_txt(t_pectoral_m, l_pectoral_m);
            }
            else
            {
                er_txt(t_pectoral_m, l_pectoral_m);
            }
            if (t_pectoral_m.Text.ToLower() == "pectoralul minor" || t_pectoral_m.Text.ToLower() == "oblici externi" || t_pectoral_m.Text.ToLower() == "pectoralul minor" || t_pectoral_m.Text.ToLower() == "pectoral minor" || t_pectoral_m.Text.ToLower() == "muschiul pectoral major")
            {
                verif_txt(t_pectoral_min, l_pectoral_min);
            }
            else
            {
                er_txt(t_pectoral_min, l_pectoral_min);
            }
            if (t_rotund_mic.Text.ToLower() == l_rotund_mic.Text.ToLower())
            {
                verif_txt(t_rotund_mic, l_rotund_mic);
            }
            else
            {
                er_txt(t_rotund_mic, l_rotund_mic);
            }
            if (t_sterno.Text.ToLower() == l_sterno.Text.ToLower())
            {
                verif_txt(t_sterno, l_sterno);
            }
            else
            {
                er_txt(t_sterno, l_sterno);
            }
            if (t_strat_teaca.Text.ToLower() == l_strat_teaca.Text.ToLower())
            {
                verif_txt(t_strat_teaca, l_strat_teaca);
            }
            else
            {
                er_txt(t_strat_teaca, l_strat_teaca);
            }
            if (t_subscap.Text.ToLower() == "subscapular" || t_subscap.Text.ToLower() == "muschi subscapular")
            {
                verif_txt(t_subscap, l_subscap);
            }
            else
            {
                er_txt(t_subscap, l_subscap);
            }
            if (t_trapez.Text.ToLower() == l_trapez.Text.ToLower())
            {
                verif_txt(t_trapez, l_trapez);
            }
            else
            {
                er_txt(t_trapez, l_trapez);
            }
            if (t_t_sup.Text.ToLower() == l_t_sup.Text.ToLower())
            {
                verif_txt(t_t_sup, l_t_sup);
            }
            else
            {
                er_txt(t_t_sup, l_t_sup);
            }
        }
        private void L_hid()
        {
            l_biceps_b.Visible = false;
            l_coaste.Visible = false;
            l_cocob.Visible = false;
            l_deltoid.Visible = false;
            l_dorsal_mare.Visible = false;
            l_ext_ab.Visible = false;
            l_mare_dintat.Visible = false;
            l_pectoral_m.Visible = false;
            l_pectoral_min.Visible = false;
            l_rotund_mic.Visible = false;
            l_sterno.Visible = false;
            l_strat_teaca.Visible = false;
            l_subscap.Visible = false;
            l_trapez.Visible = false;
            l_t_sup.Visible = false;
        }
        private void L_Show()
        {
            l_biceps_b.Visible = true;
            l_coaste.Visible = true;
            l_cocob.Visible = true;
            l_deltoid.Visible = true;
            l_dorsal_mare.Visible = true;
            l_ext_ab.Visible = true;
            l_mare_dintat.Visible = true;
            l_pectoral_m.Visible = true;
            l_pectoral_min.Visible = true;
            l_rotund_mic.Visible = true;
            l_sterno.Visible = true;
            l_strat_teaca.Visible = true;
            l_subscap.Visible = true;
            l_trapez.Visible = true;
            l_t_sup.Visible = true;
        }
        private void muschi_torace_Load(object sender, EventArgs e)
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
