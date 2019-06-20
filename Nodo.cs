using System;
using System.Collections.Generic;

namespace Practica3Matematicas
{
    public class Nodo
    {
        public Nodo FatherNode { get; set; }
        public State Data { get; set; }
        public int ID;

        public Nodo(Nodo father, State dat)
        {
            this.FatherNode = father;
            this.Data = dat;
        }


    }
}
