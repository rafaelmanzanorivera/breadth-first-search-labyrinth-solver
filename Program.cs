using System;
using System.Collections;
using System.Collections.Generic;

namespace Practica3Matematicas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            

            // Otras configuraciones para pruebas

            // 3x3
            //int[,] arrayMeta =  new int [,] { { 3, 7 ,1}, { 6, 8 ,5 }, { 4, 9, 2 }};
            //int[,] arrayInicio = new int[,] { { 1,2,3}, { 4,5,6}, { 7,8,9} };

            //Matrix meta = new Matrix(arrayInicio, 3, 3);
            //Matrix ini = new Matrix(arrayMeta, 3, 3);

            // 3x2
            //int[,] arrayMeta = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //int[,] arrayInicio = new int[,] { { 3, 6 }, { 1 ,4 }, { 2, 5} };

            //int[,] arrayMeta = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //int[,] arrayInicio = new int[,] { { 2, 6 }, { 5, 4 }, { 3, 1 } };
             
            //int[,] arrayMeta = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //int[,] arrayInicio = new int[,] { { 2, 6 }, { 4, 4 }, { 3, 1 } };

            //Matrix meta = new Matrix(arrayMeta,3,2);
            //Matrix ini = new Matrix(arrayInicio,3,2);

            // 2x2
           // int[,] arrayMeta = new int[,] { { 1, 2 }, { 3, 4 } };
            //int[,] arrayInicio = new int[,] { { 2, 3 }, { 4, 1 } };



            //Matrix meta = new Matrix(arrayMeta, 2, 2);
            //Matrix ini = new Matrix(arrayInicio, 2, 2);



            State stateMeta = new State(5,9,"Meta");
            State stateIni = new State(0,0,"ini"); 

            Search b = new Search(stateIni,stateMeta);
            Nodo n = b.RunSearch();

            Stack<Nodo> s = new Stack<Nodo>();

            while (n.FatherNode != null)
            {
                s.Push(n);
                n = n.FatherNode;
            }


            while(s.Count != 0)
            {
                n = s.Pop();
                Console.WriteLine(n.Data.Action);
                Console.WriteLine("[{0},{1}, moves: {2}", n.Data.x, n.Data.y, n.Data.moves);
            }




            Console.ReadLine();



            //Console.WriteLine(a.EqualMatrix(b));
            //Console.WriteLine(b.EqualMatrix(c));

            //Console.WriteLine(a.CoordinatesOfn(1));
            //Console.WriteLine(a.CoordinatesOfn(2));
            //Console.WriteLine(a.CoordinatesOfn(3));
            //Console.WriteLine(a.CoordinatesOfn(4));

            //a.Print();
            ////b.Print();
            ////c.Print();
            ////d.Print();
            //State e = new State(a, "d");

            //e.Expand();

        }
    }
}
