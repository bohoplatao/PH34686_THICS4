using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PH34686_THICS4.Models;

namespace PH34686_THICS4.Configrutations
{
    public class ConfigCa : IEntityTypeConfiguration<Ca> // ở trong <> chỉ là Bảng cần tham chiếu đến ko phải Config 
    {
        public void Configure(EntityTypeBuilder<Ca> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(x => x.ID);// khai báo ID chính(đéo phải khóa phụ)
            builder.HasOne(x => x.DongVat).WithMany(x =>x.Cas); // bảng 1 là bảng Dong Vật , còn n là bảng Ca
        }
    }
}
