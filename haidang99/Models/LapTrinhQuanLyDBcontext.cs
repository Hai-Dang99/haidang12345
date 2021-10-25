using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace haidang99.Models
{
    public class LapTrinhQuanLyDBcontext : DbContext
    {

        public LapTrinhQuanLyDBcontext() : base("LapTrinhQuanLyDBcontext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }



    }
}
//DESKTOP - 62IMTN6\SQLEXPRESS