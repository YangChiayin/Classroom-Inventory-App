using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms
{
    public class Classroom
    {
        // 1a. get/set properties:
        public int ClassroomId { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public int NumberOfProjectors { get; set; }
        public bool IncludesSmartBoard { get; set; }
        public bool IsAccessible { get; set; }

        // 1b. Add a read (i.e. get) only string property that returns the campus name
        public string Campus
        {
            get
            {
                if (RoomNumber.StartsWith("W"))
                    return "Waterloo";
                else if (RoomNumber.StartsWith("D"))
                    return "Doon";
                else if (RoomNumber.StartsWith("C"))
                    return "Cambridge";
                else
                    return "Unknown";
            }
        }

        // 1c. Override the ToString to return a string
        public override string ToString()
        {
            return $"{RoomNumber} | {Campus} | Capacity: {Capacity} | Projectors: {NumberOfProjectors} | Smart Board: {(IncludesSmartBoard ? "Yes" : "No")} | Accessible: {(IsAccessible ? "Yes" : "No")}";
        }


    }
}
