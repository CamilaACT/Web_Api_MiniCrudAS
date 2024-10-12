using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Api_MiniCrud_AS.util.Conexion
{
    public class Conexion
    {

        private static string servidor = @"LAPTOP_CAMILA\CAMILASQL";
        private static string base_tip = "cc_mini_core_1";
        private static string usuario = "sa";
        private static string password = "sasa";
        private static string clav_priv = "dfaeiriecmvjhe3943dfadahyeu3456";
        public static string CadenaConexion()
        {

            return "Data Source=" + servidor + ";Initial Catalog=" + base_tip + ";User ID=" + usuario + ";Password=" + password;
        }


    }
}
