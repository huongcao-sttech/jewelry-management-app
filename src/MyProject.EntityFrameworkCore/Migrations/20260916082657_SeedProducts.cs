using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "SET IDENTITY_INSERT [dbo].[Jew_Product] ON;"
            );

            migrationBuilder.InsertData(
                table: "Jew_Product",
                columns: new[]
                {
                    "Id",
                    "Title",
                    "Description",
                    "Material",
                    "Status",
                    "CategoryId",
                    "CreationTime",
                    "CreatorUserId",
                    "LastModificationTime",
                    "LastModifierUserId",
                    "IsDeleted",
                    "DeleterUserId",
                    "DeletionTime"
                },
                values: new object[,]
                {
                    {
                        1L,
                        "Bông tai Vàng trắng 14K đính đá ECZ PNJ XM00W001484",
                        "Đôi bông tai được các nghệ nhân kim hoàn khoác lên vẻ ngoài đầy tinh xảo bởi được chế tác từ vàng 14K. Và những viên đá ECZ đạt tiêu chuẩn cao nhất về chất lượng cùng độ chính xác trong từng giác cắt, được đính một cách khéo léo trên đôi khuyên tai càng làm cho sản phẩm trở nên rực rỡ và kiêu sa.\r\nMang vẻ đẹp hoàn hảo không thua kém kim cương, đôi bông tai với điểm nhấn đá ECZ sẽ là “trợ thủ” nâng tầm nhan sắc của mọi cô nàng ưa chuộng phong cách hiện đại và thanh lịch.",
                        "Vàng trắng",
                        1,
                        10L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        2L,
                        "Bông tai Vàng trắng 14K đính đá ECZ PNJ XM00W001483",
                        "Đôi bông tai được các nghệ nhân kim hoàn khoác lên vẻ ngoài đầy tinh xảo bởi được chế tác từ vàng 14K. Và những viên đá ECZ đạt tiêu chuẩn cao nhất về chất lượng cùng độ chính xác trong từng giác cắt, được đính một cách khéo léo trên đôi khuyên tai càng làm cho sản phẩm trở nên rực rỡ và kiêu sa.\r\nMang vẻ đẹp hoàn hảo không thua kém kim cương, đôi bông tai với điểm nhấn đá ECZ sẽ là “trợ thủ” nâng tầm nhan sắc của mọi cô nàng ưa chuộng phong cách hiện đại và thanh lịch.",
                        "Vàng trắng",
                        1,
                        10L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        3L,
                        "Bông tai Vàng trắng 14K Đính đá ECZ PNJ XM00W001509",
                        "Đôi bông tai được các nghệ nhân kim hoàn khoác lên vẻ ngoài đầy tinh xảo bởi được chế tác từ vàng 14K. Và những viên đá ECZ đạt tiêu chuẩn cao nhất về chất lượng cùng độ chính xác trong từng giác cắt, được đính một cách khéo léo trên đôi khuyên tai càng làm cho sản phẩm trở nên rực rỡ và kiêu sa.\r\nMang vẻ đẹp hoàn hảo không thua kém kim cương, đôi bông tai với điểm nhấn đá ECZ sẽ là “trợ thủ” nâng tầm nhan sắc của mọi cô nàng ưa chuộng phong cách hiện đại và thanh lịch.",
                        "Vàng trắng",
                        1,
                        10L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        4L,
                        "Bông tai Vàng 18K đính đá CZ PNJ XM00Y003571",
                        "Long lanh, kiêu sa tựa như những đóa hoa ban nở giữa rừng, thiết kế bông tai của PNJ được tạo nên giữa sự kết hợp của vàng 18K cùng đá CZ lấp lánh. Từng đường viền mềm mại được chế tác sinh động, kết hợp những viên đá CZ tròn nhỏ, tất cả đã mang đến đôi bông tai nổi bật với vẻ đẹp tinh tế.\r\nĐừng chờ đợi mà hãy chăm chút bản thân và đẹp mọi lúc mọi nơi vì chính nàng muốn thế mà chẳng cần lý do nào khác. PNJ tin rằng, khí chất của nàng sẽ được lột tả hết khi ướm lên mình đôi bông tai này.",
                        "Vàng 18K",
                        1,
                        10L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        5L,
                        "Bông tai Vàng trắng Ý 18K PNJ 0000W002718",
                        "Làm mới quy chuẩn cổ điển của sắc vàng 18K cùng thiết kế hiện đại, đôi bông tai PNJ hiện hữu nét tươi mới, lại thật vừa vặn để sáng bừng vẻ đẹp lạc quan của quý cô. Sự đồng điệu và hài hòa theo từng đường nét ngẫu hứng, tạo nên tổng thể cho đôi bông tai tuyệt đẹp.\r\nNhững sản phẩm vàng Ý tinh tế từ PNJ đã và đang khuấy động xu hướng thời trang hiện nay. Chọn ngay item để tôn lên vẻ đẹp và khẳng định phong cách của riêng mình, nàng nhé.",
                        "Vàng trắng",
                        1,
                        10L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        6L,
                        "Bông tai Vàng trắng 14K đính đá ECZ PNJ Audax Rosa XMXMW003087",
                        "Lấy cảm hứng từ những câu chuyện của những người phụ nữ, những hành trình người thật việc thật về sự cố gắng, PNJ mang đến BST Audax Rosa với những món trang sức biểu tượng cho sự mạnh mẽ và luôn tỏa sáng của các quý cô. Đôi bông tai đính đá ECZ được thiết kế tinh giản các chi tiết sóng nhưng vẫn giữ đúng tinh thần xuyên suốt của toàn bộ sưu tập.\r\nSự tinh tế trong thiết kế biểu tượng sóng bằng kỹ thuật khắc máy - xi vàng làm nổi bật vẻ đẹp tự nhiên và sự kiêu sa của hoa hồng, tạo nên một trang sức độc đáo và thu hút. Mang vẻ đẹp hoàn hảo, đôi bông tai với điểm nhấn đá ECZ sẽ là “trợ thủ” nâng tầm nhan sắc của mọi cô nàng ưa chuộng phong cách hiện đại và thanh lịch.",
                        "Vàng trắng",
                        1,
                        10L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        7L,
                        "Bông tai Bạc đính đá STYLE By PNJ XM00Y000066",
                        "Bông tai bạc từ STYLE By PNJ được thiết kế kiểu dáng cá tính ,tinh tế với điểm nhấn đính đá trên chất liệu bạc 92.5, sáng lấp lánh làm nền tạo điểm nhấn giúp tôn lên vẻ đẹp của nàng xinh, gây ấn tượng với nhiều người xung quanh.\r\nDù là cuộc gặp mặt cuối năm nhẹ nhàng hay những bữa tiệc sôi động, nàng hãy luôn toát lên vẻ thanh lịch nổi bật cá tính với sự kết hợp hoàn hảo của một chiếc váy đen sang trọng cùng đôi bông tai phong cách từ Style by PNJ.",
                        "Bạc",
                        1,
                        11L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        8L,
                        "Bông tai Bạc đính đá STYLE By PNJ XMXMY000041",
                        "Bông tai bạc từ STYLE By PNJ được thiết kế kiểu dáng cá tính ,tinh tế với điểm nhấn đính đá trên chất liệu bạc 92.5, sáng lấp lánh làm nền tạo điểm nhấn giúp tôn lên vẻ đẹp của nàng xinh, gây ấn tượng với nhiều người xung quanh.\r\nDù là cuộc gặp mặt cuối năm nhẹ nhàng hay những bữa tiệc sôi động, nàng hãy luôn toát lên vẻ thanh lịch nổi bật cá tính với sự kết hợp hoàn hảo của một chiếc váy đen sang trọng cùng đôi bông tai phong cách từ Style by PNJ.",
                        "Bạc",
                        1,
                        11L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        9L,
                        "Bông tai Bạc đính đá STYLE By PNJ XM00Y000067",
                        "Bông tai bạc từ STYLE By PNJ được thiết kế kiểu dáng cá tính ,tinh tế với điểm nhấn đính đá trên chất liệu bạc 92.5, sáng lấp lánh làm nền tạo điểm nhấn giúp tôn lên vẻ đẹp của nàng xinh, gây ấn tượng với nhiều người xung quanh.\r\nDù là cuộc gặp mặt cuối năm nhẹ nhàng hay những bữa tiệc sôi động, nàng hãy luôn toát lên vẻ thanh lịch nổi bật cá tính với sự kết hợp hoàn hảo của một chiếc váy đen sang trọng cùng đôi bông tai phong cách từ Style by PNJ.",
                        "Bạc",
                        1,
                        11L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        10L,
                        "Bông tai Kim cương Vàng trắng 14K PNJ Audax Rosa DDDDW004479",
                        "Đôi bông tai được chế tác từ vàng 14K và sở hữu kiểu dáng nhỏ xinh, phù hợp với những quý cô ưa chuộng phong cách sang trọng. Đặc biệt hơn nữa, đôi bông tai sở hữu điểm nhấn Kim cương tạo nên vẻ đẹp tinh tế, tôn lên vẻ đẹp dịu dàng, quý phái cho người đeo.\r\nKim cương được xem là biểu tượng của sự quyền lực, giàu sang và quý phái, do đó nó được sử dụng để tạo nên các tuyệt tác trang sức kim cương tinh tế. Sự sáng tạo mạnh mẽ của các nhà thiết kế của PNJ được phô diễn thông qua đôi bông tai với vẻ đẹp đẳng cấp và thời thượng.",
                        "Vàng trắng",
                        1,
                        10L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        11L,
                        "Bông tai Vàng trắng 14K đính đá ECZ PNJ Audax Rosa XMXMW003083",
                        "Lấy cảm hứng từ những câu chuyện của những người phụ nữ, những hành trình người thật việc thật về sự cố gắng, PNJ mang đến BST Audax Rosa với những món trang sức biểu tượng cho sự mạnh mẽ và luôn tỏa sáng của các quý cô. Đôi bông tai đính đá ECZ được thiết kế tinh giản các chi tiết sóng nhưng vẫn giữ đúng tinh thần xuyên suốt của toàn bộ sưu tập.\r\nSự tinh tế trong thiết kế biểu tượng sóng bằng kỹ thuật khắc máy - xi vàng làm nổi bật vẻ đẹp tự nhiên và sự kiêu sa của hoa hồng, tạo nên một trang sức độc đáo và thu hút. Mang vẻ đẹp hoàn hảo, đôi bông tai với điểm nhấn đá ECZ sẽ là “trợ thủ” nâng tầm nhan sắc của mọi cô nàng ưa chuộng phong cách hiện đại và thanh lịch.",
                        "Vàng trắng",
                        1,
                        10L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        12L,
                        "Bông tai Vàng trắng 14K đính đá ECZ PNJ Audax Rosa XMXMW003085",
                        "Lấy cảm hứng từ những câu chuyện của những người phụ nữ, những hành trình người thật việc thật về sự cố gắng, PNJ mang đến BST Audax Rosa với những món trang sức biểu tượng cho sự mạnh mẽ và luôn tỏa sáng của các quý cô. Đôi bông tai đính đá ECZ được thiết kế tinh giản các chi tiết sóng nhưng vẫn giữ đúng tinh thần xuyên suốt của toàn bộ sưu tập.\r\nSự tinh tế trong thiết kế biểu tượng sóng bằng kỹ thuật khắc máy - xi vàng làm nổi bật vẻ đẹp tự nhiên và sự kiêu sa của hoa hồng, tạo nên một trang sức độc đáo và thu hút. Mang vẻ đẹp hoàn hảo, đôi bông tai với điểm nhấn đá ECZ sẽ là “trợ thủ” nâng tầm nhan sắc của mọi cô nàng ưa chuộng phong cách hiện đại và thanh lịch.",
                        "Vàng trắng",
                        1,
                        10L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        13L,
                        "Bông tai Vàng trắng 14K đính đá ECZ PNJ Audax Rosa XMXMW003086",
                        "Lấy cảm hứng từ những câu chuyện của những người phụ nữ, những hành trình người thật việc thật về sự cố gắng, PNJ mang đến BST Audax Rosa với những món trang sức biểu tượng cho sự mạnh mẽ và luôn tỏa sáng của các quý cô. Đôi bông tai đính đá ECZ được thiết kế tinh giản các chi tiết sóng nhưng vẫn giữ đúng tinh thần xuyên suốt của toàn bộ sưu tập.\r\nSự tinh tế trong thiết kế biểu tượng sóng bằng kỹ thuật khắc máy - xi vàng làm nổi bật vẻ đẹp tự nhiên và sự kiêu sa của hoa hồng, tạo nên một trang sức độc đáo và thu hút. Mang vẻ đẹp hoàn hảo, đôi bông tai với điểm nhấn đá ECZ sẽ là “trợ thủ” nâng tầm nhan sắc của mọi cô nàng ưa chuộng phong cách hiện đại và thanh lịch.",
                        "Vàng trắng",
                        1,
                        10L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        14L,
                        "Bông tai Vàng trắng 14K đính đá ECZ PNJ Audax Rosa XMXMW003084",
                        "Lấy cảm hứng từ những câu chuyện của những người phụ nữ, những hành trình người thật việc thật về sự cố gắng, PNJ mang đến BST Audax Rosa với những món trang sức biểu tượng cho sự mạnh mẽ và luôn tỏa sáng của các quý cô. Đôi bông tai đính đá ECZ được thiết kế tinh giản các chi tiết sóng nhưng vẫn giữ đúng tinh thần xuyên suốt của toàn bộ sưu tập.\r\nSự tinh tế trong thiết kế biểu tượng sóng bằng kỹ thuật khắc máy - xi vàng làm nổi bật vẻ đẹp tự nhiên và sự kiêu sa của hoa hồng, tạo nên một trang sức độc đáo và thu hút. Mang vẻ đẹp hoàn hảo, đôi bông tai với điểm nhấn đá ECZ sẽ là “trợ thủ” nâng tầm nhan sắc của mọi cô nàng ưa chuộng phong cách hiện đại và thanh lịch.",
                        "Vàng trắng",
                        1,
                        10L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    },
                    {
                        15L,
                        "Bông tai Bạc đính đá STYLE By PNJ XM00W000083",
                        "Bông tai bạc từ STYLE By PNJ được thiết kế kiểu dáng cá tính ,tinh tế với điểm nhấn đính đá trên chất liệu bạc 92.5, sáng lấp lánh làm nền tạo điểm nhấn giúp tôn lên vẻ đẹp của nàng xinh, gây ấn tượng với nhiều người xung quanh.\r\nDù là cuộc gặp mặt cuối năm nhẹ nhàng hay những bữa tiệc sôi động, nàng hãy luôn toát lên vẻ thanh lịch nổi bật cá tính với sự kết hợp hoàn hảo của một chiếc váy đen sang trọng cùng đôi bông tai phong cách từ Style by PNJ.",
                        "Bạc",
                        1,
                        11L,
                        new DateTime(2025, 9, 5, 7, 55, 38),
                        null,
                        null,
                        null,
                        false,
                        null,
                        null
                    }
                }
            );

            migrationBuilder.Sql(
                "SET IDENTITY_INSERT [dbo].[Jew_Product] OFF;"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "Jew_Product",
               keyColumn: "Id",
               keyValues: new object[]
               {
                        1L,
                        2L,
                        3L,
                        4L,
                        5L,
                        6L,
                        7L,
                        8L,
                        9L,
                        10L,
                        11L,
                        12L,
                        13L,
                        14L,
                        15L
               }
           );
        }
    }
}
