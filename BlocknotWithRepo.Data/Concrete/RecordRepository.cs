using BlocknotWithRepo.Data.Abstract;
using BlocknotWithRepo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknotWithRepo.Data.Concrete
{
    public class RecordRepository : IRepository<Record>
    {
        SqlConnection connection;
        private bool disposedValue;

        public RecordRepository()
        {
            connection = new SqlConnection(Utils.ConnectionString);
            connection.Open();
        }

        public void Add(Record record)
        {
            string commandStr = "INSERT INTO Records (Name, Surname) VALUES (@Name, @Surname)";

            using SqlCommand cmd = new SqlCommand(commandStr, connection);

            cmd.Parameters.AddWithValue("@Name", record.Name);
            cmd.Parameters.AddWithValue("@Surname", record.Surname);

            cmd.ExecuteNonQuery();
        }

        public void Delete(Record record)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            this.connection.Dispose();
        }

        public IEnumerable<Record> GetAll()
        {
            string sql = "SELECT * FROM Records";

            SqlCommand command = new SqlCommand(sql, connection);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Record record = new Record()
                {
                    ID = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Surname = (string)reader["Surame"],
                };

                yield return record;
            }
        }

        public Record GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Record record)
        {
            throw new NotImplementedException();
        }


    }
}
