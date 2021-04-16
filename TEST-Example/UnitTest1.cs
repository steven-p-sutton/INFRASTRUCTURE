using System;
using Xunit;
using Conductus.EXAMPLE.Model.Core;
using Conductus.EXCEPTION.Model.Core;

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

            try
            {
                var idx = module.Find(str);
            }
            catch (ExampleNotFoundException e)
            {
            }
        }
        [Fact]
        public void HExample()
        {
            var host = new HExample();

            var s = host.Str();
            var i = host.Int();
            var p = host.Ping();

            host.Add();
            host.Find();
            host.Remove();

            host.Try = true;
        }

        [Fact]
        public void EExample()
        {
            try
            {
                var notImpementedYet = new EExample();

                notImpementedYet.Add("Item");
                notImpementedYet.Remove(notImpementedYet.Find("Item"));
                notImpementedYet.Ping("EExample.Ping()");
            }
            catch (ExampleNotImplentedException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [Fact]
        public void MExample_SUCCESS()
        {
            var mockOK = new MExample
            {
                Run = RunType.SUCCESS,
                Arrange = true,
                Test = true,
                Assert = true
            };
        }
        [Fact]
        public void MExample_FAIL()
        {
            try
            {
                var mockERROR = new MExample
                {
                    Run = RunType.FAIL_Ping,
                    ExceptionExpected = new ExampleAlreadyExistsException("Mock ERROR"),
                    Throws = true,
                    Arrange = true,
                    Test = true,
                    Assert = true
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
