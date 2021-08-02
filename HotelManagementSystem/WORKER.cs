using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotelManagementSystem
{
    class WORKER
    {
        USER user = new USER();

        public bool verifUser(string username, string password, int admin)
        {
            bool verif = true;
            string task = "SELECT `Username`, `Password`, `admin`, `id` FROM `userlogin`";

            MySqlCommand command = new MySqlCommand(task, user.getconnection);
            MySqlDataAdapter taskAdapter = new MySqlDataAdapter(command);
            DataTable userTable = new DataTable();
            taskAdapter.Fill(userTable);
            for (int i = 0; i < userTable.Rows.Count; i++)
            {
                if (username.Equals(userTable.Rows[i][0]) && password.Equals(userTable.Rows[i][1]) && admin.Equals(userTable.Rows[i][2]))
                {
                    GLOBAL.setUserID(Convert.ToInt32(userTable.Rows[i][3].ToString()));
                    verif = true;
                    break;
                }
                else
                {
                    verif = false;
                }
            }
            return verif;
        }

        public DataTable retrieveUser(int userid)
        {
            string task = "SELECT `Lastname`, `Picture` FROM `userlogin` WHERE `id` =" + userid;
            MySqlCommand command = new MySqlCommand(task, user.getconnection);
            MySqlDataAdapter taskAdapter = new MySqlDataAdapter(command);
            DataTable userTable = new DataTable();
            taskAdapter.Fill(userTable);
            return userTable;
        }

        public bool AddCustomer(string firstname, string lastname, string telephone, string telNOK, string room, string checkin, string checkout, int residents, string payment)
        {
            string insert = "INSERT INTO `customers`(`Firstname`, `Lastname`, `Telephone`, `Telephone(Next of Kin)`, `Room`, `Check in`, `Check out`, `Residents`, `Payment Type`) VALUES ('"+ firstname +"', '"+ lastname +"','" + telephone + "','" + telNOK + "','" + room + "','" + checkin + "','" + checkout + "','" + residents + "','" + payment + "')";
            MySqlCommand command = new MySqlCommand(insert, user.getconnection);
            user.openconnection();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public DataTable getRoomTypes()
        {
            string task = "SELECT * FROM `roomtypes`";
            MySqlCommand getTypes = new MySqlCommand(task, user.getconnection);
            MySqlDataAdapter taskAdapter = new MySqlDataAdapter(getTypes);
            DataTable typeTable = new DataTable();
            taskAdapter.Fill(typeTable);
            GLOBAL.setRoomId(Convert.ToInt32(typeTable.Rows[0][0].ToString()));
            return typeTable;
        }

        public DataTable getRooms(int id, int status)
        {
            string task = "SELECT `room` FROM `rooms` WHERE `room_type` = "+ id + " AND `room_status` =" +status;
            MySqlCommand getRooms = new MySqlCommand(task, user.getconnection);
            MySqlDataAdapter taskAdapter = new MySqlDataAdapter(getRooms);
            DataTable roomsTable = new DataTable();
            taskAdapter.Fill(roomsTable);
            return roomsTable;
        }

        public DataTable getRooms(int id)
        {
            string task = "SELECT `room` FROM `rooms` WHERE `room_type` = " + id;
            MySqlCommand getRooms = new MySqlCommand(task, user.getconnection);
            MySqlDataAdapter taskAdapter = new MySqlDataAdapter(getRooms);
            DataTable roomsTable = new DataTable();
            taskAdapter.Fill(roomsTable);
            return roomsTable;
        }

            public DataTable getAllRooms(int status)
        {
            string task = "SELECT `room` FROM `rooms` WHERE `room_status` =" + status;
            MySqlCommand getRooms = new MySqlCommand(task, user.getconnection);
            MySqlDataAdapter taskAdapter = new MySqlDataAdapter(getRooms);
            DataTable allRoomsTable = new DataTable();
            taskAdapter.Fill(allRoomsTable);
            return allRoomsTable;
        }

        public DataTable getAllRooms()
        {
            string task = "SELECT `room` FROM `rooms`";
            MySqlCommand getRooms = new MySqlCommand(task, user.getconnection);
            MySqlDataAdapter taskAdapter = new MySqlDataAdapter(getRooms);
            DataTable allRoomsTable = new DataTable();
            taskAdapter.Fill(allRoomsTable);
            return allRoomsTable;
        }

        public bool bookRoom(string room)
        {
            string task = "UPDATE `rooms` SET `room_status`= '1' WHERE `room`= '" + room + "'";
            MySqlCommand book = new MySqlCommand(task, user.getconnection);
            user.openconnection();
            if (book.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public DataTable retrieveMsg(int uid, int status)
        {
            string task = "SELECT `messsage`,`mid` FROM `messages` WHERE `uid` = " + uid + " AND `status` = " + status;
            MySqlCommand retrieveCommand = new MySqlCommand(task, user.getconnection);
            DataTable smsTable = new DataTable();
            MySqlDataAdapter smsAdapter = new MySqlDataAdapter(retrieveCommand);
            smsAdapter.Fill(smsTable);
            return smsTable;
        }

        public DataTable retrieveMsg(int uid)
        {
            string task = "SELECT * FROM `messages` WHERE `uid` = " + uid;
            MySqlCommand retrieveCommand = new MySqlCommand(task, user.getconnection);
            DataTable smsTable = new DataTable();
            MySqlDataAdapter smsAdapter = new MySqlDataAdapter(retrieveCommand);
            smsAdapter.Fill(smsTable);
            return smsTable;
        }

        public void UpdateMsg(int mid)
        {
            string task = "UPDATE `messages` SET `status` = '1' WHERE `mid` = " + mid;
            MySqlCommand update = new MySqlCommand(task, user.getconnection);
            user.openconnection();
            update.ExecuteNonQuery();
            user.closeconnection();
        }

        public DataTable LoadRoomStatus
        {
            get
            {
                string LoadRoomsHistory = "SELECT `room`, `room_status`, roomtypes.roomtype  FROM `rooms`  JOIN `roomtypes` ON rooms.room_type = roomtypes.id";
                using (MySqlCommand LoadRooms = new MySqlCommand(LoadRoomsHistory, user.getconnection))
                {

                    DataTable RoomsHistory = new DataTable();
                    MySqlDataAdapter roomsHistoryAdapter = new MySqlDataAdapter(LoadRooms);
                    roomsHistoryAdapter.Fill(RoomsHistory);
                    return RoomsHistory;

                }

            }
        }

        public DataTable GetRoomsByType(int rType)
        {
            string LoadRoomsHistory = "SELECT `room`, `room_status`, roomtypes.roomtype  FROM `rooms`  JOIN `roomtypes` ON rooms.room_type = roomtypes.id WHERE roomtypes.id = " + rType;
            using (MySqlCommand LoadRooms = new MySqlCommand(LoadRoomsHistory, user.getconnection))
            {

                DataTable RoomsHistory = new DataTable();
                MySqlDataAdapter roomsHistoryAdapter = new MySqlDataAdapter(LoadRooms);
                roomsHistoryAdapter.Fill(RoomsHistory);
                return RoomsHistory;

            }
        }
    }
}
