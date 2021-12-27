namespace HastaneRandevuEFCF_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Doktors", newName: "Doktorlar");
            RenameTable(name: "dbo.RandevuBilgileris", newName: "RandevuBilgileri");
            RenameTable(name: "dbo.Hastas", newName: "Hastalar");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Hastalar", newName: "Hastas");
            RenameTable(name: "dbo.RandevuBilgileri", newName: "RandevuBilgileris");
            RenameTable(name: "dbo.Doktorlar", newName: "Doktors");
        }
    }
}
