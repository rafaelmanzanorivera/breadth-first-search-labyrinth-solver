using System;
using System.Collections.Generic;

namespace Practica3Matematicas
{
    public class State
    {
       
        public String Action;
        public int x;
        public int y;
        public int moves;
        static int[,] laberinto = new int[,]
        {
                {4,6,12,6,10,14,10,14,14,12},
                {3,13,3,9,6,9,2,9,5,5 },
                {6,13,6,8,3,10,12,6,13,1},
                {1,5,3,14,12,6,9,5,3,12},
                {6,9,6,13,3,15,14,11,12,1},
                {5,6,9,5,4,5,5,4,3,12},
                {5,1,6,9,7,9,3,13,6,9},
                {5,6,13,2,11,10,14,13,3,12},
                {7,9,5,6,10,10,9,7,12,5},
                {3,8,3,11,8,2,10,9,3,9},
        };

        public State(int x, int y, string accion)
        {
            this.x = x;
            this.y = y;
            this.moves = laberinto[y,x];
            Action = accion;
        }

        public override bool Equals(Object obj)
        {
            return (this.x == ((State)obj).x && this.y == ((State)obj).y);
        }
         

        public List<State> Expand()
        {
            List<State> derivatedStates = new List<State>();
            int moves = this.moves;

            switch (moves)
            {
                case 1:
                    if (this.x >= 0 && this.x < 10 && this.y - 1 >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x, this.y - 1, "Norte"));
                    break;
                case 2:
                    if (this.x >= 0 && this.x + 1 < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x + 1, this.y, "Este"));
                    break;
                case 3:
                    if (this.x >= 0 && this.x + 1 < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x + 1, this.y, "Este"));
                    if (this.x >= 0 && this.x < 10 && this.y - 1 >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x, this.y - 1, "Norte"));
                    break;
                case 4:
                    if (this.x >= 0 && this.x < 10 && this.y >= 0 && this.y + 1 < 10)
                        derivatedStates.Add(new State(this.x, this.y + 1, "Sur"));
                    break;
                case 5:
                    if (this.x >= 0 && this.x < 10 && this.y >= 0 && this.y + 1 < 10)
                        derivatedStates.Add(new State(this.x, this.y + 1, "Sur"));
                    if (this.x >= 0 && this.x < 10 && this.y - 1 >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x, this.y - 1, "Norte"));
                    break;
                case 6:
                    if (this.x >= 0 && this.x + 1 < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x + 1, this.y, "Este"));
                    if (this.x >= 0 && this.x < 10 && this.y >= 0 && this.y + 1 < 10)
                        derivatedStates.Add(new State(this.x, this.y + 1, "Sur"));
                    break;
                case 7:
                    if (this.x >= 0 && this.x + 1 < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x + 1, this.y, "Este"));
                    if (this.x >= 0 && this.x < 10 && this.y >= 0 && this.y + 1 < 10)
                        derivatedStates.Add(new State(this.x, this.y + 1, "Sur"));
                    if (this.x >= 0 && this.x < 10 && this.y - 1 >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x, this.y - 1, "Norte"));
                    break;
                case 8:
                    if (this.x - 1 >= 0 && this.x < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x - 1, this.y, "Oeste"));
                    break;
                case 9:
                    if (this.x - 1 >= 0 && this.x < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x - 1, this.y, "Oeste"));
                    if (this.x >= 0 && this.x < 10 && this.y - 1 >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x, this.y - 1, "Norte"));
                    break;
                case 10:
                    if (this.x >= 0 && this.x + 1 < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x + 1, this.y, "Este"));
                    if (this.x - 1 >= 0 && this.x < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x - 1, this.y, "Oeste"));
                    break;
                case 11:
                    if (this.x >= 0 && this.x + 1 < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x + 1, this.y, "Este"));
                    if (this.x - 1 >= 0 && this.x < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x - 1, this.y, "Oeste"));
                    if (this.x >= 0 && this.x < 10 && this.y - 1 >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x, this.y - 1, "Norte"));
                    break;
                case 12:
                    if (this.x - 1 >= 0 && this.x < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x - 1, this.y, "Oeste"));
                    if (this.x >= 0 && this.x < 10 && this.y >= 0 && this.y + 1 < 10)
                        derivatedStates.Add(new State(this.x, this.y + 1, "Sur"));
                    break;
                case 13:
                    if (this.x - 1 >= 0 && this.x < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x - 1, this.y, "Oeste"));
                    if (this.x >= 0 && this.x < 10 && this.y - 1 >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x, this.y - 1, "Norte"));
                    if (this.x >= 0 && this.x < 10 && this.y >= 0 && this.y + 1 < 10)
                        derivatedStates.Add(new State(this.x, this.y + 1, "Sur"));
                    break;
                case 14:
                    if (this.x >= 0 && this.x + 1 < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x + 1, this.y, "Este"));
                    if (this.x - 1 >= 0 && this.x < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x - 1, this.y, "Oeste"));
                    if (this.x >= 0 && this.x < 10 && this.y >= 0 && this.y + 1 < 10)
                        derivatedStates.Add(new State(this.x, this.y + 1, "Sur"));
                    break;
                case 15:
                    if (this.x >= 0 && this.x + 1 < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x + 1, this.y, "Este"));
                    if (this.x - 1 >= 0 && this.x < 10 && this.y >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x - 1, this.y, "Oeste"));
                    if (this.x >= 0 && this.x < 10 && this.y >= 0 && this.y + 1 < 10)
                        derivatedStates.Add(new State(this.x, this.y + 1, "Sur"));
                    if (this.x >= 0 && this.x < 10 && this.y - 1 >= 0 && this.y < 10)
                        derivatedStates.Add(new State(this.x, this.y - 1, "Norte"));

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }


            return derivatedStates;
                        
        }

        public bool Contained(Queue<Nodo> nodeQueue)
        {
            foreach (Nodo n in nodeQueue)
            {
                if (n.Data.Equals(this))
                    return true;
            }
            return false;
        }


        //TODO EsMeta


    }
}
