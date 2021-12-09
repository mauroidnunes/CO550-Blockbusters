using Microsoft.EntityFrameworkCore.Migrations;

namespace blockbusters.Data.Migrations
{
    public partial class ChangedDataTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_People_PersonID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Movie_MovieID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonReview_Movie_MovieID",
                table: "PersonReview");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonReview_People_PersonID",
                table: "PersonReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonReview",
                table: "PersonReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "PersonReview",
                newName: "PeopleReviews");

            migrationBuilder.RenameTable(
                name: "OrderItem",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.RenameIndex(
                name: "IX_PersonReview_PersonID",
                table: "PeopleReviews",
                newName: "IX_PeopleReviews_PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonReview_MovieID",
                table: "PeopleReviews",
                newName: "IX_PeopleReviews_MovieID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderID",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_MovieID",
                table: "OrderItems",
                newName: "IX_OrderItems_MovieID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_PersonID",
                table: "Orders",
                newName: "IX_Orders_PersonID");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalePrice",
                table: "OrderItems",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Movies",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeopleReviews",
                table: "PeopleReviews",
                column: "PersonReviewID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "OrderItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Movies_MovieID",
                table: "OrderItems",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderID",
                table: "OrderItems",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_People_PersonID",
                table: "Orders",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleReviews_Movies_MovieID",
                table: "PeopleReviews",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleReviews_People_PersonID",
                table: "PeopleReviews",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Movies_MovieID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_People_PersonID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleReviews_Movies_MovieID",
                table: "PeopleReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleReviews_People_PersonID",
                table: "PeopleReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeopleReviews",
                table: "PeopleReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "PeopleReviews",
                newName: "PersonReview");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItem");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.RenameIndex(
                name: "IX_PeopleReviews_PersonID",
                table: "PersonReview",
                newName: "IX_PersonReview_PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_PeopleReviews_MovieID",
                table: "PersonReview",
                newName: "IX_PersonReview_MovieID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PersonID",
                table: "Order",
                newName: "IX_Order_PersonID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderID",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_MovieID",
                table: "OrderItem",
                newName: "IX_OrderItem_MovieID");

            migrationBuilder.AlterColumn<decimal>(
                name: "SalePrice",
                table: "OrderItem",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Movie",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonReview",
                table: "PersonReview",
                column: "PersonReviewID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem",
                column: "OrderItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_People_PersonID",
                table: "Order",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Movie_MovieID",
                table: "OrderItem",
                column: "MovieID",
                principalTable: "Movie",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderID",
                table: "OrderItem",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonReview_Movie_MovieID",
                table: "PersonReview",
                column: "MovieID",
                principalTable: "Movie",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonReview_People_PersonID",
                table: "PersonReview",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
