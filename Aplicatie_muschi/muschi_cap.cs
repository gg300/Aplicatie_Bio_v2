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

            if (t_masticator.Text.ToLower() == "maseter".ToLower() || t_masticator.Text.ToLower() == "masticator".ToLower() || t_masticator.Text.ToLower() == "masticator (maseter)".ToLower())
            {
                verif_txt(t_masticator, l_masticator);
            }

            else
            {
                er_txt(t_masticator, l_masticator);
            }
            if (t_front.Text.ToLower() == l_front.Text.ToLower())
            {
                verif_txt(t_front, l_front);
            }
            else
            {
                er_txt(t_front, l_front);
            }
            if (t_nazal.Text.ToLower() == l_nazal.Text.ToLower())
            {
                verif_txt(t_nazal, l_nazal);
            }
            else
            {
                er_txt(t_nazal, l_nazal);
            }
            if (t_orbicular_ochi.Text.ToLower() == l_orbicular_ochi.Text.ToLower())
            {
                verif_txt(t_orbicular_ochi, l_orbicular_ochi);
            }
            else
            {
                er_txt(t_orbicular_ochi, l_orbicular_ochi);
            }
            if (t_platisma.Text.ToLower() == "platisma (pielosul gatului)".ToLower() || t_platisma.Text.ToLower() == "platisma".ToLower() || t_platisma.Text.ToLower() == "pielosul gatului".ToLower())
            {
                verif_txt(t_platisma, l_platisma);
            }
            else
            {
                er_txt(t_platisma, l_platisma);
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

            l_masticator.Visible = false;
            l_nazal.Visible = false;
            l_front.Visible = false;
             
            l_orbicular_ochi.Visible = false;
            l_platisma.Visible = false;

            l_temporali.Visible = false;
            l_zig_mare.Visible = false;
            l_zig_mic.Visible = false;
        }
        private void L_Show()
        {

            l_masticator.Visible = true;
            l_nazal.Visible = true;
            l_front.Visible = true;

            l_orbicular_ochi.Visible = true;
            l_platisma.Visible = true;

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
