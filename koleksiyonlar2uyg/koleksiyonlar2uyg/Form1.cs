using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace koleksiyonlar2uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable hashtable = new Hashtable();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("txt" + "  " + "notepad.exe");
            listBox1.Items.Add("bmp" + "  " + "paint.exe");
            listBox1.Items.Add("dip" + "  " + "paint.exe");
            listBox1.Items.Add("rtf" + "  " + "wordpad.exe");

            hashtable.Add("txt", "notepad.exe");
            hashtable.Add("bmp", "paint.exe");
            hashtable.Add("dip", "paint.exe");
            hashtable.Add("rtf", "wordpad.exe");
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            aciklamalbl.Text="";
            ArrayList key = new ArrayList(hashtable.Keys);

            
            try
            {
                hashtable.Add("txt", "winvord");
                hashtable.Add("bmp", "winvord");
                hashtable.Add("dip", "winvord");
                hashtable.Add("rtf", "winvord");
                hashtable.Add("","");
            }
            catch
            {
                
                if (keytxt.Text=="txt")
                {
                    aciklamalbl.Text = "\"txt\" uzantılı bilgi mevcuttur";
                }
                else if (keytxt.Text == "bmp")
                {
                    aciklamalbl.Text = "\"bmp\" uzantılı bilgi mevcuttur";
                }
                else if (keytxt.Text == "dip")
                {
                    aciklamalbl.Text = "\"dip\" uzantılı bilgi mevcuttur";
                }
                else if (keytxt.Text == "rtf")
                {
                    aciklamalbl.Text = "\"rtf\" uzantılı bilgi mevcuttur";
                }
                else if (keytxt.Text == "" || valuetxt.Text == "")
                {
                    listBox1.Items.Add(keytxt.Text + " " + valuetxt.Text);
                    string cevap3 = keytxt.Text + valuetxt.Text;
                    aciklamalbl.Text = cevap3 + " " +  "uzantılı bilgi eklenmiştir";
                }



            }


            foreach (var item in key)
            {
                listBox1.Items.Add(item + "   " + hashtable[item]);

            }
            //listBox1.Items.Add(metin);

            //listBox1.Items.Add(metin1);

            if (((keytxt.Text == "") && (valuetxt.Text == "")))
            {
                ArrayList key1 = new ArrayList(hashtable.Keys);

                foreach (var item in key1)
                {
                    listBox1.Items.Add(item + "   " + hashtable[item]);


                }
            }

        }

        private void varmiyokmutxt_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //ArrayList key1 = new ArrayList(hashtable.Keys);
            //if (hashtable.ContainsKey(keytxt.Text== "doc"))
            //{
            //    aciklamalbl.Text = "\"doc\" uzantılı bilgi yoktur ";
            //    foreach (string item in key1)
            //    {
            //        listBox1.Items.Add(item + "   " + hashtable[item]);

            //    }
            //}
            //else if (hashtable.ContainsKey(keytxt.Text == "txt"))
            //{
            //    aciklamalbl.Text = "\"txt\" uzantılı bilgi vardır ";
            //    foreach (var item in key1)
            //    {
            //        listBox1.Items.Add(item + "   " + hashtable[item]);

            //    }

            //}
            //ArrayList key2 = new ArrayList(hashtable.Keys);

            //foreach (var item in key)
            //{
            //    listBox1.Items.Clear();
            //    listBox1.Items.Add(item + "   " + hashtable[item]);
            //}
            //listBox1.Items.Clear();
            //ArrayList key = new ArrayList(hashtable.Keys);

            //foreach (var item in key)
            //{
            //    listBox1.Items.Add(item + "   " + hashtable[item]);

            //}
            
            if (keytxt.Text == "doc")
            {
                hashtable.ContainsKey("doc");
                aciklamalbl.Text = "\"doc\" uzantılı bilgi yoktur ";


            }
            else if (keytxt.Text == "txt")
                
            {
                hashtable.ContainsKey(keytxt.Text == "txt");
                aciklamalbl.Text = "\"txt\" uzantılı bilgi vardır ";

            }
            else if (keytxt.Text == "bmp")
                
            {
                hashtable.ContainsKey(keytxt.Text = "bmp");
                aciklamalbl.Text = "\"bmp\" uzantılı bilgi vardır ";

            }
            else if (keytxt.Text == "dip")
            {
                hashtable.ContainsKey(keytxt.Text == "dip");
                aciklamalbl.Text = "\"dip\" uzantılı bilgi vardır ";

            }
            else if (keytxt.Text == "rtf")
            {
                hashtable.ContainsKey(keytxt.Text == "rtf");
                aciklamalbl.Text = "\"rtf\" uzantılı bilgi vardır ";

            }
            else if (keytxt.Text=="")
            {
                
                hashtable.ContainsKey(keytxt.Text == "");
                string cevap = keytxt.Text;
                aciklamalbl.Text = cevap + " " + "böyle bir uzantı yoktur.";
            }
          






            //}



        }

        private void cikarbtn_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            
           

            if (keytxt.Text == "txt")
            {
                hashtable.Remove("txt");
                aciklamalbl.Text = "\"txt\" uzantılı bilgi kaldırılmıştır";
            }
            else if (keytxt.Text == "bmp")
            {
                hashtable.Remove("bmp");
                aciklamalbl.Text = "\"bmp\" uzantılı bilgi kaldırılmıştır";
            }
            else if (keytxt.Text == "dip")
            {
                hashtable.Remove("dip");
                aciklamalbl.Text = "\"dip\" uzantılı bilgi kaldırılmıştır";
            }
            else if (keytxt.Text == "rtf")
            {
                hashtable.Remove("rtf"); 
                aciklamalbl.Text = "\"rtf\" uzantılı bilgi kaldırılmıştır";
            }
            else if (keytxt.Text == "" || valuetxt.Text == "")
            {
                hashtable.Remove(keytxt.Text + " " + valuetxt.Text);
                string cevap1 =keytxt.Text + valuetxt.Text;
                aciklamalbl.Text = cevap1 + " " + " uzantılı bilgi kaldırılmıştır.";
            }



            ArrayList key = new ArrayList(hashtable.Keys);

            foreach (var item in key)
            {
                listBox1.Items.Add(item + "   " + hashtable[item]);

            }




        }
    }
}
