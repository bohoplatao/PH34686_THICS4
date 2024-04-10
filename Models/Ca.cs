using System.ComponentModel.DataAnnotations;

namespace PH34686_THICS4.Models
{
    public class Ca
    {
        [Key]  
        public string ID { get; set; }
        public string Ten { get; set; }
        public int Tuoi {  get; set; }
        public string NoiSong { get; set; }
        public string ID_DongVat { get; set; } // thêm 1 trường dữ liệu để nối 2 bảng, chú ý kiểu dữ liệu phải giống ID của bảng bên 
        public virtual DongVat DongVat { get; set; } // virtal này ko cần Icon lếch sờn ở đây 

    }
}
