using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleReader.Responsabilities
{
    public class ManageData
    {
        public DataTable createDgvToleranceTableReference()
        {
            DataTable dgvToFill = new DataTable();

            dgvToFill.Columns.Add("Sieve_Size", typeof(string));
            dgvToFill.Columns.Add("Mesh", typeof(string));
            dgvToFill.Columns.Add("ASTM95%", typeof(string));
            dgvToFill.Columns.Add("ASTM_Max_Single_Aperture", typeof(string));

            dgvToFill.Rows.Add("20", "635", "29µm", "35µm");
            dgvToFill.Rows.Add("25", "500", "34µm", "41µm");
            dgvToFill.Rows.Add("32", "450", "42µm", "50µm");
            dgvToFill.Rows.Add("38", "400", "48µm", "57µm");
            dgvToFill.Rows.Add("45", "325", "57µm", "66µm");
            dgvToFill.Rows.Add("53", "270", "66µm", "76µm");
            dgvToFill.Rows.Add("63", "230", "77µm", "89µm");
            dgvToFill.Rows.Add("75", "200", "91µm", "103µm");
            dgvToFill.Rows.Add("90", "170", "108µm", "122µm");
            dgvToFill.Rows.Add("106", "140", "126µm", "141µm");
            dgvToFill.Rows.Add("125", "120", "147µm", "163µm");
            dgvToFill.Rows.Add("150", "100", "174µm", "192µm");
            dgvToFill.Rows.Add("180", "80", "207µm", "227µm");
            dgvToFill.Rows.Add("212", "70", "242µm", "263µm");
            dgvToFill.Rows.Add("250", "60", "283µm", "306µm");
            dgvToFill.Rows.Add("300", "50", "337µm", "363µm");
            dgvToFill.Rows.Add("355", "45", "396µm", "425µm");
            dgvToFill.Rows.Add("425", "40", "471µm", "502µm");
            dgvToFill.Rows.Add("500", "35", "550µm", "585µm");
            dgvToFill.Rows.Add("600", "30", "660µm", "695µm");
            dgvToFill.Rows.Add("710", "25", "775µm", "815µm");
            dgvToFill.Rows.Add("850", "20", "925µm", "970µm");
            dgvToFill.Rows.Add("1000", "18", "1.083mm", "1.135mm");
            dgvToFill.Rows.Add("1180", "16", "1.270mm", "1.330mm");
            dgvToFill.Rows.Add("1400", "14", "1.505mm", "1.565mm");
            dgvToFill.Rows.Add("1700", "12", "1.820mm", "1.890mm");
            dgvToFill.Rows.Add("2000", "10", "2.135mm", "2.215mm");
            dgvToFill.Rows.Add("2360", "8", "2.515mm", "2.609mm");
            dgvToFill.Rows.Add("2800", "7", "2.975mm", "3.070mm");
            dgvToFill.Rows.Add("3350", "6", "3.55mm", "3.66mm");

            return dgvToFill;
        }

        public DataTable deleteEmptyRowsOfDataTable(DataTable dataTable)
        {
            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
            {
                bool rowIsEmpty = true;
                foreach (var item in dataTable.Rows[i].ItemArray)
                {
                    if (item != null && !string.IsNullOrWhiteSpace(item.ToString()))
                    {
                        rowIsEmpty = false;
                        break;
                    }
                }
                if (rowIsEmpty)
                {
                    dataTable.Rows.RemoveAt(i);
                }             
            }
            return dataTable;
        }

        public DataTable convertDataGridViewToTable(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        public void addDataTableToDataGridView(DataTable dataTable, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            foreach (DataColumn column in dataTable.Columns)
            {
                dataGridView.Columns.Add(column.ColumnName, column.ColumnName);
            }

            foreach (DataRow row in dataTable.Rows)
            {
                object[] rowData = row.ItemArray;
                dataGridView.Rows.Add(rowData);
            }
        }


        private static bool isEmptyRow(DataRow row)
        {
            foreach (var item in row.ItemArray)
            {
                if (!(item is DBNull) && !string.IsNullOrWhiteSpace(item.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
