using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YulyaTimofeevaKt_42_21.Migrations
{
    /// <inheritdoc />
    public partial class CreateSubjectModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "c_group_id",
                table: "cd_subject",
                type: "int4",
                nullable: false,
                defaultValue: 0,
                comment: "Идентификатор группы");

            migrationBuilder.CreateIndex(
                name: "idx_cd_subject_fk_c_group_id",
                table: "cd_subject",
                column: "c_group_id");

            migrationBuilder.AddForeignKey(
                name: "fk_c_group_id",
                table: "cd_subject",
                column: "c_group_id",
                principalTable: "cd_group",
                principalColumn: "group_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_c_group_id",
                table: "cd_subject");

            migrationBuilder.DropIndex(
                name: "idx_cd_subject_fk_c_group_id",
                table: "cd_subject");

            migrationBuilder.DropColumn(
                name: "c_group_id",
                table: "cd_subject");
        }
    }
}
