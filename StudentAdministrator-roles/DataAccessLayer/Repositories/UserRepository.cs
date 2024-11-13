﻿using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRepository
    {
        private SqlDataAccess _dbConnection;
        public UserRepository()
        {
            _dbConnection = new SqlDataAccess();
        }
        public User? GetRegisterUser(string username, string password)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT * FROM users WHERE usernameUser = @usernameUser AND passwordUser = @passwordUser";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("usernameUser", username);
                command.Parameters.AddWithValue("passwordUser", password);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    User user = new User
                    {
                        idUser = reader.GetInt32(0),
                        nameUser = reader.GetString(1),
                        usernameUser = reader.GetString(2),
                        passwordUser = reader.GetString(3),
                        idRolUser = reader.GetInt32(4)
                    };
                    return user;
                }
                else
                {
                    return null;
                }
            }

        }
    }
}
