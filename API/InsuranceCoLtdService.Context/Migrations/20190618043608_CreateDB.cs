using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InsuranceCoLtdService.Context.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    PolicyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PolicyName = table.Column<string>(nullable: true),
                    PolicyDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.PolicyId);
                });

            migrationBuilder.CreateTable(
                name: "RiskTypes",
                columns: table => new
                {
                    RiskTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RiskTypeName = table.Column<string>(nullable: true),
                    RiskTypeDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskTypes", x => x.RiskTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Validations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Validations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolicyRiskTypes",
                columns: table => new
                {
                    PId = table.Column<int>(nullable: false),
                    RId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyRiskTypes", x => new { x.PId, x.RId });
                    table.ForeignKey(
                        name: "FK_PolicyRiskTypes_Policies_PId",
                        column: x => x.PId,
                        principalTable: "Policies",
                        principalColumn: "PolicyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolicyRiskTypes_RiskTypes_RId",
                        column: x => x.RId,
                        principalTable: "RiskTypes",
                        principalColumn: "RiskTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RiskFactors",
                columns: table => new
                {
                    RiskFactorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RiskFactorName = table.Column<string>(nullable: true),
                    RiskFactorDescription = table.Column<string>(nullable: true),
                    ValidationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskFactors", x => x.RiskFactorId);
                    table.ForeignKey(
                        name: "FK_RiskFactors_Validations_ValidationId",
                        column: x => x.ValidationId,
                        principalTable: "Validations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RiskTypeRiskFactor",
                columns: table => new
                {
                    RiskTypeId = table.Column<int>(nullable: false),
                    RiskFactorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskTypeRiskFactor", x => new { x.RiskFactorId, x.RiskTypeId });
                    table.ForeignKey(
                        name: "FK_RiskTypeRiskFactor_RiskFactors_RiskFactorId",
                        column: x => x.RiskFactorId,
                        principalTable: "RiskFactors",
                        principalColumn: "RiskFactorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RiskTypeRiskFactor_RiskTypes_RiskTypeId",
                        column: x => x.RiskTypeId,
                        principalTable: "RiskTypes",
                        principalColumn: "RiskTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "PolicyId", "PolicyDescription", "PolicyName" },
                values: new object[,]
                {
                    { 1, null, "Life" },
                    { 2, null, "Moter Car" }
                });

            migrationBuilder.InsertData(
                table: "RiskTypes",
                columns: new[] { "RiskTypeId", "RiskTypeDescription", "RiskTypeName" },
                values: new object[,]
                {
                    { 1, "Health", null },
                    { 2, "Vehicle", null }
                });

            migrationBuilder.InsertData(
                table: "Validations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "TextBox" },
                    { 2, "Check Box" }
                });

            migrationBuilder.InsertData(
                table: "PolicyRiskTypes",
                columns: new[] { "PId", "RId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "RiskFactors",
                columns: new[] { "RiskFactorId", "RiskFactorDescription", "RiskFactorName", "ValidationId" },
                values: new object[,]
                {
                    { 1, null, "Age", 1 },
                    { 5, null, "Gender", 1 },
                    { 6, null, "Deppendance", 1 },
                    { 2, null, "Location", 2 },
                    { 3, null, "Height", 2 },
                    { 4, null, "Waight", 2 }
                });

            migrationBuilder.InsertData(
                table: "RiskTypeRiskFactor",
                columns: new[] { "RiskFactorId", "RiskTypeId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_PolicyRiskTypes_RId",
                table: "PolicyRiskTypes",
                column: "RId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskFactors_ValidationId",
                table: "RiskFactors",
                column: "ValidationId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTypeRiskFactor_RiskTypeId",
                table: "RiskTypeRiskFactor",
                column: "RiskTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PolicyRiskTypes");

            migrationBuilder.DropTable(
                name: "RiskTypeRiskFactor");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "RiskFactors");

            migrationBuilder.DropTable(
                name: "RiskTypes");

            migrationBuilder.DropTable(
                name: "Validations");
        }
    }
}
