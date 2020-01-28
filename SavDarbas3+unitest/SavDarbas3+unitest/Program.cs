using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavDarbas3_unitest
{
    struct Point
    {
        private int X;
        private int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int taskasX
        {
            get { return X; }
            set { }
        }

        public int taskasY
        {
            get { return Y; }
            set { }
        }
    }
    struct Rectangle
    {
        private Point TopLeft;
        private Point BottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }
        public Point TTopLeft
        {
            get { return TopLeft; }
            set { }
        }
        public Point BBottomRight
        {
            get { return BottomRight; }
            set { }
        }

        public bool IsPointInReactangle(Point taskas)
        {
            if (taskas.taskasX > TopLeft.taskasX) && (BottomRight.taskasX > taskas.taskasX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    class Program { 
    
        static void Main(string[] args)
        {
            Point point = new Point(15, 3);
            Point topLeft = new Point(6, 9);
            Point buttomRight = new Point(5, 8);
            Rectangle rectangle = new Rectangle(topLeft, bottomRight);

            Console.WriteLine("Kvadrato taskai: {0}", rectangle.IsPointInReactangle(point));
            Console.ReadLine();

        }
    }
}
