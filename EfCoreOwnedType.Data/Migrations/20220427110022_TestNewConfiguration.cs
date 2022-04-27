using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreOwnedType.Data.Migrations
{
    public partial class TestNewConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_PersonalData_DataId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_DataId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "uorM-JDuHEaAR5RAfoOHeA");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "TwFrjqcdEE2PvTh2SDNVDA");

            migrationBuilder.DeleteData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "asF5V8C9706efOtbfaRn_Q");

            migrationBuilder.DropColumn(
                name: "DataId",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "TaxNo",
                table: "PersonalData",
                type: "varchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Salutation",
                keyValue: null,
                column: "Salutation",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Salutation",
                table: "PersonalData",
                type: "varchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "PersonalData",
                type: "varchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NameAffix",
                table: "PersonalData",
                type: "varchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "PersonalData",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "Gender",
                keyValue: null,
                column: "Gender",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "PersonalData",
                type: "varchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "FirstName",
                keyValue: null,
                column: "FirstName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "PersonalData",
                type: "varchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FamilyStatus",
                table: "PersonalData",
                type: "varchar(32)",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "FamilyName",
                keyValue: null,
                column: "FamilyName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FamilyName",
                table: "PersonalData",
                type: "varchar(64)",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "PersonalData",
                keyColumn: "BirthPlace",
                keyValue: null,
                column: "BirthPlace",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "BirthPlace",
                table: "PersonalData",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BirthName",
                table: "PersonalData",
                type: "varchar(64)",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PersonalData",
                type: "varchar(22)",
                maxLength: 22,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "HouseNumber", "PostalCode", "Street" },
                values: new object[] { "uXMHgZAkm0K3A4LBsxGhZg", "Citname", "1", "12345", "Street" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountType", "AddressId", "Created", "LastActive", "Mail", "Status" },
                values: new object[] { "dQR_8UZvPk61eK5bNTJWlg", "IsAdmin", "uXMHgZAkm0K3A4LBsxGhZg", new DateTime(2022, 2, 23, 12, 38, 6, 165, DateTimeKind.Utc).AddTicks(3804), new DateTime(2022, 2, 23, 12, 38, 6, 165, DateTimeKind.Utc).AddTicks(3803), "test@mail.de", "active" });

            migrationBuilder.InsertData(
                table: "PersonalData",
                columns: new[] { "Id", "BirthDate", "BirthName", "BirthPlace", "FamilyName", "FamilyStatus", "FirstName", "Gender", "NameAffix", "Nationality", "ResidentSince", "Salutation", "TaxNo", "UserId" },
                values: new object[] { "Bw9CbRsw20--SRUEM8-Xrg", new DateTime(2002, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PersonBirth", "Cityname", "Person", null, "Test", "male", null, null, null, "Herr", null, "dQR_8UZvPk61eK5bNTJWlg" });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalData_UserId",
                table: "PersonalData",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalData_Users_UserId",
                table: "PersonalData",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalData_Users_UserId",
                table: "PersonalData");

            migrationBuilder.DropIndex(
                name: "IX_PersonalData_UserId",
                table: "PersonalData");

            migrationBuilder.DeleteData(
                table: "PersonalData",
                keyColumn: "Id",
                keyValue: "Bw9CbRsw20--SRUEM8-Xrg");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "dQR_8UZvPk61eK5bNTJWlg");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: "uXMHgZAkm0K3A4LBsxGhZg");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PersonalData");

            migrationBuilder.AddColumn<string>(
                name: "DataId",
                table: "Users",
                type: "varchar(22)",
                maxLength: 22,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "TaxNo",
                table: "PersonalData",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldMaxLength: 64,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Salutation",
                table: "PersonalData",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "PersonalData",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldMaxLength: 64,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NameAffix",
                table: "PersonalData",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldMaxLength: 64,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "PersonalData",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "PersonalData",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldMaxLength: 16)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "PersonalData",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldMaxLength: 64)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FamilyStatus",
                table: "PersonalData",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(32)",
                oldMaxLength: 32,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FamilyName",
                table: "PersonalData",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldMaxLength: 64)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BirthPlace",
                table: "PersonalData",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BirthName",
                table: "PersonalData",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldMaxLength: 64,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "HouseNumber", "IsDeleted", "PostalCode", "Street" },
                values: new object[] { "TwFrjqcdEE2PvTh2SDNVDA", "Citname", "1", false, "12345", "Street" });

            migrationBuilder.InsertData(
                table: "PersonalData",
                columns: new[] { "Id", "BirthDate", "BirthName", "BirthPlace", "FamilyName", "FamilyStatus", "FirstName", "Gender", "IsDeleted", "NameAffix", "Nationality", "ResidentSince", "Salutation", "TaxNo" },
                values: new object[] { "asF5V8C9706efOtbfaRn_Q", new DateTime(2002, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PersonBirth", "Cityname", "Person", null, "Test", "male", false, null, null, null, "Herr", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccountType", "AddressId", "Created", "DataId", "IsDeleted", "LastActive", "Mail", "Status" },
                values: new object[] { "uorM-JDuHEaAR5RAfoOHeA", "IsAdmin", "TwFrjqcdEE2PvTh2SDNVDA", new DateTime(2022, 2, 23, 12, 38, 6, 165, DateTimeKind.Utc).AddTicks(3804), "asF5V8C9706efOtbfaRn_Q", false, new DateTime(2022, 2, 23, 12, 38, 6, 165, DateTimeKind.Utc).AddTicks(3803), "test@mail.de", "active" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_DataId",
                table: "Users",
                column: "DataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PersonalData_DataId",
                table: "Users",
                column: "DataId",
                principalTable: "PersonalData",
                principalColumn: "Id");
        }
    }
}
