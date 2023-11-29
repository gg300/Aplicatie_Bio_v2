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
    public partial class muschi_abdomen : Form
    {
        private Form1 main = null;
        public muschi_abdomen(Form callingForm)
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
            if(t_drept_abdominal.Text == l_drept_abdominal.Text) {
                verif_txt(t_drept_abdominal);
                l_drept_abdominal.ForeColor = Color.Green;
            }
            else
            {
                er_txt(t_drept_abdominal);
                l_drept_abdominal.ForeColor= Color.Red;
            }
            if (t_oblic_extern.Text == l_oblic_extern.Text)
            {
                verif_txt(t_oblic_extern);
                l_oblic_extern.ForeColor = Color.Green;
            }
            else
            {
                er_txt(t_oblic_extern);
                l_oblic_extern.ForeColor = Color.Red;

            }
            if (t_oblic_intern.Text == l_oblic_intern.Text)
            {
                verif_txt(t_oblic_intern);
                l_oblic_intern.ForeColor = Color.Green;
            }
            else
            {
                er_txt(t_oblic_intern);
                l_oblic_intern.ForeColor= Color.Red;
            }
            if (t_transversal.Text == l_transversal.Text)
            {
                verif_txt(t_transversal);
                l_transversal.ForeColor = Color.Green;
            }
            else
            {
                er_txt(t_transversal);
                l_transversal.ForeColor= Color.Red;
            }
        }
        private void L_hid()
        {
            l_drept_abdominal.Visible = false;
            l_oblic_extern.Visible = false;
            l_oblic_intern.Visible = false;
            l_transversal.Visible = false;
        }
        private void L_Show()
        {
            l_drept_abdominal.Visible = true;
            l_oblic_extern.Visible = true;
            l_oblic_intern.Visible = true;
            l_transversal.Visible = true;
        }
        private void muschi_abdomen_Load(object sender, EventArgs e)
        {
            b_raspunsuri.Enabled= false;
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
