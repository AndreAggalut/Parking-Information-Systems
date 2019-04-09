using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcmParkingClassLibrary;
using System.Data;
using System.Data.SqlClient;

namespace Aggalut_UCMPARKING
{
    class UCMIntermediaryClass
    {
        public string DBerror { get; set; }
        //calls on all customer
        public DataTable GetData()
        {
            
            try
            {
                //sql query
                UcmDataAccessClass ucmDataAccessInstance = new UcmDataAccessClass();
                string sqlQuery = "select [customer_id] 'ID' , [customer_ucmid]'UCM ID', [customer_lname] 'First Name', [customer_fname] 'Last Name' , [customer_email] 'Email Address' , [customer_phone] 'Phone Number' from customer order by customer_ucmid asc;";

                //call method for data
                DataSet ucmDataSet = ucmDataAccessInstance.GetUCMData(sqlQuery);
                return ucmDataSet.Tables[0];


            }
            catch (Exception ex)
            {
                DBerror = ex.Message;
                return null;
            }
        }//end get data

        public DataTable GetUCMStudent()
        {
            try
            {
                UcmDataAccessClass ucmDBAccess = new UcmDataAccessClass();
                string sqlQuery = "select[customer_ucmid] 'UCM ID' , [customer_status] 'STATUS', [customer_balance] 'Current Balance' from ucm_status order by customer_ucmid ASC;";
                DataSet ucmDataSet = ucmDBAccess.GetUCMData(sqlQuery);
                return ucmDataSet.Tables[0];

                    
            }
            catch(Exception ex)
            {
                DBerror = ex.Message;
                return null;
            }
        }//end of get ucm students


    }

}
