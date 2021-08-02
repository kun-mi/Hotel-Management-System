using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    class GLOBAL
    {

        public static int GlobalUserId { get; private set; }

        public static int  GlobalRoomId { get; private set; }

        public static void setUserID(int userID)
        {
            GlobalUserId = userID;
        }

        public static void setRoomId(int roomID)
        {
            GlobalRoomId = roomID;
        }
    }
}
