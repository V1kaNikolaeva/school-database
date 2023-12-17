using System.Collections.Generic;
using School.Models;
using MySql.Data.MySqlClient;
using System;

namespace School.db
{
    public class OrderDB : OrderModel
    {
        public OrderDB(
            int id,
            DateTime dataCreate,
            //ClientModel client,
            bool removed = false
        ) : base(id, dataCreate, /* client, */ removed)
        {

        }

        public static int GetNewId()
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = $@"SELECT AUTO_INCREMENT
                FROM INFORMATION_SCHEMA.TABLES
                WHERE TABLE_NAME = 'orders'
                AND TABLE_SCHEMA = '{DBUtils.databaseName}'";
            object result = command.ExecuteScalar();
            result = (result == DBNull.Value) ? null : result;
            return Convert.ToInt32(result);
        }

        public static OrderModel GetByID(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = $"SELECT `order_id`, `data_create`, `client`, `removed` FROM `Orders` WHERE `order_id` = {id}";

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    {
                        return new OrderModel(
                            id: reader.GetInt32(0),
                            dataCreate: reader.GetDateTime(1),
                            //client: ClientDB.GetByID(reader.GetInt32(2),
                            removed: reader.GetBoolean(3)

                        );
                    }
                }
                return null;
            }
        }
    }
}
