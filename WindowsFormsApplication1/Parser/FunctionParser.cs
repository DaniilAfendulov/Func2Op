using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication
{
    public class FunctionParser : IFunctionParser
    {
        private readonly IPointParser _pointParser;
        public FunctionParser(IPointParser pointParser)
        {
            _pointParser = pointParser;
        }
        public Function ParseFunction(string line)
        {
            return FuncOp.GetFunc(_pointParser.ParsePoints(line));
        }
        public IEnumerable<Function> ParseFunctions(string[] lines)
        {
            return lines.Select(line => ParseFunction(line));
        }

        public string GetFunctionText(Function f)
        {
            return _pointParser.GetPointsText(f.Points);
        }

        public string[] GetFunctionsText(IEnumerable<Function> functions)
        {
            return functions.Select(f => GetFunctionText(f)).ToArray(); ;
        }
    }
}
