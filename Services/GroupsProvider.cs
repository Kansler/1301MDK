using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApp2511.Models;

namespace WindowsFormsApp2511.Services
{
    public class GroupsProvider
    {
        private SqlConnection _connection;
        public GroupsProvider(SqlConnection connection)
        {
            _connection = connection;
        }
        public List<Group> GetAllWithSpecialties()
        {
            var result = new List<Group>(); //для хранения переменной

            try
            {
                _connection.Open(); //подключение открыли
                var command = new SqlCommand(
                    cmdText: @"
SELECT
	[Groups].[id],
	[Groups].[name],
	[Groups].[year],
	[Groups].[specialty_id],
	[Specialties].[code],
	[Specialties].[name]
FROM [Groups]
LEFT JOIN [Specialties]
ON [Specialties].[id] = [Groups].[id]
", //Команда
                    connection: _connection); //Подключение

                using (var reader = command.ExecuteReader()) //Заставляем команду выполниться, в ответ получим сырой набор данных
                {
                    while (reader.Read())
                    {
                        var specialty = new Specialty //Формируем объект
                        {
                            Id = reader.GetInt32(3),
                            Code = reader.GetString(4),
                            Name = reader.GetString(5)
                        };
                        var group = new Group
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Year = reader.GetInt32(2),
                            SpecialtyId = reader.GetInt32(3),
                            Specialty = specialty 
                        };

                        result.Add(group);
                    }
                }
            }
            finally
            {
                _connection.Close(); //Закрываем соединение в любом случае
            }

            return result;
        }

        public bool Add(Group group)
        {
            bool result = false;
            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    cmdText: "INSERT INTO [Groups] ([name], [year], [specialty_id]) VALUES (@Name, @Year, @Specialty_id)",
                    connection: _connection
                    );

                command.Parameters.AddWithValue("@Name", group.Name);
                command.Parameters.AddWithValue("@Year", group.Year);
                command.Parameters.AddWithValue("@Specialty_id", group.SpecialtyId);

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
        public bool Update(int id, Group group)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(cmdText: "UPDATE [Groups] SET [name] = @Name, [year] = @Year, [specialty_id] = @Specialty_id WHERE [id] = @Id",
                    connection: _connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", group.Name);
                command.Parameters.AddWithValue("@Year", group.Year);
                command.Parameters.AddWithValue("@Specialty_Id", group.SpecialtyId);

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

                var command = new SqlCommand(cmdText: "DELETE FROM [Groups] WHERE [id] = @Id",
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
