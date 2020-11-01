using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб__работа_1
{
    class Warship
    { 
     public enum Direction
    {
        Up,

        Down,

        Left,

        Right
    }


    private float _startPosX;
    /// <summary>
    /// Правая кооридната отрисовки автомобиля
    /// </summary>
    private float _startPosY;
    /// <summary>
    /// Ширина окна отрисовки
    /// </summary>
    private int _pictureWidth;
    /// <summary>
    /// Высота окна отрисовки
    /// </summary>
    private int _pictureHeight;
    /// <summary>
    /// Ширина отрисовки автомобиля
    /// </summary>
    private const int carWidth = 100;
    /// <summary>
    /// Ширина отрисовки автомобиля
    /// </summary>
    private const int carHeight = 60;
    public float Weight { protected set; get; }
    public int MaxSpeed { protected set; get; }



    public Color MainColor { private set; get; }

    /// <summary>
    /// Дополнительный цвет
    /// </summary>
    public Color DopColor { private set; get; }

    public bool plaines { private set; get; }
    public bool Aerodrom { private set; get; }



    public Warship(int maxSpeed, float weight, Color mainColor, Color dopColor, bool aerodrom, bool sideSpoiler, bool plaines
)
    {
        MaxSpeed = maxSpeed;
        Weight = weight;
        MainColor = mainColor;
        DopColor = dopColor;
        plaines = sideSpoiler;
        Aerodrom = aerodrom;

    }
    public void setposition(int x, int y, int width, int height)
    {

        _startPosX = x;

        _startPosY = y;
        _pictureWidth = width;
        _pictureHeight = height;

    }
    public void MoveTransport(Direction direction)
    {



        float step = MaxSpeed * 100 / Weight;

        switch (direction)

        {
            case Direction.Right:

                if (_startPosX + step < _pictureWidth - carWidth - 208)
                {
                    _startPosX += step;
                }
                break;

            case Direction.Left:
                if (_startPosX - step > -20)
                {
                    _startPosX -= step;
                }
                break;

            case Direction.Up:
                if (_startPosY - step > 60)
                {
                    _startPosY -= step;
                }
                break;



            case Direction.Down:
                if (_startPosY + step < _pictureWidth - carWidth - 208)
                {
                    _startPosY += step;
                }
                break;
        }
    }



    public void DrawCar(Graphics g)
    {
        Pen pen = new Pen(Color.Black);


        //redbig
        Brush brRed = new SolidBrush(Color.Red);
        g.FillEllipse(brRed, _startPosX + 190, _startPosY + 13, 35, 80);
        //قاعدة الاسفل

        g.FillRectangle(Brushes.Teal, _startPosX + 15, _startPosY + 15, 185, 72);
        g.FillEllipse(Brushes.Teal, _startPosX + 30, _startPosY + 20, 285, 62);
        g.FillEllipse(Brushes.Goldenrod, _startPosX + 170, _startPosY + 35, 120, 30);
        //yellow





        g.DrawRectangle(pen, _startPosX + 40, _startPosY + 30, 140, 40);

        g.FillRectangle(Brushes.Goldenrod, _startPosX + 40, _startPosY + 30, 140, 40);


        g.DrawRectangle(pen, _startPosX + 80, _startPosY + 35, 150, 30);

        g.FillRectangle(Brushes.Goldenrod, _startPosX + 80, _startPosY + 35, 150, 30);




        if (plaines)
        {


            //xt
            g.DrawEllipse(pen, _startPosX + 45, _startPosY + 37, 25, 25);
            g.DrawEllipse(pen, _startPosX + 160, _startPosY + 45, 10, 10);

            g.DrawRectangle(pen, _startPosX + 55, _startPosY + 33, 140, 33);
            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 45, 140, 10);
            g.DrawRectangle(pen, _startPosX + 190, _startPosY + 38, 10, 25);
            g.DrawRectangle(pen, _startPosX + 170, _startPosY + 38, 10, 25);
            g.DrawRectangle(pen, _startPosX + 150, _startPosY + 38, 10, 25);

        }








        // plane
        g.FillEllipse(Brushes.Coral, _startPosX + 160, _startPosY + 87, 25, 10);
        g.FillEllipse(Brushes.Coral, _startPosX + 170, _startPosY + 83, 5, 18);

        g.FillEllipse(Brushes.Coral, _startPosX + 130, _startPosY + 87, 25, 10);
        g.FillEllipse(Brushes.Coral, _startPosX + 140, _startPosY + 83, 5, 18);

        g.FillEllipse(Brushes.Coral, _startPosX + 100, _startPosY + 87, 25, 10);
        g.FillEllipse(Brushes.Coral, _startPosX + 110, _startPosY + 83, 5, 18);

        g.FillEllipse(Brushes.Coral, _startPosX + 70, _startPosY + 87, 25, 10);
        g.FillEllipse(Brushes.Coral, _startPosX + 80, _startPosY + 83, 5, 18);

        //dbadh


        g.FillEllipse(Brushes.Coral, _startPosX + 95, _startPosY - 2, 40, 30);

        g.FillEllipse(Brushes.Coral, _startPosX + 110, _startPosY - 30, 10, 30);



        // rsas
        g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 56, 8, 8);

        g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 66, 8, 8);

        g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 46, 8, 8);


        g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY + 20, 8, 8);
        g.FillEllipse(Brushes.Sienna, _startPosX + 125, _startPosY + 20, 8, 8);
        g.FillEllipse(Brushes.Sienna, _startPosX + 97, _startPosY + 20, 8, 8);



        g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY + 9, 8, 8);
        g.FillEllipse(Brushes.Sienna, _startPosX + 125, _startPosY + 9, 8, 8);
        g.FillEllipse(Brushes.Sienna, _startPosX + 97, _startPosY + 9, 8, 8);



        g.FillEllipse(Brushes.Sienna, _startPosX + 111, _startPosY - 2, 8, 8);
        g.FillEllipse(Brushes.Sienna, _startPosX + 125, _startPosY - 2, 8, 8);
        g.FillEllipse(Brushes.Sienna, _startPosX + 97, _startPosY - 2, 8, 8);




        if (Aerodrom)
        {
            Brush spoiler = new SolidBrush(Color.Fuchsia);
            g.FillRectangle(spoiler, _startPosX + 190, _startPosY + 38, 10, 25);
            g.FillRectangle(spoiler, _startPosX + 170, _startPosY + 38, 10, 25);
            g.FillRectangle(spoiler, _startPosX + 150, _startPosY + 38, 10, 25);

            //قاعدة الاسفل pla
            g.FillEllipse(spoiler, _startPosX + 60, _startPosY + 80, 150, 30);
            g.FillRectangle(spoiler, _startPosX + 40, _startPosY + 81, 40, 20);

        }



        if (plaines)
        {


            //xt
            g.DrawEllipse(pen, _startPosX + 45, _startPosY + 37, 25, 25);
            g.DrawEllipse(pen, _startPosX + 160, _startPosY + 45, 10, 10);

            g.DrawRectangle(pen, _startPosX + 55, _startPosY + 33, 140, 33);
            g.DrawRectangle(pen, _startPosX + 80, _startPosY + 45, 140, 10);
            g.DrawRectangle(pen, _startPosX + 190, _startPosY + 38, 10, 25);
            g.DrawRectangle(pen, _startPosX + 170, _startPosY + 38, 10, 25);
            g.DrawRectangle(pen, _startPosX + 150, _startPosY + 38, 10, 25);

        }

    }




}

        }
