using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller1_calcular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Obtener datos
            List<string> listOfData = getData();
            //Convertir datos a tipo Double
            //Obtenemos datos paseados
            List<Double> listOfDataParse = castingData(listOfData);

            //Validamos unos datos 
            Boolean resultLectura = validatelectura(listOfDataParse[2], listOfDataParse[1]);

            //Se valida
            if (resultLectura)
            {
                string menssage = "La 'Lectura Actual' NO puede ser menor que la 'Lectura Anterior'";
                string caption = "Errro Detected in Input";
                MessageBox.Show(menssage, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                //Funcion de hacer calculo
                //@Params : listtOfDataParse
                process(listOfDataParse);

            }
        }


        /** Funcion que crea una lista de tipo 'string'*/
        private List<string> createListString()
        {
            List<string> listOfData = new List<string>();
            return listOfData;
        }
        /** Funcion que crea una lista de tipo 'Double'*/
        private List<Double> createListDouble()
        {
            List<Double> listOfData = new List<Double>();
            return listOfData;
        }

        private List<string> getData()
        {
            //Obtenemos la lista de datos a guardar
            List<string> list = createListString();
            //Obtemos los datos
            String dataCode = txtCodigo.Text;
            String dataLectuAnte = txtLectuAnte.Text;
            String dataLectuActua = txtLectuActua.Text;
            String dataEstrato = txtEstrato.Text;
            //Añadimos datos
            list.Add(dataCode);
            list.Add(dataLectuActua);
            list.Add(dataLectuAnte);
            list.Add(dataEstrato);
            //retornamos
            return list;
        }

        //Validamos la lectura ingresada
        private Boolean validatelectura(double dataLecturaAnte, double dataLecturaActua)
        {
            //validamos si la lectura Actula no sea menor a la Lectura Anterior
            if(dataLecturaActua < dataLecturaAnte)
            {
                return true;
            }
            return false;
        }

        private List<Double> castingData(List<string> listOfData)
        {
            /**Guardamos los datos parseados en la lista nueva de datos*/
            List<Double> listData = createListDouble();

            //Pasamos por cada dato convirtiendolo
            foreach(string data in listOfData)
            {
                try
                {
                    //Parseamos el dato
                    double dataParseado = Double.Parse(data);
                    //Añadimos a la lista 
                    listData.Add(dataParseado);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    MessageBox.Show("Invalid data!","Error Deteted in Input",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                    
                }
            }

            //Retornamos la lista
            return listData;
        }

        /**
         Funcion encargada de hacer el proceso
         */
        private void process( List<Double> listOfData)
        {
            //Calcular el "ValorM^3"
            //FORMULA -> (estrato * 185)
            double valorM3 = 0.0;
            try
            {
                valorM3 = listOfData[3] * 185;
                Console.WriteLine("ValorM3 :: ", valorM3);

            }
            catch (Exception)
            {
                Console.WriteLine("ERROR, invalited input");
            }

            //Calcular el "Consumo"
            //FORMULA -> (lecturaActual - lecturaAnterios)
            double consumo = listOfData[1] - listOfData[2];

            //Calcular el "Aseo"
            //FORMULA -> (estrato * 370)
            double aseo = listOfData[3] * 370;

            //Calcular el "Subtotal"
            //FORMULA -> 
            double subtotal = (valorM3 * consumo) + aseo;

            //Calcular "Multa por Consumo"
            //FORMULA -> 
            double porcentaje = 10;
            //Variable por referencia
            double multaXconsumo = 0.0;
            //Validamos
            if (subtotal >= 40000)
            {
                multaXconsumo = ((porcentaje * subtotal) / 100);
            }

            //Calcular el "Total a Pagar"
            //FORMULA -> (subtotal + multaXconsumo)
            double totalPagar = (subtotal + multaXconsumo);

            //Calcular "Regalo"
            //Se valida que regalose le dara
            string regalo = "Calendario";
            if (totalPagar > 100000)
            {
                regalo = "Boleta";
            }


            // ASIGNAR datos en los campos
            txtValorM3.Text = valorM3.ToString();
            txtConsumo.Text = consumo.ToString();
            txtAseo.Text = aseo.ToString();
            txtSubtotal.Text = subtotal.ToString();
            txtMultaXconsumo.Text = multaXconsumo.ToString();
            txtTotalPagar.Text = totalPagar.ToString();
            txtRegalo.Text = regalo;

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
