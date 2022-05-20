using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Dell", Url = "dell", Icon = "laptop" },
                new Category { Id = 2, Name = "Asus", Url = "asus", Icon = "laptop" },
                new Category { Id = 3, Name = "HP", Url = "hp", Icon = "laptop" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Dell 1",
                    Description = "Với phong cách thiết kế độc đáo cùng cấu hình vượt trội, laptop Dell Gaming Alienware m15 R6 i7 11800H (70272633) sẵn sàng đáp ứng hoàn hảo mọi tác vụ của một chiếc laptop đồ họa - kỹ thuật như thiết kế hay chiến game.",
                    Image = "https://cdn.tgdd.vn/Products/Images/44/271090/Slider/dell-gaming-alienware-m15-r6-i7-70272633-fix-01-1020x570.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Dell 2",
                    Description = "Laptop Dell Gaming G15 5515 R7 5800H (70266674) sở hữu thiết kế thời thượng với từng đường nét tinh tế cùng hiệu năng mạnh mẽ, là bạn đồng hành lý tưởng cho bất kỳ ai.",
                    Image = "https://cdn.tgdd.vn/Products/Images/44/269650/Slider/dell-gaming-g15-5515-r7-70266674-01-1020x570.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Dell 3",
                    Description = "Nhắc đến dòng laptop gaming, nhà Dell cũng đã sở hữu cho mình một siêu phẩm không thể bỏ qua là chiếc laptop Dell Alienware m15 R6 i7 (P109F001DBL) với card đồ hoạ RTX 3060 6 GB mạnh mẽ sẵn sàng cùng bạn chinh phục mọi thử thách chiến game.",
                    Image = "https://cdn.tgdd.vn/Products/Images/44/271545/Slider/vi-vn-dell-gaming-alienware-m15-r6-i7-p109f001dbl-1.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Asus 1",
                    Description = "Với cấu hình khoẻ từ card rời NVIDIA GeForce GTX cùng một thiết kế ấn tượng, laptop Asus TUF Gaming FX506LH i5 (HN188W) sẽ mang đến nhiều trải nghiệm thú vị cho các game thủ.",
                    Image = "https://cdn.tgdd.vn/Products/Images/44/269241/Slider/asus-tuf-gaming-fx506lh-i5-hn188w-fix-1-1020x570.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Asus 2",
                    Description = "Sở hữu sức mạnh hiệu năng đột phá của dòng laptop CPU thế hệ 12 và card màn hình rời NVIDIA cùng thiết kế là sự cộng hưởng của chiếc máy tính bảng và chiếc laptop gaming, laptop Asus Gaming ROG Flow Z13 GZ301Z (LD110W) sẵn sàng chinh phục mọi đấu trường ảo cùng bạn.",
                    Image = "https://cdn.tgdd.vn/Products/Images/44/274539/Slider/vi-vn-asus-gaming-rog-flow-z13-gz301z-i7-ld110w-1.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Asus 3 ",
                    Description = "Laptop Asus ZenBook UX482EA i5 1135G7 (KA397W) sở hữu thiết kế thời thượng cùng hiệu năng mạnh mẽ, xứng danh bạn đồng hành lý tưởng trên chặng đường sáng tạo của người dùng.",
                    Image = "https://cdn.tgdd.vn/Products/Images/44/270920/Slider/vi-vn-asus-zenbook-ux482ea-i5-ka397w-2.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "HP 1",
                    Description = "Dòng Gaming Victus là một phiên bản lột xác hoàn toàn từ thiết kế đến hiệu năng của nhà HP. Chỉ với một mức giá tầm trung là bạn có thể sở hữu ngay chiếc laptop HP Gaming VICTUS 16 e0170AX R7 (4R0U7PA) chinh phục mọi tác vụ.",
                    Image = "https://cdn.tgdd.vn/Products/Images/44/268677/Slider/vi-vn-hp-gaming-victus-16-e0170ax-r7-4r0u7pa-1.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "HP 2",
                    Description = "HP ZBook Firefly 14 G8 (275V5AV) chinh phục mọi đối tượng khách hàng với phong cách thiết kế thời thượng, gọn nhẹ cùng những tính năng ưu việt mà nó mang lại, đáp ứng tối đa mọi nhu cầu cần thiết từ học tập - văn phòng cơ bản đến thiết kế đồ họa chuyên sâu.",
                    Image = "https://cdn.tgdd.vn/Products/Images/44/264438/Slider/vi-vn-hp-zbook-firefly-14-g8-i5-275v5av-1.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Title = "HP 3",
                    Description = "Thanh lịch hơn cùng màu vàng đồng của chiếc HP Envy 13 ba1535TU i7 1165G7 (4U6M4PA) với hệ điều hành Windows 11 được lập trình sẵn, phát huy tối đa năng lượng, sẵn sàng cùng bạn hoàn thành mọi tác vụ khó nhằn.",
                    Image = "https://cdn.tgdd.vn/Products/Images/44/256218/Slider/1-1020x570.jpg",
                    DateCreated = new DateTime(2021, 1, 1)
                }
            );

            modelBuilder.Entity<Edition>().HasData(
                    new Edition { Id = 1, Name = "Default" },
                    new Edition { Id = 2, Name = "RAM 16GB" },
                    new Edition { Id = 3, Name = "RAM 8GB" },
                    new Edition { Id = 4, Name = "RAM 4GB" },
                    new Edition { Id = 5, Name = "HDD 512GB" },
                    new Edition { Id = 6, Name = "SSD 512GB" },
                    new Edition { Id = 7, Name = "SSD 256GB" }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 2,
                    Price = 1300m,
                    OriginalPrice = 1500m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 3,
                    Price = 1100m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    EditionId = 4,
                    Price = 600m,
                    OriginalPrice = 1000m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 800m,
                    OriginalPrice = 1000m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    EditionId = 2,
                    Price = 800m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    EditionId = 1,
                    Price = 1800m,
                    OriginalPrice = 2000m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    EditionId = 1,
                    Price = 1500m,
                    OriginalPrice = 16000m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    EditionId = 1,
                    Price = 950m,
                    OriginalPrice = 1000m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 5,
                    Price = 999m,
                    OriginalPrice = 1000m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 6,
                    Price = 1350m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    EditionId = 7,
                    Price = 1300m,
                    OriginalPrice = 1399m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    EditionId = 5,
                    Price = 1560m,
                    OriginalPrice = 1590m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    EditionId = 5,
                    Price = 1250m
                }
            );
        }
    }
}
