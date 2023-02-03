using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCorePrimer.Migrations
{
    public partial class sp_OvInsertCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE dbo.OvInsertCategory
			    (
		    	@CategoryName nvarchar(15), 
		    	@Description ntext
		    	)
		    	AS
		    	INSERT INTO Categories (CategoryName, Description)
		    	VALUES (@CategoryName, @Description)
		    	SELECT SCOPE_IDENTITY() AS id;";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
