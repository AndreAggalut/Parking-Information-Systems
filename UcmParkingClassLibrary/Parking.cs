using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcmParkingClassLibrary;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace UcmParkingClassLibrary
{
    public class Parking
    {
        public string DBerror { get; set; }
        

        public int GetCount()
        {
            string queryString = "select count(*) from parking_information;";
            try
            {
                UcmDataAccessClass ucmDataAccessClass = new UcmDataAccessClass();
                return Convert.ToInt32(ucmDataAccessClass.GetScalar(queryString, System.Data.CommandType.Text));
            }
            catch (Exception ex)
            {
                DBerror = ex.Message;
                return -1;
            }
        }//end of getcount method
        public DataTable GetParkingInformation()
        {

            UcmDataAccessClass ucmDBConnect = new UcmDataAccessClass();

            string sqlQuery = "SELECT parking_no  , parking_location from parking_information;";

            try
            {
                return ucmDBConnect.GetTable(sqlQuery, CommandType.Text);
            }
            catch (Exception ex)
            {
                DBerror = ex.Message;
                return null;

            }

        }//end getParkingInfo

         public DataTable GetParking(string parking_location)
        {
            UcmDataAccessClass ucmDBConnect = new UcmDataAccessClass();
            SqlParameter param = new SqlParameter("@parking_location", SqlDbType.VarChar);
            param.Value = parking_location;
            string sqlQuery = "select [parking_location] , [license_plate]'License Plate', [vehicle_name] 'Vehicle Name', [vehicle_color] 'Vehicle Color' ,[vehicle_type] 'Vehicle Type' from parking_information a join [vehicle_information]  r on a.parking_no = r.parking_no where [parking_location] = @parking_location;";

            try 
            {
                return ucmDBConnect.GetTable(sqlQuery, CommandType.Text, param);
            }
            catch (Exception ex)
            {
                DBerror = ex.Message;
                return null;
            }
        }//end of get parking.

    }
}
