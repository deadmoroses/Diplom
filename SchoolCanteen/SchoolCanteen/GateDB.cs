using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SchoolCanteen
{
    /// <summary>
    /// Взаимодействие с базой данных
    /// </summary>
    static class DBGate
    {
        /// <summary>
        /// Позволяет проверить правильность строки подключения
        /// </summary>
        public static bool CheckConnection(string connectionString)
        {
            SqlConnection connection = new SqlConnection();
            try { connection = new SqlConnection(connectionString); connection.Open(); }
            catch { return false; }
            finally { connection.Close(); }
            return true;
        }

        /// <summary>
        /// Позволяет добавить запись в таблицу базы данных
        /// </summary>
        public static Exception Insert(string connectionString, string tableName, params string[] values)
        {
            string query = $"insert into {tableName} values('{values[0]}'";
            for (int i = 1; i < values.Length; i++) query += $", '{values[i]}'";
            query += $")";
            return NonQuery(connectionString, query);
        }

        /// <summary>
        /// Позволяет удалить запись (или записи) из базы данных по значению поля
        /// </summary>
        public static Exception Delete(string connectionString, string tableName, string keyName, string keyValue)
        {
            string query = $"delete from {tableName} where {keyName} = {keyValue}";
            return NonQuery(connectionString, query);
        }

        /// <summary>
        /// Выполняет запрос, не требующий ответа
        /// </summary>
        public static Exception NonQuery(string connectionString, string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = query;
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
                return null;
            }
            catch (Exception ex) { return ex; }
        }

        /// <summary>
        /// Выполняет запрос, результатом которого является одно значение и возвращает в виде строки
        /// </summary>
        public static string Scalar(string connectionString, string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = connection;
                return $"{command.ExecuteScalar()}";
            }
        }

        /// <summary>
        /// Получает приветствие пользователя для статусбара
        /// </summary>
        public static string GetSalutation(string connectionString, string id)
        {
            if (Scalar(connectionString, $"select name from Users where ID = {id}") != "Имя не указано")
                return $"Добро пожаловать, {Scalar(connectionString, $"select name from Users where ID = {id}")}!";
            else return "Добро пожаловать!";
        }

        /// <summary>
        /// Выполняет запрос и заполняет dataset, для заполнения datagridview
        /// </summary>
        public static DataSet GetFilledDataSet(string connectionString, string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
        }

        /// <summary>
        /// Выполняет запрос и возвращает список
        /// </summary>
        public static List<string> GetColumnFromDB(string connectionString, string query)
        {
            List<string> list = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) { while (reader.Read()) { list.Add(reader[0].ToString()); } }
                return list;
            }
        }
    }
}

