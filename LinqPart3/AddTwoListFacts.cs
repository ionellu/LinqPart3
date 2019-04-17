using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqPart3
{
    public class LinqPart3
    {
        [Fact]
        public void AddTwoProductsList()
        {
            Product[] list1 = { new Product("pere", 10), new Product("prune", 3) };
            Product[] list2 = { new Product("pere", 4), new Product("cirese", 3) };
            Product[] list3 = { new Product("pere", 14),new Product("prune", 3),
                new Product("cirese", 3)};
            Assert.Equal(list3, AddTwoList(list1, list2));
        }

        private IEnumerable<Product> AddTwoList(IEnumerable<Product> list1, IEnumerable<Product> list2)
        {
            return list1
                .Union(list2)
                .GroupBy(p => p.Name)
                .Select(r => new Product(r.Key, r.Aggregate(0, (sum, next) => sum + next.Quantity)));
        }
    }
}