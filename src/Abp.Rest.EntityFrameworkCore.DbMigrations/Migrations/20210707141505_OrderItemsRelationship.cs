using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Abp.Rest.Migrations
{
    public partial class OrderItemsRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppOrderItems_AppOrders_OrderId",
                table: "AppOrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOrders_AppClients_ClientId",
                table: "AppOrders");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "AppOrders",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "AppOrderItems",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrderItems_AppOrders_OrderId",
                table: "AppOrderItems",
                column: "OrderId",
                principalTable: "AppOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrders_AppClients_ClientId",
                table: "AppOrders",
                column: "ClientId",
                principalTable: "AppClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppOrderItems_AppOrders_OrderId",
                table: "AppOrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOrders_AppClients_ClientId",
                table: "AppOrders");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "AppOrders",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "AppOrderItems",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrderItems_AppOrders_OrderId",
                table: "AppOrderItems",
                column: "OrderId",
                principalTable: "AppOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrders_AppClients_ClientId",
                table: "AppOrders",
                column: "ClientId",
                principalTable: "AppClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
