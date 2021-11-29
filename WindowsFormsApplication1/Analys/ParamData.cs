using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication.Analys
{
    public struct ParamData<T>
    {
        public string Name;
        public T AssociatedAnswer;
        public float[] Data;

        public ParamData(T associatedAnswer, float[] data, string name)
        {
            AssociatedAnswer = associatedAnswer;
            Data = data;
            Name = name;
        }
    }
}
