using Microsoft.EntityFrameworkCore.Migrations;

namespace ApolloIntegration.Infrastructure.Migrations
{
    public partial class AddKeywords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"ApolloKeyword\"(\"Keyword\") VALUES ('Founder')");
            migrationBuilder.Sql("INSERT INTO \"ApolloKeyword\"(\"Keyword\") VALUES ('C Suite')");
            migrationBuilder.Sql("INSERT INTO \"ApolloKeyword\"(\"Keyword\") VALUES ('Partner')");
            migrationBuilder.Sql("INSERT INTO \"ApolloKeyword\"(\"Keyword\") VALUES ('Head')");
            migrationBuilder.Sql("INSERT INTO \"ApolloKeyword\"(\"Keyword\") VALUES ('Director')");
            migrationBuilder.Sql("INSERT INTO \"ApolloKeyword\"(\"Keyword\") VALUES ('Vp')");
            migrationBuilder.Sql("INSERT INTO \"ApolloKeyword\"(\"Keyword\") VALUES ('Manager')");
            migrationBuilder.Sql("INSERT INTO \"ApolloKeyword\"(\"Keyword\") VALUES ('Owner')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM \"ApolloKeyword\"");
        }
    }
}
