using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YulyaTimofeevaKt_42_21.Migrations
{
    /// <inheritdoc />
    public partial class CreateDeletionStatusField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deletion status",
                table: "cd_student",
                type: "bool",
                nullable: false,
                defaultValue: false,
                comment: "Статус удаления");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deletion status",
                table: "cd_student");
        }
    }
}
