using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ClassifProject.Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classifiers",
                columns: table => new
                {
                    id_class = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name_class = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifiers", x => x.id_class);
                });

            migrationBuilder.CreateTable(
                name: "EducationLevel",
                columns: table => new
                {
                    id_edulvl = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code_edulvl = table.Column<string>(nullable: true),
                    name_edulvl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLevel", x => x.id_edulvl);
                });

            migrationBuilder.CreateTable(
                name: "EnlargedGroups",
                columns: table => new
                {
                    id_engr = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code_engr = table.Column<string>(nullable: true),
                    name_engr = table.Column<string>(nullable: true),
                    id_class = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnlargedGroups", x => x.id_engr);
                    table.ForeignKey(
                        name: "FK_EnlargedGroups_Classifiers_id_class",
                        column: x => x.id_class,
                        principalTable: "Classifiers",
                        principalColumn: "id_class",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specialties",
                columns: table => new
                {
                    id_spec = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code_spec = table.Column<string>(nullable: true),
                    name_spec = table.Column<string>(nullable: true),
                    id_engr = table.Column<int>(nullable: false),
                    id_class = table.Column<int>(nullable: false),
                    id_edulvl = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialties", x => x.id_spec);
                    table.ForeignKey(
                        name: "FK_Specialties_Classifiers_id_class",
                        column: x => x.id_class,
                        principalTable: "Classifiers",
                        principalColumn: "id_class",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specialties_EducationLevel_id_edulvl",
                        column: x => x.id_edulvl,
                        principalTable: "EducationLevel",
                        principalColumn: "id_edulvl",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specialties_EnlargedGroups_id_engr",
                        column: x => x.id_engr,
                        principalTable: "EnlargedGroups",
                        principalColumn: "id_engr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transcoding",
                columns: table => new
                {
                    id_trans = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    id_spec_1 = table.Column<int>(nullable: false),
                    id_spec_2 = table.Column<int>(nullable: false),
                    id_class_1 = table.Column<int>(nullable: false),
                    id_class_2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transcoding", x => x.id_trans);
                    table.ForeignKey(
                        name: "FK_Transcoding_Classifiers_id_class_1",
                        column: x => x.id_class_1,
                        principalTable: "Classifiers",
                        principalColumn: "id_class",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transcoding_Classifiers_id_class_2",
                        column: x => x.id_class_2,
                        principalTable: "Classifiers",
                        principalColumn: "id_class",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transcoding_Specialties_id_spec_1",
                        column: x => x.id_spec_1,
                        principalTable: "Specialties",
                        principalColumn: "id_spec",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transcoding_Specialties_id_spec_2",
                        column: x => x.id_spec_2,
                        principalTable: "Specialties",
                        principalColumn: "id_spec",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnlargedGroups_id_class",
                table: "EnlargedGroups",
                column: "id_class");

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_id_class",
                table: "Specialties",
                column: "id_class");

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_id_edulvl",
                table: "Specialties",
                column: "id_edulvl");

            migrationBuilder.CreateIndex(
                name: "IX_Specialties_id_engr",
                table: "Specialties",
                column: "id_engr");

            migrationBuilder.CreateIndex(
                name: "IX_Transcoding_id_class_1",
                table: "Transcoding",
                column: "id_class_1");

            migrationBuilder.CreateIndex(
                name: "IX_Transcoding_id_class_2",
                table: "Transcoding",
                column: "id_class_2");

            migrationBuilder.CreateIndex(
                name: "IX_Transcoding_id_spec_1",
                table: "Transcoding",
                column: "id_spec_1");

            migrationBuilder.CreateIndex(
                name: "IX_Transcoding_id_spec_2",
                table: "Transcoding",
                column: "id_spec_2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transcoding");

            migrationBuilder.DropTable(
                name: "Specialties");

            migrationBuilder.DropTable(
                name: "EducationLevel");

            migrationBuilder.DropTable(
                name: "EnlargedGroups");

            migrationBuilder.DropTable(
                name: "Classifiers");
        }
    }
}
