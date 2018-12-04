using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Memorama
{
    public partial class Nivel1 : Form
    {
        Random random = new Random(); //Funcion random para los caracteres aleatorios
        List<string> imagenes = new List<string>() //Declaracion de una lista para almacenar los caracteres
        {
            "p","p","N","N",",",",","k","k", //Datos que contendra la lista
            "b","b","v","v","w","w","z","z"
        };

        Label primerclick, segundoclick; // Funcion Label con declaracion de dos variables
        public Nivel1()
        {
            InitializeComponent();
            MecanicaJuego(); // Inicializacion del metodo MecanicaJuego
            conteo = 0; //Contador para el timer de contra reloj 
        }
       
        private void MecanicaJuego() // Metodo MecaniJuego
        {
            Label label; //Funcion del label con declaración de variable label(etiqueta)
            int numerorandom; // Declaracion de variable entera numerorandom

            for (int i=0; i<tableLayoutPanel1.Controls.Count;i++) // Uso de un ciclo for para que aparezcan los caracteres en el panel
            {
                if(tableLayoutPanel1.Controls[i] is Label) //Conficion Si panel es etiqueta hacer lo siguiente
                {
                    label = (Label)tableLayoutPanel1.Controls[i]; // Etiqueta se le asignara el valor del panel con los controles
                } 
                else //Condicion Si no
                {
                    continue; // Cotinuar con la función
                }

                numerorandom = random.Next(0, imagenes.Count); // Generador del caracter aleatorio
                label.Text = imagenes[numerorandom]; // Se imprimiran los caracteres en los label del panel

                imagenes.RemoveAt(numerorandom); // Remueve el elemento situado en la lista
            }
        }


        private void Label_Click(object sender, EventArgs e) // Metodo Label _Click , evento generado al dar click a las etiquetas
        {
            if(primerclick!=null && segundoclick != null) // Si primer click es igual o diferente a Null y segundo click es igual o diferente a null entonces
            {
                return; // Regresa el valor
            }

            Label LabelClickeado = sender as Label;  // Funcion del label es label clickeado se le asignara el valor a la etiqueta

            if (LabelClickeado==null) // Condición Si la etiqueta clickeada es igual igual a Null entonces has lo siguiente
            {
                return; // Regresa el valor obtenido 
            }

            if(LabelClickeado.ForeColor==Color.Black) // Condicion Si el color de la etiqueta clickeada es igual igual al color negro entonces
            {
                return; // Regresa el valor
            } 

            if (primerclick == null) // Condición Si primerClick es igual igual a Null
            {
                primerclick = LabelClickeado; // Entonces primer click sera igual al label clickeado
                primerclick.ForeColor = Color.Black; // Entonces el primer Click sera igual al color negro
                return; // Regresa el valor obtenido
            }

            segundoclick = LabelClickeado; // SegundoClick es igual al labelClikeado
            segundoclick.ForeColor = Color.Black;// El color primario sera negro

            Ganador(); // Llamado al metodo Ganador 
            if(primerclick.Text==segundoclick.Text) //Condicion Si el primer click es igual igual al segundo click hacer lo siguiente
            {
                primerclick = null; //Valor del primer click sera null
                segundoclick = null; //Valor del segundo click sera null

            } 
            else // Si no
            Timer.Start(); // Inicio del timer
        } 

        private void Ganador() // Metodo Ganador
        {
            Label label; // Declaracion de variable Label 
            for (int i=0; i<tableLayoutPanel1.Controls.Count;i++) // Uso del ciclo for para recorrer los espacio del panel
            {
                label = tableLayoutPanel1.Controls[i] as Label; // A la variabel label se le asignara el valor del panel como etiqueta

                if (label != null && label.ForeColor == label.BackColor) // Condicion Si la variable label es diferente o igual a null y el color de las etiquetas es negro
                    return; // Regresa el valor 
            }
            MessageBox.Show("Felicidades haz logrado completar el nivel :)"); // Mensaje en pantalla para felicitar al usuario por haber ganado:)
        }

        private void Timer_Tick(object sender, EventArgs e) // Metodo del Timer al dar un Tick
        {
            Timer.Stop(); // El timer se detendra

            primerclick.ForeColor = primerclick.BackColor; // Asignacion de color al primer click se le asignara el color de fondo que contenga el primer click
            segundoclick.ForeColor = segundoclick.BackColor;// Asignacion de color al segundo click se le asignara el color de fondo que contenga el segundo click

            primerclick = null; // Primer click igual a null
            segundoclick = null; // Segundo click igual a null
        }

     
        private void BtnInicio_Click(object sender, EventArgs e) //Metodo del evento del BotonInicio al dar click
        {
            if (MessageBox.Show("Deseas jugar en modo contra reloj? (30 SEGUNDOS)? ", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) // Se le mostrara una ventana emergente al usuario de si quiere activar el modo contra reloj
            {
                BtnInicio.Enabled = false; // Al elegir opcion el mismo boton se congelara para evitar otro ingreso
            }
            else // Condicion Si no
            {
                this.Close(); // Se cerrara dicho formulario
                Nivel1 frm = new Nivel1(); // Creacion del objeto
                frm.Show();// Mostrara el formulario nivel 1
            }
            TmrPrueba.Enabled = true; // Empezara a correr el tiempo en el modo contra reloj

        }
        private int conteo;// Declaracion de variable privada entera conteo
        private void TmrPrueba_Tick(object sender, EventArgs e) // Evento generado del TimerPrueba(Modo contra reloj)
        {
            conteo++; // Se le sumara 1 al contador
            lblValor.Text = conteo.ToString(); // Etiqueta level se le asignara el valor de la variable conteo
            if (conteo == 30) // Si conteo es igual al valor 30
            {
                TmrPrueba.Enabled = false; // Se deshabilitara el timer Prueba
                if (MessageBox.Show("Te has quedado sin tiempo , por lo tanto haz perdido:( ", "salir", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.Yes) // Se le desplegara mensaje al usuario de que perdio
                {
                    this.Close(); // Al dar Ok cerrara esta forma
                    Niveles frm = new Niveles(); // Creacion del objeto Niveles
                    frm.Show(); // Mostrara la forma niveles
                }
                else // Condición Si no
                {
                    this.Close(); // Cerrara dicha ventana
                    Niveles frm = new Niveles(); // Creación del objeto niveles
                    frm.Show();// Mostrara la forma niveles
                }
            }
            else // Condición Si no 
            {                
                Label label; // Declaración de la variable label 
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++) // Ciclo for para recorrer todo los elementos de el panel
                {

                    label = tableLayoutPanel1.Controls[i] as Label; // Asignacion del valor de las etiquetas a la variable label

                    if (label != null && label.ForeColor == label.BackColor) // Condición Si la variable etiqueta es igual o diferente a null y la etiqueta tiene el color primario igual igual a color de fondo
                        return;// Regresa el valor
                    
                }
                TmrPrueba.Enabled = false; // El TimerPrueba se deshabilita
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e) // Evento al dar click al boton Restar
        {
            this.Close(); // Cerrara la forma actual
            Nivel1 N1 = new Nivel1();// Creación del objeto Nivel1
            N1.Show();// Mostrara la forma Nivel1

           
        }

        private void Nivel1_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e) // Evento al dar click al boton Regresar
        {
            this.Close(); // Cerrar el formulario actual
            Niveles frm = new Niveles(); // Creación del objeto niveles
            frm.Show();// Mostrara la forma niveles

        }



       
    }
}
