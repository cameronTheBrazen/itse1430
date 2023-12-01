using System.Data;
using System.Data.SqlClient;

namespace MovieLibrary.Sql
{
    public class SqlMovieDatabase : MovieDatabase
    {
        public SqlMovieDatabase(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override Movie AddCore ( Movie movie )
        {
            using var conn=OpenConnection();
            var cmd = new SqlCommand("AddMovie", conn) { CommandType=CommandType.StoredProcedure };
            //var parmName= cmd.Parameters.Add("@name",SqlDbType.VarChar);
            // parmName.Value= movie.Title;
            cmd.Parameters.AddWithValue("@name", movie.Title);
            cmd.Parameters.AddWithValue("@rating", movie.Rating?.Name);
            cmd.Parameters.AddWithValue("@description", movie.Description);
            cmd.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
            cmd.Parameters.AddWithValue("@runLength", movie.RunLength);
            cmd.Parameters.AddWithValue("@isClassic", movie.IsBlackAndWhite);

          movie.Id=Convert.ToInt32(cmd.ExecuteScalar());
            return movie;
        }
        protected override void DeleteCore ( int id )
        {
            using var conn=OpenConnection();
            var cmd= new SqlCommand("DeleteMovie", conn) { CommandType= CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        protected override Movie FindById ( int id )=> GetCore(id);
        protected override Movie FindByTitle ( string title ) {
            using var conn = OpenConnection();
            var cmd = new SqlCommand("FindByName", conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@name", title);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                return new Movie() {

                    Id=reader.GetInt32("Id"),
                    Title=reader.GetString("Name"),
                    Description=reader.IsDBNull("Description")?"":reader.GetFieldValue<string>("Description"),
                    Rating= new Rating(reader.GetString("Rating")),
                    RunLength= reader.GetInt32("RunLength"),
                    ReleaseYear= reader.GetInt32("ReleaseYear"),
                    IsBlackAndWhite=reader.GetBoolean("IsClassic")



                };
            }

            return null;
        }
        protected override IEnumerable<Movie> GetAllCore () {
            using var conn = OpenConnection();
            var ds = new DataSet();
            var da = new SqlDataAdapter() {
                SelectCommand=new SqlCommand("GetMovies", conn) {
                    CommandType = CommandType.StoredProcedure
                }
            };
            da.Fill(ds);

            //enumerate the dataset
            var movies = new List<Movie>();

            var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
            if( table != null)
            {
                foreach (var row in table.Rows.OfType<DataRow>()) {
                  
                     movies.Add(new Movie() {
                        Id= Convert.ToInt32(row["Id"]),
                        Title=  Convert.ToString(row["Name"]),
                        Description=row.IsNull("Description")?"":row.Field<string>("Description"),
                        Rating= new Rating(row.Field<string>("Rating")),
                        RunLength= Convert.ToInt32(row["RunLength"]),
                        ReleaseYear= Convert.ToInt32(row["ReleaseYear"]),
                        IsBlackAndWhite=row.Field<bool>("isClassic"),
                        //Genre=
                    }) ;
                }
            }
            return movies;
        }
        protected override Movie GetCore ( int id ) {
            using var conn = OpenConnection();
            var cmd = new SqlCommand("GetMovie", conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@id", id);
            using var reader= cmd.ExecuteReader();
            while (reader.Read()) {

                return new Movie() {

                    Id=reader.GetInt32("Id"),
                    Title=reader.GetString("Name"),
                    Description=reader.IsDBNull("Description")?"":reader.GetFieldValue<string>("Description"),
                    Rating= new Rating(reader.GetString("Rating")),
                    RunLength= reader.GetInt32("RunLength"),
                    ReleaseYear= reader.GetInt32("ReleaseYear"),
                    IsBlackAndWhite=reader.GetBoolean("IsClassic")



                };
            }

            return null;
        }
        protected override void UpdateCore ( int id, Movie movie )
        {
            using var conn = OpenConnection();
            var cmd = new SqlCommand("UpdateMovie", conn) { CommandType=CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", movie.Title);
            cmd.Parameters.AddWithValue("@rating", movie.Rating?.Name);
            cmd.Parameters.AddWithValue("@description", movie.Description);
            cmd.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
            cmd.Parameters.AddWithValue("@runLength", movie.RunLength);
            cmd.Parameters.AddWithValue("@isClassic", movie.IsBlackAndWhite);

            cmd.ExecuteNonQuery();
           
        }
        private SqlConnection OpenConnection () { 
            var conn= new SqlConnection (_connectionString);
            conn.Open ();
            
            return conn;
        }   

        private readonly string _connectionString;
    }
}