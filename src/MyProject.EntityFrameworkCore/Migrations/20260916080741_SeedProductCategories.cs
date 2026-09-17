using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
             table: "Jew_ProductCategory",
             columns: new[]
             {
                "Id",
                "Name",
                "Description",
                "CreationTime",
                "IsDeleted"
             },
             values: new object[,]
         {
            { 1L, "Nhẫn", "Các loại nhẫn trang sức dành cho nhiều phong cách và nhu cầu sử dụng.", new DateTime(2025, 3, 19, 0, 40, 2), false },
            { 2L, "Vòng", "Các loại vòng tay trang sức với nhiều chất liệu và kiểu dáng khác nhau.", new DateTime(2025, 3, 19, 0, 40, 11), false },
            { 3L, "Dây chuyền", "Các loại dây chuyền trang sức dành cho nam và nữ.", new DateTime(2025, 3, 19, 0, 40, 18), false },
            { 4L, "Mặt dây chuyền", "Các loại mặt dây chuyền với nhiều kiểu dáng và chất liệu.", new DateTime(2025, 3, 19, 0, 40, 25), false },
            { 5L, "Bông tai", "Các loại bông tai trang sức với nhiều thiết kế và chất liệu.", new DateTime(2025, 3, 19, 0, 40, 31), false },
            { 6L, "Lắc", "Các loại lắc tay trang sức mang phong cách thanh lịch và hiện đại.", new DateTime(2025, 3, 19, 0, 40, 37), false },
            { 7L, "Dây cổ", "Các loại dây cổ trang sức với nhiều kiểu dáng và chất liệu.", new DateTime(2025, 3, 19, 0, 40, 43), false },
            { 8L, "Kiềng", "Các loại kiềng trang sức với thiết kế sang trọng và tinh tế.", new DateTime(2025, 3, 19, 0, 40, 50), false },
            { 9L, "Charm", "Các loại charm dùng để kết hợp và trang trí cho vòng hoặc dây chuyền.", new DateTime(2025, 3, 19, 0, 41, 43), false },

            { 10L, "Bông tai vàng", "Bông tai được chế tác từ vàng với nhiều kiểu dáng sang trọng.", new DateTime(2025, 3, 19, 0, 41, 43), false },
            { 11L, "Bông tai bạc", "Bông tai bạc có thiết kế đa dạng, phù hợp sử dụng hằng ngày.", new DateTime(2025, 3, 19, 0, 41, 59), false },

            { 12L, "Charm bạc", "Charm bạc với thiết kế nhỏ gọn, phù hợp kết hợp với vòng tay và dây chuyền.", new DateTime(2025, 3, 19, 0, 42, 17), false },
            { 13L, "Charm vàng", "Charm vàng mang đến điểm nhấn sang trọng cho vòng tay và dây chuyền.", new DateTime(2025, 3, 19, 0, 42, 25), false },

            { 14L, "Dây chuyền vàng", "Dây chuyền vàng với thiết kế sang trọng, phù hợp cho nhiều dịp.", new DateTime(2025, 3, 19, 0, 43, 16), false },
            { 15L, "Dây chuyền bạc", "Dây chuyền bạc với nhiều kiểu dáng trẻ trung và thanh lịch.", new DateTime(2025, 3, 19, 0, 43, 24), false },
            { 16L, "Dây chuyền bạch kim", "Dây chuyền bạch kim cao cấp với thiết kế tinh tế và sang trọng.", new DateTime(2025, 3, 19, 0, 43, 28), false },

            { 17L, "Dây cổ bạc", "Dây cổ bạc với thiết kế thanh lịch, phù hợp sử dụng hằng ngày.", new DateTime(2025, 3, 19, 0, 43, 46), false },
            { 18L, "Dây cổ vàng", "Dây cổ vàng với thiết kế sang trọng và nổi bật.", new DateTime(2025, 3, 19, 0, 43, 53), false },

            { 19L, "Kiềng vàng", "Kiềng vàng với thiết kế sang trọng, phù hợp làm điểm nhấn cho trang phục.", new DateTime(2025, 3, 19, 0, 44, 13), false },
            { 20L, "Kiềng bạc", "Kiềng bạc với thiết kế tinh tế và dễ dàng kết hợp với nhiều phong cách.", new DateTime(2025, 3, 19, 0, 44, 16), false },

            { 21L, "Lắc bạc", "Lắc bạc với kiểu dáng thanh lịch, phù hợp sử dụng hằng ngày.", new DateTime(2025, 3, 19, 0, 44, 35), false },
            { 22L, "Lắc vàng", "Lắc vàng mang phong cách sang trọng và tinh tế.", new DateTime(2025, 3, 19, 0, 44, 39), false },

            { 23L, "Mặt dây chuyền vàng", "Mặt dây chuyền vàng với nhiều thiết kế nổi bật và sang trọng.", new DateTime(2025, 3, 19, 0, 45, 0), false },
            { 24L, "Mặt dây chuyền bạc", "Mặt dây chuyền bạc với thiết kế tinh tế và dễ phối hợp.", new DateTime(2025, 3, 19, 0, 45, 4), false },

            { 25L, "Nhẫn vàng", "Nhẫn vàng với nhiều kiểu dáng sang trọng, phù hợp cho nhiều dịp.", new DateTime(2025, 3, 19, 0, 45, 24), false },
            { 26L, "Nhẫn bạc", "Nhẫn bạc với thiết kế trẻ trung, thanh lịch và dễ sử dụng.", new DateTime(2025, 3, 19, 0, 45, 28), false },
            { 27L, "Nhẫn bạch kim", "Nhẫn bạch kim cao cấp với thiết kế tinh tế và độ bền cao.", new DateTime(2025, 3, 19, 0, 45, 34), false },

            { 28L, "Vòng vàng", "Vòng vàng với thiết kế sang trọng, phù hợp làm phụ kiện thời trang.", new DateTime(2025, 3, 19, 0, 45, 53), false },
            { 29L, "Vòng bạc", "Vòng bạc với nhiều kiểu dáng trẻ trung và thanh lịch.", new DateTime(2025, 3, 19, 0, 45, 56), false },
            { 30L, "Vòng bạch kim", "Vòng bạch kim cao cấp với thiết kế tinh tế và sang trọng.", new DateTime(2025, 3, 19, 0, 46, 1), false }
         });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jew_ProductCategory",
                keyColumn: "Id",
                keyValues: new object[]
                {
                    1L, 2L, 3L, 4L, 5L,
                    6L, 7L, 8L, 9L, 10L,
                    11L, 12L, 13L, 14L, 15L,
                    16L, 17L, 18L, 19L, 20L,
                    21L, 22L, 23L, 24L, 25L,
                    26L, 27L, 28L, 29L, 30L
                });
        }
    }
}
