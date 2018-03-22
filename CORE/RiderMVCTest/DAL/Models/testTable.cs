using System.ComponentModel.DataAnnotations;

namespace RiderMVCTest.DAL.Models
{
    public class TestTable
    {
        [Key]
        public int Unid { get; set; }
        public string Name { get; set; }
    }
}