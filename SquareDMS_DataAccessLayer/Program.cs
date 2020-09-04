using System;
using System.Globalization;
using System.IO;
using System.Threading;

namespace SquareDMS_DataAccessLayer
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var file = File.ReadAllBytes(@"C:\Users\Administrator\Desktop\bigskript.pdf");

            var db = new SquareDbMsSql("Server = HPSERVER; Database = Square_DMS; Integrated Security = True");

            await db.CreateDocumentVersionAsync(1, new Entities.DocumentVersion(1, 1, file));
        }
    }
}
