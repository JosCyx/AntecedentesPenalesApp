using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntecedentesPenalesApp.Data
{
    internal class AntecedentesDataAccess
    {
        private readonly string _connectionString;

        public AntecedentesDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable BuscarAntecedentes(string numeroCedula)
        {
            DataTable resultTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("BuscarAntecedentes", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NumeroCedula", numeroCedula);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(resultTable);
                }
            }

            return resultTable;
        }
    }
}
