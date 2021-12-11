using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssignmentWAP.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string MaSinhVien { get; set; }
        public string HinhThucNopPhat { get; set; }
        public int SoTienNopPhat { get; set; }
        public DateTime NgayNopPhat
        {
            get { return DateTime.Now; }
        }
    }
}