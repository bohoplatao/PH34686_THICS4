using System.ComponentModel.DataAnnotations;

namespace PH34686_THICS4.Models
{
    public class DongVat
    {
        [Key]
        public string ID { get; set; }
        public string Ho { get; set; }
        public string ThucAn { get; set; }
        public virtual ICollection<Ca> Cas { get; set; } // thêm virtal Icon lêch sờn trong <> là tên bảng còn lại,
                                                         // Phần màu trắng chỉ là tên đặt cái đéo j cũng đc 

    }
}
