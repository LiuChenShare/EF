namespace LC.Data.HR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogUrl1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeInfoes",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        PersonalId = c.Guid(),
                        CreatedById = c.Guid(),
                        JoinDate = c.DateTime(nullable: false),
                        AwayDate = c.DateTime(),
                        LatestJoinDate = c.DateTime(nullable: false),
                        Birthday = c.DateTime(nullable: false),
                        EmployeeNo = c.String(),
                        ProbationEndDate = c.DateTime(nullable: false),
                        Salary = c.Int(),
                        Deleted = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        LastUpdatedOn = c.DateTime(nullable: false),
                        Timestamp = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeInfoes");
        }
    }
}
