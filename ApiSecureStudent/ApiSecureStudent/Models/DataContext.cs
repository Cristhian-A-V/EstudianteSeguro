namespace ApiSecureStudent.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ApiSecureStudent.Models.Student> Students { get; set; }
    }
}