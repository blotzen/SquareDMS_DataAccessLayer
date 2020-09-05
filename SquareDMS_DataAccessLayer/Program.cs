using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace SquareDMS_DataAccessLayer
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var file = File.ReadAllBytes(@"C:\Users\Administrator\Desktop\CompSci.pdf");

            var db = new SquareDbMsSql("Server=127.0.0.1; Database=Square_DMS; Integrated Security=True");

            await db.CreateDocumentVersionAsync(1, new Entities.DocumentVersion(1, 1, file));

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            var docversions = await db.RetrieveDocumentVersionAsync(1, 10);

            var docVersion = docversions.Resultset.ToList()[0];

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
