using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations.Pg
{
    /// <inheritdoc />
    public partial class ProjeEntityEkleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppId",
                table: "Translates",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Translates",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Translates",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Translates",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Translates",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Translates",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Translates",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Translates",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Translates",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppId",
                table: "OperationClaims",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "OperationClaims",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OperationClaims",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "OperationClaims",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "OperationClaims",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "OperationClaims",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "OperationClaims",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "OperationClaims",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "OperationClaims",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppId",
                table: "MobileLogins",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "MobileLogins",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "MobileLogins",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "MobileLogins",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "MobileLogins",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "MobileLogins",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MobileLogins",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "MobileLogins",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "MobileLogins",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppId",
                table: "Languages",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Languages",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Languages",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Languages",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Languages",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Languages",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Languages",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Languages",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Languages",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppId",
                table: "Groups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Groups",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Groups",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Groups",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Groups",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Groups",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Groups",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                table: "Groups",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Groups",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sinavs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KisaAd = table.Column<string>(type: "text", nullable: true),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    SiraNo = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    DeletedBy = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    AppId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinavs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bolums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SinavId = table.Column<int>(type: "integer", nullable: false),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    SiraNo = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    DeletedBy = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    AppId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bolums_Sinavs_SinavId",
                        column: x => x.SinavId,
                        principalTable: "Sinavs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Konus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BolumId = table.Column<int>(type: "integer", nullable: false),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    SiraNo = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    DeletedBy = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    AppId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Konus_Bolums_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sorus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KonuId = table.Column<int>(type: "integer", nullable: false),
                    Metin = table.Column<string>(type: "text", nullable: true),
                    GorselUrl = table.Column<string>(type: "text", nullable: true),
                    SiraNo = table.Column<int>(type: "integer", nullable: false),
                    ErisimSeviyesi = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    DeletedBy = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    AppId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sorus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sorus_Konus_KonuId",
                        column: x => x.KonuId,
                        principalTable: "Konus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoruSeceneks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SoruId = table.Column<int>(type: "integer", nullable: false),
                    Anahtar = table.Column<string>(type: "text", nullable: true),
                    Metin = table.Column<string>(type: "text", nullable: true),
                    GorselUrl = table.Column<string>(type: "text", nullable: true),
                    DogruMu = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true),
                    DeletedBy = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    AppId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoruSeceneks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoruSeceneks_Sorus_SoruId",
                        column: x => x.SoruId,
                        principalTable: "Sorus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.UpdateData(
                table: "Translates",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AppId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "IsDeleted", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 0, null, null, null, null, true, false, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Bolums_SinavId",
                table: "Bolums",
                column: "SinavId");

            migrationBuilder.CreateIndex(
                name: "IX_Konus_BolumId",
                table: "Konus",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_Sorus_KonuId",
                table: "Sorus",
                column: "KonuId");

            migrationBuilder.CreateIndex(
                name: "IX_SoruSeceneks_SoruId",
                table: "SoruSeceneks",
                column: "SoruId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SoruSeceneks");

            migrationBuilder.DropTable(
                name: "Sorus");

            migrationBuilder.DropTable(
                name: "Konus");

            migrationBuilder.DropTable(
                name: "Bolums");

            migrationBuilder.DropTable(
                name: "Sinavs");

            migrationBuilder.DropColumn(
                name: "AppId",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Translates");

            migrationBuilder.DropColumn(
                name: "AppId",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "OperationClaims");

            migrationBuilder.DropColumn(
                name: "AppId",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "MobileLogins");

            migrationBuilder.DropColumn(
                name: "AppId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "AppId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Groups");
        }
    }
}
