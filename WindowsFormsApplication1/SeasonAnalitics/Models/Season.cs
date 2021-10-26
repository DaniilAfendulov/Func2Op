using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication
{
    public class Season
    {
        public string Name { get; } 
        public Mounth[] Mounths { get; private set; }
        public Season(string name)
        {
            Name = name;
            Mounths = new Mounth[3];
        }

        public void SetData(Weather[] datas)
        {
            int amount = datas.Length;
            int center = (amount-1)/2+1;
            float step = 1f / center;
            Weather[] sortedData = datas.OrderBy(d => d.Mounth).ToArray();
            Mounths[center] = new Mounth(1f, sortedData[center]);
            for(int i=0;i<center;i++)
            {
                float weight = i*step;
                Mounths[i] = new Mounth(weight, sortedData[center]);
                Mounths[amount-i] = new Mounth(weight, sortedData[center]);
            }

        }

    }
}