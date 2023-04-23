using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "AreaInAcres", "Designation", "GoverningBody", "LocationState", "ParkCode", "ParkName", "URL" },
                values: new object[,]
                {
                    { 1, 922650, "National Park", "NPS", "Washington", "OLYM", "Olympic National Park", "https://www.nps.gov/olym/index.htm" },
                    { 2, 3373063, "National Park", "NPS", "California", "DEVA", "Death Valley National Park", "https://www.nps.gov/deva/index.htm" },
                    { 3, 1159801, "National Forest", "USFS", "Arkansas", "osfnf", "Ozark-St. Francis National Forest", "https://www.fs.usda.gov/osfnf" },
                    { 4, 759620, "National Park", "NPS", "California", "YOSE", "Yosemite National Park", "https://www.nps.gov/yose/index.htm" },
                    { 5, 1071466, "National Forest", "USFS", "Oregon", "mthood", "Mt. Hood National Forest", "https://www.fs.usda.gov/mthood" },
                    { 6, 0, "National Monument", "NPS", "Wyoming", "DETO", "Devil's Tower National Monument", "https://www.nps.gov/deto/index.htm" },
                    { 7, 9000, "State Park", "OPRD", "Oregon", null, "Silver Falls State Parlk", "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=151" },
                    { 8, 183224, "National Park", "NPS", "Oregon", "CRLA", "Crater Lake National Park", "https://www.nps.gov/crla/index.htm" },
                    { 9, 8472506, "National Park", "NPS", "Alaska", "GAAR", "Gates Of The Arctic National Park", "https://www.nps.gov/gaar/index.htm" },
                    { 10, 8472506, "National Park", "NPS", "Florida", "EVER", "Everglades National Park", "https://www.nps.gov/gaar/index.htm" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);
        }
    }
}
