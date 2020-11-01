using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static лаб__работа_1.Warship;
namespace лаб__работа_1
{
     
    public partial class Form1 : Form
    {
       
        private Warship car;
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
            Graphics gr = Graphics.FromImage(bmp);
            car.DrawCar(gr);
            pictureBoxCars.Image = bmp;



        }

        


        private void button1_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            car = new Warship(rnd.Next(100, 300), rnd.Next(100, 2000), Color.Blue,
           Color.Yellow,true,true,true);
            car.setposition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width,
           pictureBoxCars.Height);
            Draw();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    car.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    car.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    car.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    car.MoveTransport(Direction.Right);
                    break;
            }
            Draw();




        }

        
    }
}
