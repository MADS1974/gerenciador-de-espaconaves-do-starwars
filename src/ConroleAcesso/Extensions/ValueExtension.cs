using System.Data.SqlClient;

namespace ConroleAcesso.Extensions
{
    public static class ValueExtension
    {

        public static T GetValueOrDefault<T>(this SqlDataReader reader, string campo)
        {
            try
            {
                return (T)reader[campo];
            }
            catch
            {
                return default(T);
            }
        }

    }
}

//--*****Projeto replicado do Bootcamp Everis New talents 3 MADS1974 * ****--//