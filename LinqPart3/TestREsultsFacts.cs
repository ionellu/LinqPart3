using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqPart3
{
    public class TestREsultsFacts
    {
        [Fact]
        public void Test()
        {
            TestResults[] input =
            {
                new TestResults("cucu", "pasare", 7),
                new TestResults("gasca", "pasare", 8),
                new TestResults("strut", "pasare", 9),
                new TestResults("fluture", "insecta", 2),
                new TestResults("albina" ,"insecta", 5)
            };

            TestResults[] result =
            {
                new TestResults("strut", "pasare", 9),
                new TestResults("albina", "insecta", 5)
            };
            Assert.Equal(result, Filter(input));
        }

        private IEnumerable<TestResults> Filter(IEnumerable<TestResults> input)
        {
            return input.GroupBy(fam => fam.FamilyId)
                .Select(r =>
                    r.Aggregate(r.First(), (max, next) => max.Score < next.Score ? next : max)
                 );
        }
    }
}