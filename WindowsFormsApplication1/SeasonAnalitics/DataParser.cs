using FuncOperationsApplication.Analys;
using FuncOperationsApplication.SeasonAnalitics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication.SeasonAnalitics
{
    public class DataParser<T>
    {
        private readonly string[] _paramsNames;
        private readonly Func<string, T> AssociatedAnswerParsingMethod;
        public DataParser(string[] paramsNames, Func<string, T> associatedAnswerParsingMethod)
        {
            _paramsNames = paramsNames;
            AssociatedAnswerParsingMethod = associatedAnswerParsingMethod;
        }
        public ParamData<T>[] Parse(string[] lines)
        {
            List<ParamData<T>> result = new List<ParamData<T>>();
            var allData = lines.Select(l => ParseLine(l)).ToArray();
            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < allData[0].Length; j++)
                {
                    if (result.Exists(el =>
                        el.AssociatedAnswer.Equals(allData[i][j].AssociatedAnswer) &&
                        el.Name == allData[i][j].Name))
                    {
                        var element = result.Find(el =>
                            el.AssociatedAnswer.Equals(allData[i][j].AssociatedAnswer) &&
                            el.Name == allData[i][j].Name);
                        element.Data = element.Data.Concat(allData[i][j].Data).ToArray();
                        continue;
                    }
                    result.Add(allData[i][j]);
                }
            }            
            return result.ToArray();
        }

        private ParamData<T>[] ParseLine(string line)
        {
            string[] parts = line.Split(' ', '\t');            
            ParamData<T>[] result = new ParamData<T>[parts.Length - 1];
            T associatedAnswer = AssociatedAnswerParsingMethod(parts[0]);
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new ParamData<T>(associatedAnswer, new float[] { float.Parse(parts[i + 1]) }, _paramsNames[i]);
            }
            return result;
        }
    }
}
