using Microsoft.EntityFrameworkCore.Migrations;

namespace blockbusters.Data.Migrations
{
    public partial class LinkEnumGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_PersonGenre_People_PersonID",
                table: "PersonGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonGenre",
                table: "PersonGenre");

            migrationBuilder.RenameTable(
                name: "PersonGenre",
                newName: "PeopleGenres");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "PeopleGenres",
                newName: "GenreID");

            migrationBuilder.RenameIndex(
                name: "IX_PersonGenre_PersonID",
                table: "PeopleGenres",
                newName: "IX_PeopleGenres_PersonID");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "PeopleReviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "PeopleReviews",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "PeopleGenres",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeopleGenres",
                table: "PeopleGenres",
                column: "PersonGenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Movies_MovieID",
                table: "OrderItems",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderID",
                table: "OrderItems",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_People_PersonID",
                table: "Orders",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleGenres_People_PersonID",
                table: "PeopleGenres",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleReviews_Movies_MovieID",
                table: "PeopleReviews",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleReviews_People_PersonID",
                table: "PeopleReviews",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
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
                name: "FK_PeopleGenres_People_PersonID",
                table: "PeopleGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleReviews_Movies_MovieID",
                table: "PeopleReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleReviews_People_PersonID",
                table: "PeopleReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeopleGenres",
                table: "PeopleGenres");

            migrationBuilder.RenameTable(
                name: "PeopleGenres",
                newName: "PersonGenre");

            migrationBuilder.RenameColumn(
                name: "GenreID",
                table: "PersonGenre",
                newName: "Genre");

            migrationBuilder.RenameIndex(
                name: "IX_PeopleGenres_PersonID",
                table: "PersonGenre",
                newName: "IX_PersonGenre_PersonID");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "PeopleReviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "PeopleReviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "OrderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieID",
                table: "OrderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "PersonGenre",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonGenre",
                table: "PersonGenre",
                column: "PersonGenreID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PersonGenre_People_PersonID",
                table: "PersonGenre",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
