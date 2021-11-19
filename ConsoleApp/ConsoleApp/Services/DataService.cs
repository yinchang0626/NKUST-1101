using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public class DataService
    {
        private string _connectionString = @"Server=(LocalDb)\MSSQLLocalDB;Database=NKUST;Trusted_Connection=True";


        public List<Activity> GetActivities()
        {
            var result = new List<Activity>();
            SqlConnection cn = new SqlConnection(_connectionString);

            cn.Open();

            SqlCommand command = new SqlCommand("Select * from Activity", cn);
            
            var indexer = command.ExecuteReader();


            while (indexer.Read())
            {
                var id = indexer["Id"];
                var prgName = indexer["PrgName"];
                var prgDate = indexer["PrgDate"];
                var prgPlace = indexer["PrgPlace"];
                var price = indexer["Price"];
                var item = new Activity()
                {
                    PrgName = prgName.ToString(),
                    PrgDate = prgDate.ToString(),
                    PrgPlace = prgPlace.ToString(),
                    Id = long.Parse(id.ToString())
                };
                result.Add(item);

            }

            cn.Close();

            return result;
        }


        public void Insert(Activity activity)
        {

            var commandString = @"
INSERT INTO [dbo].[Activity] ([PrgName],[PrgDate],[PrgPlace]) 
VALUES (@PrgName,@PrgDate,@PrgPlace)";

            SqlConnection cn = new SqlConnection(_connectionString);

            cn.Open();

            SqlCommand command = new SqlCommand(commandString, cn);

            command.Parameters.Add(new SqlParameter("PrgName", activity.PrgName));
            command.Parameters.Add(new SqlParameter("PrgDate", activity.PrgDate));
            command.Parameters.Add(new SqlParameter("PrgPlace", activity.PrgPlace));

            var count = command.ExecuteNonQuery();

            cn.Close();
        }

        public void Update(Activity activity)
        {
            var commandString = @"
UPDATE [dbo].[Activity]
SET [PrgName] = ''
      ,[PrgDate] =''
      ,[PrgPlace] =''
      ,[Price] = 0
WHERE Id=1";

            SqlConnection cn = new SqlConnection(_connectionString);

            cn.Open();

            SqlCommand command = new SqlCommand(commandString, cn);

            var count = command.ExecuteNonQuery();

            cn.Close();
        }

        public void Delete(int id)
        {

            var commandString = @"
DELETE FROM [dbo].[Activity]
WHERE Id=0";

            SqlConnection cn = new SqlConnection(_connectionString);

            cn.Open();

            SqlCommand command = new SqlCommand(commandString, cn);

            var count = command.ExecuteNonQuery();

            cn.Close();
        }

    }
}
