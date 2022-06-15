using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApolloIntegration.Infrastructure.Migrations
{
    public partial class AddingLastUpdatedDateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedDate",
                table: "ApolloContact",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: DateTime.Today);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdatedDate",
                table: "ApolloContact");
        }
    }
}
