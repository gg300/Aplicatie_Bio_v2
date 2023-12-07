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
    public partial class muschi_membre_inferioare : Form
    {
        private Form1 main = null;
        public muschi_membre_inferioare(Form callingForm)
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
            if(t_ahile.Text.ToLower() == l_ahile.Text.ToLower())
            {
                verif_txt(t_ahile, l_ahile);
            }
            else
            {
                er_txt(t_ahile, l_ahile);
            }
            if(t_calcai.Text.ToLower() == "calcai")
            {
                verif_txt(t_calcai, l_calcai);
            }
            else
            {
                er_txt(t_calcai, l_calcai);
            }
            if (t_extensor_degete.Text.ToLower() == l_extensor_degete.Text.ToLower())
            {
                verif_txt(t_extensor_degete, l_extensor_degete);
            }
            else
            {
                er_txt(t_extensor_degete, l_extensor_degete);
            }
            if (t_extensor_hal.Text.ToLower() == l_extensor_hal.Text.ToLower())
            {
                verif_txt(t_extensor_hal, l_extensor_hal);
            }
            else
            {
                er_txt(t_extensor_hal, l_extensor_hal);
            }
            if (t_flexor_degete.Text.ToLower() == l_flexor_degete.Text.ToLower())
            {
                verif_txt(t_flexor_degete, l_flexor_degete);
            }
            else
            {
                er_txt(t_flexor_degete, l_flexor_degete);
            }
            if (t_flexor_lung.Text.ToLower() == l_flexor_hal.Text.ToLower())
            {
                verif_txt(t_flexor_lung, l_flexor_hal);
            }
            else
            {
                er_txt(t_flexor_lung, l_flexor_hal);
            }
            if (t_gastrocnemiu_lateral.Text.ToLower() == "gastrocnemiu lateral" || t_gastrocnemiu_lateral.Text.ToLower() == "muschiul gastrocnemiu lateral")
            {
                verif_txt(t_gastrocnemiu_lateral, l_gastrocnemiu_lateral);
            }
            else
            {
                er_txt(t_gastrocnemiu_lateral, l_gastrocnemiu_lateral);
            }
            if (t_gastrocnemiu_median.Text.ToLower() == "gastrocnemiu median" || t_gastrocnemiu_median.Text.ToLower() == "muschiul gastrocnemiu median")
            {
                verif_txt(t_gastrocnemiu_median, l_gastrocnemiu_median);
            }
            else
            {
                er_txt(t_gastrocnemiu_median, l_gastrocnemiu_median);
            }
            if (t_peronier_3.Text.ToLower() == l_peronier_3.Text.ToLower())
            {
                verif_txt(t_peronier_3, l_peronier_3);
            }
            else
            {
                er_txt(t_peronier_3, l_peronier_3);
            }
            if (t_peronier_lung.Text.ToLower() == l_peronier_lung.Text.ToLower())
            {
                verif_txt(t_peronier_lung, l_peronier_lung);
            }
            else
            {
                er_txt(t_peronier_lung, l_peronier_lung);
            }
            if (t_peronier_lung_2.Text.ToLower() == l_peronioer_lung_2.Text.ToLower())
            {
                verif_txt(t_peronier_lung_2, l_peronioer_lung_2);
            }
            else
            {
                er_txt(t_peronier_lung_2, l_peronioer_lung_2);
            }
            if (t_peronier_scurt.Text.ToLower() == l_peronier_scurt.Text.ToLower())
            {
                verif_txt(t_peronier_scurt, l_peronier_scurt);
            }
            else
            {
                er_txt(t_peronier_scurt, l_peronier_scurt);
            }
            if (t_peronier_scurt_2.Text.ToLower() == l_peronier_scurt_2.Text.ToLower())
            {
                verif_txt(t_peronier_scurt_2, l_peronier_scurt_2);
            }
            else
            {
                er_txt(t_peronier_scurt_2, l_peronier_scurt_2);
            }
            if (t_plantar.Text.ToLower() == "plantarul" || t_plantar.Text.ToLower() == "plantar" || t_plantar.Text.ToLower() == "muschiul plantar")
            {
                verif_txt(t_plantar, l_plantar);
            }
            else
            {
                er_txt(t_plantar, l_plantar);
            }
            if (t_popliteu.Text.ToLower() == l_popliteu.Text.ToLower())
            {
                verif_txt(t_popliteu, l_popliteu);
            }
            else
            {
                er_txt(t_popliteu, l_popliteu);
            }
            if (t_ret_ext_inf.Text.ToLower() == "retinaculul extensorilor inferiori" || t_ret_ext_inf.Text.ToLower() == "muschiul retinacul al extensorilor inferiori")
            {
                verif_txt(t_ret_ext_inf, l_ret_ext_inf);
            }
            else
            {
                er_txt(t_ret_ext_inf, l_ret_ext_inf);
            }
            if (t_ret_ext_sup.Text.ToLower() == "retinaculul extensorilor superiori" || t_ret_ext_sup.Text.ToLower() == "muschiul retinacul al extensorilor superiori")
            {
                verif_txt(t_ret_ext_sup, l_ret_ext_sup);
            }
            else
            {
                er_txt(t_ret_ext_sup, l_ret_ext_sup);
            }
            if (t_solear.Text.ToLower() == "muschiul solear" || t_solear.Text.ToLower() == "solear")
            {
                verif_txt(t_solear, l_solear);
            }
            else
            {
                er_txt(t_solear, l_solear);
            }
            if (t_solear_cut.Text.ToLower() == "solear" || t_solear_cut.Text.ToLower() == "muschiul solear")
            {
                verif_txt(t_solear_cut, l_solear_cut);
            }
            else
            {
                er_txt(t_solear_cut, l_solear_cut);
            }
            if (t_tibial_anterior.Text.ToLower() == "tibial anterior" || t_tibial_anterior.Text.ToLower() == "muschi tibial anterior")
            {
                verif_txt(t_tibial_anterior, l_tibial_anterior);
            }
            else
            {
                er_txt(t_tibial_anterior, l_tibial_anterior);
            }
            if (t_tibial_posterior.Text.ToLower() == "muschi tibial posterior" || t_tibial_posterior.Text.ToLower() == "muschi tibial posterior")
            {
                verif_txt(t_tibial_posterior, l_tibial_posterior);
            }
            else
            {
                er_txt(t_tibial_posterior, l_tibial_posterior);
            }

        }
        private void L_hid()
        {
            l_ahile.Visible = false;
            l_calcai.Visible = false;
            l_extensor_degete.Visible = false;
            l_extensor_hal.Visible = false;
            l_flexor_degete.Visible = false;
            l_flexor_hal.Visible = false;
            l_gastrocnemiu_lateral.Visible = false;
            l_gastrocnemiu_median.Visible = false;
            l_peronier_3.Visible = false;
            l_peronier_lung.Visible = false;
            l_peronier_scurt.Visible = false;
            l_peronier_scurt_2.Visible = false;
            l_peronioer_lung_2.Visible = false;
            l_plantar.Visible = false;
            l_popliteu.Visible = false;
            l_ret_ext_inf.Visible = false;
            l_ret_ext_sup.Visible = false;
            l_solear.Visible = false;
            l_solear_cut.Visible = false;
            l_tibial_anterior.Visible = false;
            l_tibial_posterior.Visible = false;
        }
        private void L_Show()
        {
            l_ahile.Visible = true;
            l_calcai.Visible = true;
            l_extensor_degete.Visible = true;
            l_extensor_hal.Visible = true;
            l_flexor_degete.Visible = true;
            l_flexor_hal.Visible = true;
            l_gastrocnemiu_lateral.Visible = true;
            l_gastrocnemiu_median.Visible = true;
            l_peronier_3.Visible = true;
            l_peronier_lung.Visible = true;
            l_peronier_scurt.Visible = true;
            l_peronier_scurt_2.Visible = true;
            l_peronioer_lung_2.Visible = true;
            l_plantar.Visible = true;
            l_popliteu.Visible = true;
            l_ret_ext_inf.Visible = true;
            l_ret_ext_sup.Visible = true;
            l_solear.Visible = true;
            l_solear_cut.Visible = true;
            l_tibial_anterior.Visible = true;
            l_tibial_posterior.Visible = true;
        }
        private void muschi_membre_inferioare_Load(object sender, EventArgs e)
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
