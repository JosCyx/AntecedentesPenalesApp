using AntecedentesPenalesApp.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntecedentesPenalesApp.Business
{
    internal class AntecedentesService
    {
        private readonly AntecedentesDataAccess _dataAccess;

        public AntecedentesService(string connectionString)
        {
            _dataAccess = new AntecedentesDataAccess(connectionString);
        }

        public DataTable ObtenerAntecedentes(string numeroCedula)
        {
            return _dataAccess.BuscarAntecedentes(numeroCedula);
        }

    }
}
