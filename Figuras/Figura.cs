using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace Figuras
{
        abstract class Figura
        {
            protected int X, Y;
            protected Pen pluma;
            protected int ancho, largo;
            

            public Figura(int x, int y)
            {
                X = x;
                Y = y;
                
                pluma = new Pen(Color.Aqua, 2);
                Random rnd = new Random();
                ancho = rnd.Next(10,80);
                largo = ancho;
            }

            public abstract void Dibuja(Form f);

            
        }

        class Rectangulo : Figura
        {
            public Rectangulo(int x, int y)
                : base(x, y)
            {
            }
            public override void Dibuja(Form f)
            {
                Graphics g = f.CreateGraphics();
                g.DrawRectangle(pluma, X, Y, ancho, largo);
                
            }
        }

        class Circulo : Figura
        {
            public Circulo(int x, int y)
                : base(x, y)
            {
            }
            public override void Dibuja(Form f)
            {
                Graphics g = f.CreateGraphics();
                g.DrawEllipse(pluma, X, Y, ancho, largo);
            }
        }
    }
   
