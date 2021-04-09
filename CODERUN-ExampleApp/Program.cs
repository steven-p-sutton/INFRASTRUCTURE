using Conductus.CODERUN.Model.Core;
using Conductus.CODERUN.Example;

namespace Conductus.CODERUN.Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Each code module to run implenets the ICodeRunModule interface.
            // Built as a .NET Core class library dll and refernced by its
            // namespace. Call CodeRunModule using CodeRunFramework.run(CodeRunModule)

            var rm = new CodeRunModule();
            CodeRun.Run(rm);
        }
    }
}
