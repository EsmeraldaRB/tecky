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
        public void AgregarPersona(String paterno,String materno, String nombres, DateTime fecha_nac,int sexo,String curp,String telefono, String numExt, String numInt, String cp, int edoCivil, int discapacidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into personas (paterno,materno,nombres,fecha_nac,sexo,curp,telefono,numExt,numInt,cp," +
                "edoCivil,discapacidad) values('"+paterno+"', '"+materno+"', '"+nombres+"', convert(datetime,'"+fecha_nac.ToString("MM-dd-yyyy")+"',101)," +
                " "+sexo+", '"+curp+"', '"+telefono+"', '"+numExt+"', '"+numInt+"', '"+cp+"', "+edoCivil+", "+discapacidad+")";
            //comando.CommandText = "insert into personas" +
            //    "(paterno, materno, nombres,fecha_nac, sexo, curp, telefono, idCalle, numExt, numInt, cp, edoCivil, discapacidad) " +
            //    "values('"+paterno+"', '"+materno+ "', '"+nombres+ "', '"+fecha_nac.ToShortDateString()+ "', "+sexo+ ", '"+curp+ "', '"+telefono+ "', "+idCalle+ ", '"+numExt+ "', '"+numInt+ "', '"+cp+ "', "+edoCivil+ ", "+discapacidad+");";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

}
}
