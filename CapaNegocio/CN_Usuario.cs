using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objetoCD = new CD_Usuario();

        public DataTable ConsultarUsuario()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarUsuario(string Nombre, string Apellido, string RUT, string Direccion, string telefono)
        {

            objetoCD.Insertar(Nombre, Apellido, RUT, Direccion, Convert.ToInt32(telefono));
        }

        public void ActualizarUsuario(string Nombre, string Apellido, string RUT, string Direccion, string telefono, string ID)
        {

            objetoCD.Editar(Nombre, Apellido, RUT, Direccion, Convert.ToInt32(telefono), Convert.ToInt32(ID));
        }

        public void EliminarUsuario(string ID)
        {

            objetoCD.Eliminar(Convert.ToInt32(ID));
        }
    }
}
