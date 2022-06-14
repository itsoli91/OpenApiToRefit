namespace OpenApiToRefit.Cli
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            var generator = new RefitGenerator();

           await generator.Generate();
        }
    }
}