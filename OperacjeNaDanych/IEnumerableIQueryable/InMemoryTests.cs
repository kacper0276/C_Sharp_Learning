using Xunit;

namespace OperacjeNaDanych.IEnumerableIQueryable
{
    public class InMemoryTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void IEnumerable_ShouldFilterAndReturnTwentyNineElements(List<Actor> list)
        {
            var enumerable = list.AsEnumerable();

            var enumerableFiltered = enumerable.Where(a => a.Id > 0);
            enumerableFiltered = enumerableFiltered.Where(a => a.Id > 10 && a.Id < 180);
            enumerableFiltered = enumerableFiltered.Where(a => a.Id > 50);
            enumerableFiltered = enumerableFiltered.Where(a => a.Id > 150);
            var listFiltered = enumerableFiltered.ToList();

            Assert.NotEmpty(listFiltered);
            Assert.True(listFiltered.Count == 29);
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void IQuerable_ShouldFilterAndReturnTwentyNineElements(List<Actor> list)
        {
            var queryable = list.AsQueryable();

            var queryFiltered = queryable.Where(a => a.Id > 0);
            queryFiltered = queryFiltered.Where(a => a.Id > 10 && a.Id < 180);
            queryFiltered = queryFiltered.Where(a => a.Id > 50);
            queryFiltered = queryFiltered.Where(a => a.Id > 150);
            var listFiltered = queryFiltered.ToList();

            Assert.NotEmpty(listFiltered);
            Assert.True(listFiltered.Count == 29);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            var list = new List<Actor>();
            for (int i = 0; i < 200; i++)
            {
                list.Add(new Actor() { Id = i });
            }
            yield return new object[] { list };
        }
    }
}
