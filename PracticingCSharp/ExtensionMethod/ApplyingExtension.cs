using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingCSharp.ExtensionMethod
{
    public class ApplyingExtension
    {
        public async Task AwaitStringAsync()
        {
            var result = new List<int>
            {
                1,2, GetAnotherListOfInt(), 7
            };

            var matrix = new List<double>
            {
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 }
            };

            var populations = new Dictionary<string, int>
            {
              { "China", 1_409_517_397 },
              { "India", 1_339_180_127 },
              { "USA", 324_459_463 },
              { "Indonesia", 263_991_379 },
              { "Brazil", 209_288_278 },
              GetAfricanCountries(),
              GetEuropeanCountries()
            };

            var advancedPopulations = new Dictionary<string, int>
            {
              { "China", 1,409,517,397 },
              { "India", 1,339,180,127 },
              { "USA", 324,459,463 },
              { "Indonesia", 263,991,379 },
              { "Brazil", 209,288,278 }
            };

            await "";
            
        }

        private Dictionary<string, int> GetEuropeanCountries()
        {
            return new Dictionary<string, int>
            {
              { "China", 1,409,517,397 },
              { "India", 1,339,180,127 },
              { "USA", 324,459,463 },
              { "Indonesia", 263,991,379 },
              { "Brazil", 209,288,278 }
            };
        }

        private Dictionary<string, int> GetAfricanCountries()
        {
            return new Dictionary<string, int>
            {
              { "China", 1,409,517,397 },
              { "India", 1,339,180,127 },
              { "USA", 324,459,463 },
              { "Indonesia", 263,991,379 },
              { "Brazil", 209,288,278 }
            };
        }

        private List<int> GetAnotherListOfInt()
        {
            return new List<int> { 4,5,6 };
        }
    }
}
