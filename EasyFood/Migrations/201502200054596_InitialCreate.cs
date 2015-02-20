namespace EasyFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        TotalPrice = c.Double(nullable: false),
                        Restaurant_RestaurantID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_RestaurantID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.Restaurant_RestaurantID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.PlateOrders",
                c => new
                    {
                        PlateOrderID = c.Int(nullable: false, identity: true),
                        PlatePrice = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Order_OrderID = c.Int(),
                        Plate_PlateID = c.Int(),
                    })
                .PrimaryKey(t => t.PlateOrderID)
                .ForeignKey("dbo.Orders", t => t.Order_OrderID)
                .ForeignKey("dbo.Plates", t => t.Plate_PlateID)
                .Index(t => t.Order_OrderID)
                .Index(t => t.Plate_PlateID);
            
            CreateTable(
                "dbo.Plates",
                c => new
                    {
                        PlateID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Restaurant_RestaurantID = c.Int(),
                    })
                .PrimaryKey(t => t.PlateID)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_RestaurantID)
                .Index(t => t.Restaurant_RestaurantID);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        RestaurantID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RIF = c.String(),
                        DeliveryRate = c.Double(nullable: false),
                        Manager_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.RestaurantID)
                .ForeignKey("dbo.Users", t => t.Manager_UserID)
                .Index(t => t.Manager_UserID);
            
            CreateTable(
                "dbo.PhoneNumbers",
                c => new
                    {
                        PhoneNumberID = c.Int(nullable: false, identity: true),
                        Cellphone = c.String(),
                        Restaurant_RestaurantID = c.Int(),
                    })
                .PrimaryKey(t => t.PhoneNumberID)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_RestaurantID)
                .Index(t => t.Restaurant_RestaurantID);
            
            AddColumn("dbo.Users", "Name", c => c.String());
            AddColumn("dbo.Users", "Lastname", c => c.String());
            AddColumn("dbo.Users", "Username", c => c.String());
            AddColumn("dbo.Users", "Email", c => c.String());
            AddColumn("dbo.Users", "Number", c => c.String());
            AddColumn("dbo.Users", "UserType", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "nombre");
            DropColumn("dbo.Users", "apellido");
            DropColumn("dbo.Users", "location");
            DropColumn("dbo.Users", "user");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "user", c => c.String());
            AddColumn("dbo.Users", "location", c => c.String());
            AddColumn("dbo.Users", "apellido", c => c.String());
            AddColumn("dbo.Users", "nombre", c => c.String());
            DropForeignKey("dbo.Orders", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Orders", "Restaurant_RestaurantID", "dbo.Restaurants");
            DropForeignKey("dbo.Plates", "Restaurant_RestaurantID", "dbo.Restaurants");
            DropForeignKey("dbo.PhoneNumbers", "Restaurant_RestaurantID", "dbo.Restaurants");
            DropForeignKey("dbo.Restaurants", "Manager_UserID", "dbo.Users");
            DropForeignKey("dbo.PlateOrders", "Plate_PlateID", "dbo.Plates");
            DropForeignKey("dbo.PlateOrders", "Order_OrderID", "dbo.Orders");
            DropIndex("dbo.Orders", new[] { "User_UserID" });
            DropIndex("dbo.Orders", new[] { "Restaurant_RestaurantID" });
            DropIndex("dbo.Plates", new[] { "Restaurant_RestaurantID" });
            DropIndex("dbo.PhoneNumbers", new[] { "Restaurant_RestaurantID" });
            DropIndex("dbo.Restaurants", new[] { "Manager_UserID" });
            DropIndex("dbo.PlateOrders", new[] { "Plate_PlateID" });
            DropIndex("dbo.PlateOrders", new[] { "Order_OrderID" });
            DropColumn("dbo.Users", "UserType");
            DropColumn("dbo.Users", "Number");
            DropColumn("dbo.Users", "Email");
            DropColumn("dbo.Users", "Username");
            DropColumn("dbo.Users", "Lastname");
            DropColumn("dbo.Users", "Name");
            DropTable("dbo.PhoneNumbers");
            DropTable("dbo.Restaurants");
            DropTable("dbo.Plates");
            DropTable("dbo.PlateOrders");
            DropTable("dbo.Orders");
        }
    }
}
