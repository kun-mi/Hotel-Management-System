using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class roomsH : UserControl
    {
        WORKER worker = new WORKER();

        public roomsH()
        {
            InitializeComponent();
        }

        private void RoomsH_Load(object sender, EventArgs e)
        {
            DataTable AllRooms = worker.LoadRoomStatus;
            roomsData.DataSource = AllRooms;
            /*foreach (var cell in roomsData.Rows[2].Cells)
            {
                if (cell.Equals(0))
                {
                    roomsData.CurrentRow.Cells[2].EditType.IsValueType = true;
                    roomsData.CurrentRow.Cells[2].Value = 'Unoccupied';
                }
            }*/
            progressBarTimer.Start();

            
        }

        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {
            allRoomsPB.Value = worker.getAllRooms().Rows.Count - worker.getAllRooms(0).Rows.Count;
            standardpb.Value = worker.getRooms(1).Rows.Count - worker.getRooms(1, 0).Rows.Count;
            deluxepb.Value = worker.getRooms(2).Rows.Count - worker.getRooms(2, 0).Rows.Count;
            executivepb.Value = worker.getRooms(3).Rows.Count - worker.getRooms(3, 0).Rows.Count;
            standard2pb.Value = worker.getRooms(4).Rows.Count - worker.getRooms(4, 0).Rows.Count;
            deluxe2pb.Value = worker.getRooms(5).Rows.Count - worker.getRooms(5, 0).Rows.Count;

        }

        private void RefreshRoomsBtn_Click(object sender, EventArgs e)
        {
            DataTable AllRooms = worker.LoadRoomStatus;
            roomsData.DataSource = AllRooms;
        }

        private void SortRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (sortRooms.SelectedIndex.Equals(0))
            {
                DataTable AllRooms = worker.LoadRoomStatus;
                roomsData.DataSource = AllRooms;
            }
            else
            {
                int id = Convert.ToInt32(sortRooms.SelectedIndex.ToString());
                DataTable rooms = worker.GetRoomsByType(id);
                roomsData.DataSource = rooms;
            }
            
        }
    }
}
