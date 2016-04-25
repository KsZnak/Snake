using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
     class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym ) // Конструктор  для инкапсуляции (должен иметь имя класса) 
        {
            x = _x; // переменным перисваются новые значения в конструкторе 
            y = _y;
            sym = _sym;

           

        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move ( int offset, Direction direction)
        {
            if (direction == Direction.right)
            {
                x = x + offset;
            }
            else if (direction == Direction.Left)
            {
                x = x - offset;
            }
            else if (direction == Direction.up)
            {
                y = y - offset;
            }
            else if (direction == Direction.down)
            {
                y = y + offset;
            }
                


        }
        public bool IsHit (Point p)
        {
            return p.x == this.x && p.y == this.y;
        }


        public void Draw()
        {
            Console.SetCursorPosition(x, y); // забирает значения переменных, преобразовывает в координаты  
            Console.Write(sym); // выводит символ по заданным координатам 
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
