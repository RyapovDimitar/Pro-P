using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Prop
{
    class DataHelper
    {
        public MySqlConnection connection;

        public DataHelper()
        {
            String connectionInfo = "server=athena01.fhict.local;" +
                                    "database=dbi335303;" +
                                    "user id=dbi335303;" +
                                    "password=WpjQ5DPPt9;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }


        public List<User> GetAllUsers()
        {
            String sql = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<User> temp;
            temp = new List<User>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int nr;
                string email;
                string fname;
                string lname;
                decimal money;
                bool over;
                bool inevent;
                bool incamping;
                string rfid;
                while (reader.Read())
                {
                    nr = Convert.ToInt32(reader["USER_ID"]);
                    email = Convert.ToString(reader["EMAIL"]);
                    fname = Convert.ToString(reader["FNAME"]);
                    lname = Convert.ToString(reader["LNAME"]);
                    money = Convert.ToDecimal(reader["MONEY"]);
                    over = Convert.ToBoolean(reader["OVER"]);
                    inevent = Convert.ToBoolean(reader["INEVENT"]);
                    incamping = Convert.ToBoolean(reader["INCAMPING"]);
                    rfid = Convert.ToString(reader["RFID"]);
                    temp.Add(new User(nr, email, fname, lname, money, over, inevent, incamping, rfid));
                }
            }
            catch
            {
                MessageBox.Show("error while loading the students");
            }
            finally
            {
                connection.Close();
            }
            return temp;
        }

        public int AddAUser(string email, string fname, string lname, decimal money, int over, int inevent, int incamping, string rfid)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?

            String sql = "INSERT INTO `dbi335303`.`users` (`USER_ID`, `EMAIL`, `FNAME`, `LNAME`, `MONEY`, `OVER`, `INEVENT`, `INCAMPING`, `RFID`) VALUES(NULL, '" + email + "', '" + fname + "','" + lname + "', '" + money + "', '" + over + "', '" + inevent + "','" + incamping + "', '" + rfid + "')";

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }
            finally
            {
                connection.Close();
            }
        }

        public int AssignARFID(int id, string rfid)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?

            try
            {
                
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update dbi335303.users set RFID='" + rfid + "' , INEVENT=1 where USER_ID='" + id + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, connection);
                MySqlDataReader MyReader2;
                connection.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }

                int nrOfRecordsChanged = MyCommand2.ExecuteNonQuery();
                return nrOfRecordsChanged;//Connection closed here  
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }

        public int PutInEvent(int id)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?

            try
            {

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update dbi335303.users set INEVENT=1 where USER_ID='" + id + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, connection);
                MySqlDataReader MyReader2;
                connection.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }

                int nrOfRecordsChanged = MyCommand2.ExecuteNonQuery();
                return nrOfRecordsChanged;//Connection closed here  
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }

        public int ExitFromEvent(int id)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?

            try
            {

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update dbi335303.users set INEVENT=0 where USER_ID='" + id + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, connection);
                MySqlDataReader MyReader2;
                connection.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }

                int nrOfRecordsChanged = MyCommand2.ExecuteNonQuery();
                return nrOfRecordsChanged;//Connection closed here  
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }

        }

        public int NumberOfUsers()
        {
            String sql = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int number = 0;
            try
            {
                connection.Open();
                number = Convert.ToInt32(command.ExecuteScalar());
                return number;
            }
            catch
            {
                return -1;

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
