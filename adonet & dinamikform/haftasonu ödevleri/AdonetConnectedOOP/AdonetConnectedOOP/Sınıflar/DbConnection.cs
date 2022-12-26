using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonetConnectedOOP.Sınıflar
{
    class DbConnection
    {
        public SqlConnection cn;
        public DbConnection() {

            string baglantiCumlesi = "Data Source=SEVDE;Initial Catalog=Northwind;Integrated Security=True";
            cn = new SqlConnection(baglantiCumlesi);
        }
    }

    //CustomerID, CompanyName, ContactName


    //create function
    class CRUD : DbConnection
    {
        public string companyname { set; get; }
        public string contactname { set; get; }
        public string customerID { set; get; }

        //read properties 
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public void insert_data() 
        {
            cn.Open();
            using (SqlCommand eklekomut = new SqlCommand())
            {
                eklekomut.CommandText = "insert into Customers(CustomerID, CompanyName, ContactName) values(@customerID, @companyname, @contactname)";
                eklekomut.CommandType = CommandType.Text;
                eklekomut.Connection = cn;

                eklekomut.Parameters.AddWithValue("@customerID", customerID);
                eklekomut.Parameters.AddWithValue("@companyname", companyname);
                eklekomut.Parameters.AddWithValue("@contactname", contactname);

                eklekomut.ExecuteNonQuery();
                cn.Close();
            }
        }

        //update function
        public void update_data()
        {
            cn.Open();
            using (SqlCommand komutsil = new SqlCommand())
            {
                komutsil.CommandText = "UPDATE Customers set CompanyName = @companyname, ContactName = @contactname where CustomerID = @customerID ";
                komutsil.CommandType = CommandType.Text;
                komutsil.Connection = cn;

                komutsil.Parameters.AddWithValue("@customerID", customerID);
                komutsil.Parameters.AddWithValue("@companyname", companyname);
                komutsil.Parameters.AddWithValue("@contactname", contactname);

                komutsil.ExecuteNonQuery();
                cn.Close();
            }
        }


        public void delete_data()
        {
            cn.Open();
            using (SqlCommand komutsil = new SqlCommand())
            {
                komutsil.CommandText = "delete from Customers where CustomerID=@customerID";
                komutsil.CommandType = CommandType.Text;
                komutsil.Connection = cn;

                komutsil.Parameters.AddWithValue("@customerID", customerID);
                komutsil.Parameters.AddWithValue("@companyname", companyname);
                komutsil.Parameters.AddWithValue("@contactname", contactname);

                komutsil.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void read_data()
        {
            dt.Clear();
            string query = "select * from Customers";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(ds);
            dt = ds.Tables[0];
        }

    }


   
}
