using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yolo
{
    class DatabaseSavedStuff
    {
        /*
        public string GetAll()
        {
            string output = "Default";
            using (var conn = new SqlConnection(Helper.CnnVal("SampleDB")))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from Category";

                using (var reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {

                        string name = reader.GetString(0);
                        output = name;


                    }

                }


            }

            return output;

        }



        public string GetGategoryItem(int indexer)
        {
            string output = "Default";
            using (var conn = new SqlConnection(Helper.CnnVal("SampleDB")))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select GategoryItem from Category where Id = @Id";
                cmd.Parameters.AddWithValue("@Id", indexer);
                using (var reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {


                        output = reader.GetString(0);


                    }

                }
            }

            return output;

        }

        public int GetCount()
        {
            int output = 0;

            using (var conn = new SqlConnection(Helper.CnnVal("SampleDB")))
            using (var cmd = conn.CreateCommand())
            {

                conn.Open();
                cmd.CommandText = "SELECT COUNT(Id) FROM Category; ";
                cmd.ExecuteNonQuery();
                output = (Int32)cmd.ExecuteScalar();


            }




            return output;
        }


        public int GetLastID()
        {
            int output = 0;

            using (var conn = new SqlConnection(Helper.CnnVal("SampleDB")))
            using (var cmd = conn.CreateCommand())
            {

                conn.Open();
                cmd.CommandText = "SELECT MAX(ISNULL(Id, 0)) FROM Category";
                //cmd.CommandText = "SELECT MAX(Id) FROM Category";
                cmd.ExecuteNonQuery();
                try
                {
                    if (System.Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                    {
                        output = 0;
                    }
                    else
                    {
                        output = System.Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception)
                {

                    output = 0;
                }

                Console.WriteLine("output is " + output);



            }




            return output;
        }


        public int ReturnIndex()
        {
            int x = 0;

            x = int.Parse(RunAny("SELECT COUNT(GategoryItem)FROM Category;"));

            return x;
        }




        public string RunAny(string SQLCommand)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                return connection.Query<string>(SQLCommand).AsList()[0];

            }

        }


        public void DeleteAllGategory()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {

                connection.Execute($"DELETE FROM Category");
            }
        }

        public void GategoryAdd(int _id, string _GategoryName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
                List<Gategory> myGategory = new List<Gategory>();

                myGategory.Add(new Gategory { id = _id, GategoryName = _GategoryName });

                connection.Execute("CategoryName_Insert @id, @GategoryName", myGategory);

            }
        }

        public void GategoryItemAdd(int _id, string _GategoryItem)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
                List<Gategory> myGategory = new List<Gategory>();

                myGategory.Add(new Gategory { id = _id, GategoryItem = _GategoryItem });

                connection.Execute("CategoryItem_Insert @id, @GategoryItem", myGategory);

            }
        }







        public List<T> GetAllGategory<T>()
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<T>($"select * from Category").ToList();
                return output;
            }

        }



        public void GenericList<T>(List<T> myList)
        {
            List<T> test = myList;
            foreach (var item in test)
            {
                Console.WriteLine("This is number" + item);
            }

        }







        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber };
                List<Person> people = new List<Person>();

                people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });

                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);

            }
        }

        */
    }
}
