using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTableExt;

namespace DrinkInfo
{
    public class TableVisualisationEngine
    {
        //                              Generic type list
        public static void ShowTable<T>(List<T> tableData, [AllowNull] string tableName) where T : class
        {
            Console.Clear();
            
            if (tableName == null)
                tableName = "";

            Console.WriteLine("\n\n");

            ConsoleTableBuilder
            .From(tableData)
            .WithColumn(tableName)
            .ExportAndWrite();
            Console.WriteLine("\n\n");
        }
    }
}
