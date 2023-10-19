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
        private bool _motoreAcceso;
        private double _velocita;
        private int _marcia;

        public double Velocita
        {
            get { return _velocita; }
            set { _velocita = value; }
        }

        public int Marcia
        {
            get { return _marcia; }
            set { _marcia=value; }
        }

        public auto()
        {
            _motoreAcceso = false;
            _velocita = 0;
            _marcia = 0; 
        }

        public void AccendiMotore()
        {
            _motoreAcceso = true;
           
        }
        public void Spegnimento()
        {
            _motoreAcceso = false;
            _velocita= 0;
            _marcia = 0; 
            
        }

        public void Accelerazione(double valore)
        {
            if (_motoreAcceso)
            {
                _velocita += valore;

            }

        }

        public void Decelerazione(double valore)
        {
            if (_motoreAcceso)
            {
                if (_velocita - valore >= 0)
                {
                    _velocita -= valore;
                }
                else
                {
                    _velocita = 0;
                    
                }
            }

        }
            

    }
}
