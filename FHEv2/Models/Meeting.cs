using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal.Mapping;

namespace FHEv2.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public List<Member> Members { get; set; } = [];
        public List<Assignment> Assignments { get; set; } = [];
    }
}
