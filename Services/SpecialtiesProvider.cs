using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp2511.Models;

namespace WindowsFormsApp2511.Services
{
    public class SpecialtiesProvider
    {
        private SqlConnection _connection;
        public SpecialtiesProvider(SqlConnection connection)
        {
            _connection = connection;
        }
        public List<Specialty> GetAll()
        {
            List<Specialty> result = new List<Specialty>(); //Создаем список

            try
            {
                _connection.Open(); //подключение открыли
                var command = new SqlCommand(
                    cmdText: "SELECT [id], [code], [name] FROM [Specialties]", //Команда
                    connection: _connection); //Подключение

                using(var reader = command.ExecuteReader()) //Заставляем команду выполниться, в ответ получим сырой набор данных
                {
                    while(reader.Read() )
                    {
                        var speciality = new Specialty //Формируем объект
                        {
                            Id = reader.GetInt32(0), //Присваиваем, где 0 - атрибут в списке
                            Code = reader.GetString(1),
                            Name = reader.GetString(2)
                        };
                        result.Add(speciality); //Собираем в список
                    }
                }
            }
            finally
            {
                _connection.Close(); //Закрываем соединение в любом случае
            }

            return result;
        }
        public bool Add(Specialty specialty)
        {
            bool result = false;
            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    cmdText:"INSERT INTO [Specialties] ([code], [name]) VALUES (@Code, @Name)",
                    connection: _connection
                    );

                command.Parameters.AddWithValue("@Code", specialty.Code);
                command.Parameters.AddWithValue("@Name", specialty.Name);

                //Affected = меньше 1 - не верно. Больше 1 - запрос отработал.
                int affected = command.ExecuteNonQuery(); //Не возвращает объект. После добавления, ничего не нужно.
                result = affected > 0; //Если больше 0 - true, если меньше - false
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }
        public bool Update(int id, Specialty specialty)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(cmdText:"UPDATE [Specialties] SET [code] = @Code, [name] = @Name WHERE [id] = @Id",
                    connection: _connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Code", specialty.Code);
                command.Parameters.AddWithValue("@Name", specialty.Name);

                int affected = command.ExecuteNonQuery();
                result = affected > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }
        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                _connection.Open();

                var command = new SqlCommand(cmdText: "DELETE FROM [Specialties] WHERE [id] = @Id",
                    connection: _connection);

                command.Parameters.AddWithValue("@Id", id);

                int affected = command.ExecuteNonQuery();
                result = affected > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }
    }
}