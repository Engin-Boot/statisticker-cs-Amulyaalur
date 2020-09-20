using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
       // public double average;

        public struct Stats
        {
            public double average;
            public double minimum;
            public double maximum;
        }
        public Stats CalculateStatistics(List<double> numbers) {
            Stats statistics= new Stats();
            statistics.average = WhenComputeAverage(numbers);
            statistics.minimum = WhenComputeMinimum(numbers);
            statistics.maximum = WhenComputeMaximum(numbers);
            return statistics;
        }

        public static double WhenComputeAverage(List<double> numbers)
        {
            double average = 0;
            if (numbers.Count == 0)
            {
                return double.NaN;
            }
            else
            {
                double sum = 0;
                for (var i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }

                 average = sum / numbers.Count;
            }

            return average;
        }

        public static double WhenComputeMinimum(List<double> numbers)
        {
            if (numbers.Count == 0)
            {
                return double.NaN;
            }
            double min = numbers.Min();
            return min;
        }

        public static double WhenComputeMaximum(List<double> numbers)
        {
            if (numbers.Count == 0)
            {
                return double.NaN;
            }
            double max = numbers.Max();
            return max;
        }
    }

}
