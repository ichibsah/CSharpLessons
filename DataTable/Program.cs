using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTables
{
    class Program
    {
        static void Main()
        {
            // Get the DataTable.
            DataTable table = GetTable();
            // ... Use the DataTable here with SQL.

            // This uses the GetTable method (please paste it in).
            DataTable data = GetTable();
            // ... Loop over all rows.
            foreach (DataRow row in data.Rows)
            {
                // ... Write value of first field as integer.
                Console.WriteLine(row.Field<int>(0));
            }
        }

        /// <summary>
        /// This example method generates a DataTable.
        /// </summary>
        static DataTable GetTable()
        {
            // Here we create a DataTable with four columns.
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            // Here we add five DataRows.
            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
            return table;
        }

    }
}
