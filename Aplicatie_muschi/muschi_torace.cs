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
            
            if (t_sterno.Text.ToLower() == l_sterno.Text.ToLower())
            {
                verif_txt(t_sterno, l_sterno);
            }
            else
            {
                er_txt(t_sterno, l_sterno);
            }
            
            if (t_trapez.Text.ToLower() == l_trapez.Text.ToLower())
            {
                verif_txt(t_trapez, l_trapez);
            }
            else
            {
                er_txt(t_trapez, l_trapez);
            }
            
        }
        private void L_hid()
        {
            l_deltoid.Visible = false;
            l_dorsal_mare.Visible = false;
            l_mare_dintat.Visible = false;
            l_pectoral_m.Visible = false;
            l_pectoral_min.Visible = false;
            l_sterno.Visible = false;
            l_trapez.Visible = false;
        }
        private void L_Show()
        {
            l_deltoid.Visible = true;
            l_dorsal_mare.Visible = true;
            l_mare_dintat.Visible = true;
            l_pectoral_m.Visible = true;
            l_pectoral_min.Visible = true;
            l_sterno.Visible = true;
            l_trapez.Visible = true;
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
