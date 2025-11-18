using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondoLounge.Migrations
{
    /// <inheritdoc />
    public partial class AddedEntitiesToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserCondo_Condo_CondosCondo_Number",
                table: "ApplicationUserCondo");

            migrationBuilder.DropForeignKey(
                name: "FK_Building_AspNetUsers_ApplicationUserId",
                table: "Building");

            migrationBuilder.DropForeignKey(
                name: "FK_Condo_Building_BuildingId",
                table: "Condo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Condo",
                table: "Condo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building",
                table: "Building");

            migrationBuilder.RenameTable(
                name: "Condo",
                newName: "Condos");

            migrationBuilder.RenameTable(
                name: "Building",
                newName: "Buildings");

            migrationBuilder.RenameColumn(
                name: "CondosCondo_Number",
                table: "ApplicationUserCondo",
                newName: "CondosId");

            migrationBuilder.RenameIndex(
                name: "IX_Condo_BuildingId",
                table: "Condos",
                newName: "IX_Condos_BuildingId");

            migrationBuilder.RenameIndex(
                name: "IX_Building_ApplicationUserId",
                table: "Buildings",
                newName: "IX_Buildings_ApplicationUserId");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingId",
                table: "Condos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Condo_Number",
                table: "Condos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Condos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Condos",
                table: "Condos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buildings",
                table: "Buildings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserCondo_Condos_CondosId",
                table: "ApplicationUserCondo",
                column: "CondosId",
                principalTable: "Condos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_AspNetUsers_ApplicationUserId",
                table: "Buildings",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Condos_Buildings_BuildingId",
                table: "Condos",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserCondo_Condos_CondosId",
                table: "ApplicationUserCondo");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_AspNetUsers_ApplicationUserId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Condos_Buildings_BuildingId",
                table: "Condos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Condos",
                table: "Condos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Buildings",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Condos");

            migrationBuilder.RenameTable(
                name: "Condos",
                newName: "Condo");

            migrationBuilder.RenameTable(
                name: "Buildings",
                newName: "Building");

            migrationBuilder.RenameColumn(
                name: "CondosId",
                table: "ApplicationUserCondo",
                newName: "CondosCondo_Number");

            migrationBuilder.RenameIndex(
                name: "IX_Condos_BuildingId",
                table: "Condo",
                newName: "IX_Condo_BuildingId");

            migrationBuilder.RenameIndex(
                name: "IX_Buildings_ApplicationUserId",
                table: "Building",
                newName: "IX_Building_ApplicationUserId");

            migrationBuilder.AlterColumn<int>(
                name: "Condo_Number",
                table: "Condo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingId",
                table: "Condo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Condo",
                table: "Condo",
                column: "Condo_Number");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building",
                table: "Building",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserCondo_Condo_CondosCondo_Number",
                table: "ApplicationUserCondo",
                column: "CondosCondo_Number",
                principalTable: "Condo",
                principalColumn: "Condo_Number",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Building_AspNetUsers_ApplicationUserId",
                table: "Building",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Condo_Building_BuildingId",
                table: "Condo",
                column: "BuildingId",
                principalTable: "Building",
                principalColumn: "Id");
        }
    }
}
