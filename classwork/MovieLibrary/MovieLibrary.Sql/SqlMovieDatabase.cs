﻿using System.Data;
using System.Data.SqlClient;

namespace MovieLibrary.Sql
{
    public class SqlMovieDatabase : MovieDatabase
    {
        public SqlMovieDatabase(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override Movie AddCore ( Movie movie ) => throw new NotImplementedException();
        protected override void DeleteCore ( int id ) => throw new NotImplementedException();
        protected override Movie FindById ( int id ) => throw new NotImplementedException();
        protected override Movie FindByTitle ( string title ) => throw new NotImplementedException();
        protected override IEnumerable<Movie> GetAllCore () {
            using var conn = OpenConnection();
            var ds = new DataSet();
            var da = new SqlDataAdapter() {
                SelectCommand=new SqlCommand("Get Movies", conn) {
                    CommandType = CommandType.StoredProcedure
                }
            };
            da.Fill(ds);

            return Enumerable.Empty<Movie>();
        }
        protected override Movie GetCore ( int id ) => throw new NotImplementedException();
        protected override void UpdateCore ( int id, Movie movie ) => throw new NotImplementedException();
        private SqlConnection OpenConnection () { 
            var conn= new SqlConnection (_connectionString);
            conn.Open ();
            
            return conn;
        }   

        private readonly string _connectionString;
    }
}