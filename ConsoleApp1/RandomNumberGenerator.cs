using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RandomNumberGenerator : NumberGeneratorBase
    {
        private Random random = new Random();

        public RandomNumberGenerator(double limit)
        {
            this.Limit = limit;
        }
        
        double Limit { get; set; }

        public override double GetValue(int row, int col)
        {
            return random.NextDouble() * Limit;
        }
    }
}
