using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntecedentesPenalesApp.Classes;
using AntecedentesPenalesApp.Models;

namespace AntecedentesPenalesApp.Data
{
    internal class AntecedentesDataAccess
    {

        // Buscar antecedentes de una persona por cédula
        public DataTable BuscarAntecedentes(string numeroCedula)
        {
            string query = "EXEC BuscarAntecedentes @NumeroCedula";
            SqlParameter[] parameters = { new SqlParameter("@NumeroCedula", numeroCedula) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // Consultar códigos de provincia
        public string[] ConsultarCodigosProvincia()
        {
            string query = "SELECT CodigoProvincia FROM Provincias";
            DataTable table = DatabaseHelper.ExecuteQuery(query);
            List<string> codigos = new List<string>();

            foreach (DataRow row in table.Rows)
            {
                codigos.Add(row["CodigoProvincia"].ToString());
            }

            return codigos.ToArray();
        }

        // Obtener nombre de la tabla de una provincia por su código
        public string ObtenerNombreTablaProvincia(string codigoProvincia)
        {
            string query = "SELECT NombreTabla FROM Provincias WHERE CodigoProvincia = @CodigoProvincia";
            SqlParameter[] parameters = { new SqlParameter("@CodigoProvincia", codigoProvincia) };
            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            return result.Rows.Count > 0 ? result.Rows[0]["NombreTabla"].ToString() : null;
        }

        // Verificar si una persona existe en la base de datos por su cédula
        public bool PersonaExiste(string cedula)
        {
            string query = "SELECT COUNT(1) FROM Personas WHERE Cedula = @Cedula";
            SqlParameter[] parameters = { new SqlParameter("@Cedula", cedula) };
            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            return result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0;
        }

        // Insertar un antecedente en una tabla específica
        public bool RegistrarAntecedente(string nombreTabla, string cedula, string antecedente, string fechaRegistro)
        {
            //convertir la fecha a DateTime
            DateTime fecha = Convert.ToDateTime(fechaRegistro);

            string query = $@"
                INSERT INTO {nombreTabla} (Cedula, Antecedentes, FechaRegistro)
                VALUES (@Cedula, @Antecedentes, @FechaRegistro)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Cedula", cedula),
                new SqlParameter("@Antecedentes", antecedente),
                new SqlParameter("@FechaRegistro", fecha)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Buscar el nombre completo de una persona por su cédula
        public string BuscarNombrePorCedula(string cedula)
        {
            string query = "SELECT Nombres + ' ' + Apellidos AS NombreCompleto FROM Personas WHERE Cedula = @Cedula";
            SqlParameter[] parameters = { new SqlParameter("@Cedula", cedula) };
            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            return result.Rows.Count > 0 ? result.Rows[0]["NombreCompleto"].ToString() : "PERSONA NO ENCONTRADA";
        }

        public string ObtenerTablaProvincia(string codigoProvincia)
        {
            string query = "SELECT NombreTabla FROM Provincias WHERE CodigoProvincia = @CodigoProvincia";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CodigoProvincia", codigoProvincia)
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result.Rows.Count > 0 ? result.Rows[0]["NombreTabla"].ToString() : null;
        }

        public bool VerificarPersona(string cedula)
        {
            string query = "SELECT COUNT(1) FROM Personas WHERE Cedula = @Cedula";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Cedula", cedula)
            };

            int count = Convert.ToInt32(DatabaseHelper.ExecuteQuery(query, parameters).Rows[0][0]);
            return count > 0;
        }


        public DataTable BuscarPersonasAll()
        {
            string query = "EXEC ConsultarPersonasAll";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public Persona BuscarPersonabyCedula(string cedula)
        {
            string query = "EXEC ConsultarPersonaByCedula @NumeroCedula";
            SqlParameter[] parameters = { new SqlParameter("@NumeroCedula", cedula) };
            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);
            if (result.Rows.Count == 0)
            {
                return null;
            }
            DataRow row = result.Rows[0];
            return new Persona
            {
                Cedula = row["Cedula"].ToString(),
                Nombres = row["Nombres"].ToString(),
                Apellidos = row["Apellidos"].ToString(),
                FechaNacimiento = Convert.ToDateTime(row["FechaNacimiento"]),
                ProvinciaID = Convert.ToInt32(row["ProvinciaID"])
            };
        }

        public DataTable BuscarProvinciasAll()
        {
            string query = "SELECT ProvinciaID, Nombre FROM Provincias";
            return DatabaseHelper.ExecuteQuery(query);
        }

        //insertar una persona en la base de datos
        public bool InsertarPersona(Persona persona)
        {
            string query = "EXEC GuardarPersona @Cedula, @Nombres, @Apellidos, @FechaNacimiento, @ProvinciaID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Cedula", persona.Cedula),
                new SqlParameter("@Nombres", persona.Nombres),
                new SqlParameter("@Apellidos", persona.Apellidos),
                new SqlParameter("@FechaNacimiento", persona.FechaNacimiento),
                new SqlParameter("@ProvinciaID", persona.ProvinciaID)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable BuscarProvincias()
        {
            string query = "EXEC ConsultarProvinciasll";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public Provincia BuscarProvinciaByCodigo(string codigo)
        {
            string query = "EXEC ConsultarProvinciaByCodigo @codigo";
            SqlParameter[] parameters = { new SqlParameter("@codigo", codigo) };
            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);
            if (result.Rows.Count == 0)
            {
                return null;
            }
            DataRow row = result.Rows[0];
            return new Provincia
            {
                CodigoProvincia = row["CodigoProvincia"].ToString(),
                NombreProvincia = row["Nombre"].ToString(),
                TablaProvincia = row["NombreTabla"].ToString()
            };
        }

        //insertar provincia
        public bool InsertarProvincia(Provincia provincia)
        {
            string query = "EXEC GuardarProvincia @Nombre, @CodigoProvincia, @NombreTabla";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nombre", provincia.NombreProvincia),
                new SqlParameter("@CodigoProvincia", provincia.CodigoProvincia),
                new SqlParameter("@NombreTabla", provincia.TablaProvincia)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
