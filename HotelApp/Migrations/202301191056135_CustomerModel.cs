namespace HotelApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false),
                        RetypeEmail = c.String(nullable: false),
                        Phone = c.String(),
                        ZipCode = c.String(nullable: false),
                        Age = c.String(),
                        City = c.String(maxLength: 35),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
