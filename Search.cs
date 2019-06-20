using System;
using System.Collections.Generic;

namespace Practica3Matematicas
{
    public class Search
    {
        State inicialState;
        State goalStates;

        Queue<Nodo> openNodes;

        Nodo nodoEvaluado;

        Queue<Nodo> Nodes;


        public Search(State ini, State goal)
        {
            this.inicialState = ini;
            this.goalStates = goal;
        }

        private Boolean EsMeta(Nodo nodoCandidato)
        {
            return ( nodoCandidato.Data.Equals(goalStates) );
        }


        public Nodo RunSearch()
        {
            openNodes = new Queue<Nodo>();
            Nodes = new Queue<Nodo>();

            //Introducir nodo inicial en la cola
            Nodo ininode = new Nodo(null, inicialState);
            openNodes.Enqueue(ininode);
            Nodes.Enqueue(ininode);
            int node = 1;




            while (true)
            {
                Nodo nodoEvaluado;

                if (openNodes.Count == 0)
                {
                    return null;
                }

                //Sacas primer elemento
                nodoEvaluado = openNodes.Dequeue();


                if (EsMeta(nodoEvaluado))
                    return nodoEvaluado;

                foreach (State n in nodoEvaluado.Data.Expand())
                {
                    if(!(n.Contained(Nodes)))//Check if known node memory optimization
                    {
                        Nodo NuevoNodo = new Nodo(nodoEvaluado, n);
                        openNodes.Enqueue(NuevoNodo);
                        Nodes.Enqueue(NuevoNodo);
                        Console.WriteLine("Open nodes: " + node);
                        node++;
                    }
                    Console.WriteLine("Already in list. ");


                }


            }

        }
    }
}
