using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApp2511.Models;

namespace WindowsFormsApp2511.Services
{
    public class StudentsProvider
    {
        private SqlConnection _connection;
        public StudentsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Student> GetAllWithGroups()
        {
            var result = new List<Student>();

            try
            {
                _connection.Open();
                var command = new SqlCommand(@"
                        SELECT
	                        [Students].[id],
	                        [Students].[name],
	                        [Students].[surname],
	                        [Students].[group_id],
	                        [Groups].[name] AS GroupName,
	                        [Groups].[year] AS GroupYear
                        FROM
	                        [Students]
                        LEFT JOIN [Groups]
                        ON [Groups].[id] = [Students].[id];
                    ", connection: _connection);
                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var group = new Group
                        {
                            Name = reader.GetString(4),
                            Year = reader.GetInt32(5)
                        };
                        var student = new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Surname = reader.GetString(2),
                            GroupId = reader.GetInt32(3)
                        };
                        result.Add(student);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Add(Student student)
        {
            bool result = false;
            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    cmdText: "INSERT INTO [Students] ([name], [surname]) VALUES (@Name, @Surname)",
                    connection: _connection
                    );

                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Surname", student.Surname);

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
        public bool Update(int id, Student student)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(cmdText: "UPDATE [Students] SET [name] = @Name, [Surname] = @Surname WHERE [id] = @Id",
                    connection: _connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Surname", student.Surname);

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

                var command = new SqlCommand(cmdText: "DELETE FROM [Students] WHERE [id] = @Id",
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
