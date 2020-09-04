using System;

namespace SquareDMS_DataAccessLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new SquareDbMsSql("Server = 192.168.178.15; Database = Square_DMS; Integrated Security = True");

            db.CreateDocumentVersionAsync(1, new Entities.DocumentVersion(1, 1, null));
        }
    }
}
