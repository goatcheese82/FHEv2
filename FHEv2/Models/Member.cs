using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal.Mapping;

namespace FHEv2.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Birthdate { get; set; } = DateTime.Now;
        public List<Meeting> Meetings { get; set; } = [];
        public List<Assignment> Assignments { get; set; } = [];
    }
}
