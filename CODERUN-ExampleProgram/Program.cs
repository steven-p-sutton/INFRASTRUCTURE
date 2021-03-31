using Conductus.CODERUN.Library.Core;
using Conductus.CODERUN.EXAMPLE;

namespace Conductus.CODERUN.EXAMPLE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Each code module to run implenets the ICodeRunModule interface.
            // Built as a .NET Core class library dll and refernced by its
            // namespace. Call CodeRunModule using CodeRunFramework.run(CodeRunModule)

            var rm = new RunModule();
            CodeRunFramework.Run(rm);
        }
    }
}
