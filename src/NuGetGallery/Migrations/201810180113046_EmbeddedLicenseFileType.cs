namespace NuGetGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmbeddedLicenseFileType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Packages", "EmbeddedLicenseType", c => c.Int(nullable: false, defaultValue: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Packages", "EmbeddedLicenseType");
        }
    }
}
