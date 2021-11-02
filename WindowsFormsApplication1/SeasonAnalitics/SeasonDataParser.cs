using FuncOperationsApplication.Analys;
using FuncOperationsApplication.SeasonAnalitics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOperationsApplication.SeasonAnalitics
{
    public class SeasonDataParser : DataParser<Season>
    {
        public SeasonDataParser() : base(new string[] { "температура", "количество осадков"}, ParseSeason)
        {
        }

        private static Season ParseSeason(string line)
        {
            int val0 = int.Parse(line);
            return
                val0 <= 2 ? Season.Winter :
                val0 <= 5 ? Season.Spring :
                val0 <= 8 ? Season.Summer :
                val0 <= 11 ? Season.Autumn :
                Season.Winter;
        }
    }
}
