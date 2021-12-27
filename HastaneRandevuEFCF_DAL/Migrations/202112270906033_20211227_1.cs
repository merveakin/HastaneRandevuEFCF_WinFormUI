namespace HastaneRandevuEFCF_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20211227_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doktors",
                c => new
                    {
                        DoktorId = c.Int(nullable: false, identity: true),
                        DoktorAdi = c.String(nullable: false, maxLength: 50),
                        DoktorSoyadi = c.String(nullable: false, maxLength: 50),
                        Brans = c.Byte(nullable: false),
                        Maas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TCNumarasi = c.String(nullable: false, maxLength: 11),
                        Telefon = c.String(maxLength: 11),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.DoktorId);
            
            CreateTable(
                "dbo.RandevuBilgileris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoktorId = c.Int(nullable: false),
                        HastaId = c.Int(nullable: false),
                        RandevuTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doktors", t => t.DoktorId, cascadeDelete: true)
                .ForeignKey("dbo.Hastas", t => t.HastaId, cascadeDelete: true)
                .Index(t => t.DoktorId)
                .Index(t => t.HastaId);
            
            CreateTable(
                "dbo.Hastas",
                c => new
                    {
                        HastaId = c.Int(nullable: false, identity: true),
                        HastaAdi = c.String(nullable: false, maxLength: 50),
                        HastaSoyadi = c.String(nullable: false, maxLength: 50),
                        TCNumarasi = c.String(nullable: false, maxLength: 11),
                        Telefon = c.String(maxLength: 11),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.HastaId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.RandevuBilgileris", "HastaId", "dbo.Hastas");
            DropForeignKey("dbo.RandevuBilgileris", "DoktorId", "dbo.Doktors");
            DropIndex("dbo.RandevuBilgileris", new[] { "HastaId" });
            DropIndex("dbo.RandevuBilgileris", new[] { "DoktorId" });
            DropTable("dbo.Hastas");
            DropTable("dbo.RandevuBilgileris");
            DropTable("dbo.Doktors");
        }        
    }
}
