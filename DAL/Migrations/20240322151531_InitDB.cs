using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
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
                    { 1, "Fruit", new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2178), null, null, null },
                    { 2, "Drink", new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2189), null, null, null },
                    { 3, "Snack", new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2190), null, null, null },
                    { 4, "Dessert", new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2190), null, null, null },
                    { 5, "Vegetable", new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2191), null, null, null },
                    { 6, "Dairy", new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2192), null, null, null },
                    { 7, "Fish and Seafood", new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2193), null, null, null },
                    { 8, "Fast Food", new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2193), null, null, null },
                    { 9, "Meat or Poultry", new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2194), null, null, null },
                    { 10, "Others", new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2195), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealID", "CreationDate", "DeletedDate", "MealName", "ModifiedDate", "Status", "TotalCalorie" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2854), null, "Breakfast", null, null, 0.0 },
                    { 2, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2856), null, "Lunch", null, null, 0.0 },
                    { 3, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2857), null, "Dinner", null, null, 0.0 },
                    { 4, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2858), null, "Snack", null, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calorie", "CategoryID", "CreationDate", "DeletedDate", "Image", "ModifiedDate", "Name", "Status", "Unit" },
                values: new object[,]
                {
                    { 1, 52.0, 1, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2464), null, "\\FoodPhotos\\2.jpg", null, "Apple", 1, 2 },
                    { 2, 47.0, 1, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2469), null, "\\FoodPhotos\\2.jpg", null, "Orange", 1, 2 },
                    { 3, 131.0, 1, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2471), null, "\\FoodPhotos\\2.jpg", null, "Banana", 1, 2 },
                    { 4, 46.0, 1, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2472), null, "\\FoodPhotos\\2.jpg", null, "Plum", 1, 2 },
                    { 5, 61.0, 1, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2474), null, "\\FoodPhotos\\2.jpg", null, "Kiwi", 1, 2 },
                    { 6, 30.0, 1, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2475), null, "\\FoodPhotos\\2.jpg", null, "Watermelon", 1, 2 },
                    { 7, 34.0, 1, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2476), null, "\\FoodPhotos\\2.jpg", null, "Melon", 1, 2 },
                    { 8, 59.0, 1, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2478), null, "\\FoodPhotos\\2.jpg", null, "Peach", 1, 2 },
                    { 9, 60.0, 1, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2479), null, "\\FoodPhotos\\2.jpg", null, "Mango", 1, 2 },
                    { 10, 50.0, 1, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2480), null, "\\FoodPhotos\\2.jpg", null, "Cherry", 1, 2 },
                    { 11, 0.0, 2, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2482), null, "\\FoodPhotos\\2.jpg", null, "Water", 1, 3 },
                    { 12, 113.0, 2, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2483), null, "\\FoodPhotos\\2.jpg", null, "Milkshake", 1, 3 },
                    { 13, 37.0, 2, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2484), null, "\\FoodPhotos\\2.jpg", null, "Cola", 1, 3 },
                    { 14, 48.0, 2, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2486), null, "\\FoodPhotos\\2.jpg", null, "Fanta", 1, 3 },
                    { 15, 89.0, 2, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2487), null, "\\FoodPhotos\\2.jpg", null, "Hot Chocolate", 1, 3 },
                    { 16, 53.0, 2, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2488), null, "\\FoodPhotos\\2.jpg", null, "Soda", 1, 3 },
                    { 17, 1.0, 2, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2491), null, "\\FoodPhotos\\2.jpg", null, "Coffee", 1, 3 },
                    { 18, 45.0, 2, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2493), null, "\\FoodPhotos\\2.jpg", null, "Orange Juice", 1, 3 },
                    { 19, 2.0, 2, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2494), null, "\\FoodPhotos\\2.jpg", null, "Tea", 1, 3 },
                    { 20, 42.0, 2, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2496), null, "\\FoodPhotos\\2.jpg", null, "Lemonade", 1, 3 },
                    { 21, 433.0, 3, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2498), null, "\\FoodPhotos\\2.jpg", null, "Wafer", 1, 2 },
                    { 22, 11.0, 3, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2502), null, "\\FoodPhotos\\2.jpg", null, "Almond", 1, 2 },
                    { 23, 6.0, 3, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2504), null, "\\FoodPhotos\\2.jpg", null, "Peanut", 1, 2 },
                    { 24, 488.0, 3, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2506), null, "\\FoodPhotos\\2.jpg", null, "Snickers", 1, 2 },
                    { 25, 375.0, 3, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2507), null, "\\FoodPhotos\\2.jpg", null, "Popcorn", 1, 1 },
                    { 26, 536.0, 3, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2509), null, "\\FoodPhotos\\2.jpg", null, "Chips", 1, 1 },
                    { 27, 502.0, 3, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2518), null, "\\FoodPhotos\\2.jpg", null, "Cookies", 1, 1 },
                    { 28, 20.0, 3, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2520), null, "\\FoodPhotos\\2.jpg", null, "Crackers", 1, 2 },
                    { 29, 559.0, 3, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2522), null, "\\FoodPhotos\\2.jpg", null, "Sunflower Seed", 1, 1 },
                    { 30, 318.0, 3, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2524), null, "\\FoodPhotos\\2.jpg", null, "Marshmallow", 1, 1 },
                    { 31, 321.0, 4, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2526), null, "\\FoodPhotos\\2.jpg", null, "Cheesecake", 1, 2 },
                    { 32, 174.0, 4, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2527), null, "\\FoodPhotos\\2.jpg", null, "Baklava", 1, 2 },
                    { 33, 438.0, 4, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2529), null, "\\FoodPhotos\\2.jpg", null, "Doughnut", 1, 2 },
                    { 34, 321.0, 4, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2530), null, "\\FoodPhotos\\2.jpg", null, "Creme brulee", 1, 1 },
                    { 35, 49.0, 4, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2532), null, "\\FoodPhotos\\2.jpg", null, "Cookie", 1, 2 },
                    { 36, 466.0, 4, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2533), null, "\\FoodPhotos\\2.jpg", null, "Brownie", 1, 1 },
                    { 37, 250.0, 4, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2534), null, "\\FoodPhotos\\2.jpg", null, "Ice cream", 1, 2 },
                    { 38, 290.0, 4, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2536), null, "\\FoodPhotos\\2.jpg", null, "Tiramisu", 1, 1 },
                    { 39, 271.0, 4, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2537), null, "\\FoodPhotos\\2.jpg", null, "Pavlova", 1, 1 },
                    { 40, 120.0, 4, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2538), null, "\\FoodPhotos\\2.jpg", null, "Pudding", 1, 1 },
                    { 41, 33.0, 5, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2540), null, "\\FoodPhotos\\2.jpg", null, "Broccoli", 1, 1 },
                    { 42, 15.0, 5, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2541), null, "\\FoodPhotos\\2.jpg", null, "Cucumber", 1, 1 },
                    { 43, 42.0, 5, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2542), null, "\\FoodPhotos\\2.jpg", null, "Celery", 1, 1 },
                    { 44, 16.0, 5, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2544), null, "\\FoodPhotos\\2.jpg", null, "Courgette", 1, 1 },
                    { 45, 24.0, 5, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2546), null, "\\FoodPhotos\\2.jpg", null, "Eggplant", 1, 1 },
                    { 46, 19.0, 5, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2547), null, "\\FoodPhotos\\2.jpg", null, "Tomatoes", 1, 1 },
                    { 47, 41.0, 5, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2548), null, "\\FoodPhotos\\2.jpg", null, "Carrot", 1, 1 },
                    { 48, 39.0, 5, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2550), null, "\\FoodPhotos\\2.jpg", null, "Pepper", 1, 1 },
                    { 49, 47.0, 5, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2552), null, "\\FoodPhotos\\2.jpg", null, "Artichoke", 1, 1 },
                    { 50, 22.0, 5, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2553), null, "\\FoodPhotos\\2.jpg", null, "Mushroom", 1, 1 },
                    { 51, 59.0, 6, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2555), null, "\\FoodPhotos\\2.jpg", null, "Yogurt", 1, 1 },
                    { 52, 62.0, 6, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2557), null, "\\FoodPhotos\\2.jpg", null, "Tzatziki", 1, 1 },
                    { 53, 50.0, 6, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2558), null, "\\FoodPhotos\\2.jpg", null, "Ayran", 1, 3 },
                    { 54, 402.0, 6, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2559), null, "\\FoodPhotos\\2.jpg", null, "Cheddar cheese", 1, 1 },
                    { 55, 98.0, 6, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2561), null, "\\FoodPhotos\\2.jpg", null, "Cottage cheese", 1, 1 },
                    { 56, 280.0, 6, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2562), null, "\\FoodPhotos\\2.jpg", null, "Mozzarella cheese", 1, 1 },
                    { 57, 42.0, 6, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2563), null, "\\FoodPhotos\\2.jpg", null, "Milk", 1, 3 },
                    { 58, 68.0, 6, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2564), null, "\\FoodPhotos\\2.jpg", null, "Goat milk", 1, 3 },
                    { 59, 32.0, 6, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2566), null, "\\FoodPhotos\\2.jpg", null, "Almond milk", 1, 3 },
                    { 60, 54.0, 6, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2570), null, "\\FoodPhotos\\2.jpg", null, "Soy milk", 1, 3 },
                    { 61, 164.0, 7, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2572), null, "\\FoodPhotos\\2.jpg", null, "Octopus", 1, 2 },
                    { 62, 124.0, 7, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2573), null, "\\FoodPhotos\\2.jpg", null, "Sea Bass", 1, 2 },
                    { 63, 264.0, 7, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2574), null, "\\FoodPhotos\\2.jpg", null, "Caviar", 1, 2 },
                    { 64, 89.0, 7, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2576), null, "\\FoodPhotos\\2.jpg", null, "Lobster", 1, 2 },
                    { 65, 175.0, 7, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2577), null, "\\FoodPhotos\\2.jpg", null, "Calamary", 1, 2 },
                    { 66, 159.0, 7, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2578), null, "\\FoodPhotos\\2.jpg", null, "Blue Fish", 1, 2 },
                    { 67, 90.0, 7, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2581), null, "\\FoodPhotos\\2.jpg", null, "Whiting", 1, 2 },
                    { 68, 206.0, 7, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2582), null, "\\FoodPhotos\\2.jpg", null, "Salmon", 1, 2 },
                    { 69, 150.0, 7, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2583), null, "\\FoodPhotos\\2.jpg", null, "Sushi", 1, 2 },
                    { 70, 262.0, 7, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2585), null, "\\FoodPhotos\\2.jpg", null, "Mackerel", 1, 2 },
                    { 71, 295.0, 8, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2586), null, "\\FoodPhotos\\2.jpg", null, "Burger", 1, 1 },
                    { 72, 266.0, 8, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2587), null, "\\FoodPhotos\\2.jpg", null, "Pizza", 1, 1 },
                    { 73, 239.0, 8, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2589), null, "\\FoodPhotos\\2.jpg", null, "Doner", 1, 1 },
                    { 74, 312.0, 8, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2590), null, "\\FoodPhotos\\2.jpg", null, "French fries", 1, 1 },
                    { 75, 164.0, 8, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2591), null, "\\FoodPhotos\\2.jpg", null, "Mac and cheese", 1, 1 },
                    { 76, 118.0, 8, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2593), null, "\\FoodPhotos\\2.jpg", null, "Lahmacun", 1, 1 },
                    { 77, 390.0, 8, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2594), null, "\\FoodPhotos\\2.jpg", null, "Tantuni", 1, 1 },
                    { 78, 284.0, 8, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2595), null, "\\FoodPhotos\\2.jpg", null, "Sandwich", 1, 1 },
                    { 79, 411.0, 8, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2597), null, "\\FoodPhotos\\2.jpg", null, "Onion rings", 1, 1 },
                    { 80, 203.0, 8, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2598), null, "\\FoodPhotos\\2.jpg", null, "Chicken wing", 1, 1 },
                    { 81, 360.0, 9, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2599), null, "\\FoodPhotos\\2.jpg", null, "Adana Kebab", 1, 1 },
                    { 82, 235.0, 9, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2600), null, "\\FoodPhotos\\2.jpg", null, "Meatball", 1, 1 },
                    { 83, 336.0, 9, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2602), null, "\\FoodPhotos\\2.jpg", null, "Salami", 1, 1 },
                    { 84, 300.0, 9, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2603), null, "\\FoodPhotos\\2.jpg", null, "Sausage", 1, 1 },
                    { 85, 186.0, 9, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2604), null, "\\FoodPhotos\\2.jpg", null, "Beef Stew", 1, 1 },
                    { 86, 290.0, 9, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2606), null, "\\FoodPhotos\\2.jpg", null, "Chicken Marsal", 1, 1 },
                    { 87, 350.0, 9, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2608), null, "\\FoodPhotos\\2.jpg", null, "Chicken Tikka Masala", 1, 1 },
                    { 88, 308.0, 9, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2609), null, "\\FoodPhotos\\2.jpg", null, "Chimichanga", 1, 1 },
                    { 89, 290.0, 9, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2610), null, "\\FoodPhotos\\2.jpg", null, "Fajita", 1, 1 },
                    { 90, 220.0, 9, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2612), null, "\\FoodPhotos\\2.jpg", null, "Steak", 1, 1 },
                    { 91, 264.0, 10, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2613), null, "\\FoodPhotos\\2.jpg", null, "Bread", 1, 2 },
                    { 92, 220.0, 10, new DateTime(2024, 3, 22, 18, 15, 31, 255, DateTimeKind.Local).AddTicks(2614), null, "\\FoodPhotos\\2.jpg", null, "Egg", 1, 1 }
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
