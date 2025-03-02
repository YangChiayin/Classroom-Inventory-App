using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Rooms
{
    public class ClassroomManager : IClassroomManager
    {
        // Private field for the filename
        private readonly string filename = "classrooms.txt";

        // Constructor
        public ClassroomManager()
        {
            // Create the file if it doesn't exist
            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
            }
        }

        // GetNextClassroomId method
        public int GetNextClassroomId()
        {
            var classrooms = GetAllClassrooms();
            return classrooms.Count > 0 ? classrooms.Max(c => c.ClassroomId) + 1 : 1;
        }

        // AddClassroom method
        public void AddClassroom(Classroom classroom)
        {
            classroom.ClassroomId = GetNextClassroomId();
            string classroomRecord = FormatClassroomForFile(classroom);
            File.AppendAllText(filename, classroomRecord + Environment.NewLine);
        }

        // GetAllClassrooms method
        public List<Classroom> GetAllClassrooms()
        {
            var classrooms = new List<Classroom>();
            var lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                var classroom = ParseFileLineToClassroom(line);
                if (classroom != null)
                {
                    classrooms.Add(classroom);
                }
            }
            return classrooms;
        }

        // GetClassroomById method
        public Classroom GetClassroomById(int classroomId)
        {
            return GetAllClassrooms().FirstOrDefault(c => c.ClassroomId == classroomId);
        }

        // UpdateClassroom method
        public void UpdateClassroom(Classroom classroom)
        {
            var classrooms = GetAllClassrooms();
            var existingClassroom = classrooms.FirstOrDefault(c => c.ClassroomId == classroom.ClassroomId);
            if (existingClassroom != null)
            {
                classrooms.Remove(existingClassroom);
                classrooms.Add(classroom);
                WriteClassroomsToFile(classrooms);
            }
        }
        // Private helper methods
        private Classroom ParseFileLineToClassroom(string line)
        {
            var parts = line.Split('|');
            if (parts.Length == 6)
            {
                return new Classroom
                {
                    ClassroomId = int.Parse(parts[0]),
                    RoomNumber = parts[1],
                    Capacity = int.Parse(parts[2]),
                    NumberOfProjectors = int.Parse(parts[3]),
                    IncludesSmartBoard = bool.Parse(parts[4]),
                    IsAccessible = bool.Parse(parts[5])
                };
            }
            return null;
        }

        private string FormatClassroomForFile(Classroom classroom)
        {
            return $"{classroom.ClassroomId}|{classroom.RoomNumber}|{classroom.Capacity}|{classroom.NumberOfProjectors}|{classroom.IncludesSmartBoard}|{classroom.IsAccessible}";
        }

        private void WriteClassroomsToFile(List<Classroom> classrooms)
        {
            var lines = classrooms.Select(FormatClassroomForFile).ToArray();
            File.WriteAllLines(filename, lines);
        }
    }
}
