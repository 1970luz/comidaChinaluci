using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuChino
{
    public partial class Form1 : Form
    {
        //Variables Declaradas 
       //contadores
        int BaseTotal = 0;
        int ToppingTotal = 0;
        int CrugienteTotal = 0;
        int aderezoTotal = 0;
        int ProteinaTotal = 0;
        //Arreglos
        string[] arrayBase = new string[0];
        string[] arrayProteina = new string[0];
        string[] arrayCrujiente = new string[0];
        string[] arrayAderezo = new string[0];
        string[] arrayTopping = new string[0];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /////////////////////// Checar si ya seleecione una base /////////////////////
        private void checkBoxBasearroz_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBasearroz.CheckState == CheckState.Checked)
            {
              
                string arroz = "Arroz";
                List<string> elementosBase = new List<string>(arrayBase.ToList());
                elementosBase.Add(arroz);
                arrayBase = elementosBase.ToArray();
                BaseTotal++;

            }
            else
            {
                BaseTotal--;   
            }
        }

        private void checkBoxBasetallarines_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBasetallarines.CheckState == CheckState.Checked)
            {
                string Tallarines = "Tallarines";
                List<string> elementosBase = new List<string>(arrayBase.ToList());
                elementosBase.Add(Tallarines);
                arrayBase = elementosBase.ToArray();
                BaseTotal++;
              
            }
            else
            {
                BaseTotal--;
            }
        }

        private void checkBoxBasefideos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBasefideos.CheckState == CheckState.Checked)
            {
                string fideos = "fideos";
                List<string> elementosBase = new List<string>(arrayBase.ToList());
                elementosBase.Add(fideos);
                arrayBase = elementosBase.ToArray();
                BaseTotal++;
                
            }
            else
            {
                BaseTotal--;
            }
        }

        private void checkBoxBaselechuga_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBaselechuga.CheckState == CheckState.Checked)
            {
                string Lechuga = "Lechuga";
                List<string> elementosBase = new List<string>(arrayBase.ToList());
                elementosBase.Add(Lechuga);
                arrayBase = elementosBase.ToArray();
                BaseTotal++;
               
            }
            else
            {
                BaseTotal--;
            }
        }


        //Checar si ya seleccionamos un topping ////////////////////////////

        private void checkBoxTopmango_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTopmango.CheckState == CheckState.Checked)
            {

                string Tmango = "mango";
                List<string> elementostopping = new List<string>(arrayTopping.ToList());
                elementostopping.Add(Tmango);
                arrayTopping = elementostopping.ToArray();
                ToppingTotal++;
            }
            else
            {
                ToppingTotal--;
            }
        }

        private void checkBoxTopdurazno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTopdurazno.CheckState == CheckState.Checked)
            {
                string Tdurazno = "durazno";
                List<string> elementostopping = new List<string>(arrayTopping.ToList());
                elementostopping.Add(Tdurazno);
               arrayTopping = elementostopping.ToArray();
                ToppingTotal++;
            }
            else
            {
                ToppingTotal--;
            }
        }

        private void checkBoxToptomate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxToptomate.CheckState == CheckState.Checked)
            {
                string Ttomate = "Tomate";
                List<string> elementostopping = new List<string>(arrayTopping.ToList());
                elementostopping.Add(Ttomate);
                 arrayTopping= elementostopping.ToArray();
                ToppingTotal++;
            }
            else
            {
                ToppingTotal--;
            }
        }

        private void checkBoxTopadamame_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTopadamame.CheckState == CheckState.Checked)
            {
                string Tadamame = "adamame";
                List<string> elementostopping = new List<string>(arrayTopping.ToList());
                elementostopping.Add(Tadamame);
                arrayTopping = elementostopping.ToArray();
                ToppingTotal++;
            }
            else
            {
               ToppingTotal--;
            }
        }

        private void checkBoxTopchampinones_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTopchampinones.CheckState == CheckState.Checked)
            {
                string Tchampiniones = "champiniones";
                List<string> elementostopping = new List<string>(arrayTopping.ToList());
                elementostopping.Add(Tchampiniones);
                arrayTopping = elementostopping.ToArray();
                ToppingTotal++;
            }
            else
            {
                ToppingTotal--;
            }
        }



        //checar si ya se seleccionar una proteina

        private void checkBoxProteinapollo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProteinapollo.CheckState == CheckState.Checked)
            {
                string Ppollo = "Pollo";
                List<string> elementosProte = new List<string>(arrayProteina.ToList());
                elementosProte.Add(Ppollo);
                  arrayProteina =elementosProte.ToArray();
                ProteinaTotal++;
            }
            else
            {
                ProteinaTotal--;
            }
        }
        private void checkBoxProteinacerdo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProteinacerdo.CheckState == CheckState.Checked)
            {

                string PCerdo = "Cerdo";
                List<string> elementosProte = new List<string>(arrayProteina.ToList());
                elementosProte.Add(PCerdo);
                arrayProteina = elementosProte.ToArray();
                ProteinaTotal++;
            }
            else
            {
                ProteinaTotal--;
            }
        }

        private void checkBoxProteinarollo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProteinarollo.CheckState == CheckState.Checked)
            {

                string Prollo = "rollo";
                List<string> elementosProte = new List<string>(arrayProteina.ToList());
                elementosProte.Add(Prollo);
                arrayProteina = elementosProte.ToArray();
                ProteinaTotal++;
            }
            else
            {
                ProteinaTotal--;
            }
        }

        private void checkBoxProteinasurimi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProteinasurimi.CheckState == CheckState.Checked)
            {

                string PSurimi = "Surimi";
                List<string> elementosProte = new List<string>(arrayProteina.ToList());
                elementosProte.Add(PSurimi);
                arrayProteina = elementosProte.ToArray();
                ProteinaTotal++;
            }
            else
            {
                ProteinaTotal--;
            }
        }



        //Checar si esta seleecionado un Aderezp

        private void checkBoxAderezozolike_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAderezozolike.CheckState == CheckState.Checked)
            {


                string Alike = "Like";
                List<string> elementosaderezo = new List<string>(arrayAderezo.ToList());
                elementosaderezo.Add(Alike);
                arrayAderezo = elementosaderezo.ToArray();
                aderezoTotal++;
            }
            else
            {
                aderezoTotal--;
            }
        }

        private void checkBoxAderezoagridulce_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAderezoagridulce.CheckState == CheckState.Checked)
            {
                string AAgridulce = "Agridulce";
                List<string> elementosaderezo = new List<string>(arrayAderezo.ToList());
                elementosaderezo.Add(AAgridulce);
                arrayAderezo = elementosaderezo.ToArray();
                aderezoTotal++;
            }
            else
            {
                aderezoTotal--;
            }
    }

        private void checkBoxAderezosoya_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAderezosoya.CheckState == CheckState.Checked)
            {
                string Asoya = "soya";
                List<string> elementosaderezo = new List<string>(arrayAderezo.ToList());
                elementosaderezo.Add(Asoya);
                arrayAderezo = elementosaderezo.ToArray();
                aderezoTotal++;
            }
            else
            {
                aderezoTotal--;
            }
    }

        private void checkBoxAderezoteriyaki_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxAderezoteriyaki.CheckState == CheckState.Checked)
            {
                string Ateriyaki = "teriyaki";
                List<string> elementosaderezo = new List<string>(arrayAderezo.ToList());
                elementosaderezo.Add(Ateriyaki);
                arrayAderezo = elementosaderezo.ToArray();
                aderezoTotal++;
            }
            else
            {
                aderezoTotal--;
            }

        }
      
        
        
        
        //verificar si ya se selecciono un crujiente
        private void checkBoxCrugientearandanos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCrugientearandanos.CheckState == CheckState.Checked)
            {
                string CArandano = "Arandano";
                List<string> elementoCrujiente = new List<string>(arrayCrujiente.ToList());
               elementoCrujiente.Add(CArandano);
                arrayCrujiente =elementoCrujiente.ToArray();
                CrugienteTotal++;
            }
            else
            {
                CrugienteTotal--;
            }
        }

        private void checkBoxCrugienteamarantu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCrugienteamarantu.CheckState == CheckState.Checked)
            {
                string CAmarantu = "Amarantu";
                List<string> elementoCrujiente = new List<string>(arrayCrujiente.ToList());
                elementoCrujiente.Add(CAmarantu);
                arrayCrujiente = elementoCrujiente.ToArray();
                CrugienteTotal++;
            }
            else
            {
                CrugienteTotal--;
            }
        }

        private void checkBoxCrugientecacahuate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCrugientecacahuate.CheckState == CheckState.Checked)
            {
                string Ccacahuate= "Cacahuate";
                List<string> elementoCrujiente = new List<string>(arrayCrujiente.ToList());
                elementoCrujiente.Add(Ccacahuate);
                arrayCrujiente = elementoCrujiente.ToArray();
                CrugienteTotal++;
            }
            else
            {
                CrugienteTotal--;
            }
        }

        private void checkBoxCrugientesemilla_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCrugientesemilla.CheckState == CheckState.Checked)
            {
                string csemilla = "Semilla";
                List<string> elementoCrujiente = new List<string>(arrayCrujiente.ToList());
                elementoCrujiente.Add(csemilla);
                arrayCrujiente = elementoCrujiente.ToArray();
                CrugienteTotal++;
            }
            else
            {
                CrugienteTotal--;
            }
        }


        ///////////// //Boton Para Agregar Menu////////////////////////////
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (BaseTotal == 1)
            {
                labelAviso.Text = "base ok";

            }
            else if (BaseTotal == 0)
            {
                labelAviso.Text = "Falta elegir una base";
                goto salir;
            }
            else
            {
                labelAviso.Text = "solo puedes elegir una base";
                goto salir;
            }

            //apartado para proteinas
            if (ProteinaTotal >= 1 && ProteinaTotal <= 3)
            {
                labelProteina.Text = "proteina ok";
            }
            else if (ProteinaTotal == 0)
            {
                labelProteina.Text = "Falta elegir una proteina";

                goto salir;
            }
            else
            {
                labelProteina.Text = "solo puedes elegir hasta tres proteinas ";
            }
            //apartado de crujientes
            if (CrugienteTotal == 1)
            {
                labelCrugiente.Text = "crujiente ok";
            }
            else if (CrugienteTotal == 0)
            {
                labelCrugiente.Text = "Falta elegir un crujiente";
            }
            else
            {
                labelCrugiente.Text = "solo puedes elegir hasta un Crugiente";
            }
            //topping
            if (ToppingTotal >= 1 && ToppingTotal <= 2)
            {
                labelTopping.Text = "Topping ok";
            }
            else if (ToppingTotal == 0)
            {
                labelTopping.Text = "Falta elegir un topping";
            }
            else
            {
                labelTopping.Text = "solo puedes elegir hasta dos topping ";
            }
            //aderezo
            if (aderezoTotal == 1)
            {
                labelAderezo.Text = "aderezo ok";
            }
            else if (aderezoTotal == 0)
            {
                labelAderezo.Text = "Falta elegir un aderezo";
            }
            else
            {
                labelAderezo.Text = "solo puedes elegir un aderezo ";
            }

        salir:;

        }
        //Boton para Salir
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baseselec = "";
            string proteinaselec = "";
            string aderezoselec = "";
            string toppingselec = "";
            string crujienteselec = "";


            // Leemos el arreglo base
            for (int i = 0; i < arrayBase.Length; i++)
            {
                baseselec = arrayBase[i].ToString();
            }

            //leemos el arreglo proteina
            for (int i = 0; i < arrayProteina.Length; i++)
            {
                proteinaselec = arrayProteina[i].ToString();
            }
            //leemos el arreglo crujiente

            for (int i = 0; i < arrayCrujiente.Length; i++)
            {

                crujienteselec = arrayCrujiente[i].ToString();
            }

            //leemo el arreglo aderezo
            for (int i = 0; i < arrayAderezo.Length; i++)
            {
                aderezoselec = arrayAderezo[i].ToString();
            }

            //leemos el arreglo 
            for (int i = 0; i < arrayTopping.Length; i++)
            {
                toppingselec = arrayTopping[i].ToString();
            }

            if (baseselec == "")
            {
                // MessageBox.Show("falta elegir un crujiente");
                goto Sal;
            }
            if (proteinaselec == "")
            {
                // MessageBox.Show("falta elegir una proteina");
                goto Sal;
            }
            if (aderezoselec == "")
            {
                // MessageBox.Show("falta elegir una aderozo");
                goto Sal;
            }
            if (toppingselec == "")
            {
                // MessageBox.Show("falta elegir un topping");
                goto Sal;
            }
            if (crujienteselec == "")
            {
                // MessageBox.Show("falta elegir un crujiente");
                goto Sal;
            }

            else
            {
                listBoxMenu.Items.Add(baseselec);
                listBoxMenu.Items.Add(proteinaselec);
                listBoxMenu.Items.Add(aderezoselec);
                listBoxMenu.Items.Add(toppingselec);
                listBoxMenu.Items.Add(crujienteselec);
            }
        Sal:;
        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBorrarmenu_Click(object sender, EventArgs e)
        {
            listBoxMenu.Items.Clear();
        }

        private void buttonAgregarcomida_Click(object sender, EventArgs e)
        {
            string baseselec = "";
            string proteinaselec = "";
            string aderezoselec = "";
            string toppingselec = "";
            string crujienteselec = "";


            // Leemos el arreglo base
            for (int i = 0; i < arrayBase.Length; i++)
            {
                baseselec = arrayBase[i].ToString();
            }

            //leemos el arreglo proteina
            for (int i = 0; i < arrayProteina.Length; i++)
            {
                proteinaselec = arrayProteina[i].ToString();
            }
            //leemos el arreglo crujiente

            for (int i = 0; i < arrayCrujiente.Length; i++)
            {

                crujienteselec = arrayCrujiente[i].ToString();
            }

            //leemo el arreglo aderezo
            for (int i = 0; i < arrayAderezo.Length; i++)
            {
                aderezoselec = arrayAderezo[i].ToString();
            }

            //leemos el arreglo 
            for (int i = 0; i < arrayTopping.Length; i++)
            {
                toppingselec = arrayTopping[i].ToString();
            }

            if (baseselec == "")
            {
                // MessageBox.Show("falta elegir un crujiente");
                goto Sal;
            }
            if (proteinaselec == "")
            {
                // MessageBox.Show("falta elegir una proteina");
                goto Sal;
            }
            if (aderezoselec == "")
            {
                // MessageBox.Show("falta elegir una aderozo");
                goto Sal;
            }
            if (toppingselec == "")
            {
                // MessageBox.Show("falta elegir un topping");
                goto Sal;
            }
            if (crujienteselec == "")
            {
                // MessageBox.Show("falta elegir un crujiente");
                goto Sal;
            }

            else
            {
                listBoxMenu.Items.Add(baseselec);
                listBoxMenu.Items.Add(proteinaselec);
                listBoxMenu.Items.Add(aderezoselec);
                listBoxMenu.Items.Add(toppingselec);
                listBoxMenu.Items.Add(crujienteselec);
            }
        Sal:;
        }
    }
}