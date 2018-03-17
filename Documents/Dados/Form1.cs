using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanzarDados
{
    public partial class Form1 : Form
    {
        Dado dado = new Dado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1Lanze_Click(object sender, EventArgs e)
        {
            txtShow.Text += Convert.ToString(dado.Lanzar())+"\r\n";
        }

        //public string lanzar100Veces()
        //{
        //    int uno=0, dos=0, tres=0, cuatro=0, cinco=0, seis=0,temp=0;
        //    for (int i = 0; i <= 100; i++)
        //    {
        //        temp = dado.Lanzar();
        //        switch (temp)
        //        {
        //            case 1:
        //                uno += temp;
        //                break;
        //            case 2:
        //                dos += temp;
        //                break;
        //            case 3:
        //                tres += temp;
        //                break;
        //            case 4:
        //                cuatro += temp;
        //                break;
        //            case 5:
        //                cinco += temp;
        //                break;
        //            default:
        //                seis += temp;
        //                break;
        //        }
        //    }
        //}

        //public string lanzar100convector()
        //{
        //    int temp = 0;
        //    int[] vec = new int[5];
        //    for(int i=0; i<=100; i++)
        //    {
        //        temp = dado.Lanzar();
        //        vec[temp - 1]++;
        //    }
        //}

        private void btn100Lan_Click(object sender, EventArgs e)
        {
            int temp = 0;
            int[] vec = new int[6];
            for (int i = 0; i <= 100; i++)
            {
                //temp = dado.Lanzar();
                vec[dado.Lanzar() - 1]++;
            }
            for(int i=0; i < 6; i++)
            {
                txtShow.Text += " Cara " + (i+1) + "= " + vec[i].ToString()+"\r\n";
            }
            txtShow.Text += "------------------------------------\r\n";
        }

        private void btn1x2x100L_Click(object sender, EventArgs e)
        {
            int[] vec = new int[11];
            for(int i=0; i<=100; i++)
            {
                vec[dado.Lanzar() + dado.Lanzar() - 2]++;
            }
            for(int i=0; i < 11; i++)
            {
                txtShow.Text += "Cara " + (i+2) + " =" + vec[i].ToString()+"\r\n";
            }
            txtShow.Text += "----------------------------------------\r\n";

        }
    }
}
