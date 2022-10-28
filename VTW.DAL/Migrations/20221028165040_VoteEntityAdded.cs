using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VTW.DAL.Migrations
{
    public partial class VoteEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Team_1",
                table: "Votes");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Team_2",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_Team1",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_Team2",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Team1",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Team2",
                table: "Votes");

            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "Votes",
                newName: "IsStarted");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Votes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "Votes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Votes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "TeamId",
                table: "Votes",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "VoteTeamInfos",
                columns: table => new
                {
                    VoteTeamInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPercent = table.Column<float>(type: "real", nullable: false),
                    VoteId = table.Column<long>(type: "bigint", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteTeamInfos", x => x.VoteTeamInfoId);
                    table.ForeignKey(
                        name: "FK_VoteTeamInfos_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoteTeamInfos_Vote",
                        column: x => x.VoteId,
                        principalTable: "Votes",
                        principalColumn: "VoteId");
                });

            migrationBuilder.CreateTable(
                name: "Bets",
                columns: table => new
                {
                    BetId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VoteTeamInfoId = table.Column<long>(type: "bigint", nullable: false),
                    BetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BetPlacedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BetType = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bets", x => x.BetId);
                    table.ForeignKey(
                        name: "FK_Bets_Voter",
                        column: x => x.VoterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bets_VoteTeamInfo",
                        column: x => x.VoteTeamInfoId,
                        principalTable: "VoteTeamInfos",
                        principalColumn: "VoteTeamInfoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Votes_TeamId",
                table: "Votes",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Bets_VoterId",
                table: "Bets",
                column: "VoterId");

            migrationBuilder.CreateIndex(
                name: "IX_Bets_VoteTeamInfoId",
                table: "Bets",
                column: "VoteTeamInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteTeamInfos_TeamId",
                table: "VoteTeamInfos",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_VoteTeamInfos_VoteId",
                table: "VoteTeamInfos",
                column: "VoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Teams_TeamId",
                table: "Votes",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Teams_TeamId",
                table: "Votes");

            migrationBuilder.DropTable(
                name: "Bets");

            migrationBuilder.DropTable(
                name: "VoteTeamInfos");

            migrationBuilder.DropIndex(
                name: "IX_Votes_TeamId",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "IsStarted",
                table: "Votes",
                newName: "IsCompleted");

            migrationBuilder.AddColumn<long>(
                name: "Team1",
                table: "Votes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Team2",
                table: "Votes",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Votes_Team1",
                table: "Votes",
                column: "Team1");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_Team2",
                table: "Votes",
                column: "Team2");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Team_1",
                table: "Votes",
                column: "Team1",
                principalTable: "Teams",
                principalColumn: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Team_2",
                table: "Votes",
                column: "Team2",
                principalTable: "Teams",
                principalColumn: "TeamId");
        }
    }
}
