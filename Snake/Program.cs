﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // установка размера консоли 

            Console.SetBufferSize(80,25);

            // отрисовка рамочки
            
            HorizontalLine upline = new HorizontalLine(0,78,0,'+');
            upline.Drown();

            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
            downline.Drown();

            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            leftline.Drown();

            VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
            rightline.Drown();

            // отрисовка точки

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.right);
            snake.Drown();

            FoodCreator foodcreator = new FoodCreator(80, 25, '#');
            Point food = foodcreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat (food))

                {
                    food = foodcreator.CreateFood();
                    food.Draw();
                  
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
               
            }




         
            
        }
        
        
    }
}
