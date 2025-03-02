using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms
{
    public interface IClassroomManager
    {
        int GetNextClassroomId();
        void AddClassroom(Classroom classroom);
        List<Classroom> GetAllClassrooms();
        Classroom GetClassroomById(int classroomId);
        void UpdateClassroom(Classroom classroom);
    }
}
