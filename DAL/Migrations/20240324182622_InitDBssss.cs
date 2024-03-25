using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDBssss : Migration
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
                    MealID = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Foods_Meals_MealID",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "MealID");
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
                    { 1, "Fruit", new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6203), null, null, null },
                    { 2, "Drink", new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6214), null, null, null },
                    { 3, "Snack", new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6216), null, null, null },
                    { 4, "Dessert", new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6216), null, null, null },
                    { 5, "Vegetable", new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6217), null, null, null },
                    { 6, "Dairy", new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6218), null, null, null },
                    { 7, "Fish and Seafood", new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6218), null, null, null },
                    { 8, "Fast Food", new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6219), null, null, null },
                    { 9, "Meat or Poultry", new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6220), null, null, null },
                    { 10, "Others", new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6221), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealID", "CreationDate", "DeletedDate", "MealName", "ModifiedDate", "Status", "TotalCalorie" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6838), null, "Breakfast", null, null, 0.0 },
                    { 2, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6841), null, "Lunch", null, null, 0.0 },
                    { 3, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6842), null, "Dinner", null, null, 0.0 },
                    { 4, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6843), null, "Snack", null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calorie", "CategoryID", "CreationDate", "DeletedDate", "Image", "MealID", "ModifiedDate", "Name", "Status", "Unit" },
                values: new object[,]
                {
                    { 1, 52.0, 1, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6460), null, "\\Resources\\Apple.jpeg", null, null, "Apple", 1, 2 },
                    { 2, 47.0, 1, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6468), null, "\\Resources\\Orange.jpg", null, null, "Orange", 1, 2 },
                    { 3, 131.0, 1, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6469), null, "\\Resources\\Banana.jpg", null, null, "Banana", 1, 2 },
                    { 4, 46.0, 1, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6471), null, "\\Resources\\Plum.jpeg", null, null, "Plum", 1, 2 },
                    { 5, 61.0, 1, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6472), null, "\\Resources\\Kiwi.jpg", null, null, "Kiwi", 1, 2 },
                    { 6, 30.0, 1, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6473), null, "\\Resources\\Watermelon.jpg", null, null, "Watermelon", 1, 2 },
                    { 7, 34.0, 1, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6474), null, "\\Resources\\Melon.jpg", null, null, "Melon", 1, 2 },
                    { 8, 59.0, 1, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6476), null, "\\Resources\\Peach.jpeg", null, null, "Peach", 1, 2 },
                    { 9, 60.0, 1, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6477), null, "\\Resources\\Mango.jpg", null, null, "Mango", 1, 2 },
                    { 10, 50.0, 1, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6479), null, "\\Resources\\Cherry.jpg", null, null, "Cherry", 1, 2 },
                    { 11, 0.0, 2, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6481), null, "\\Resources\\Water.jpg", null, null, "Water", 1, 3 },
                    { 12, 113.0, 2, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6483), null, "\\Resources\\Milkshake.jpg", null, null, "Milkshake", 1, 3 },
                    { 13, 37.0, 2, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6485), null, "\\Resources\\Cola.jpg", null, null, "Cola", 1, 3 },
                    { 14, 48.0, 2, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6487), null, "\\Resources\\Fanta.jpg", null, null, "Fanta", 1, 3 },
                    { 15, 89.0, 2, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6490), null, "\\Resources\\Hotchocolate.jpg", null, null, "Hot Chocolate", 1, 3 },
                    { 16, 53.0, 2, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6494), null, "\\Resources\\Soda.jpg", null, null, "Soda", 1, 3 },
                    { 17, 1.0, 2, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6496), null, "\\Resources\\Coffee.jpg", null, null, "Coffee", 1, 3 },
                    { 18, 45.0, 2, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6497), null, "\\Resources\\Orangejuice.jpg", null, null, "Orange Juice", 1, 3 },
                    { 19, 2.0, 2, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6499), null, "\\Resources\\Tea.jpg", null, null, "Tea", 1, 3 },
                    { 20, 42.0, 2, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6502), null, "\\Resources\\Lemonade.jpg", null, null, "Lemonade", 1, 3 },
                    { 21, 433.0, 3, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6504), null, "\\Resources\\Wafer.jpg", null, null, "Wafer", 1, 2 },
                    { 22, 11.0, 3, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6505), null, "\\Resources\\Almond.jpg", null, null, "Almond", 1, 2 },
                    { 23, 6.0, 3, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6507), null, "\\Resources\\Peanut.png", null, null, "Peanut", 1, 2 },
                    { 24, 488.0, 3, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6508), null, "\\Resources\\Snickers.jpeg", null, null, "Snickers", 1, 2 },
                    { 25, 375.0, 3, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6509), null, "\\Resources\\Popcorn.jpeg", null, null, "Popcorn", 1, 1 },
                    { 26, 536.0, 3, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6510), null, "\\Resources\\Chips.jpg", null, null, "Chips", 1, 1 },
                    { 27, 502.0, 3, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6512), null, "\\Resources\\Cookies.jpg", null, null, "Cookies", 1, 1 },
                    { 28, 20.0, 3, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6514), null, "\\Resources\\Crackers.jpg", null, null, "Crackers", 1, 2 },
                    { 29, 559.0, 3, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6515), null, "\\Resources\\Sunflowerseed.jpg", null, null, "Sunflower Seed", 1, 1 },
                    { 30, 318.0, 3, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6516), null, "\\Resources\\Marshmallow.jpg", null, null, "Marshmallow", 1, 1 },
                    { 31, 321.0, 4, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6519), null, "\\Resources\\Cheesecake.jpg", null, null, "Cheesecake", 1, 2 },
                    { 32, 174.0, 4, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6520), null, "\\Resources\\Baklava.jpg", null, null, "Baklava", 1, 2 },
                    { 33, 438.0, 4, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6522), null, "\\Resources\\Doughnut.jpg", null, null, "Doughnut", 1, 2 },
                    { 34, 321.0, 4, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6524), null, "\\Resources\\Cremebrulee.jpg", null, null, "Creme brulee", 1, 1 },
                    { 35, 49.0, 4, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6525), null, "\\Resources\\Cookie.jpg", null, null, "Cookie", 1, 2 },
                    { 36, 466.0, 4, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6527), null, "\\Resources\\Brownie.jpg", null, null, "Brownie", 1, 1 },
                    { 37, 250.0, 4, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6530), null, "\\Resources\\Icecream.jpg", null, null, "Ice cream", 1, 2 },
                    { 38, 290.0, 4, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6531), null, "\\Resources\\Tiramisu.jpg", null, null, "Tiramisu", 1, 1 },
                    { 39, 271.0, 4, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6533), null, "\\Resources\\Pavlova.jpg", null, null, "Pavlova", 1, 1 },
                    { 40, 120.0, 4, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6534), null, "\\Resources\\Pudding.jpg", null, null, "Pudding", 1, 1 },
                    { 41, 33.0, 5, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6535), null, "\\Resources\\Brocoli.jpg", null, null, "Broccoli", 1, 1 },
                    { 42, 15.0, 5, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6536), null, "\\Resources\\Cucumber.jpg", null, null, "Cucumber", 1, 1 },
                    { 43, 42.0, 5, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6545), null, "\\Resources\\Celery.jpg", null, null, "Celery", 1, 1 },
                    { 44, 16.0, 5, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6546), null, "\\Resources\\Courgette.jpg", null, null, "Courgette", 1, 1 },
                    { 45, 24.0, 5, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6547), null, "\\Resources\\Eggplant.jpg", null, null, "Eggplant", 1, 1 },
                    { 46, 19.0, 5, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6549), null, "\\Resources\\Tomatoes.jpg", null, null, "Tomatoes", 1, 1 },
                    { 47, 41.0, 5, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6550), null, "\\Resources\\Carrot.jpg", null, null, "Carrot", 1, 1 },
                    { 48, 39.0, 5, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6551), null, "\\Resources\\Pepper.jpg", null, null, "Pepper", 1, 1 },
                    { 49, 47.0, 5, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6552), null, "\\Resources\\Artichoke.jpg", null, null, "Artichoke", 1, 1 },
                    { 50, 22.0, 5, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6554), null, "\\Resources\\Mushroom.jpg", null, null, "Mushroom", 1, 1 },
                    { 51, 59.0, 6, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6555), null, "\\Resources\\Yogurt.jpg", null, null, "Yogurt", 1, 1 },
                    { 52, 62.0, 6, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6556), null, "\\Resources\\Tzatziki.jpg", null, null, "Tzatziki", 1, 1 },
                    { 53, 50.0, 6, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6558), null, "\\Resources\\Ayran.jpg", null, null, "Ayran", 1, 3 },
                    { 54, 402.0, 6, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6560), null, "\\Resources\\Cheddarcheese.jpg", null, null, "Cheddar cheese", 1, 1 },
                    { 55, 98.0, 6, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6562), null, "\\Resources\\Cottagecheese.jpg", null, null, "Cottage cheese", 1, 1 },
                    { 56, 280.0, 6, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6563), null, "\\Resources\\Mozzarellacheese.jpg", null, null, "Mozzarella cheese", 1, 1 },
                    { 57, 42.0, 6, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6564), null, "\\Resources\\Milk.jpg", null, null, "Milk", 1, 3 },
                    { 58, 68.0, 6, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6565), null, "\\Resources\\Goatmilk.jpg", null, null, "Goat milk", 1, 3 },
                    { 59, 32.0, 6, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6567), null, "\\Resources\\Almondmilk.jpg", null, null, "Almond milk", 1, 3 },
                    { 60, 54.0, 6, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6568), null, "\\Resources\\Soymilk.jpg", null, null, "Soy milk", 1, 3 },
                    { 61, 164.0, 7, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6569), null, "\\Resources\\Octopus.jpg", null, null, "Octopus", 1, 2 },
                    { 62, 124.0, 7, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6572), null, "\\Resources\\Seabass.jpg", null, null, "Sea Bass", 1, 2 },
                    { 63, 264.0, 7, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6575), null, "\\Resources\\Caviar.jpg", null, null, "Caviar", 1, 2 },
                    { 64, 89.0, 7, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6576), null, "\\Resources\\Lobster.jpg", null, null, "Lobster", 1, 2 },
                    { 65, 175.0, 7, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6579), null, "\\Resources\\Calamary.jpg", null, null, "Calamary", 1, 2 },
                    { 66, 159.0, 7, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6580), null, "\\Resources\\Bluefish.jpg", null, null, "Blue Fish", 1, 2 },
                    { 67, 90.0, 7, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6582), null, "\\Resources\\whiting.jpg", null, null, "Whiting", 1, 2 },
                    { 68, 206.0, 7, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6583), null, "\\Resources\\Salmon.jpg", null, null, "Salmon", 1, 2 },
                    { 69, 150.0, 7, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6586), null, "\\Resources\\Sushi.jpg", null, null, "Sushi", 1, 2 },
                    { 70, 262.0, 7, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6587), null, "\\Resources\\Mackerel.jpg", null, null, "Mackerel", 1, 2 },
                    { 71, 295.0, 8, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6588), null, "\\Resources\\Burger.jpg", null, null, "Burger", 1, 1 },
                    { 72, 266.0, 8, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6589), null, "\\Resources\\Pizza.jpeg", null, null, "Pizza", 1, 1 },
                    { 73, 239.0, 8, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6591), null, "\\Resources\\Doner.jpg", null, null, "Doner", 1, 1 },
                    { 74, 312.0, 8, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6592), null, "\\Resources\\Frenchfries.jpg", null, null, "French fries", 1, 1 },
                    { 75, 164.0, 8, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6593), null, "\\Resources\\Macandcheese.jpg", null, null, "Mac and cheese", 1, 1 },
                    { 76, 118.0, 8, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6594), null, "\\Resources\\Lahmacun.jpg", null, null, "Lahmacun", 1, 1 },
                    { 77, 390.0, 8, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6596), null, "\\Resources\\Tantuni.jpg", null, null, "Tantuni", 1, 1 },
                    { 78, 284.0, 8, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6597), null, "\\Resources\\Sandwich.jpg", null, null, "Sandwich", 1, 1 },
                    { 79, 411.0, 8, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6598), null, "\\Resources\\Onionrings.jpeg", null, null, "Onion rings", 1, 1 },
                    { 80, 203.0, 8, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6600), null, "\\Resources\\Chickenwing.jpg", null, null, "Chicken wing", 1, 1 },
                    { 81, 360.0, 9, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6601), null, "\\Resources\\Adanakebab.jpg", null, null, "Adana Kebab", 1, 1 },
                    { 82, 235.0, 9, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6602), null, "\\Resources\\Meatball.jpg", null, null, "Meatball", 1, 1 },
                    { 83, 336.0, 9, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6604), null, "\\Resources\\Salami.jpg", null, null, "Salami", 1, 1 },
                    { 84, 300.0, 9, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6605), null, "\\Resources\\Sausage.jpg", null, null, "Sausage", 1, 1 },
                    { 85, 186.0, 9, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6606), null, "\\Resources\\Beefstew.jpg", null, null, "Beef Stew", 1, 1 },
                    { 86, 290.0, 9, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6608), null, "\\Resources\\Chickenmarsal.jpg", null, null, "Chicken Marsal", 1, 1 },
                    { 87, 350.0, 9, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6609), null, "\\Resources\\Chickentikkamasala.jpg", null, null, "Chicken Tikka Masala", 1, 1 },
                    { 88, 308.0, 9, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6610), null, "\\Resources\\Chimichanga.jpg", null, null, "Chimichanga", 1, 1 },
                    { 89, 290.0, 9, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6611), null, "\\Resources\\Fajita.jpg", null, null, "Fajita", 1, 1 },
                    { 90, 220.0, 9, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6612), null, "\\Resources\\Steak.jpg", null, null, "Steak", 1, 1 },
                    { 91, 264.0, 10, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6614), null, "\\Resources\\Bread.jpg", null, null, "Bread", 1, 2 },
                    { 92, 220.0, 10, new DateTime(2024, 3, 24, 21, 26, 22, 221, DateTimeKind.Local).AddTicks(6615), null, "\\Resources\\Egg.jpg", null, null, "Egg", 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_MealID",
                table: "Foods",
                column: "MealID");

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
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Meals");
        }
    }
}
