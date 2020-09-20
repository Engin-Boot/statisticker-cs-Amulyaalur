using System;
using System.Collections.Generic;
using Xunit;
using Statistics;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double> {1.5, 8.9, 3.2, 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.maximum - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.minimum - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double> { });
            Assert.True(Math.Abs(computedStats.average).Equals(double.NaN));
            Assert.True(Math.Abs(computedStats.maximum).Equals(double.NaN));
            Assert.True(Math.Abs(computedStats.minimum).Equals(double.NaN));

        }
    }
}
