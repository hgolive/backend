using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
    {

         migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Username = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Role = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
            
        // Tabela Customer
        migrationBuilder.CreateTable(
            name: "Customer",
            columns: table => new
            {
                CustomerId = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(nullable: false),
                Email = table.Column<string>(nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Customer", x => x.CustomerId);
            });

        // Tabela Products
        migrationBuilder.CreateTable(
            name: "Products",
            columns: table => new
            {
                ProductId = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(nullable: false),
                Price = table.Column<decimal>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Products", x => x.ProductId);
            });

        // Tabela Sales
        migrationBuilder.CreateTable(
            name: "Sales",
            columns: table => new
            {
                SaleId = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                SaleNumber = table.Column<string>(nullable: false),
                SaleDate = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()"),
                CustomerId = table.Column<int>(nullable: false),
                TotalSaleAmount = table.Column<decimal>(nullable: false),
                Branch = table.Column<string>(nullable: false),
                Products = table.Column<string>(nullable: false), // Pode ser uma lista de IDs de produtos
                Quantities = table.Column<string>(nullable: false), // Pode ser uma lista de quantidades
                UnitPrices = table.Column<string>(nullable: false), // Pode ser uma lista de preços unitários
                Discounts = table.Column<string>(nullable: false), // Pode ser uma lista de descontos
                TotalAmountForEachItem = table.Column<string>(nullable: false), // Pode ser uma lista de totais por item
                IsCancelled = table.Column<bool>(nullable: false, defaultValue: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Sales", x => x.SaleId);
                table.ForeignKey(
                    name: "FK_Sales_Customer_CustomerId",
                    column: x => x.CustomerId,
                    principalTable: "Customer",
                    principalColumn: "CustomerId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Sales_CustomerId",
            table: "Sales",
            column: "CustomerId");
    }
        
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
            
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
