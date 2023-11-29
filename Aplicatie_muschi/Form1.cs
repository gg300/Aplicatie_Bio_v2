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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mușchii_capului_Click(object sender, EventArgs e)
        {
            muschi_cap form = new muschi_cap(this);
            form.Show();
        }

        private void mușchii_gâtului_Click(object sender, EventArgs e)
        {
            muschi_gat form = new muschi_gat(this);
            form.Show();
        }

        private void mușchii_cefei_spatelui_Click(object sender, EventArgs e)
        {
            muschi_ceafa_spate form = new muschi_ceafa_spate(this);
            form.Show();
        }

        private void mușchii_abdomenului_Click(object sender, EventArgs e)
        {
            muschi_abdomen form = new muschi_abdomen(this);
            form.Show();
        }

        private void mușchii_părții_anterolaterale_toracelui_Click(object sender, EventArgs e)
        {
            muschi_torace form = new muschi_torace(this);
            form.Show();
        }

        private void mușchii_membrelor_superioare_Click(object sender, EventArgs e)
        {
            muschi_membre_superioare form = new muschi_membre_superioare(this);
            form.Show();
        }

        private void mușchii_membrelor_inferioare_Click(object sender, EventArgs e)
        {
            muschi_membre_inferioare form = new muschi_membre_inferioare(this);
            form.Show();
        }
    }
}
