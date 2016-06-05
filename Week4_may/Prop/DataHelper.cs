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

        public List<CampingSpot> GetAllCampingSpots()
        {
            String sql = "SELECT * FROM camping_spot";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<CampingSpot> temp;
            temp = new List<CampingSpot>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int spot_id;
                int id;
                string spot_type;
                string rfid_assigned;
                while (reader.Read())
                {
                    spot_id = Convert.ToInt32(reader["SPOT_ID"]);
                    id = Convert.ToInt32(reader["ID"]);
                    spot_type = Convert.ToString(reader["SPOT_TYPE"]);
                    rfid_assigned = Convert.ToString(reader["RFID_ASSIGNED"]);
                    temp.Add(new CampingSpot(spot_id, id, spot_type, rfid_assigned));
                }
                temp.Add(new CampingSpot(21, 21, "sth", "sth"));
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
        public List<Item> GetAllItems()
        {
            String sql = "SELECT * FROM item";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<Item> ListofItems;
            ListofItems = new List<Item>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int id;
                string description;
                int price;
                int quantity;

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ITEM_ID"]);
                    description = Convert.ToString(reader["DESCRIPTION"]);
                    price = Convert.ToInt32(reader["PRICE"]);
                    quantity = Convert.ToInt32(reader["QUANTITY"]);
                    ListofItems.Add(new Item(id, description, price, quantity));
                }
            }
            catch
            {
                MessageBox.Show("error while loading the items");
            }
            finally
            {
                connection.Close();
            }
            return ListofItems;
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
        public int AddASpotAssigned(string rfid, int id, decimal newmoney)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?

            String sql = "update dbi335303.camping_spot set RFID_ASSIGNED='" + rfid + "' where SPOT_ID='" + id + "';";
            String sql2 = "update dbi335303.users set MONEY='" + newmoney + "' where RFID='" + rfid + "';";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlCommand command2 = new MySqlCommand(sql2, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                nrOfRecordsChanged = command2.ExecuteNonQuery();
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
        public int BuyItem(string rfid, int item_id, int quantity, decimal newmoney)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?

            String sql = "INSERT INTO `dbi335303`.`transaction` (`RFID`, `ITEM_ID`, `QUANTITY`) VALUES('" + rfid + "', '" + item_id + "','" + quantity + "')";
            String sql2 = "update dbi335303.users set MONEY='" + newmoney + "' where RFID='" + rfid + "';";
            String sql3 = "update dbi335303.item set QUANTITY = QUANTITY -'" + quantity + "' where ITEM_ID='" + item_id + "';";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlCommand command2 = new MySqlCommand(sql2, connection);
            MySqlCommand command3 = new MySqlCommand(sql3, connection);
            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                nrOfRecordsChanged = command2.ExecuteNonQuery();
                nrOfRecordsChanged = command3.ExecuteNonQuery();
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

        public int AddItem(int id, string description, int price, int quantity)
        {
            String sql = "INSERT INTO dbi335303.item (`ITEM_ID`, `DESCRIPTION`, `PRICE`, `QUANTITY`) VALUES('" + id + "', '" + description + "','" + price + "', '" + quantity + "')";

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

        public int SetQuantity(int iD, int quantity)
        {

            try
            {

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
               
                
                string Command = "Update item set QUANTITY='" + quantity + "' where ITEM_ID='" + iD;

                MySqlCommand MyCommand2 = new MySqlCommand(Command, connection);
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

        public int PutInCamping(string rfid)
        {       
            try
            {

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update dbi335303.users set INCAMPING=1 where RFID='" + rfid + "';";
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

        public int PutOutOfCamping(string rfid)
        {
            try
            {

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update dbi335303.users set INCAMPING=0 where RFID='" + rfid + "';";
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

        public int CheckForAssignedCampingSpot(string id)
        {

            try
            {

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "SELECT * FROM dbi335303.camping_spot where ID='" + id + "';";
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
        public int ExitFromEvent(string rfid)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?

            try
            {

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update dbi335303.users set INEVENT=0, LEFTEVENT=1 where RFID='" + rfid + "';";
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
        public string NameCorrespondingToRFID(string rfid)
        {
            String sql = "SELECT FNAME FROM users WHERE RFID='" + rfid + "';";
            MySqlCommand command = new MySqlCommand(sql, connection);
            string name = string.Empty;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    name = Convert.ToString(reader["FNAME"]);
                }
            }
            catch
            {
                MessageBox.Show("error while loading the items");
            }
            finally
            {
                connection.Close();
            }
            return name;
        }

        public int IDCorrespondingToRFID(string rfid)
        {
            String sql = "SELECT USER_ID FROM users WHERE RFID='" + rfid + "';";
            MySqlCommand command = new MySqlCommand(sql, connection);
            int id = -1;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["USER_ID"]);
                }
            }
            catch
            {
                MessageBox.Show("error while loading the items");
            }
            finally
            {
                connection.Close();
            }
            return id;
        }

        public string ItemForLoanNameFromID(int id)
        {
            String sql = "SELECT item_name FROM items_for_loan WHERE ITEM_ID='" + id + "';";
            MySqlCommand command = new MySqlCommand(sql, connection);
            string ItemName = string.Empty;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ItemName = Convert.ToString(reader["item_name"]);
                }
            }
            catch
            {
                MessageBox.Show("error while loading the items");
            }
            finally
            {
                connection.Close();
            }
            return ItemName;
        }
        public List<string> GetAllItemsToLoan(int id)
        {
            String sql = "SELECT * FROM item_loaned WHERE user_id='" + id + "';";
            MySqlCommand command = new MySqlCommand(sql, connection);
            List<string> temp;
            temp = new List<string>();
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                string item;
                while (reader.Read())
                {
                    item = Convert.ToString(reader["item_id"]);
                    temp.Add(item);
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
    }
}
