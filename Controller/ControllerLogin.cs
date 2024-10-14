using DataAccess;
using Identities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerLogin
    {
        Funciones f = new Funciones();

        public string[] Validar(string _user, string _pass)
        {
            string[] resultado = new string[2];
            DataSet r = f.Mostrar($"call p_validar('{_user}', '{Sha1(_pass)}')", "Usuarios");
            DataTable dt = r.Tables[0];

            if (dt.Rows.Count > 0)
            {
                resultado[0] = "Correcto";
                resultado[1] = dt.Rows[0]["Username"].ToString();

                IdentitiesPermisos.LimpiarPermisos();

                foreach (DataRow row in dt.Rows)
                {
                    string formulario = row["NombreFormulario"].ToString();
                    IdentitiesPermisos.AsignarPermisos(formulario,
                        Convert.ToBoolean(row["FrmLectura"]),
                        Convert.ToBoolean(row["FrmEscritura"]),
                        Convert.ToBoolean(row["FrmActualizacion"]),
                        Convert.ToBoolean(row["FrmEliminacion"]));
                }
            }
            else
            {
                resultado[0] = "Incorrecto";
                resultado[1] = string.Empty;
            }

            return resultado;
        }

        public static string Sha1(string texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
