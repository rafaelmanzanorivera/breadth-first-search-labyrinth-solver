using System;
namespace Practica3Matematicas
{
    public class Matrix 
    {
        public int[,] Data;
        public int Rows;
        public int Cols;

        public Matrix(int[,] m, int r, int c)
        {
            this.Data = m;
            this.Rows = r;
            this.Cols = c;
        }

        public Matrix cpyMatrix()
        {
            Matrix newMatrix;
            int newR = this.Rows;
            int newC = this.Cols;
            int[,] newData = new int[newR, newC];

            for (int i = 0; i < newR; i++)
            {
                for (int j = 0; j < newC; j++)
                {
                    newData[i, j] = this.Data[i, j];
                }
            }
            newMatrix  = new Matrix(newData, newR, newC);
            return newMatrix;
        }


        public bool EqualMatrix(Matrix a)
        {
            if ((a.Rows != this.Rows) || (a.Cols != this.Cols))
                return false;

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    if (a.Data[i, j] != this.Data[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        //public bool GetNeighboorPositions(Matrix a, int i, int j)
        //{
            
        //}

        public Tuple<int, int> CoordinatesOfn(int value)
        {
            int w = Rows; // width
            int h = Cols; // height

            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    if (Data[x, y].Equals(value))
                        return Tuple.Create(x, y);
                }
            }

            return Tuple.Create(-1, -1);
        }

        public void Print()
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    if(this.Data[i, j] == 2)
                        Console.Write("#" + " ");
                    else
                        Console.Write(this.Data[i,j] + " ");
                }
                Console.Write("\n");
            }
        }



    }
}