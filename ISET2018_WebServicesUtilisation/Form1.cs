using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET2018_WebServicesUtilisation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            UtiliserServiceHEL.ServiceHELClient s = new UtiliserServiceHEL.ServiceHELClient();
            MessageBox.Show(s.HelloWorld());
        }

        private void btnPersonneByID_Click(object sender, EventArgs e)
        {
            int nID;
            if (int.TryParse(tbID.Text, out nID)) //vérifie que la conversion se passe bien, et donc si on a bien entré un int ID
            {
                UtiliserServiceHEL.ServiceHELClient s = new UtiliserServiceHEL.ServiceHELClient();
                UtiliserServiceHEL.WS_Personne p = s.GetPersonneByID(nID);
                if (p.ID == 0)
                    MessageBox.Show("Personne non enregistrée");
                else
                    MessageBox.Show(p.Prenom + " " + p.Nom + " (" + p.ID.ToString() + ")");
            }
            else MessageBox.Show("Entrer un entier");
        }

        private void btnVerifier_Click(object sender, EventArgs e)
        {
            UtiliserServiceHEL.ServiceHELClient s = new UtiliserServiceHEL.ServiceHELClient();
            UtiliserServiceHEL.WS_Personne p = s.CheckPersonneMDP(tbCheckPersonne.Text.ToString(), tbCheckMDP.Text.ToString());

            MessageBox.Show(p.Prenom);
        }

        private void btnVerifierISBN_Click(object sender, EventArgs e)
        {
            //  978-0-306-40615-?
            try
            {
                string codeISBNTraite = String.Join("", tbCodeISBN.Text.Split('-'));

                if (codeISBNTraite.Length == 13)
                {
                    UtiliserServiceHEL.ServiceHELClient s = new UtiliserServiceHEL.ServiceHELClient();
                    UtiliserServiceHEL.WS_CheckISBN p = s.CheckISBNNumber(codeISBNTraite);
                    /*
                    int[] ISBN = new int[codeISBNTraite.Length];
                    Console.WriteLine("T:" + codeISBNTraite.Length);

                    for (int i = 0; i < codeISBNTraite.Length; i++)
                    {
                        ISBN[i] = Int32.Parse(codeISBNTraite.Substring(i, 1));
                        Console.WriteLine(ISBN[i]);
                    }

                    calculISBN = 10 - ((ISBN[0] * 1 + ISBN[1] * 3 + ISBN[2] * 1 + ISBN[3] * 3 + ISBN[4] * 1 + ISBN[5] * 3 + ISBN[6] * 1 + ISBN[7] * 3 + ISBN[8] * 1 + ISBN[9] * 3 + ISBN[10] * 1 + ISBN[11] * 3) % 10);
                    Console.WriteLine("OK : " + calculISBN);

                    if (calculISBN == ISBN[12])
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                    */

                    MessageBox.Show("Validité du code : " + p.codeValide.ToString() + " (Check Digit : " + p.checkDigit.ToString() + ")");

                }
                else
                    MessageBox.Show("Code ISBN invalide!");
            }
            catch
            {
                MessageBox.Show("Code ISBN invalide!");
            }
            
            
        }
    }
}
