using Entidades;
using MySqlConnector;

namespace Datos;

public class FormaPagoDatos
{
    public List<FormaDePago> Listar()
    {
        List<FormaDePago> formasDePago = new List<FormaDePago>();

        MySqlConnection conexion = ConexionDB.ObtenerConexion();
        conexion.Open();

        string consulta = "SELECT * FROM formapago;";
        MySqlCommand cmd = new MySqlCommand(consulta, conexion);

        MySqlDataReader lector = cmd.ExecuteReader();
        while (lector.Read())
        {
            FormaDePago formaDePago = new FormaDePago();
            formaDePago.Id = lector.GetInt32("id");
            formaDePago.Metodo = lector.GetString("metodo");

            formasDePago.Add(formaDePago);
        }
        lector.Close();
        conexion.Close();            
        return formasDePago;
    }

    public FormaDePago ObtenerPorId(int id)
    {
        MySqlConnection conexion = ConexionDB.ObtenerConexion();
        conexion.Open();

        string consulta = "SELECT * FROM formapago;";
        MySqlCommand cmd = new MySqlCommand(consulta, conexion);
        MySqlDataReader lector = cmd.ExecuteReader();

        FormaDePago formaDePago = null;
        if (lector.Read())
        {
            formaDePago = new FormaDePago();
            formaDePago.Id = lector.GetInt32("id");
            formaDePago.Metodo = lector.GetString("metodo");

        }
        
        lector.Close();
        conexion.Close();
        
        return formaDePago;
    }
    
}