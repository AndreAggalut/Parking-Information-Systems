using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace UcmParkingClassLibrary
{
    /*
     *Created by: Andre Aggalut
     * ID:700658038
     */
    public class UcmDataAccessClass
    {
        private string DBerror { get; set; }
        //variable for connection
        private SqlConnection ucmParkingConn;

        //creating the connection string.
        private string ucmParkingConnectionString = ConfigurationManager.ConnectionStrings["Aggalut_UCMPARKING.Properties.Settings.ucmParkingString"].ConnectionString;

        public SqlConnection GetConnection()
        {
            if(ucmParkingConn == null)
            {
                ucmParkingConn = new SqlConnection(ucmParkingConnectionString);

                
            }//end if
            return ucmParkingConn;
        }//end get connection
        public void openUCMConnection()
        {
            if(ucmParkingConn.State == ConnectionState.Closed)
       
            {
                ucmParkingConn.Open();
            }
        }//end open connection
        public void closeUCMConnection()
        {
            ucmParkingConn.Close();
        }//end close connection

        public DataSet GetUCMData(string sqlString)
        {
            DataSet ucmDataSet = new DataSet();
            try
            {
                SqlDataAdapter ucmDataAdapter = new SqlDataAdapter(sqlString, this.GetConnection());
                this.openUCMConnection();
                ucmDataAdapter.Fill(ucmDataSet);
                return ucmDataSet;

            }//end of filling the dataset
            finally
            {
                this.closeUCMConnection();
            }//closing the connection
        }

        public DataTable QueryWithParams(string procNameOrQuery, CommandType cmdType, SqlParameter
            param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null, SqlParameter param5 = null, SqlParameter param6 = null)
        {
            SqlCommand cmd = new SqlCommand(procNameOrQuery, this.GetConnection());
            SqlDataAdapter ucmDataAdapter = new SqlDataAdapter();
            DataSet UCMDataSet = new DataSet();

            cmd.CommandType = cmdType;
            if (param1 != null) cmd.Parameters.Add(param1);
            if (param2 != null) cmd.Parameters.Add(param2);

            try
            {
                this.openUCMConnection();
                ucmDataAdapter.Fill(UCMDataSet);
                return UCMDataSet.Tables[0];
            }
            finally
            {
                this.closeUCMConnection();
            }
        }
            public SqlDataReader GetReader(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null)
            {
                SqlCommand cmd = new SqlCommand(procNameOrQuery, this.GetConnection());
                cmd.CommandType = cmdType;

                if (param1 != null) cmd.Parameters.Add(param1);
                if (param2 != null) cmd.Parameters.Add(param2);
                if (param3 != null) cmd.Parameters.Add(param3);
                if (param4 != null) cmd.Parameters.Add(param4);

                try
                {
                    this.openUCMConnection();
                    return cmd.ExecuteReader();
                }
                finally
                {
                    cmd.Dispose();
                }//end finally
            }// end GetReader()
        public object GetScalar(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null)
        {
            SqlCommand cmd = new SqlCommand(procNameOrQuery, this.GetConnection());
            //add the query parameters to the command.

            if (param1 != null) cmd.Parameters.Add(param1);
            if (param2 != null) cmd.Parameters.Add(param2);
            if (param3 != null) cmd.Parameters.Add(param3);
            if (param4 != null) cmd.Parameters.Add(param4);

            try
            {
                this.openUCMConnection();
                return cmd.ExecuteScalar();
            }
            finally
            {
                this.closeUCMConnection();
                cmd.Dispose();
            }

        }// end GetScalar
        public int ExecuteNonQuery(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null)
        {
            SqlCommand cmd = new SqlCommand(procNameOrQuery, this.GetConnection());
            cmd.CommandType = cmdType;

            //add the query parameters to the command.

            if (param1 != null) cmd.Parameters.Add(param1);
            if (param2 != null) cmd.Parameters.Add(param2);
            if (param3 != null) cmd.Parameters.Add(param3);
            if (param4 != null) cmd.Parameters.Add(param4);

            try
            {
                this.openUCMConnection();
                return cmd.ExecuteNonQuery();

            }
            finally
            {
                this.closeUCMConnection();
                cmd.Dispose();
            }

        }//end ExecuteNonQuery()

        public DataSet GetDataSet(string SqlString)
        {
            DataSet hwDataSet = new DataSet();
            try
            {
                SqlDataAdapter hwAdapter = new SqlDataAdapter(SqlString, this.GetConnection());
                this.openUCMConnection();
                hwAdapter.Fill(hwDataSet);
                return hwDataSet;

            }
            finally
            {
                this.closeUCMConnection();
            }
        }//end GetDataSet()

  
        //get the table method
        public DataTable GetTable(string procNameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null)
        {
            //load a datable from the database using either query or text or  a stored procedure name.
            DataTable table = new DataTable();
            SqlDataReader reader = null;

            try
            {

                reader = GetReader(procNameOrQuery, cmdType, param1, param2, param3, param4);
                table.Load(reader);
                reader.Close();
                return table;


            }
            finally
            {
                this.closeUCMConnection();
            }
        }//end GetTable()
       

       
       
    }


}

