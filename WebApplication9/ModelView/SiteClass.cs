using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication9.ModelView
{
    public class TeacherDersListClass
    {
        public int TeacherDersID { get; set; }
        public int? OgretmenID { get; set; }
        public string OgretmenAdi { get; set; }
        public int? DersId { get; set; }
        public string DersAdi { get; set; }
    }
}