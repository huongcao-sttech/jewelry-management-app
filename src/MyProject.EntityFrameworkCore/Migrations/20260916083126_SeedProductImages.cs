using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
               "SET IDENTITY_INSERT [dbo].[Jew_ProductImage] ON;"
           );

            migrationBuilder.InsertData(
                table: "Jew_ProductImage",
                columns: new[]
                {
                    "Id",
                    "Name",
                    "Url",
                    "ProductId",
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
                    // Product 1
                    {
                        1L,
                        "sp-gbxm00w001484-bong-tai-vang-dinh-da-ecz-pnj-1.png",
                        "https://cdn.pnj.io/images/detailed/239/sp-gbxm00w001484-bong-tai-vang-dinh-da-ecz-pnj-1.png",
                        1L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },
                    {
                        2L,
                        "sp-gbxm00w001484-bong-tai-vang-dinh-da-ecz-pnj-2.png",
                        "https://cdn.pnj.io/images/detailed/239/sp-gbxm00w001484-bong-tai-vang-dinh-da-ecz-pnj-2.png",
                        1L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },
                    {
                        3L,
                        "on-gbxm00w001484-bong-tai-vang-dinh-da-ecz-pnj-1.jpg",
                        "https://cdn.pnj.io/images/detailed/239/on-gbxm00w001484-bong-tai-vang-dinh-da-ecz-pnj-1.jpg",
                        1L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },
                    {
                        4L,
                        "on-gbxm00w001484-bong-tai-vang-dinh-da-ecz-pnj-2.jpg",
                        "https://cdn.pnj.io/images/detailed/239/on-gbxm00w001484-bong-tai-vang-dinh-da-ecz-pnj-2.jpg",
                        1L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },
                    {
                        5L,
                        "on-gbxm00w001484-bong-tai-vang-dinh-da-ecz-pnj-3.jpg",
                        "https://cdn.pnj.io/images/detailed/239/on-gbxm00w001484-bong-tai-vang-dinh-da-ecz-pnj-3.jpg",
                        1L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },

                    // Product 2
                    {
                        6L,
                        "sp-gbxm00w001483-bong-tai-vang-dinh-da-ecz-pnj-1.png",
                        "https://cdn.pnj.io/images/detailed/239/sp-gbxm00w001483-bong-tai-vang-dinh-da-ecz-pnj-1.png",
                        2L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },
                    {
                        7L,
                        "sp-gbxm00w001483-bong-tai-vang-dinh-da-ecz-pnj-2.png",
                        "https://cdn.pnj.io/images/detailed/239/sp-gbxm00w001483-bong-tai-vang-dinh-da-ecz-pnj-2.png",
                        2L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },
                    {
                        8L,
                        "on-gbxm00w001483-bong-tai-vang-dinh-da-ecz-pnj-1.jpg",
                        "https://cdn.pnj.io/images/detailed/239/on-gbxm00w001483-bong-tai-vang-dinh-da-ecz-pnj-1.jpg",
                        2L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },
                    {
                        9L,
                        "on-gbxm00w001483-bong-tai-vang-dinh-da-ecz-pnj-2.jpg",
                        "https://cdn.pnj.io/images/detailed/239/on-gbxm00w001483-bong-tai-vang-dinh-da-ecz-pnj-2.jpg",
                        2L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },
                    {
                        10L,
                        "on-gbxm00w001483-bong-tai-vang-dinh-da-ecz-pnj-3.jpg",
                        "https://cdn.pnj.io/images/detailed/239/on-gbxm00w001483-bong-tai-vang-dinh-da-ecz-pnj-3.jpg",
                        2L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },

                    // Product 3
                    {
                        11L,
                        "sp-gbxm00w001509-bong-tai-vang-dinh-da-ecz-pnj-1.png",
                        "https://cdn.pnj.io/images/detailed/237/sp-gbxm00w001509-bong-tai-vang-dinh-da-ecz-pnj-1.png",
                        3L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },
                    {
                        12L,
                        "sp-gbxm00w001509-bong-tai-vang-dinh-da-ecz-pnj-2.png",
                        "https://cdn.pnj.io/images/detailed/237/sp-gbxm00w001509-bong-tai-vang-dinh-da-ecz-pnj-2.png",
                        3L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },
                    {
                        13L,
                        "on-gbxm00w001509-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.jpg",
                        "https://cdn.pnj.io/images/detailed/237/on-gbxm00w001509-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.jpg",
                        3L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },
                    {
                        14L,
                        "on-gbxm00w001509-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.jpg",
                        "https://cdn.pnj.io/images/detailed/237/on-gbxm00w001509-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.jpg",
                        3L,
                        new DateTime(2025, 9, 5, 7, 58, 2),
                        null, null, null, false, null, null
                    },
                    {
                        15L,
                        "on-gbxm00w001509-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.jpg",
                        "https://cdn.pnj.io/images/detailed/237/on-gbxm00w001509-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.jpg",
                        3L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },

                    // Product 4
                    {
                        16L,
                        "sp-gbxm00y003571-bong-tai-vang-dinh-da-ecz-pnj-1.png",
                        "https://cdn.pnj.io/images/detailed/239/sp-gbxm00y003571-bong-tai-vang-dinh-da-ecz-pnj-1.png",
                        4L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        17L,
                        "sp-gbxm00y003571-bong-tai-vang-dinh-da-ecz-pnj-2.png",
                        "https://cdn.pnj.io/images/detailed/239/sp-gbxm00y003571-bong-tai-vang-dinh-da-ecz-pnj-2.png",
                        4L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        18L,
                        "on-gbxm00y003571-bong-tai-vang-dinh-da-ecz-pnj-1.jpg",
                        "https://cdn.pnj.io/images/detailed/239/on-gbxm00y003571-bong-tai-vang-dinh-da-ecz-pnj-1.jpg",
                        4L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        19L,
                        "on-gbxm00y003571-bong-tai-vang-dinh-da-ecz-pnj-2.jpg",
                        "https://cdn.pnj.io/images/detailed/239/on-gbxm00y003571-bong-tai-vang-dinh-da-ecz-pnj-2.jpg",
                        4L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        20L,
                        "on-gbxm00y003571-bong-tai-vang-dinh-da-ecz-pnj-3.jpg",
                        "https://cdn.pnj.io/images/detailed/239/on-gbxm00y003571-bong-tai-vang-dinh-da-ecz-pnj-3.jpg",
                        4L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },

                    // Product 5
                    {
                        21L,
                        "sp-gb0000w002718-bong-tai-vang-trang-y-pnj-1.png",
                        "https://cdn.pnj.io/images/detailed/239/sp-gb0000w002718-bong-tai-vang-trang-y-pnj-1.png",
                        5L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        22L,
                        "sp-gb0000w002718-bong-tai-vang-trang-y-pnj-2.png",
                        "https://cdn.pnj.io/images/detailed/239/sp-gb0000w002718-bong-tai-vang-trang-y-pnj-2.png",
                        5L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        23L,
                        "on-gb0000w002718-bong-tai-vang-trang-y-pnj-1.jpg",
                        "https://cdn.pnj.io/images/detailed/239/on-gb0000w002718-bong-tai-vang-trang-y-pnj-1.jpg",
                        5L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        24L,
                        "on-gb0000w002718-bong-tai-vang-trang-y-pnj-2.jpg",
                        "https://cdn.pnj.io/images/detailed/239/on-gb0000w002718-bong-tai-vang-trang-y-pnj-2.jpg",
                        5L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        25L,
                        "on-gb0000w002718-bong-tai-vang-trang-y-pnj-3.jpg",
                        "https://cdn.pnj.io/images/detailed/239/on-gb0000w002718-bong-tai-vang-trang-y-pnj-3.jpg",
                        5L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },

                    // Product 6
                    {
                        26L,
                        "sp-gbxmxmw003087-bong-tai-vang-dinh-da-ecz-pnj-1.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003087-bong-tai-vang-dinh-da-ecz-pnj-1.png",
                        6L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        27L,
                        "sp-gbxmxmw003087-bong-tai-vang-dinh-da-ecz-pnj-2.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003087-bong-tai-vang-dinh-da-ecz-pnj-2.png",
                        6L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        28L,
                        "on-gbxmxmw003087-bong-tai-vang-dinh-da-ecz-pnj-1.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003087-bong-tai-vang-dinh-da-ecz-pnj-1.jpg",
                        6L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        29L,
                        "on-gbxmxmw003087-bong-tai-vang-dinh-da-ecz-pnj-2.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003087-bong-tai-vang-dinh-da-ecz-pnj-2.jpg",
                        6L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        30L,
                        "on-gbxmxmw003087-bong-tai-vang-dinh-da-ecz-pnj-3.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003087-bong-tai-vang-dinh-da-ecz-pnj-3.jpg",
                        6L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },

                    // Product 7
                    {
                        31L,
                        "sp-sbxm00y000066-bong-tai-bac-dinh-da-style-by-pnj-01.png",
                        "https://cdn.pnj.io/images/detailed/239/sp-sbxm00y000066-bong-tai-bac-dinh-da-style-by-pnj-01.png",
                        7L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },

                    // Product 8
                    {
                        32L,
                        "sp-sbxmxmy000041-bong-tai-bac-dinh-da-style-by-pnj-01.png",
                        "https://cdn.pnj.io/images/detailed/239/sp-sbxmxmy000041-bong-tai-bac-dinh-da-style-by-pnj-01.png",
                        8L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },

                    // Product 9
                    {
                        33L,
                        "sp-sbxm00y000067-bong-tai-bac-dinh-da-style-by-pnj-01.png",
                        "https://cdn.pnj.io/images/detailed/239/sp-sbxm00y000067-bong-tai-bac-dinh-da-style-by-pnj-01.png",
                        9L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },

                    // Product 10
                    {
                        34L,
                        "sp-gbddddw004479-bong-tai-kim-cuong-vang-trang-14k-pnj-1.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbddddw004479-bong-tai-kim-cuong-vang-trang-14k-pnj-1.png",
                        10L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        35L,
                        "sp-gbddddw004479-bong-tai-kim-cuong-vang-trang-14k-pnj-2.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbddddw004479-bong-tai-kim-cuong-vang-trang-14k-pnj-2.png",
                        10L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        36L,
                        "on-gbddddw004479-bong-tai-kim-cuong-vang-trang-14k-pnj-1.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbddddw004479-bong-tai-kim-cuong-vang-trang-14k-pnj-1.jpg",
                        10L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        37L,
                        "on-gbddddw004479-bong-tai-kim-cuong-vang-trang-14k-pnj-2.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbddddw004479-bong-tai-kim-cuong-vang-trang-14k-pnj-2.jpg",
                        10L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        38L,
                        "on-gbddddw004479-bong-tai-kim-cuong-vang-trang-14k-pnj-3.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbddddw004479-bong-tai-kim-cuong-vang-trang-14k-pnj-3.jpg",
                        10L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },

                    // Product 11
                    {
                        39L,
                        "sp-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.png",
                        11L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        40L,
                        "sp-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.png",
                        11L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        41L,
                        "sp-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.png",
                        11L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        42L,
                        "sp-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-4.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-4.png",
                        11L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        43L,
                        "sp-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-5.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-5.png",
                        11L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        44L,
                        "sp-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-6.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-6.png",
                        11L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        45L,
                        "on-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.jpg",
                        11L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        46L,
                        "on-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.jpg",
                        11L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        47L,
                        "on-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.jpg",
                        11L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        48L,
                        "on-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-4.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003083-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-4.jpg",
                        11L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },

                    // Product 12
                    {
                        49L,
                        "sp-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.png",
                        12L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        50L,
                        "sp-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.png",
                        12L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        51L,
                        "sp-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.png",
                        12L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        52L,
                        "sp-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-4.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-4.png",
                        12L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        53L,
                        "sp-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-5.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-5.png",
                        12L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        54L,
                        "sp-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-6.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-6.png",
                        12L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        55L,
                        "on-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.jpg",
                        12L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        56L,
                        "on-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.jpg",
                        12L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        57L,
                        "on-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.jpg",
                        12L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        58L,
                        "on-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-4.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003085-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-4.jpg",
                        12L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },

                    // Product 13
                    {
                        59L,
                        "sp-gbxmxmw003086-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003086-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.png",
                        13L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        60L,
                        "sp-gbxmxmw003086-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003086-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.png",
                        13L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        61L,
                        "on-gbxmxmw003086-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003086-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.jpg",
                        13L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        62L,
                        "on-gbxmxmw003086-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003086-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.jpg",
                        13L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        63L,
                        "on-gbxmxmw003086-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003086-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.jpg",
                        13L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },

                    // Product 14
                    {
                        64L,
                        "sp-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.png",
                        14L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        65L,
                        "sp-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.png",
                        14L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        66L,
                        "sp-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.png",
                        14L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        67L,
                        "sp-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-4.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-4.png",
                        14L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        68L,
                        "sp-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-5.png",
                        "https://cdn.pnj.io/images/detailed/238/sp-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-5.png",
                        14L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        69L,
                        "on-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-1.jpg",
                        14L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        70L,
                        "on-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-2.jpg",
                        14L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        71L,
                        "on-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-3.jpg",
                        14L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        72L,
                        "on-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-4.jpg",
                        "https://cdn.pnj.io/images/detailed/238/on-gbxmxmw003084-bong-tai-vang-trang-14k-dinh-da-ecz-pnj-4.jpg",
                        14L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },

                    // Product 15
                    {
                        73L,
                        "sp-sbxm00w000083-bong-tai-bac-dinh-da-style-by-pnj-1.png",
                        "https://cdn.pnj.io/images/detailed/242/sp-sbxm00w000083-bong-tai-bac-dinh-da-style-by-pnj-1.png",
                        15L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        74L,
                        "sp-sbxm00w000083-bong-tai-bac-dinh-da-style-by-pnj-2.png",
                        "https://cdn.pnj.io/images/detailed/242/sp-sbxm00w000083-bong-tai-bac-dinh-da-style-by-pnj-2.png",
                        15L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    },
                    {
                        75L,
                        "sp-sbxm00w000083-bong-tai-bac-dinh-da-style-by-pnj-3.png",
                        "https://cdn.pnj.io/images/detailed/242/sp-sbxm00w000083-bong-tai-bac-dinh-da-style-by-pnj-3.png",
                        15L,
                        new DateTime(2025, 9, 5, 7, 58, 3),
                        null, null, null, false, null, null
                    }
                });

            migrationBuilder.Sql(
                "SET IDENTITY_INSERT [dbo].[Jew_ProductImage] OFF;"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jew_ProductImage",
                keyColumn: "Id",
                keyValues: new object[]
                {
                    1L, 2L, 3L, 4L, 5L,
                    6L, 7L, 8L, 9L, 10L,
                    11L, 12L, 13L, 14L, 15L,
                    16L, 17L, 18L, 19L, 20L,
                    21L, 22L, 23L, 24L, 25L,
                    26L, 27L, 28L, 29L, 30L,
                    31L, 32L, 33L, 34L, 35L,
                    36L, 37L, 38L, 39L, 40L,
                    41L, 42L, 43L, 44L, 45L,
                    46L, 47L, 48L, 49L, 50L,
                    51L, 52L, 53L, 54L, 55L,
                    56L, 57L, 58L, 59L, 60L,
                    61L, 62L, 63L, 64L, 65L,
                    66L, 67L, 68L, 69L, 70L,
                    71L, 72L, 73L, 74L, 75L
                }
            );
        }
    }
}
