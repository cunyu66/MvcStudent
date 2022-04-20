using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcStudent.Controllers
{
    public class student
    {
        public int Id { get; set; }
        [Display(Name = "姓名")]      
        [StringLength(60, MinimumLength = 2)]       
        public string Name { get; set; }
        [Display(Name = "性别")]
        [StringLength(1)]
        public string? sex { get; set; }

        [Display(Name ="年龄")]
        [Range(1,200)]        
        public int age { get; set; }
        [Display(Name = "出生日期")]
        public DateTime Birthday { get; set; }
        [Display(Name = "手机号")]
        public string? phone { get; set; }
        [Display(Name = "体温")]       
        public int temperature { get; set; }
        [Display(Name = "填表日期")]
        public DateTime Date { get; set; }

    }
}
