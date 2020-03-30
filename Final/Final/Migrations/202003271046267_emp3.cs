namespace Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emp3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(),
                        LastName = c.String(nullable: false),
                        Gender = c.String(),
                        Address = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(),
                        Country = c.String(nullable: false),
                        Mobile = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
