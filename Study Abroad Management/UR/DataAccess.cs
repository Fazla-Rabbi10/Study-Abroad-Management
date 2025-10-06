using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Abroad_Management.UR
{
    public class DataAccess
    {
        public SqlConnection Sqlcon {get ;set;}

        public SqlCommand Sqlcom{get; set;}

        public SqlDataAdapter Sda { get ;set;}

        public DataSet Ds{get; set;} 

        public DataAccess()
        {

            this.Sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Project(Database);Integrated Security=True;");
            Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds.Tables[0];
        }

        public int ExecuteDMLQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }

        public int ExecuteDMLQuery(string sql, SqlParameter[] parameters)
        {
            try
            {
                this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
                if (parameters != null)
                {
                    this.Sqlcom.Parameters.AddRange(parameters);
                }
                return this.Sqlcom.ExecuteNonQuery(); // Execute the command
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing DML query: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
