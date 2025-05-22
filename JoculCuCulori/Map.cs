using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoculCuCulori
{
    internal class Map
    {
        #region Fields
        public static int rows = 25;
        public static int columns = 34;
        public static int size = 25;
        public static int top = 10;
        public static int left = 10;
        public static Random random = new Random();
        public static int noc = 6; // nuber of colors

        public int[,] values;
        public bool[,] visited;

        public static Color backColor = Color.LightGray;
        public static Color[] colors = new Color[]
        {
            backColor,
            Color.Red,
            Color.Green,
            Color.Blue,
            Color.Yellow,
            Color.Cyan,
            Color.Magenta,
            Color.White,
            Color.Gray,
            Color.DarkGray,
            Color.LightBlue,
            Color.LightGreen,
            Color.LightPink,
            Color.LightYellow,
            Color.LightCyan,
            Color.LightCoral,
            Color.LightSalmon,
        };
        #endregion

        #region Constructors
        public Map()
        {
            values = new int[rows, columns];
            visited = new bool[rows, columns];
            Init();
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        public void Init()
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    values[i, j] = random.Next(1, noc + 1);
        }

        public void Draw(Graphics handler)
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    int x = left + j * size;
                    int y = top + i * size;
                    

                    using (SolidBrush brush = new SolidBrush(colors[values[i, j]]))
                    {
                        handler.FillRectangle(brush, x, y, size, size);
                    }
                    using (Pen pen = new Pen(Color.Black, 1))
                    {
                        handler.DrawRectangle(pen, x, y, size, size);
                    }
                }
        }

        public void SetNull()
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    visited[i, j] = false;
        }

        public void PA(int i, int j, int value)
        {
            if(i >= 0 && j >= 0 && i < rows && j < columns && !visited[i, j] && values[i, j] == value)
            {
                visited[i, j] = true;
                PA(i - 1, j, value);
                PA(i + 1, j, value);
                PA(i, j - 1, value);
                PA(i, j + 1, value);
            }
        }

        public void Calculus()
        {
            int nof = 0; // number of visited cells

            // Count the number of visited cells (part of the selected group)
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (visited[i, j])
                        nof++;
            // If at least 3 cells are selected, set their values to 0 (remove them)
            if (nof >= 3)
            {
                for (int i = 0; i < rows; i++)
                    for (int j = 0; j < columns; j++)
                        if (visited[i, j])
                            values[i, j] = 0;
            }
        }

        public bool EtapR()
        {
            bool ok = true;
            for (int j = columns - 1; j >= 0; j--)
                for (int i = rows - 1; i > 0; i--)
                {
                    if (values[i, j] == 0 && values[i - 1, j] != 0)
                    {
                        int aux = values[i, j];
                        values[i, j] = values[i - 1, j];
                        values[i - 1, j] = aux;
                        ok = false;
                    }
                }
            return ok;
        }

        public bool EtapC()
        {
            bool ok = true;

            for (int j = 0; j < columns-1; j++)
                for (int i = 0; i < rows; i++)
                {
                    if (values[i, j] == 0 && values[i, j + 1] != 0)
                    {
                        int aux = values[i, j];
                        values[i, j] = values[i, j + 1];
                        values[i, j + 1] = aux;
                        ok = false;
                    }
                }
            return ok;
        }
        #endregion
    }
}
