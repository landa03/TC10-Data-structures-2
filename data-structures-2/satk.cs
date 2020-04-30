using System;
using System.Collections.Generic;

namespace data_structures_2
{
    class stak
    {
        
        private List<int>elem = new List<int>();
        

        //push
        public void Push(int etopush)
        {
            elem.Add(etopush);
        }
        public int pop()
        {
            int lastindex = elem.Count - 1;
            elem.RemoveAt(lastindex);
            return lastindex;
        }
        public override string ToString()
        {
            string stakstring ="";
            for (int i = 0; i < elem.Count; i++)
            {
                int insersi = elem.Count - i - 1;
                stakstring += elem[i];
                stakstring += "\n";
            }
            return stakstring;
        }
        public int top()
        {
            int lastIndex = elem.Count - 1;

            int lastElement = elem[lastIndex];

            return lastElement;
        }
        public int botom()
        {
            return elem[0];
        }
        
    }
}
