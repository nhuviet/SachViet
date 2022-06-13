using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace SachViet.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            BooksLibDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BooksLibDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                new Book
                {
                    Title = "Nhà giả kim",
                    Description = "khi người nào muốn điều gì thì cả vũ trụ sẽ chung sức lại để người ấy đạt được điều mơ ước. Những thứ vào miệng con người không độc hại, xấu xa. Xấu xa, độc hại là những gì từ miệng họ tuôn ra. Nếu cậu hiểu rõ trái tim mình thì sẽ không xảy ra điều gì bất trắc",
                    Price = 143,
                    Author = "Paulo Coelho",
                    Genre = "Tâm Linh",
                    ImgPath = "https://isach.info/images/story/cover/nha_gia_kim__paulo_coelho.jpg"
                },new Book
                {
                    Title = "Hành trình về phương đông",
                    Description = "Kể về những trải nghiệm của một đoàn khoa học gồm các chuyên gia hàng đầu của Hội Khoa Học Hoàng Gia Anh được cử sang Ấn Độ nghiên cứu về huyền học và những khả năng siêu nhiên của con người.",
                    Price = 106,
                    Author = "Baird T. Spalding",
                    Genre = "Tâm Linh",
                    ImgPath = "https://cf.shopee.vn/file/90c279c2bf3fcc2b59479d121de65093"

                }
                );
                context.SaveChanges();
            }
        }
    }
}
