using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class initDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalCalorie = table.Column<double>(type: "float", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Calorie = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserDetailID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    ActivityLevel = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserDetailID);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_UserDetailID",
                        column: x => x.UserDetailID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealSummaries",
                columns: table => new
                {
                    MealSummaryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealSummaries", x => x.MealSummaryID);
                    table.ForeignKey(
                        name: "FK_MealSummaries_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealSummaries_Meals_MealID",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "MealID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealSummaries_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "CreationDate", "DeletedDate", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, "Fruit", new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(772), null, null, null },
                    { 2, "Drink", new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(790), null, null, null },
                    { 3, "Snack", new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(791), null, null, null },
                    { 4, "Dessert", new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(792), null, null, null },
                    { 5, "Vegetable", new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(793), null, null, null },
                    { 6, "Dairy", new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(793), null, null, null },
                    { 7, "Fish and Seafood", new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(794), null, null, null },
                    { 8, "Fast Food", new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(795), null, null, null },
                    { 9, "Meat or Poultry", new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(796), null, null, null },
                    { 10, "Others", new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(797), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealID", "CreationDate", "DeletedDate", "MealName", "ModifiedDate", "Status", "TotalCalorie" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1395), null, "Breakfast", null, null, 0.0 },
                    { 2, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1397), null, "Lunch", null, null, 0.0 },
                    { 3, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1398), null, "Dinner", null, null, 0.0 },
                    { 4, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1399), null, "Snack", null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calorie", "CategoryID", "CreationDate", "DeletedDate", "Image", "ModifiedDate", "Name", "Status", "Unit" },
                values: new object[,]
                {
                    { 1, 52.0, 1, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1027), null, "\\Resources\\Apple.jpeg", null, "Apple", 1, 2 },
                    { 2, 47.0, 1, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1035), null, "\\Resources\\Orange.jpg", null, "Orange", 1, 2 },
                    { 3, 131.0, 1, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1037), null, "\\Resources\\Banana.jpg", null, "Banana", 1, 2 },
                    { 4, 46.0, 1, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1039), null, "\\Resources\\Plum.jpeg", null, "Plum", 1, 2 },
                    { 5, 61.0, 1, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1040), null, "\\Resources\\Kiwi.jpg", null, "Kiwi", 1, 2 },
                    { 6, 30.0, 1, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1042), null, "\\Resources\\Watermelon.jpg", null, "Watermelon", 1, 2 },
                    { 7, 34.0, 1, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1044), null, "\\Resources\\Melon.jpg", null, "Melon", 1, 2 },
                    { 8, 59.0, 1, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1046), null, "\\Resources\\Peach.jpeg", null, "Peach", 1, 2 },
                    { 9, 60.0, 1, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1048), null, "\\Resources\\Mango.jpg", null, "Mango", 1, 2 },
                    { 10, 50.0, 1, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1049), null, "\\Resources\\Cherry.jpg", null, "Cherry", 1, 2 },
                    { 11, 0.0, 2, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1051), null, "\\Resources\\Water.jpg", null, "Water", 1, 3 },
                    { 12, 113.0, 2, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1053), null, "\\Resources\\Milkshake.jpg", null, "Milkshake", 1, 3 },
                    { 13, 37.0, 2, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1054), null, "\\Resources\\Cola.jpg", null, "Cola", 1, 3 },
                    { 14, 48.0, 2, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1056), null, "\\Resources\\Fanta.jpg", null, "Fanta", 1, 3 },
                    { 15, 89.0, 2, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1057), null, "\\Resources\\Hotchocolate.jpg", null, "Hot Chocolate", 1, 3 },
                    { 16, 53.0, 2, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1059), null, "\\Resources\\Soda.jpg", null, "Soda", 1, 3 },
                    { 17, 1.0, 2, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1061), null, "\\Resources\\Coffee.jpg", null, "Coffee", 1, 3 },
                    { 18, 45.0, 2, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1063), null, "\\Resources\\Orangejuice.jpg", null, "Orange Juice", 1, 3 },
                    { 19, 2.0, 2, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1065), null, "\\Resources\\Tea.jpg", null, "Tea", 1, 3 },
                    { 20, 42.0, 2, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1067), null, "\\Resources\\Lemonade.jpg", null, "Lemonade", 1, 3 },
                    { 21, 433.0, 3, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1068), null, "\\Resources\\Wafer.jpg", null, "Wafer", 1, 2 },
                    { 22, 11.0, 3, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1070), null, "\\Resources\\Almond.jpg", null, "Almond", 1, 2 },
                    { 23, 6.0, 3, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1071), null, "\\Resources\\Peanut.png", null, "Peanut", 1, 2 },
                    { 24, 488.0, 3, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1073), null, "\\Resources\\Snickers.jpeg", null, "Snickers", 1, 2 },
                    { 25, 375.0, 3, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1075), null, "\\Resources\\Popcorn.jpeg", null, "Popcorn", 1, 1 },
                    { 26, 536.0, 3, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1076), null, "\\Resources\\Chips.jpg", null, "Chips", 1, 1 },
                    { 27, 502.0, 3, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1078), null, "\\Resources\\Cookies.jpg", null, "Cookies", 1, 1 },
                    { 28, 20.0, 3, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1080), null, "\\Resources\\Crackers.jpg", null, "Crackers", 1, 2 },
                    { 29, 559.0, 3, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1081), null, "\\Resources\\Sunflowerseed.jpg", null, "Sunflower Seed", 1, 1 },
                    { 30, 318.0, 3, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1083), null, "\\Resources\\Marshmallow.jpg", null, "Marshmallow", 1, 1 },
                    { 31, 321.0, 4, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1084), null, "\\Resources\\Cheesecake.jpg", null, "Cheesecake", 1, 2 },
                    { 32, 174.0, 4, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1086), null, "\\Resources\\Baklava.jpg", null, "Baklava", 1, 2 },
                    { 33, 438.0, 4, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1089), null, "\\Resources\\Doughnut.jpg", null, "Doughnut", 1, 2 },
                    { 34, 321.0, 4, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1090), null, "\\Resources\\Cremebrulee.jpg", null, "Creme brulee", 1, 1 },
                    { 35, 49.0, 4, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1092), null, "\\Resources\\Cookie.jpg", null, "Cookie", 1, 2 },
                    { 36, 466.0, 4, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1093), null, "\\Resources\\Brownie.jpg", null, "Brownie", 1, 1 },
                    { 37, 250.0, 4, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1095), null, "\\Resources\\Icecream.jpg", null, "Ice cream", 1, 2 },
                    { 38, 290.0, 4, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1097), null, "\\Resources\\Tiramisu.jpg", null, "Tiramisu", 1, 1 },
                    { 39, 271.0, 4, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1098), null, "\\Resources\\Pavlova.jpg", null, "Pavlova", 1, 1 },
                    { 40, 120.0, 4, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1100), null, "\\Resources\\Pudding.jpg", null, "Pudding", 1, 1 },
                    { 41, 33.0, 5, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1101), null, "\\Resources\\Brocoli.jpg", null, "Broccoli", 1, 1 },
                    { 42, 15.0, 5, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1111), null, "\\Resources\\Cucumber.jpg", null, "Cucumber", 1, 1 },
                    { 43, 42.0, 5, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1113), null, "\\Resources\\Celery.jpg", null, "Celery", 1, 1 },
                    { 44, 16.0, 5, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1115), null, "\\Resources\\Courgette.jpg", null, "Courgette", 1, 1 },
                    { 45, 24.0, 5, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1116), null, "\\Resources\\Eggplant.jpg", null, "Eggplant", 1, 1 },
                    { 46, 19.0, 5, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1118), null, "\\Resources\\Tomatoes.jpg", null, "Tomatoes", 1, 1 },
                    { 47, 41.0, 5, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1119), null, "\\Resources\\Carrot.jpg", null, "Carrot", 1, 1 },
                    { 48, 39.0, 5, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1121), null, "\\Resources\\Pepper.jpg", null, "Pepper", 1, 1 },
                    { 49, 47.0, 5, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1124), null, "\\Resources\\Artichoke.jpg", null, "Artichoke", 1, 1 },
                    { 50, 22.0, 5, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1125), null, "\\Resources\\Mushroom.jpg", null, "Mushroom", 1, 1 },
                    { 51, 59.0, 6, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1127), null, "\\Resources\\Yogurt.jpg", null, "Yogurt", 1, 1 },
                    { 52, 62.0, 6, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1128), null, "\\Resources\\Tzatziki.jpg", null, "Tzatziki", 1, 1 },
                    { 53, 50.0, 6, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1130), null, "\\Resources\\Ayran.jpg", null, "Ayran", 1, 3 },
                    { 54, 402.0, 6, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1131), null, "\\Resources\\Cheddarcheese.jpg", null, "Cheddar cheese", 1, 1 },
                    { 55, 98.0, 6, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1133), null, "\\Resources\\Cottagecheese.jpg", null, "Cottage cheese", 1, 1 },
                    { 56, 280.0, 6, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1135), null, "\\Resources\\Mozzarellacheese.jpg", null, "Mozzarella cheese", 1, 1 },
                    { 57, 42.0, 6, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1136), null, "\\Resources\\Milk.jpg", null, "Milk", 1, 3 },
                    { 58, 68.0, 6, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1138), null, "\\Resources\\Goatmilk.jpg", null, "Goat milk", 1, 3 },
                    { 59, 32.0, 6, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1139), null, "\\Resources\\Almondmilk.jpg", null, "Almond milk", 1, 3 },
                    { 60, 54.0, 6, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1141), null, "\\Resources\\Soymilk.jpg", null, "Soy milk", 1, 3 },
                    { 61, 164.0, 7, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1142), null, "\\Resources\\Octopus.jpg", null, "Octopus", 1, 2 },
                    { 62, 124.0, 7, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1144), null, "\\Resources\\Seabass.jpg", null, "Sea Bass", 1, 2 },
                    { 63, 264.0, 7, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1146), null, "\\Resources\\Caviar.jpg", null, "Caviar", 1, 2 },
                    { 64, 89.0, 7, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1147), null, "\\Resources\\Lobster.jpg", null, "Lobster", 1, 2 },
                    { 65, 175.0, 7, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1150), null, "\\Resources\\Calamary.jpg", null, "Calamary", 1, 2 },
                    { 66, 159.0, 7, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1152), null, "\\Resources\\Bluefish.jpg", null, "Blue Fish", 1, 2 },
                    { 67, 90.0, 7, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1154), null, "\\Resources\\whiting.jpg", null, "Whiting", 1, 2 },
                    { 68, 206.0, 7, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1155), null, "\\Resources\\Salmon.jpg", null, "Salmon", 1, 2 },
                    { 69, 150.0, 7, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1157), null, "\\Resources\\Sushi.jpg", null, "Sushi", 1, 2 },
                    { 70, 262.0, 7, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1159), null, "\\Resources\\Mackerel.jpg", null, "Mackerel", 1, 2 },
                    { 71, 295.0, 8, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1160), null, "\\Resources\\Burger.jpg", null, "Burger", 1, 1 },
                    { 72, 266.0, 8, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1162), null, "\\Resources\\Pizza.jpeg", null, "Pizza", 1, 1 },
                    { 73, 239.0, 8, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1164), null, "\\Resources\\Doner.jpg", null, "Doner", 1, 1 },
                    { 74, 312.0, 8, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1165), null, "\\Resources\\Frenchfries.jpg", null, "French fries", 1, 1 },
                    { 75, 164.0, 8, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1167), null, "\\Resources\\Macandcheese.jpg", null, "Mac and cheese", 1, 1 },
                    { 76, 118.0, 8, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1168), null, "\\Resources\\Lahmacun.jpg", null, "Lahmacun", 1, 1 },
                    { 77, 390.0, 8, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1170), null, "\\Resources\\Tantuni.jpg", null, "Tantuni", 1, 1 },
                    { 78, 284.0, 8, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1172), null, "\\Resources\\Sandwich.jpg", null, "Sandwich", 1, 1 },
                    { 79, 411.0, 8, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1173), null, "\\Resources\\Onionrings.jpeg", null, "Onion rings", 1, 1 },
                    { 80, 203.0, 8, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1175), null, "\\Resources\\Chickenwing.jpg", null, "Chicken wing", 1, 1 },
                    { 81, 360.0, 9, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1177), null, "\\Resources\\Adanakebab.jpg", null, "Adana Kebab", 1, 1 },
                    { 82, 235.0, 9, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1178), null, "\\Resources\\Meatball.jpg", null, "Meatball", 1, 1 },
                    { 83, 336.0, 9, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1180), null, "\\Resources\\Salami.jpg", null, "Salami", 1, 1 },
                    { 84, 300.0, 9, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1181), null, "\\Resources\\Sausage.jpg", null, "Sausage", 1, 1 },
                    { 85, 186.0, 9, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1183), null, "\\Resources\\Beefstew.jpg", null, "Beef Stew", 1, 1 },
                    { 86, 290.0, 9, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1185), null, "\\Resources\\Chickenmarsal.jpg", null, "Chicken Marsal", 1, 1 },
                    { 87, 350.0, 9, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1186), null, "\\Resources\\Chickentikkamasala.jpg", null, "Chicken Tikka Masala", 1, 1 },
                    { 88, 308.0, 9, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1188), null, "\\Resources\\Chimichanga.jpg", null, "Chimichanga", 1, 1 },
                    { 89, 290.0, 9, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1190), null, "\\Resources\\Fajita.jpg", null, "Fajita", 1, 1 },
                    { 90, 220.0, 9, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1191), null, "\\Resources\\Steak.jpg", null, "Steak", 1, 1 },
                    { 91, 264.0, 10, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1193), null, "\\Resources\\Bread.jpg", null, "Bread", 1, 2 },
                    { 92, 220.0, 10, new DateTime(2024, 3, 24, 14, 57, 47, 799, DateTimeKind.Local).AddTicks(1194), null, "\\Resources\\Egg.jpg", null, "Egg", 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_MealSummaries_FoodID",
                table: "MealSummaries",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_MealSummaries_MealID",
                table: "MealSummaries",
                column: "MealID");

            migrationBuilder.CreateIndex(
                name: "IX_MealSummaries_UserID",
                table: "MealSummaries",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealSummaries");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
