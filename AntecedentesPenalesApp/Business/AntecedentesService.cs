using AntecedentesPenalesApp.Classes;
using AntecedentesPenalesApp.Data;
using AntecedentesPenalesApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntecedentesPenalesApp.Business
{
    internal class AntecedentesService
    {
        private readonly AntecedentesDataAccess _dataAccess;

        public AntecedentesService()
        {
            // Usamos DatabaseHelper directamente.
            _dataAccess = new AntecedentesDataAccess();
        }

        public DataTable ObtenerAntecedentes(string numeroCedula)
        {
            return _dataAccess.BuscarAntecedentes(numeroCedula);
        }

        public string[] ConsultarCodigosProvincia()
        {
            return _dataAccess.ConsultarCodigosProvincia();
        }

        public void RegistrarAntecedente(string cedula, string descripcion, string fecha)
        {
            if (string.IsNullOrWhiteSpace(cedula) || string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentException("La cédula y la descripción son obligatorias.");
            }

            // 1. Obtener el código de provincia
            string codigoProvincia = cedula.Substring(0, 2);

            // 2. Obtener el nombre de la tabla de la provincia
            string nombreTabla = _dataAccess.ObtenerNombreTablaProvincia(codigoProvincia);
            if (string.IsNullOrEmpty(nombreTabla))
            {
                throw new Exception("El código de provincia no es válido o no está registrado.");
            }

            // 3. Verificar si la persona existe
            if (!_dataAccess.PersonaExiste(cedula))
            {
                throw new Exception("La persona con la cédula especificada no existe en el sistema.");
            }

            // 4. Insertar el antecedente en la tabla correspondiente
            _dataAccess.RegistrarAntecedente(nombreTabla, cedula, descripcion, fecha);
        }
        
        public string BuscarNombrePorCedula(string cedula)
        {
            return _dataAccess.BuscarNombrePorCedula(cedula);
        }

        public string ObtenerTablaProvincia(string codigoProvincia)
        {
            return _dataAccess.ObtenerTablaProvincia(codigoProvincia);
        }

        public bool VerificarPersona(string cedula)
        {
            return _dataAccess.VerificarPersona(cedula);
        }

        public bool RegistrarAntecedente(string nombreTabla, string cedula, string antecedente, string fechaRegistro)
        {
            return _dataAccess.RegistrarAntecedente(nombreTabla, cedula, antecedente, fechaRegistro);
        }

        public DataTable BuscarPersonasAll()
        {
            return _dataAccess.BuscarPersonasAll();
        }

        public Persona BuscarPersonabyCedula(string cedula)
        {
            return _dataAccess.BuscarPersonabyCedula(cedula);
        }

        public DataTable ObtenerProvincias() 
        {
            return _dataAccess.BuscarProvinciasAll();
        }
        public bool RegistrarPersona(Persona persona)
        {
            return _dataAccess.InsertarPersona(persona);
        }

        public DataTable BuscarProvincias()
        {
            return _dataAccess.BuscarProvincias();
        }

        public bool InsertarProvincia(Provincia provincia)
        {
            return _dataAccess.InsertarProvincia(provincia);
        }

        public Provincia BuscarProvinciaByCodigo(string codigo)
        {
            return _dataAccess.BuscarProvinciaByCodigo(codigo);
        }
    }
}
