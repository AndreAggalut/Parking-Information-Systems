using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace UcmParkingClassLibrary
{
    public class UserClass
    {
        public string DBerror { get; set; }
        public int CreateUser (int customer_ucmid, string customer_status, decimal credit)
        {
            UcmDataAccessClass ucmDBConnect = new UcmDataAccessClass();
            string sqlQuery = "insert into ucm_status values (@customer_ucmid, @customer_status, @customer_balance);";

            SqlParameter param1 = new SqlParameter("@customer_ucmid", SqlDbType.Char);
            param1.Value = customer_ucmid;
            SqlParameter param2 = new SqlParameter("@customer_status", SqlDbType.VarChar);
            param2.Value = customer_status;
            SqlParameter param3 = new SqlParameter("@customer_balance", SqlDbType.Money);
            param3.Value = credit;

            try
            {
                return ucmDBConnect.ExecuteNonQuery(sqlQuery, CommandType.Text, param1, param2, param3);
            }
            catch(Exception ex)
            {
                DBerror = ex.Message;
                return -1;
            }

        }//end of create user

        public int PurchaseCredit (int ucmid, decimal credit)
        {
            UcmDataAccessClass ucmDBconnect = new UcmDataAccessClass();
            string sqlQuery = "UPDATE ucm_status set customer_balance = customer_balance + @customer_balance where customer_ucmid = @customer_ucmid;";
            SqlParameter param1 = new SqlParameter("@customer_ucmid", SqlDbType.Char);
            param1.Value = ucmid;

            SqlParameter param2 = new SqlParameter("@customer_balance", SqlDbType.Decimal);
            param2.SqlValue = credit;

            try
            {
                return ucmDBconnect.ExecuteNonQuery(sqlQuery, CommandType.Text, param1, param2);
            }
            catch(Exception ex)
            {
                DBerror = ex.Message;
                return -1;
            }
        }//end of purchase credit

        public int DeleteUser (int ucmid)
        {
            UcmDataAccessClass ucmConnectClass = new UcmDataAccessClass();
            string sqlQuery = "delete from ucm_status where customer_ucmid = @customer_ucmid;";
            SqlParameter param1 = new SqlParameter("@customer_ucmid", SqlDbType.Char);
            param1.Value = ucmid;

            try
            {
                return ucmConnectClass.ExecuteNonQuery(sqlQuery, CommandType.Text, param1);
            }
            catch(Exception ex)
            {
                DBerror = ex.Message;
                return -1;
            }
        }
    }
}
