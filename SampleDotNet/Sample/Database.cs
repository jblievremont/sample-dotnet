/*
 * Copyright (C) 2023 AsteroMitH
 */
using System.Data.SqlClient;

namespace Database
{

    public static class DBAccess
    {
        public static void ExecuteRawSql(string connectionString, string statement)
        {
            using var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(statement, connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
