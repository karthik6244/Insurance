using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.Persistance.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO BANK (Bankname) VALUES ('SBI')");
            migrationBuilder.Sql("INSERT INTO BANK (Bankname) VALUES ('ICICI')");
            migrationBuilder.Sql("INSERT INTO BANK (Bankname) VALUES ('CITI')");
            migrationBuilder.Sql("INSERT INTO BANK (Bankname) VALUES ('AXIS')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
