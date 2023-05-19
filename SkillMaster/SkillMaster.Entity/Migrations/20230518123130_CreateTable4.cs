using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillMaster.Model.Migrations
{
    public partial class CreateTable4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "skill");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "skill",
                newName: "created_at");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "skill",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Active",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "skill",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_skill",
                table: "skill",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_skill",
                table: "skill");

            migrationBuilder.RenameTable(
                name: "skill",
                newName: "Skills");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Skills",
                newName: "CreatedAt");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Active");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Skills",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "SkillId");
        }
    }
}
