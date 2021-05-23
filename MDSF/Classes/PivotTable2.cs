using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDSF.Classes
{
    public static class PivotTable2
    {
        /// <summary>
        /// Gets a Inverted DataTable
        /// </summary>
        /// <param name="table">DataTable do invert</param>
        /// <param name="columnX">X Axis Column</param>
        /// <param name="nullValue">null Value to Complete the Pivot Table</param>
        /// <param name="columnsToIgnore">Columns that should be ignored in the pivot process (X Axis column is ignored by default)</param>
        /// <returns>C# Pivot Table Method  - Felipe Sabino</returns>
        public static DataTable GetInversedDataTable(DataTable table, string columnX, params string[] columnsToIgnore)
        {
            //Create a DataTable to Return
            DataTable returnTable = new DataTable();

            if (columnX == "")
                columnX = table.Columns[0].ColumnName;

            //Add a Column at the beginning of the table
            returnTable.Columns.Add(columnX);

            //Read all DISTINCT values from columnX Column in the provided DataTale
            List<string> columnXValues = new List<string>();


            //Creates list of columns to ignore
            List<string> listColumnsToIgnore = new List<string>();
            if (columnsToIgnore.Length > 0)
                listColumnsToIgnore.AddRange(columnsToIgnore);

            if (!listColumnsToIgnore.Contains(columnX))
                listColumnsToIgnore.Add(columnX);

            foreach (DataRow dr in table.Rows)
            {
                string columnXTemp = dr[columnX].ToString();
                //Verify if the value was already listed
                if (!columnXValues.Contains(columnXTemp))
                {
                    //if the value id different from others provided, add to the list of values and creates a new Column with its value.
                    columnXValues.Add(columnXTemp);
                    returnTable.Columns.Add(columnXTemp);
                }
                else
                {
                    //Throw exception for a repeated value
                    throw new Exception("The inversion used must have unique values for column " + columnX);
                }
            }

            //Add a line for each column of the DataTable
            foreach (DataColumn dc in table.Columns)
            {
                if (!columnXValues.Contains(dc.ColumnName) && !listColumnsToIgnore.Contains(dc.ColumnName))
                {
                    DataRow dr = returnTable.NewRow();
                    dr[0] = dc.ColumnName;
                    returnTable.Rows.Add(dr);
                }
            }

            //Complete the datatable with the values
            for (int i = 0; i < returnTable.Rows.Count; i++)
            {
                for (int j = 1; j < returnTable.Columns.Count; j++)
                {
                    returnTable.Rows[i][j] = table.Rows[j - 1][returnTable.Rows[i][0].ToString()].ToString();
                }
            }

            return returnTable;
        }

        /// <summary>
        /// Gets a Inverted DataTable
        /// </summary>
        /// <param name="table">Provided DataTable</param>
        /// <param name="columnX">X Axis Column</param>
        /// <param name="columnY">Y Axis Column</param>
        ///  <param name="columnY2">Y2 Axis Column</param>
        /// <param name="columnZ">Z Axis Column (values)</param>
        /// <param name="columnsToIgnore">Whether to ignore some column, it must be provided here</param>
        /// <param name="nullValue">null Values to be filled</param>
        /// <returns>C# Pivot Table Method  - Felipe Sabino</returns>
        public static DataTable GetInversedDataTable(DataTable table, string columnX, string columnY, string columnY2, string columnY3, string columnY4, string columnY5, string columnZ, string nullValue, bool sumValues)
        {
            //Create a DataTable to Return
            DataTable returnTable = new DataTable();

            if (columnX == "")
                columnX = table.Columns[0].ColumnName;

            //Add a Column at the beginning of the table
            returnTable.Columns.Add(columnY);
            returnTable.Columns.Add(columnY2);
            //returnTable.Columns.Add(columnY3);
            //returnTable.Columns.Add(columnY4);
            //returnTable.Columns.Add(columnY5);


            //Read all DISTINCT values from columnX Column in the provided DataTale
            List<string> columnXValues = new List<string>();

            foreach (DataRow dr in table.Rows)
            {

                string columnXTemp = dr[columnX].ToString();
                if (!columnXValues.Contains(columnXTemp))
                {
                    //Read each row value, if it's different from others provided, add to the list of values and creates a new Column with its value.
                    columnXValues.Add(columnXTemp);
                    returnTable.Columns.Add(columnXTemp);
                }
            }

            //Verify if Y and Z Axis columns re provided
            //if (columnY != "" && columnZ != "")
                if (columnY != "" )
            {
                //Read DISTINCT Values for Y Axis Column
                List<string> columnYValues = new List<string>();
                List<string> columnY2Values = new List<string>();
                //List<string> columnY3Values = new List<string>();
                //List<string> columnY4Values = new List<string>();
                //List<string> columnY5Values = new List<string>();
               

                foreach (DataRow dr in table.Rows)
                {
                    if (!columnYValues.Contains(dr[columnY].ToString()))
                        columnYValues.Add(dr[columnY].ToString());
                    if (!columnY2Values.Contains(dr[columnY2].ToString()))
                    columnY2Values.Add(dr[columnY2].ToString());
                    ////if (!columnY3Values.Contains(dr[columnY3].ToString()))
                    //columnY3Values.Add(dr[columnY3].ToString());
                    //// if (!columnY4Values.Contains(dr[columnY4].ToString()))
                    //columnY4Values.Add(dr[columnY4].ToString());
                    ////if (!columnY5Values.Contains(dr[columnY5].ToString()))
                    //columnY5Values.Add(dr[columnY5].ToString());

                }
               

               
                for (int i = 0; i < columnYValues.Count; i++)
                {
                   
                    //Creates a new Row
                    DataRow drReturn = returnTable.NewRow();
                    drReturn[0] = columnYValues[i];
                    drReturn[1] = columnY2Values[i];
                    //drReturn[2] = columnY3Values[i];
                    //drReturn[3] = columnY4Values[i];
                    //drReturn[4] = columnY5Values[i];

                    //foreach column Y value, The rows are selected distincted
                    DataRow[] rows = table.Select(columnY + "='" + columnYValues[i]+ "'");
                     rows = table.Select(columnY2 + "='" + columnY2Values[i] + "'");
                     //rows = table.Select(columnY3 + "='" + columnY3Values[i] + "'");
                     //rows = table.Select(columnY4 + "='" + columnY4Values[i] + "'");
                     //rows = table.Select(columnY5 + "='" + columnY5Values[i] + "'");



                    //Read each row to fill the DataTable
                    foreach (DataRow dr in rows)
                        {
                            string rowColumnTitle = dr[columnX].ToString();

                            //Read each column to fill the DataTable
                            foreach (DataColumn dc in returnTable.Columns)
                            {
                                if (dc.ColumnName == rowColumnTitle)
                                {
                                    //If Sum of Values is True it try to perform a Sum
                                    //If sum is not possible due to value types, the value displayed is the last one read
                                    if (sumValues)
                                    {
                                        try
                                        {
                                            drReturn[rowColumnTitle] = Convert.ToDecimal(drReturn[rowColumnTitle]) + Convert.ToDecimal(dr[columnZ]);
                                        }
                                        catch
                                        {
                                            drReturn[rowColumnTitle] = dr[columnZ];
                                        }
                                    }
                                    else
                                    {
                                        drReturn[rowColumnTitle] = dr[columnZ];
                                    }

                              
                            }
                        }
                    }

                    returnTable.Rows.Add(drReturn);
                }

            }
            else
            {
                throw new Exception("The columns to perform inversion are not provided");
            }

            //if a nullValue is provided, fill the datable with it
            if (nullValue != "")
            {
                foreach (DataRow dr in returnTable.Rows)
                {
                    foreach (DataColumn dc in returnTable.Columns)
                    {
                        if (dr[dc.ColumnName].ToString() == "")
                            dr[dc.ColumnName] = nullValue;
                    }
                }
            }

            return returnTable;
        }
    }
}
