using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PwaProject2.Server.Migrations
{
    public partial class addedpwauserSessiondetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PwaUsers",
                columns: table => new
                {
                    inUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    unUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    stFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stLastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PwaUsers", x => x.inUserId);
                });

            migrationBuilder.CreateTable(
                name: "UserSessionDetail",
                columns: table => new
                {
                    inId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    inUserId = table.Column<int>(type: "int", nullable: false),
                    stSessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    flgIsActive = table.Column<bool>(type: "bit", nullable: false),
                    stBrowserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSessionDetail", x => x.inId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PwaUsers");

            migrationBuilder.DropTable(
                name: "UserSessionDetail");
        }
    }
}
