namespace Day02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kll1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.courses", "TeacherId", "dbo.teachers");
            DropIndex("dbo.courses", new[] { "TeacherId" });
            AlterColumn("dbo.courses", "TeacherId", c => c.Int());
            CreateIndex("dbo.courses", "TeacherId");
            AddForeignKey("dbo.courses", "TeacherId", "dbo.teachers", "teacherID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.courses", "TeacherId", "dbo.teachers");
            DropIndex("dbo.courses", new[] { "TeacherId" });
            AlterColumn("dbo.courses", "TeacherId", c => c.Int(nullable: false));
            CreateIndex("dbo.courses", "TeacherId");
            AddForeignKey("dbo.courses", "TeacherId", "dbo.teachers", "teacherID", cascadeDelete: true);
        }
    }
}
