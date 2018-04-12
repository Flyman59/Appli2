using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appli2
{
    public partial class frmAppli2 : Form
    {
        public frmAppli2()
        {
            InitializeComponent();
        }
       //Synchronisation github
        /// <summary>
        /// Réinitialise l'application par défaut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cbx_speed.Enabled = true;
            cbx_Temp.Enabled = true;
            gbx_Para.Visible = false;
        }

        /// <summary>
        /// Quitte l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Demande confirmation de l'utilisateur par "oui" ou "non" pour quitter l'appli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Appli2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep;

            rep = MessageBox.Show("Voulez vous quitter", "Terminer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rep == DialogResult.No)
            {
                e.Cancel = true;

                //Rend invisible la gbx_para et disponible aux controle utilisateur la gbx Speed et Temp
                cbx_speed.Enabled = true;
                cbx_Temp.Enabled = true;
                gbx_Para.Visible = false;
            }
        }

        /// <summary>
        ///Rend visible la gbx_para et indisponible aux controle utilisateur la gbx Speed et Temp quand ont clik sur le btn "OK"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            gbx_Para.Visible = true;
            cbx_speed.Enabled = false;
            cbx_Temp.Enabled = false;

            
            
        }

        /// <summary>
        /// Affiche la vitesse choisie de cbx_speed dans la textBox_Vitesse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_speed_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox_Vtesse.Text = cbx_speed.Text;
        }

        /// <summary>
        /// Affiche la température choisie de cbx_Temp dans la textBox_Temp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_Temp_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox_Temp.Text = cbx_Temp.Text;
        }
    }
}
