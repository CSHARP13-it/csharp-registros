﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiProyecto.Properties
{
    public partial class frm_numericupdown : Form
    {
        public frm_numericupdown()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            string DiaTexto="";
            decimal Nrodia;
            Nrodia = num_nrodia.Value;

            switch (Nrodia)
            {
                case 1:
                    DiaTexto = "LUNES";
                    break;
                case 2:
                    DiaTexto = "MARTES";
                    break;
                case 3:
                    DiaTexto = "MIERCOLES";
                    break;
                case 4:
                    DiaTexto = "JUEVES";
                    break;
                case 5:
                    DiaTexto = "VIERNES";
                    break;
                case 6:
                    DiaTexto = "SABADO";
                    break;
                case 7:
                    DiaTexto = "DOMINGO";
                    break;
                
            }
            txt_resultado.Text = DiaTexto;
        }

        private void txt_resultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
