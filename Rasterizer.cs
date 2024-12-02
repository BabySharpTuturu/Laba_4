using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class Rasterizer
    {
        public Rasterizer()
        {

        }
        public void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public void Swap(ref float x, ref float y)
        {
            float temp = x;
            x = y;
            y = temp;
        }
        public Point[] Bresenham(PointF begin, PointF end)
        {
            var x0 = (int)begin.X;
            var y0 = (int)begin.Y;
            var x1 = (int)end.X;
            var y1 = (int)end.Y;

            List<Point> list = new List<Point>();
            var steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0); // Проверяем рост отрезка по оси икс и по оси игрек
                                                               // Отражаем линию по диагонали, если угол наклона слишком большой
            if (steep)
            {
                Swap(ref x0, ref y0); // Перетасовка координат вынесена в отдельную функцию для красоты
                Swap(ref x1, ref y1);
            }
            // Если линия растёт не слева направо, то меняем начало и конец отрезка местами
            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }
            int dx = x1 - x0;
            int dy = y1 - y0;
            int error = dx / 2; // Здесь используется оптимизация с умножением на dx, чтобы избавиться от лишних дробей
            int ystep = (y0 < y1) ? 1 : -1; // Выбираем направление роста координаты y
            int y = y0;
            for (int x = x0; x <= x1; x++)
            {
                list.Add(new Point(steep ? y : x, steep ? x : y)); // Не забываем вернуть координаты на место
                error -= Math.Abs(dy);
                if (error < 0)
                {
                    y += ystep;
                    error += Math.Abs(dx);
                }
            }
            return list.ToArray();
        }

        public Point[] Naive(PointF begin, PointF end)
        {
            var x0 = (int)begin.X;
            var y0 = (int)begin.Y;
            var x1 = (int)end.X;
            var y1 = (int)end.Y;

            List<Point> list = new List<Point>();
            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }
            // Если линия растёт не слева направо, то меняем начало и конец отрезка местами
            float dx = x1 - x0;
            if (dx == 0)
            {
                if (y1 < y0)
                {
                    Swap(ref y1, ref y0);
                }
                for (int y = y0; y <= y1; y++)
                {
                    list.Add(new Point(x1, y));
                }
                return list.ToArray();
            }
            float dy = y1 - y0;
            var b = (float)y0 - (float)x0 * dy / dx;
            bool steep = false;
            if (Math.Abs(dy) > Math.Abs(dx))
            {
                steep = true;
            }

            list.Add(new Point(x0, y0));
            list.Add(new Point(x1, y1));
            float temp;
            if (!steep)
            {
                if (x1 < x0)
                {
                    Swap(ref x1, ref x0);
                }
                for (float x = x0 + 1; x < x1; x++)
                {
                    list.Add(new Point((int)x, (int)Math.Round(dy / dx * x + b))); // Не забываем вернуть координаты на место
                }
            }
            else
            {
                if (y1 < y0)
                {
                    Swap(ref y1, ref y0);
                }
                for (float y = y0 + 1; y < y1; y++)
                {
                    list.Add(new Point((int)Math.Round((y - b) * dx / dy), (int)y)); // Не забываем вернуть координаты на место
                }
            }
            return list.ToArray();
        }
        public Point[] CircleBresenham(PointF center, int radius)
        {
            var x0 = (int)center.X;
            var y0 = (int)center.Y;
            List<Point> list = new List<Point>();
            int x = radius;
            int y = 0;
            int radiusError = 1 - x;
            while (x >= y)
            {
                list.Add(new Point(x + x0, y + y0));
                list.Add(new Point(y + x0, x + y0));
                list.Add(new Point(-x + x0, y + y0));
                list.Add(new Point(-y + x0, x + y0));
                list.Add(new Point(-x + x0, -y + y0));
                list.Add(new Point(-y + x0, -x + y0));
                list.Add(new Point(x + x0, -y + y0));
                list.Add(new Point(y + x0, -x + y0));
                y++;
                if (radiusError < 0)
                {
                    radiusError += 2 * y + 1;
                }
                else
                {
                    x--;
                    radiusError += 2 * (y - x + 1);
                }
            }
            return list.ToArray();
        }

        public List<KeyValuePair<PointF, float>> Wu(PointF begin, PointF end)
        {
            float ipart(float x)
            {
                return (int)Math.Floor(x);
            };

            float round(float x)
            {
                return ipart(x + 0.5f);
            };

            float fpart(float x)
            {
                return x - (float)Math.Floor(x);
            };

            float rfpart(float x)
            {
                return 1 - fpart(x);
            };
            bool reflOx = false;
            bool reflOy = false;
            List<KeyValuePair<PointF, float>> list = new List<KeyValuePair<PointF, float>>();
            var x0s = (int)begin.X;
            var y0s = (int)begin.Y;
            var x1s = (int)end.X;
            var y1s = (int)end.Y;
            var x0 = 0;
            var y0 = 0;
            var x1 = x1s - x0s;
            var y1 = y1s - y0s;

            if (x1 < 0)
            {
                reflOy = true;
                x1 *= -1;
            }
            if (y1 < 0)
            {
                reflOx = true;
                y1 *= -1;
            }
            var steep = Math.Abs(y1) > Math.Abs(x1);
            if (steep)
            {
                Swap(ref x0, ref y0);
                Swap(ref x1, ref y1);
            }
            void add(float x, float tmp, float intensity)
            {
                if (intensity < 0 || intensity > 1)
                {
                    return;
                }
                if (reflOy)
                {
                    if (!steep)
                    {
                        x *= -1;
                    }
                    else
                    {
                        tmp *= -1;
                    }
                }
                if (reflOx)
                {
                    if (!steep)
                    {
                        tmp *= -1;
                    }
                    else
                    {
                        x *= -1;
                    }

                }
                if (!steep)
                {
                    x += x0s;
                    tmp += y0s;
                }
                else
                {
                    tmp += x0s;
                    x += y0s;
                }
                if (steep)
                {
                    Swap(ref x, ref tmp);
                }
                if (end.X > begin.X)
                {
                    x = (int)Math.Floor(x);
                }
                else
                {
                    x = (int)Math.Ceiling(x);
                }
                if (end.Y > begin.Y)
                {
                    tmp = (int)Math.Floor(tmp);
                }
                else
                {
                    tmp = (int)Math.Ceiling(tmp);
                }
                list.Add(new KeyValuePair<PointF, float>(new PointF(x, tmp), intensity));
            }

            float dx = x1 - x0;
            float dy = y1 - y0;
            add(x0, y0, 1);
            add(x1, y1, 1);

            float gradient = dy / dx;
            float y = y0 + gradient;
            for (var x = x0 + 1; x < x1; x++)
            {
                add(x, y, rfpart(y));
                add(x, y + 1, fpart(y));
                y += gradient;
            }

            return list;

        }

        public Point[] CastlePitway(PointF begin, PointF end)
        {
            List<Point> list = new List<Point>();
            string reverse(string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
            // Координаты концов отрезка - (0,0) и (a,b)
            int x, y;
            y = (int)end.Y;
            x = (int)end.X - (int)end.Y;
            string m1 = "s";
            string m2 = "d";
            while (x != y)
            {
                if (x > y)
                {
                    x -= y;
                    m2 = m1 + reverse(m2);
                }
                else
                {
                    y -= x;
                    m1 = m2 + reverse(m1);
                }

            }
            var m = m2 + reverse(m1);
            int cur_X = (int)begin.X;
            int cur_y = (int)begin.Y;
            list.Add(new Point(cur_X, cur_y));
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] == 's')
                {
                    cur_X++;
                    list.Add(new Point(cur_X, cur_y));
                }
                else
                {
                    cur_X++;
                    cur_y++;
                    list.Add(new Point(cur_X, cur_y));
                }
            }
            list.Add(new Point((int)end.X, (int)end.Y));
            return list.ToArray();
        }

        public Point[] DDA(PointF begin, PointF end)
        {
            var x1 = (int)begin.X;
            var y1 = (int)begin.Y;
            var x2 = (int)end.X;
            var y2 = (int)end.Y;
            int deltaX = (int)Math.Abs(x2 - x1);
            int deltaY = (int)Math.Abs(y2 - y1);

            int signX = (x1 < x2) ? 1 : -1;
            int signY = y1 < y2 ? 1 : -1;
            int error = deltaX - deltaY;
            List<Point> list = new List<Point>();
            list.Add(new Point(x2, y2));
            while (x1 != x2 || y1 != y2)
            {
                list.Add(new Point(x1, y1));
                int error2 = error * 2;
                if (error2 > -deltaY)
                {
                    error -= deltaY;
                    x1 += signX;
                }
                if (error2 < deltaX)
                {
                    error += deltaX;
                    y1 += signY;
                }
            }
            return list.ToArray();
        }
    }
}