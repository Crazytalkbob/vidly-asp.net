namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomer1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1952-06-20' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
