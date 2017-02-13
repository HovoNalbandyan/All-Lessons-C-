using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverride
{    
    // Использовать ключевое слово operator, можно только вместе с ключевым словом static.  
        public struct Point : IComparable
        {
            // Координаты точки.
            private int x, y;
            public Point(int xPos, int yPos)
            {
                x = xPos;
                y = yPos;
            }

            public static bool operator <(Point p1, Point p2)
            {
                return (p1.CompareTo(p2) < 0);
            }

            public static bool operator >(Point p1, Point p2)
            {
                return (p1.CompareTo(p2) > 0);
            }

            public static bool operator <=(Point p1, Point p2)
            {
                return (p1.CompareTo(p2) <= 0);
            }

            public static bool operator >=(Point p1, Point p2)
            {
                return (p1.CompareTo(p2) >= 0);
            }        
            // Реализация интерфейса IComparable.

            public int CompareTo(object obj)
            {
                if (obj is Point)
                {
                    Point p = (Point)obj;

                    if (this.x > p.x && this.y > p.y)
                    {
                        return 1;
                    }
                    else if (this.x < p.x && this.y < p.y)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
