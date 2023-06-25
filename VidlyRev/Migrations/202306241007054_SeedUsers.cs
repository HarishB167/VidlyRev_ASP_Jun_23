namespace VidlyRev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0c5821b9-3744-4d18-9e04-4f6359cfb307', N'admin@vidlyrev.com', 0, N'ALwP6pP6aaOqEpukWlf+ab+dTABz+hElW6tF/kfcF2UbFTRR9/n/ZNeWhx4BQTQkwA==', N'339c2e7b-e724-41d8-875d-bd8c66f9a1a4', NULL, 0, 0, NULL, 1, 0, N'admin@vidlyrev.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'569d2fa0-bcfc-498c-b540-87ac015ff440', N'guest@vidlyrev.com', 0, N'AInLWBd/j4hNrV8bQHQhDjEEqAUy7J7enAhFiDq6ELXTYIFMFpbcyFlbFaPpehjyXw==', N'caaa84a5-55e8-4586-bfa5-acf8d72acf10', NULL, 0, 0, NULL, 1, 0, N'guest@vidlyrev.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3bb5f015-c7b8-40c0-b0f7-5c9549d0230b', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0c5821b9-3744-4d18-9e04-4f6359cfb307', N'3bb5f015-c7b8-40c0-b0f7-5c9549d0230b')
");
        }
        
        public override void Down()
        {
        }
    }
}
