using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tickets.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.AddColumn<Guid>(
                name: "DeptId",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeveloperTicket",
                columns: table => new
                {
                    DevelopersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TicketsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeveloperTicket", x => new { x.DevelopersId, x.TicketsId });
                    table.ForeignKey(
                        name: "FK_DeveloperTicket_Developers_DevelopersId",
                        column: x => x.DevelopersId,
                        principalTable: "Developers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeveloperTicket_Tickets_TicketsId",
                        column: x => x.TicketsId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5346da07-28c3-452a-815b-7b2731ff6146"), "Beauty & Health" },
                    { new Guid("8c975e5d-6ec1-4930-8d46-f3ddd2ee076b"), "Electronics" },
                    { new Guid("b3617127-2b58-438b-b5cc-ac3c3d9e5a21"), "Automotive & Baby" }
                });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("0b731ee0-a2a0-4120-8211-76b161f64535"), "Freddie", "Johnson" },
                    { new Guid("1c1bf402-5fe3-497a-9c57-475ff7ce1487"), "Jamie", "Berge" },
                    { new Guid("6001109e-314f-46dd-be5c-9703a1a4fb51"), "Sophia", "O'Keefe" },
                    { new Guid("d9d44861-081b-4c33-a415-c3146b38aa5d"), "Geoffrey", "Abbott" },
                    { new Guid("dd56d068-ef7b-4226-91eb-35fb10aa2d6d"), "Angela", "McClure" }
                });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeptId", "Description", "Severity", "Title" },
                values: new object[] { new Guid("8c975e5d-6ec1-4930-8d46-f3ddd2ee076b"), "Harum hic impedit dolore voluptate placeat.", 1, "in" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeptId", "Description", "Severity", "Title" },
                values: new object[] { new Guid("8c975e5d-6ec1-4930-8d46-f3ddd2ee076b"), "Rerum totam est quo possimus sunt sunt ad.", 0, "id" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeptId", "Description", "Severity", "Title" },
                values: new object[] { new Guid("b3617127-2b58-438b-b5cc-ac3c3d9e5a21"), "Id cumque explicabo beatae.", 1, "dicta" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeptId", "Description", "Severity", "Title" },
                values: new object[] { new Guid("8c975e5d-6ec1-4930-8d46-f3ddd2ee076b"), "Consectetur beatae dolorem voluptates occaecati.", 0, "eius" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DeptId", "Description", "Severity", "Title" },
                values: new object[] { new Guid("8c975e5d-6ec1-4930-8d46-f3ddd2ee076b"), "Nulla est doloribus ut non aspernatur vero dolores.", 2, "assumenda" });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DeptId",
                table: "Tickets",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_DeveloperTicket_TicketsId",
                table: "DeveloperTicket",
                column: "TicketsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Departments_DeptId",
                table: "Tickets",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Departments_DeptId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "DeveloperTicket");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_DeptId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Severity", "Title" },
                values: new object[] { "Rerum totam est quo possimus sunt sunt ad.", 0, "id" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Severity", "Title" },
                values: new object[] { "Id cumque explicabo beatae.", 1, "dicta" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Severity", "Title" },
                values: new object[] { "Consectetur beatae dolorem voluptates occaecati.", 0, "eius" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Severity", "Title" },
                values: new object[] { "Nulla est doloribus ut non aspernatur vero dolores.", 2, "assumenda" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Severity", "Title" },
                values: new object[] { "Et praesentium est ipsum eligendi rerum itaque voluptate quia.", 1, "ex" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Description", "Severity", "Title" },
                values: new object[,]
                {
                    { 6, "Optio non debitis ut molestiae dolorem ad.", 2, "velit" },
                    { 7, "Dolor quae iure quas error est.", 2, "voluptas" },
                    { 8, "Iste molestiae aut inventore necessitatibus necessitatibus perspiciatis sit.", 2, "recusandae" },
                    { 9, "Voluptas expedita placeat ad sint consequuntur.", 0, "qui" },
                    { 10, "Voluptates qui sed aliquid laudantium in.", 0, "autem" },
                    { 11, "Placeat non repellat qui libero.", 1, "totam" },
                    { 12, "Debitis vero laborum asperiores deserunt nihil tempora quia.", 2, "enim" },
                    { 13, "Voluptatibus a et natus ipsa at quis rem dolores.", 0, "natus" },
                    { 14, "Dolorem qui animi sint ad facere ut ullam voluptatem repellendus.", 1, "et" },
                    { 15, "Sint suscipit delectus accusamus distinctio earum aliquam.", 2, "aut" },
                    { 16, "Et vel tempora.", 0, "et" },
                    { 17, "Aut atque officiis numquam mollitia voluptas dolore.", 1, "iusto" },
                    { 18, "Ipsum mollitia sit officiis sapiente natus.", 2, "facere" },
                    { 19, "Inventore aut reprehenderit vitae ratione dolorum harum.", 2, "recusandae" },
                    { 20, "Harum hic impedit dolore voluptate placeat.", 1, "in" }
                });
        }
    }
}
