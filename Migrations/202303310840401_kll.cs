namespace Day02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(maxLength: 50),
                        password = c.String(maxLength: 20),
                        fname = c.String(maxLength: 20),
                        sname = c.String(maxLength: 20),
                        phone = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.id)
                .Index(t => t.email, unique: true);
            
            CreateTable(
                "dbo.courses",
                c => new
                    {
                        IDcourse = c.String(nullable: false, maxLength: 15, unicode: false),
                        label = c.String(maxLength: 50),
                        period = c.Int(nullable: false),
                        semester = c.String(maxLength: 50),
                        description = c.String(unicode: false, storeType: "text"),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDcourse)
                .ForeignKey("dbo.teachers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        studentId = c.String(maxLength: 10, unicode: false),
                        courseId = c.String(maxLength: 15, unicode: false),
                        studentScore = c.Single(nullable: false),
                        description = c.String(unicode: false, storeType: "text"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.courses", t => t.courseId)
                .ForeignKey("dbo.students", t => t.studentId)
                .Index(t => t.studentId)
                .Index(t => t.courseId);
            
            CreateTable(
                "dbo.students",
                c => new
                    {
                        mssv = c.String(nullable: false, maxLength: 10, unicode: false),
                        email = c.String(maxLength: 50),
                        password = c.String(maxLength: 50),
                        firstName = c.String(maxLength: 20),
                        lastName = c.String(maxLength: 20),
                        phone = c.String(maxLength: 20),
                        address = c.String(maxLength: 50),
                        birthDay = c.DateTime(nullable: false),
                        gender = c.String(maxLength: 10),
                        pirture = c.Binary(),
                        country = c.String(maxLength: 50),
                        faculty = c.String(maxLength: 50),
                        major = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.mssv)
                .Index(t => t.email, unique: true);
            
            CreateTable(
                "dbo.teachers",
                c => new
                    {
                        teacherID = c.Int(nullable: false, identity: true),
                        email = c.String(maxLength: 50),
                        password = c.String(maxLength: 20),
                        fname = c.String(maxLength: 20),
                        sname = c.String(maxLength: 20),
                        phone = c.String(),
                        address = c.String(maxLength: 50),
                        birthDay = c.DateTime(nullable: false),
                        gender = c.String(maxLength: 10),
                        pirture = c.Binary(),
                        country = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.teacherID)
                .Index(t => t.email, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.courses", "TeacherId", "dbo.teachers");
            DropForeignKey("dbo.Scores", "studentId", "dbo.students");
            DropForeignKey("dbo.Scores", "courseId", "dbo.courses");
            DropIndex("dbo.teachers", new[] { "email" });
            DropIndex("dbo.students", new[] { "email" });
            DropIndex("dbo.Scores", new[] { "courseId" });
            DropIndex("dbo.Scores", new[] { "studentId" });
            DropIndex("dbo.courses", new[] { "TeacherId" });
            DropIndex("dbo.admins", new[] { "email" });
            DropTable("dbo.teachers");
            DropTable("dbo.students");
            DropTable("dbo.Scores");
            DropTable("dbo.courses");
            DropTable("dbo.admins");
        }
    }
}
