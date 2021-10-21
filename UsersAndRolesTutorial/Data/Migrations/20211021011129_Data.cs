using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersAndRolesTutorial.Data.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6231345d-82f8-46ab-9530-e557c7aaf7db", "0f853fa1-d720-43aa-80d6-d26dad5dfb46", "Sales", "SALES" },
                    { "cf58b5bd-bad7-4af9-aa09-874b584e5392", "5affd6e2-dc6f-46b4-af81-0ff60c12b8b3", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "064fda21-7c0c-4806-a631-6992e8a4c605", 0, "d14280af-5ec4-4ea7-a591-0ddfb3687dcf", "adminUser@hotmail.com", false, false, null, "ADMINUSER@HOTMAIL.COM", "ADMINUSER", null, null, false, "9bb1075c-f9da-4f34-9a1e-39f3714404e2", false, "adminUser" },
                    { "14607602-a3d0-41b2-97de-50a0ab003d4d", 0, "1bbb2ff0-abbb-4161-ab4a-f8570f20f86e", "salesUser@hotmail.com", false, false, null, "SALESUSER@HOTMAIL.COM", "SALESUSER", null, null, false, "ca0363b6-15be-4910-a4c5-824daac905db", false, "salesUser" },
                    { "1f0ecf34-6a47-4c61-b6b0-8c1eae7401e1", 0, "09559c14-d1c2-4f9e-bdb8-fc03cb8e9cc2", "userWithoutRole@hotmail.com", false, false, null, "USERWITHOUTROLE@HOTMAIL.COM", "USERWITHOUTROLE", null, null, false, "cbc89290-cd66-4a6a-be22-5c06eca6bf1a", false, "userWithoutRole" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cf58b5bd-bad7-4af9-aa09-874b584e5392", "064fda21-7c0c-4806-a631-6992e8a4c605" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6231345d-82f8-46ab-9530-e557c7aaf7db", "14607602-a3d0-41b2-97de-50a0ab003d4d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cf58b5bd-bad7-4af9-aa09-874b584e5392", "064fda21-7c0c-4806-a631-6992e8a4c605" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6231345d-82f8-46ab-9530-e557c7aaf7db", "14607602-a3d0-41b2-97de-50a0ab003d4d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f0ecf34-6a47-4c61-b6b0-8c1eae7401e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6231345d-82f8-46ab-9530-e557c7aaf7db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf58b5bd-bad7-4af9-aa09-874b584e5392");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "064fda21-7c0c-4806-a631-6992e8a4c605");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14607602-a3d0-41b2-97de-50a0ab003d4d");
        }
    }
}
