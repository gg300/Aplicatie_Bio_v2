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
    public partial class muschi_ceafa_spate : Form
    {
        private Form1 main = null;
        public muschi_ceafa_spate(Form callingForm)
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
        private void L_hid()
        {
            l_deltoid.Visible = false;
            l_dorsal_mare.Visible = false;
            l_infraspinos.Visible = false;  
            l_rid_scap.Visible = false;
            l_romb_mare.Visible = false;
            l_romb_mic.Visible = false;
            l_rotund_mare.Visible = false;
            l_rotund_mic.Visible = false;
            l_sterno.Visible = false;
            l_sterno.Visible = false;
            l_supraspin.Visible = false;
            l_trapez.Visible   = false;
        }
        private void L_Show()
        {
            l_deltoid.Visible = true;
            l_dorsal_mare.Visible = true;
            l_infraspinos.Visible = true;
            l_rid_scap.Visible = true;
            l_romb_mare.Visible = true;
            l_romb_mic.Visible = true;
            l_rotund_mare.Visible = true;
            l_rotund_mic.Visible = true;
            l_sterno.Visible = true;
            l_sterno.Visible = true;
            l_supraspin.Visible = true;
            l_trapez.Visible = true;
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
            if (t_dorsal_mare.Text.ToLower() == "dorsalul mare" || t_dorsal_mare.Text.ToLower() == "dorsal mare" || t_dorsal_mare.Text.ToLower() == "muschiul dorsal mare")
            {
                verif_txt(t_dorsal_mare, l_dorsal_mare);
            }
            else
            {
                er_txt(t_dorsal_mare, l_dorsal_mare);
            }
            if (t_infraspinos.Text.ToLower() == "infraspinos" || t_infraspinos.Text.ToLower() == "muschiul infraspinos")
            {
                verif_txt(t_infraspinos, l_infraspinos);
            }
            else
            {
                er_txt(t_infraspinos, l_infraspinos);
            }
            if (t_rid_scap.Text.ToLower() == "ridicator al scapulei" || t_rid_scap.Text.ToLower() == "ridicatorul scapulei" || t_rid_scap.Text.ToLower() == "muschiul ridicator al scapulei")
            {
                verif_txt(t_rid_scap, l_rid_scap);
            }
            else
            {
                er_txt(t_rid_scap, l_rid_scap);
            }
            if (t_romb_mare.Text.ToLower() == "romboid mare" || t_romb_mare.Text.ToLower() == "romboidul mare" ||  t_romb_mare.Text.ToLower() == "muschiul romboid mare")
            {
                verif_txt(t_romb_mare, l_romb_mare);
            }
            else
            {
                er_txt(t_romb_mare, l_romb_mare);
            }
            if (t_romb_mic.Text.ToLower() == "romboid mic" || t_romb_mic.Text.ToLower() == "romboidul mic" || t_romb_mic.Text.ToLower() == "muschiul romboid mic")
            {
                verif_txt(t_romb_mic, l_romb_mic);
            }
            else
            {
                er_txt(t_romb_mic, l_romb_mic);
            }
            if (t_rotund_mic.Text.ToLower() == "rotund mare" || t_rotund_mic.Text.ToLower() == "rotundul mare" || t_rotund_mic.Text.ToLower() == "muschiul rotund mare")
            {
                verif_txt(t_rotund_mare, l_rotund_mare);
            }
            else
            {
                er_txt(t_rotund_mare, l_rotund_mare);
            }
            if (t_rotund_mic.Text.ToLower() == "rotund mic" || t_rotund_mic.Text.ToLower() == "rotundul mic" || t_rotund_mic.Text.ToLower() == "muschiul rotund mic")
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
            if (t_supraspin.Text.ToLower() == "supraspinos" || t_supraspin.Text.ToLower() == "muschiul supraspinos")
            {
                verif_txt(t_supraspin, l_supraspin);
            }
            else
            {
                er_txt(t_supraspin, l_supraspin);
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
        private void muschi_ceafa_spate_Load(object sender, EventArgs e)
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
