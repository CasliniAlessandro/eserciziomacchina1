using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eserciziomacchina1
{
    public partial class Form1 : Form
    {
        auto auto;

        public Form1()
        {
            InitializeComponent();
            auto=new auto();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            auto.AccendiMotore();
            listView1.Items.Add("Motore acceso");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto.Spegnimento();
            listView1.Items.Add("Motore spento");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double velocità = Double.Parse(textBox1.Text);
            if (velocità>1)
            {
                
                auto.Accelerazione(velocità);
                listView1.Items.Add($"Velocità aumentata a {auto.Velocita}km/h");
            }
            else
            {
                auto.Spegnimento();
                listView1.Items.Add("Motore spento");
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double velocità = double.Parse(textBox2.Text);
            if (velocità>1)
            {
                auto.Decelerazione(velocità);
                listView1.Items.Add($"Velocità ridotta a {auto.Velocita}km/h");
            }
            else
            {
                auto.Spegnimento();
                listView1.Items.Add("Motore spento");
            }

        }
    }
}
