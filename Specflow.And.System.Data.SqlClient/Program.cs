using System;
using System.Data.SqlClient;

namespace Specflow.And.System.Data.SqlClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("bob");
        }
    }
}
