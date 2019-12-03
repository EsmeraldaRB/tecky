using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TecSystem;

namespace CapaDatos
{
    public class CD_persona
    {
        Conexion conexion = new Conexion();
        SqlDataReader leer;
        DataTable tablaPersona = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarPersona()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from personas";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tablaPersona.Load(leer);
            conexion.CerrarConexion();
            return tablaPersona;
        }

        public int InsertPersona(CapaEntidades.Persona persona)
        {
            try
            {
                SqlCommand command = new SqlCommand("PROC_ALTA_personas", conexion.AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                for (int i = 1; i < 7; i++)
                    command.Parameters[i].Value = persona.Datos[i];
                command.ExecuteNonQuery();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int UpdatePersona(CapaEntidades.Persona persona)
        {
            try
            {
                SqlCommand command = new SqlCommand("PROC_CAMBIO_personas", conexion.AbrirConexion());
                command.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_personas", persona.Id_persona);
                comando.Parameters.AddWithValue("@nombre", persona.Nombre);
                comando.Parameters.AddWithValue("@apellido_paterno", persona.Apellido_paterno);
                comando.Parameters.AddWithValue("@apellido_materno", persona.Apellido_materno);
                comando.Parameters.AddWithValue("@sexo", persona.Sexo);
                comando.Parameters.AddWithValue("@curp", persona.Curp);
                comando.Parameters.AddWithValue("@fecha_nacimiento", persona.Fecha_nacimiento);
                command.ExecuteNonQuery();

                return 1;
            }
            catch
            {
                return 0;
            }
        }


    }

    


}
