//using Conductus.CODERUN.Model.Core;
using Conductus.MOCK.Model.Core;
using Conductus.EXAMPLE.Model;

namespace Conductus.EXAMPLE.CODERUN
{
    public class CodeRunExample : ACodeRunModule
    {
        public override string Title
        {
            get { return "RunCode Example"; }
        }

        public override void Run()
        {
            Msg("Example");

            try
            {
                var module = new Example();

                module.Str = "CODERUN_Example";
                module.Int = 99;

                var idxStr = module.Add(module.Str);
                var idxInt = module.Add(module.Int.ToString());
                var idxItem = module.Add("Item");
                var str = module.Remove(idxItem);
            }
            catch
            {
            }

            Msg("HExample");

            try
            {
                var host = new HExample();
            }
            catch
            {
            }

            Msg("EExample");

            try
            {
                var empty = new EExample();
            }
            catch
            {
            }

            Msg("MExample");

            try
            {
                var mock = new MExample
                {
                    Run = RunType.SUCCESS,
                    Arrange = true,
                    Test = true,
                    Assert = true
                };
            }
            catch
            {
            }
        }
    }
}
