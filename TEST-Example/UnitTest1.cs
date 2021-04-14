using Xunit;
using Conductus.EXAMPLE.Model.Core;

namespace Conductus.EXAMPLE.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Example()
        {
            var module = new Example();

            module.Str = "APP-Example";
            module.Int = 99;

            var idxStr = module.Add(module.Str);
            Assert.Equal(idxStr, module.Find(module.Str));

            var idxInt = module.Add(module.Int.ToString());
            Assert.Equal(idxInt, module.Find(module.Int.ToString()));

            var idxItem = module.Add("Item");
            Assert.Equal(idxItem, module.Find("Item"));

            var str = module.Remove(idxItem);
            Assert.False(idxItem == module.Find("Item"));
        }
        [Fact]
        public void HExample()
        {
            var host = new HExample();
        }

        [Fact]
        public void EExample()
        {
            var empty = new EExample();
        }

        [Fact]
        public void MExample()
        {
            var mock = new MExample();
        }
    }
}
