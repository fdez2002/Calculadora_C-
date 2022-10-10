using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * @autor Antonio Fernandez Villa 2ºDAM
 * 
 * Diseña una interfaz de una calculadora. 
 * Debe de tener la funcionalidades típicas de una calculadora simple. 
 * Al realizar una operacon con un operador igual te deja añadir valores hasta que cambies de operadores o pulser el boton igual.
 * Al cambiar de operador realiza el resultado de la anterior operacion y con ese resulatado comienzas la nueva operacion
 */

namespace CalculadoraWindows
{
    /*
     * En c# tenemos los enumeradores y sirve para definir todos los valores posibles uqe puede contener un dato, en este caso,
     * he agregado todas las operaciones posibles que hay en esta calculadora.
     * Con este metodo tambien conseguimos que sea mas legible el codigo.
     */
public enum Operacion
    { 
        NoDefinido = 0, 
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
        Raiz = 5,
        Elevar2 = 6,
        

    }
    public partial class Form1 : Form
    {
        string signoN;
        double resultado = 0, resultadoDiviMulti = 1;//Almacenamos los resultados
        ArrayList valores = new ArrayList();//Array que contendrá los distintos valores que se agreguen
        Operacion operador = Operacion.NoDefinido;//Variable de timo enumerador y por defecto comenzara con noDefinida
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Este metodo obtiene los distintos botones con numeros y los guarda en la variable boton.
         * Para que esto sea posible que poner que cuando el boton haga click inice el metodo
         */
        private void AgregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);


            //Comprobamos si textBoxNumeros es igual a 0, si es asi los vacia y le agrega el boton pulsado
            if (textBoxNumeros.Text == "0")
            
                textBoxNumeros.Text = "";

                textBoxNumeros.Text += boton.Text;
            

        }
        /*
         * Agregamos los valores introducidos  en el textBoxNumeros al array
         */
        private void IntroducirDatosArray()
        {
            valores.Add(Convert.ToDouble(textBoxNumeros.Text));
        }
        /*
         * Metodo que obtiene el boton pulsado y lo guarda en la variable botonOperadores.
         * Al igual que el anterior metodo AgregarNumero obtenemos el boton pulsado y lo alamacenamos; 
         * este metodo solo se usara para los operadores
         */
        private void AgregarOperador(object sender, EventArgs e)
        {
            var botonOperadores = ((Button)sender);//Almacenamos el operador

            //Comporbamos si los resultados estan con los valores por defectos, si es asi llamamos al metodo
            if((resultado == 0) && (resultadoDiviMulti == 1))
            {
                IntroducirDatosArray();

            }

            //Comprobamos si hay el boton es diferente al boton que se pulso anteriormente 
            if ((botonOperadores.Text != signoN) && (signoN != null) && (botonOperadores.Text != "=") )
            {
                Operaciones();
            }

            //Este switch evalua que dato hay almacenado en botonOperadores, dependiendo del dato asignara a operador una operacion
            switch (botonOperadores.Text)
            {

                case "+":
                    operador = Operacion.Suma; //Asignamos al operador la Operacion suma
                    break;
                case "-":
                    operador = Operacion.Resta;//Asignamos al operador la Operacion resta
                    break;
                case "*":
                    operador = Operacion.Multiplicacion;//Asignamos al operador la Operacion multiplicacion

                    break;
                case "/":
                    operador = Operacion.Division;//Asignamos al operador la Operacion division
                    break;
                case "√":
                    operador = Operacion.Raiz;//Asignamos al operador la Operacion raiz
                    break;
                case "x²":
                    operador = Operacion.Elevar2;//Asignamos al operador la Operacion elevar a dos
                    break;
            }

            //Comprobamos si se ha selecionado la raiz, ya que al pulsar la raiz se mostrar en el txtResultado de diferente manera
            if ((operador == Operacion.Raiz) || (operador == Operacion.Elevar2))
            {
                if (operador == Operacion.Raiz)
                {
                    textBoxHistorial.Text += botonOperadores.Text + "(" + textBoxNumeros.Text + ")";
                }
                else
                {
                    textBoxHistorial.Text += textBoxNumeros.Text + "²";
                }

                Operaciones();

            }
            else
            {

                textBoxHistorial.Text += textBoxNumeros.Text + botonOperadores.Text;
                textBoxNumeros.Text = "0";

            }


            signoN = botonOperadores.Text; //Guardamos en una variable el contenido de botonOperadores


        }

        /*
         * Con este metodo conseguimos realizar las diferentes operaciones que hay en la calculadora.
         * El switch comprueba el contenido de operador del metodo enum y dependiendo del resultado ira a las distintas opciones
         */
        private void Operaciones()
        {
            switch (operador)
            {

                case Operacion.Suma:
                    foreach (double numeros in valores)//Recorremos el array y vamos sumando su contenido
                    {
                        resultado += numeros;
                    }
                    break;
                case Operacion.Resta:
                    //En la resta debemos comprobar si resultado es igual a 0 ya que de la otra forma nos saldria un resultado negativo
                    //empezando a operar por la resta
                    if (resultado == 0)
                    {

                        resultado = (double)valores[0];


                        for (int i = 1; i < valores.Count; i++)
                        {

                            resultado -= (double)valores[i];
                        }
                    }
                    else
                    {
                        foreach (double numeros in valores)
                        {
                            resultado -= numeros;
                        }
                    }
                    break;
                case Operacion.Division:

                    //En la division tenemos que comprobar si el resultado esta vacio (resultado = 0),
                    //si es asi el primer valor del array lo guardaremos y empezaremos a realizar la division.
                    //Si no e sigual a 0 haremos la division con el contenido del resultado
                    if (resultado == 0)
                    {
                        
                        resultadoDiviMulti = (double)valores[0];
                        

                        for (int i = 1; i < valores.Count; i++)
                        {
                            
                            resultadoDiviMulti /= (double)valores[i];
                        }
                        resultado = resultadoDiviMulti;
                    }
                    else
                    {
                        foreach (double numeros in valores)
                        {
                            resultado /= numeros;
                        }
                    }

                    break;
                case Operacion.Multiplicacion:
                    if (resultado == 0)
                    {
                        foreach (double numeros in valores)
                        {
                            resultadoDiviMulti *= numeros;
                        }
                        resultado = resultadoDiviMulti;
                    }
                    else
                    {
                        foreach (double numeros in valores)
                        {
                            resultado *= numeros;
                        }
                    }
                    break;
                case Operacion.Raiz:
                    
                    resultado = Math.Sqrt(Convert.ToDouble(textBoxNumeros.Text));//Con este metodo nos ayuda a realizar directamente la operacion de raiz
                    break;
                case Operacion.Elevar2:

                    resultado = Math.Pow((Convert.ToDouble(textBoxNumeros.Text)), 2);//Nos eleva directamente al numero que hemos asignado, en este caso 2
                    break;
            }
            
           
            valores.Clear();//Limpiamos el array


            
            resultadoOperacion();
        }

        /*
         * Mostramos por pantalla el resultado de la operacion
         */
        private void resultadoOperacion()
        {
            if ((operador == Operacion.Raiz) || (operador == Operacion.Elevar2))
            {
                textBoxHistorial.Text +=  "=";
                textBoxNumeros.Text = Convert.ToString(resultado);

            }
            else
            {
                textBoxHistorial.Text += textBoxNumeros.Text + "=";
                textBoxNumeros.Text = Convert.ToString(resultado);


            }

        }

        /*
         * Método que elimina de uno en uno los datos que hay en textBoxNumeros. 
         * Cada click del boton buttonBorrarUno_Click elimina un valor del contenido de la caja
         * 
         */
        private void buttonBorrarUno_Click(object sender, EventArgs e)
        {
            //Comprobamos si la longitud de la caja es mayor a uno.
            //
            //Si la longitud es menor que 1, no habra valores que leer.
            
            if (textBoxNumeros.Text.Length > 1)
            {
                textBoxNumeros.Text  = textBoxNumeros.Text.Substring(0, textBoxNumeros.TextLength -1);//elimina de la posicion 0 a la longitud del textBoxNumeros

                //Cuando la longitud del textBoxNumeros sea 0, le agregamos un 0 al  textBoxNumeros
                if (textBoxNumeros.Text.Length == 0)
                {
                    textBoxNumeros.Text = "0";
                }
            }
            else
            {
                textBoxNumeros.Text = "0";
            }
        }
        /*
         *Con este metodo controlamos y permitimos la entrada de comas para los numeros decimales
         */
        private void buttonPuntoDecimal_Click(object sender, EventArgs e)
        {
            if (textBoxNumeros.Text.Contains(","))//Comprobamos si textBoxNumeros contiene alguna coma, si es asi nos salimos del if y no agregamos comas
            { 
                return;
            }
            textBoxNumeros.Text += ",";
        }

        /*
        * Este metodo nos inicia todas las variables por defecto a cuando se inico la calculadora.
        * Ademas limpia los diferentes textbox de la calculadora
        */

        private void buttonBorrarTodo_Click(object sender, EventArgs e)
        {
            signoN = null;
            resultado = 0;
            resultadoDiviMulti = 1;
            valores.Clear();
            operador = Operacion.NoDefinido;
            textBoxNumeros.Text = "0";
            textBoxHistorial.Text = "";

        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            IntroducirDatosArray();
            Operaciones();
            signoN = null;
        }

       
       
    }
}
