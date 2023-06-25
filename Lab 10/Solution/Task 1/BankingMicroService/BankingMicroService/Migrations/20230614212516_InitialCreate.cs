using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingMicroService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank_Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountNumber = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    TransactionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank_Transactions", x => x.TransactionId);
                });

            migrationBuilder.InsertData(
                table: "Bank_Transactions",
                columns: new[] { "TransactionId", "AccountNumber", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 1, "123456789", 100.0, new DateTime(2023, 6, 15, 2, 25, 16, 721, DateTimeKind.Local).AddTicks(4327), "Deposit" });

            migrationBuilder.InsertData(
                table: "Bank_Transactions",
                columns: new[] { "TransactionId", "AccountNumber", "Amount", "TransactionDate", "TransactionType" },
                values: new object[] { 2, "987654321", 50.0, new DateTime(2023, 6, 15, 2, 25, 16, 722, DateTimeKind.Local).AddTicks(2959), "Withdrawal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bank_Transactions");
        }
    }
}
