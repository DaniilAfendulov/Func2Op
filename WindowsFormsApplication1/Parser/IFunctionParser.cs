using System.Collections.Generic;

namespace FuncOperationsApplication
{
    public interface IFunctionParser
    {
        string[] GetFunctionsText(IEnumerable<Function> functions);
        string GetFunctionText(Function f);
        Function ParseFunction(string line);
        IEnumerable<Function> ParseFunctions(string[] lines);
    }
}