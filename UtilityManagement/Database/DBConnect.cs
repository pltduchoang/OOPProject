﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityManagement;

namespace UtilityManagement.Database
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }
        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "utilitymanagementdatabase";
            uid = "root";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        //Select statement
        public  List<AppartmentCreator> DataTenent()
        {
            string query = "SELECT * FROM tenant";

            //Create a list to store the result
            //List<string>[] tenantList = new List<string>[6];
            //tenantList[0] = new List<string>();
            //tenantList[1] = new List<string>();
            //tenantList[2] = new List<string>();
            //tenantList[3] = new List<string>();
            //tenantList[4] = new List<string>();
            //tenantList[5] = new List<string>();

            var list = new List<AppartmentCreator>();

            //Open connection
            
            
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Read the data and store them in the list
            while (dataReader.Read())
            {
                int unitNum = dataReader.GetInt32(0);
                string fName = dataReader.GetString(1);
                string lName = dataReader.GetString(2);
                string beganDate = dataReader.GetString(3);
                double deposite = dataReader.GetDouble(4);
                string phone = dataReader.GetString(5);
                double rent = dataReader.GetInt32(6);
                double waterLaundry = dataReader.GetDouble(7);
                int lastPower = dataReader.GetInt32(8);
                int power = dataReader.GetInt32(9);
                AppartmentCreator appartmentData = new AppartmentCreator(unitNum, fName, lName, beganDate, deposite, phone, rent, waterLaundry, lastPower, power);
                //AppartmentCreator ac = new AppartmentCreator();
                //ac.appartmentList.Add(appartmentData);
                list.Add(appartmentData);
            }

            //close Data Reader
            dataReader.Close();

            //close Connection
            this.CloseConnection();

            //return list to be displayed
            return list;

        }

        //Select statement
        public List<string>[] DataBill()
        {
            string query = "SELECT * FROM bill";

            //Create a list to store the result
            List<string>[] billList = new List<string>[5];
            billList[0] = new List<string>();
            billList[1] = new List<string>();
            billList[2] = new List<string>();
            billList[3] = new List<string>();
            billList[4] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    billList[0].Add(dataReader["rent_$"] + "");
                    billList[1].Add(dataReader["waterLaundry_$"] + "");
                    billList[2].Add(dataReader["last_power"] + "");
                    billList[3].Add(dataReader["power_$"] + "");
                    billList[4].Add(dataReader["unitNum"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return billList;
            }
            else
            {
                return billList;
            }
        }
    }
}
