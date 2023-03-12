using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuonRoiSocialNetwork.Migrations
{
    public partial class AddPropertySaltPassword202303051157 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("72377426-b057-46ca-98ff-1ca9d33ea0c1"),
                column: "ConcurrencyStamp",
                value: "04206472-837f-4c3b-8f60-4d679cf1f8e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0223a03-2945-49db-976e-736433465b7f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ddeeba95-d80b-4f24-a2b4-5f2d49ed2707", "AQAAAAEAACcQAAAAEKGgCTz2o06E6fuRLTGGi6Q8nFLoBWdEXPUQxpCwA5vKgBs/0N9pnPLSlRrD6Wb0lw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("72377426-b057-46ca-98ff-1ca9d33ea0c1"),
                column: "ConcurrencyStamp",
                value: "ecda25d3-92f9-4ee4-bb64-cc59241c1b62");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0223a03-2945-49db-976e-736433465b7f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "342c35cf-baee-4196-ab95-4c18325e3f0a", "AQAAAAEAACcQAAAAEOyvy74t2iHmvOreeZrGKebcFsZaGRuxZqgWXRM/kV14In1d/Ig4jnbW38MpBtatfQ==" });
        }
    }
}
