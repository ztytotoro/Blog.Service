using System;

namespace Database.Entities.Visitor
{
    class VisitRecord
    {
        public string Ip { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime LeaveTime { get; set; }
        public string Path { get; set; }
    }
}
