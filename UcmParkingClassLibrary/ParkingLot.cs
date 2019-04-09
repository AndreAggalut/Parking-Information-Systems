using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UcmParkingClassLibrary
{
    public class ParkingLot
    {
        public string DBerror { get; set; }

        //get the count method for parking lot.
        public int GetCount()
        {
            try
            {
                string queryString = "select count (*) from parking_information;";
                //instantiate ucm access class
                UcmDataAccessClass ucmDbConnect = new UcmDataAccessClass();
                return Convert.ToInt32(ucmDbConnect.GetScalar(queryString, System.Data.CommandType.Text));
            }
            catch(Exception ex)
            {
                DBerror = ex.Message;
                return -1;
            }

        }//end of getcount();

        //method for getting the parking lot table
       public DataTable GetParking(string parking_location)
        {
            UcmDataAccessClass ucmDataConnect = new UcmDataAccessClass();
            SqlParameter param = new SqlParameter("@parking_location", SqlDbType.VarChar);
            param.Value = parking_location;
            string sqlQuery = "select parking_location, parking_availability, license_plate, vehicle_name, vehicle_color,vehicle_type from parking_information a join vehicle_information r on a.parking_no = r.parking_no where parking_location = @parking_location;";

            try
            {
                return ucmDataConnect.GetTable(sqlQuery, CommandType.Text, param);
            }
            catch (Exception ex)
            {
                DBerror = ex.Message;
                return null;
            }
        }//end of get parking.

        public DataTable GetParkingInformation()
        { 
            
            UcmDataAccessClass ucmDBConnect = new UcmDataAccessClass();

            string sqlQuery = "SELECT parking_no, parking_location from parking_information";
            
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
    }
}
