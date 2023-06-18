using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ConsoleTableExt;
using System.Linq;
using System.Threading.Tasks;

namespace drinks_info
{
    public class Visualiser
    {
        public static void ShowTable<T>(List<T> tableData, [AllowNull] string tableName) where T : class
        {
            if (tableName == null)
                tableName = "";
            Console.WriteLine("\n\n");

            ConsoleTableBuilder
            .From(tableData)
            .WithColumn(tableName)
            .ExportAndWriteLine();
            Console.WriteLine("\n\n");


        }
    }
}