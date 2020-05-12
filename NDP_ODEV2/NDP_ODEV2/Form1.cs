/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:2
**				ÖĞRENCİ ADI............:MAFTUN HASHIMLI
**				ÖĞRENCİ NUMARASI.......:G181210554
**                         DERSİN ALINDIĞI GRUP...:2C
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ODEV2
{
    public partial class Form1 : Form
    {
        //X VE Y DEGERLERINE SADECE RAKAMGIRILE BILSIN
        private void txtx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(312, 335);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool kontrol = true;
        bool listekontrol = false;
         int x = 0;
        int y=0;
        //EK 3 Label, 2 ListBox ve 2 TextBox ekliyoruz
        ListBox lstboxX;
        ListBox lstboxY;
        TextBox txtcarpanlarintoplamiX;
        TextBox txtcarpanlarintoplamiY;
        Label lblx;
            Label lbly;
        private void btnarkadasmi_Click(object sender, EventArgs e)
        {
             
            if (kontrol == true)
            {    
                lstboxX= new ListBox();
                lstboxY = new ListBox();
                txtcarpanlarintoplamiX = new TextBox();
                txtcarpanlarintoplamiY = new TextBox();
                lblx= new Label(); 
                lbly= new Label();
                //onlarin CONTROLLERINI EKLIYORUZ
                this.AutoSize = true;
                //KONTROLLERIN SADECE 1 KERE EKLENMESI ICIN
                kontrol = false;
              
                lblx.Size = new Size(21, 20);
                lblx.Text = "X";
                lblx.Location = new Point(314, 70);
                lblx.Font = new Font(lblx.Font.Name, 10.2f, FontStyle.Bold);
                this.Controls.Add(lblx);

              
                lbly.Size = new Size(21, 20);
                lbly.Text = "Y";
                lbly.Location = new Point(440, 70);
                lbly.Font = new Font(lbly.Font.Name, 10.2f, FontStyle.Bold);
                this.Controls.Add(lbly);


                lstboxX.Location = new Point(270, 110);
                lstboxX.ItemHeight = 16;
                lstboxX.Size = new Size(107, 212);
                this.Controls.Add(lstboxX);


                lstboxY.Location = new Point(410, 110);
                lstboxY.ItemHeight = 16;
                lstboxY.Size = new Size(107, 212);
                this.Controls.Add(lstboxY);

                Label lbltoplam = new Label();
                lbltoplam.Size = new Size(106, 20);
                lbltoplam.Text = "TOPLAMLAR:";
                lbltoplam.Location = new Point(150, 334);
                lbltoplam.Font = new Font(lbltoplam.Font.Name, 10.2f, FontStyle.Bold);
                this.Controls.Add(lbltoplam);


                txtcarpanlarintoplamiX.Size = new Size(106, 22);
                txtcarpanlarintoplamiX.Location = new Point(269, 335);
                txtcarpanlarintoplamiX.ReadOnly = true;
                this.Controls.Add(txtcarpanlarintoplamiX);


                txtcarpanlarintoplamiY.Size = new Size(106, 22);
                txtcarpanlarintoplamiY.Location = new Point(410, 335);
                txtcarpanlarintoplamiY.ReadOnly = true;
                this.Controls.Add(txtcarpanlarintoplamiY);
                kontrol = false;
            }

           

            //Her yeni deger girildingde basildiginda alanlari temizlemekicin
            if (listekontrol==true)
            {
                lstboxX.Items.Clear();
                lstboxY.Items.Clear();
                txtcarpanlarintoplamiX.Text = "";
                txtcarpanlarintoplamiY.Text = "";
            }
            //ALANLAR BOS DEGILSE VE BOSLUK DA ICERMIYORRSA ASAGDAKILERI YAP DIYORUZ
            if (txtx != null && !string.IsNullOrWhiteSpace(txtx.Text)
                  && txty != null && !string.IsNullOrWhiteSpace(txty.Text))
                {
                listekontrol = true;
                     x = int.Parse(txtx.Text);
                     y = int.Parse(txty.Text);
                int carpantoplamix = 0;
                int carpantoplamiy = 0;

                //girilen X degerinin yarisina kadar dondurecegiz
                for (int carpanx = 1; carpanx <= (x / 2); carpanx++)
                    {
                        //Eger carpani ise
                        if (x % carpanx == 0)
                        {
                            //listboxa ekliyoruz,ve carpan toplanina ekliyoruz deger
                            carpantoplamix += carpanx;
                            lstboxX.Items.Add(carpanx);
                            txtcarpanlarintoplamiX.Text = carpantoplamix.ToString();
                        }
                    }
                    //girilen Y degerinin yarisina kadar dondurecegiz
                    for (int carpany = 1; carpany <= (y / 2); carpany++)
                    {
                        //Eger carpani ise
                        if (x % carpany == 0)
                        {
                            //listboxa ekliyoruz,ve carpan toplanina ekliyoruz deger
                            carpantoplamiy += carpany;
                            lstboxY.Items.Add(carpany);
                            txtcarpanlarintoplamiY.Text = carpantoplamiy.ToString();
                        }
                    }
          
                }
                else
                {
                    MessageBox.Show("Lutfen X ve Y degerlerini girin", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        

        private void btnson_Click(object sender, EventArgs e)
        {  
            
            this.Close();
          
        }
    }
}
