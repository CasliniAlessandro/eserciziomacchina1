using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eserciziomacchina1
{
    public class auto
    {
        private bool MotoreAcceso;
        private double velocità;
        private int marcia;

        public auto()
        {
            MotoreAcceso = false;
            velocità = 0;
            marcia = 0; 
        }

        public void AccendiMotore()
        {
            MotoreAcceso = true;
            MessageBox.Show("motore acceso");
        }
        public void Spegnimento()
        {
            MotoreAcceso = false;
            velocità= 0;
            marcia = 0; 
            MessageBox.Show("motore spento");
        }

        public void Accelerazione(double valore)
        {
            if (MotoreAcceso)
            {
                velocità += valore;
                MessageBox.Show($"Velocità aumentata a {velocità} km/h");
            }
            else
            {
                MessageBox.Show("Il motore è spento. Impossibile accelerare");
            }
        }

        public void Decelerazione(double valore)
        {
            if (MotoreAcceso)
            {
                if (velocità - valore >= 0)
                {
                    velocità-= valore;
                    MessageBox.Show($"Velocità ridotta a {velocità} km/h");

                }
                else
                {
                    velocità = 0;
                    MessageBox.Show("La velocità è già a 0 km/h");
                }
            }
            else
            {
                MessageBox.Show("Il motore è spento impossibile decelerare");
            }
        }
            

    }
}
