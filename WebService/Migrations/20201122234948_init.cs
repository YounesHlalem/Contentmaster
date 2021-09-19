using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebService.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_content_element_type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_content_element_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_content_theme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_content_theme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_didactical_model",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_didactical_model", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_difficulty_level",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<int>(type: "INT(11)", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_difficulty_level", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_exercisefile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Filename = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    ContainsCurrency = table.Column<ulong>(type: "BIT", nullable: false),
                    ContainsDate = table.Column<ulong>(type: "BIT", nullable: false),
                    ContainsTime = table.Column<ulong>(type: "BIT", nullable: false),
                    ContainsGeographical = table.Column<ulong>(type: "BIT", nullable: false),
                    ContainsNamesToTranslate = table.Column<ulong>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_exercisefile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NativeName = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    Code = table.Column<string>(type: "VARCHAR(3)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_office_application",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_office_application", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question_formulation_type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question_formulation_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_questiontype",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_questiontype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    DisplayName = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_didactical_model_level",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DidacticalModelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    SortOrder = table.Column<int>(type: "INT(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_didactical_model_level", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_didactical_model_level_tbl_didactical_model_DidacticalMo~",
                        column: x => x.DidacticalModelId,
                        principalTable: "tbl_didactical_model",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_content_element_type_translation",
                columns: table => new
                {
                    ContentElementTypeId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Translation = table.Column<string>(type: "VARCHAR(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_ContentElementTypeTranslation", x => new { x.LanguageId, x.ContentElementTypeId });
                    table.ForeignKey(
                        name: "FK_tbl_content_element_type_translation_tbl_content_element_typ~",
                        column: x => x.ContentElementTypeId,
                        principalTable: "tbl_content_element_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_content_element_type_translation_tbl_language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_content_theme_translation",
                columns: table => new
                {
                    ContentThemeId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Translation = table.Column<string>(type: "VARCHAR(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_content_theme_translation", x => new { x.ContentThemeId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_tbl_content_theme_translation_tbl_content_theme_ContentTheme~",
                        column: x => x.ContentThemeId,
                        principalTable: "tbl_content_theme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_content_theme_translation_tbl_language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_didactical_model_level_translation",
                columns: table => new
                {
                    DidacticalModelLevelId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Translation = table.Column<string>(type: "VARCHAR(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_didactical_model_level_translation", x => new { x.LanguageId, x.DidacticalModelLevelId });
                    table.ForeignKey(
                        name: "FK_tbl_didactical_model_level_translation_tbl_didactical_model_~",
                        column: x => x.DidacticalModelLevelId,
                        principalTable: "tbl_didactical_model",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_didactical_model_level_translation_tbl_language_Language~",
                        column: x => x.LanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_didactical_model_translation",
                columns: table => new
                {
                    DidacticalModelId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Translation = table.Column<string>(type: "CHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_didactical_model_translation", x => new { x.LanguageId, x.DidacticalModelId });
                    table.ForeignKey(
                        name: "FK_tbl_didactical_model_translation_tbl_didactical_model_Didact~",
                        column: x => x.DidacticalModelId,
                        principalTable: "tbl_didactical_model",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_didactical_model_translation_tbl_language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_difficulty_level_translation",
                columns: table => new
                {
                    DifficultyLevelId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Translation = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_difficulty_level_translation", x => new { x.LanguageId, x.DifficultyLevelId });
                    table.ForeignKey(
                        name: "FK_tbl_difficulty_level_translation_tbl_difficulty_level_Diffic~",
                        column: x => x.DifficultyLevelId,
                        principalTable: "tbl_difficulty_level",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_difficulty_level_translation_tbl_language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_language_translation",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    TranslationLanguageId = table.Column<int>(type: "int", nullable: false),
                    Translation = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_language_translation", x => new { x.LanguageId, x.TranslationLanguageId });
                    table.ForeignKey(
                        name: "FK_tbl_language_translation_tbl_language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_language_translation_tbl_language_TranslationLanguageId",
                        column: x => x.TranslationLanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PreferredLanguageId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Firstname = table.Column<string>(type: "VARCHAR(70)", nullable: true),
                    Lastname = table.Column<string>(type: "VARCHAR(70)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_user", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_user_tbl_language_PreferredLanguageId",
                        column: x => x.PreferredLanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_quiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OfficeApplicationId = table.Column<int>(type: "int", nullable: false),
                    InstructionsLanguageId = table.Column<int>(type: "int", nullable: false),
                    UserinterfaceLanguageId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(255)", nullable: false),
                    short_intro = table.Column<string>(type: "text", nullable: true),
                    Intro = table.Column<string>(type: "text", nullable: true),
                    default_time_limit = table.Column<TimeSpan>(type: "time", nullable: false),
                    default_minimum_score = table.Column<decimal>(type: "decimal(12,7)", nullable: false),
                    Identification_code = table.Column<string>(type: "varchar(100)", nullable: false),
                    Replicationkey = table.Column<string>(type: "VARchar(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_quiz", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_quiz_tbl_language_InstructionsLanguageId",
                        column: x => x.InstructionsLanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_quiz_tbl_language_UserinterfaceLanguageId",
                        column: x => x.UserinterfaceLanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_quiz_tbl_office_application_OfficeApplicationId",
                        column: x => x.OfficeApplicationId,
                        principalTable: "tbl_office_application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question_formulation_type_translation",
                columns: table => new
                {
                    QuestionFormulationTypeId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Translation = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question_formulation_type_translation", x => new { x.LanguageId, x.QuestionFormulationTypeId });
                    table.ForeignKey(
                        name: "FK_tbl_question_formulation_type_translation_tbl_language_Langu~",
                        column: x => x.LanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_question_formulation_type_translation_tbl_question_formu~",
                        column: x => x.QuestionFormulationTypeId,
                        principalTable: "tbl_question_formulation_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false),
                    IsMasterQuestion = table.Column<ulong>(type: "BIT", nullable: false),
                    MasterQuestionId = table.Column<int>(type: "int", nullable: false),
                    InstructionsLanguageId = table.Column<int>(type: "int", nullable: false),
                    UserinterfaceLanguageId = table.Column<int>(type: "int", nullable: false),
                    QuestionFormulationTypeId = table.Column<int>(type: "int", nullable: false),
                    OfficeApplicationId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Questiontext = table.Column<string>(type: "TEXT", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    VersionNumber = table.Column<int>(type: "INT(11)", nullable: false),
                    Replicationkey = table.Column<string>(type: "VARCHAR(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_question_tbl_language_InstructionsLanguageId",
                        column: x => x.InstructionsLanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_question_tbl_language_UserinterfaceLanguageId",
                        column: x => x.UserinterfaceLanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_question_tbl_office_application_OfficeApplicationId",
                        column: x => x.OfficeApplicationId,
                        principalTable: "tbl_office_application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_question_tbl_question_formulation_type_QuestionFormulati~",
                        column: x => x.QuestionFormulationTypeId,
                        principalTable: "tbl_question_formulation_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_question_tbl_question_MasterQuestionId",
                        column: x => x.MasterQuestionId,
                        principalTable: "tbl_question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_question_tbl_questiontype_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalTable: "tbl_questiontype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_questiontype_translation",
                columns: table => new
                {
                    QuestiontypeId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Translation = table.Column<string>(type: "VARCHAR(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_questiontype_translation", x => new { x.LanguageId, x.QuestiontypeId });
                    table.ForeignKey(
                        name: "FK_tbl_questiontype_translation_tbl_language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_questiontype_translation_tbl_questiontype_QuestiontypeId",
                        column: x => x.QuestiontypeId,
                        principalTable: "tbl_questiontype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_role_translation",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Translation = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_role_translation", x => new { x.LanguageId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_tbl_role_translation_tbl_language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_role_translation_tbl_role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "tbl_role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Icon = table.Column<string>(type: "VARCHAR(255)", nullable: true),
                    InstructionsLanguageId = table.Column<int>(type: "int", nullable: false),
                    UserinterfaceLanguageId = table.Column<int>(type: "int", nullable: false),
                    OfficeApplicationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "DATE", nullable: false),
                    Replicationkey = table.Column<string>(type: "VARCHAR(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_course_tbl_language_InstructionsLanguageId",
                        column: x => x.InstructionsLanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_course_tbl_language_UserinterfaceLanguageId",
                        column: x => x.UserinterfaceLanguageId,
                        principalTable: "tbl_language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_course_tbl_office_application_OfficeApplicationId",
                        column: x => x.OfficeApplicationId,
                        principalTable: "tbl_office_application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_course_tbl_user_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "tbl_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_questions_history",
                columns: table => new
                {
                    QuestionReplicationkey = table.Column<string>(type: "VARCHAR(36)", nullable: false),
                    Action = table.Column<string>(type: "CHAR(1)", nullable: false),
                    ActionTimestamp = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ActionDoneByUserId = table.Column<int>(type: "int", nullable: false),
                    QuestionTypeId = table.Column<int>(type: "INT(11)", nullable: false),
                    IsMasterQuestion = table.Column<ulong>(type: "BIT", nullable: false),
                    MasterQuestionId = table.Column<int>(type: "INT(11)", nullable: false),
                    InstructionsLanguageId = table.Column<int>(type: "INT(11)", nullable: false),
                    UserinterfaceLanguageId = table.Column<int>(type: "INT(11)", nullable: false),
                    QuestionFormulationTypeId = table.Column<int>(type: "INT(11)", nullable: false),
                    OfficeApplicationId = table.Column<int>(type: "INT(11)", nullable: false),
                    title = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Questiontext = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    VersionNumber = table.Column<int>(type: "INT(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_tbl_questions_history_tbl_user_ActionDoneByUserId",
                        column: x => x.ActionDoneByUserId,
                        principalTable: "tbl_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_user_role",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_user_role", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_tbl_user_role_tbl_role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "tbl_role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_user_role_tbl_user_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question_answer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Questionid = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question_answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_question_answer_tbl_question_Questionid",
                        column: x => x.Questionid,
                        principalTable: "tbl_question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question_content_theme",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    ContentThemeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question_content_theme", x => new { x.ContentThemeId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_tbl_question_content_theme_tbl_content_theme_ContentThemeId",
                        column: x => x.ContentThemeId,
                        principalTable: "tbl_content_theme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_question_content_theme_tbl_question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "tbl_question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question_exercisefile",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    ExercisefileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question_exercisefile", x => new { x.QuestionId, x.ExercisefileId });
                    table.ForeignKey(
                        name: "FK_tbl_question_exercisefile_tbl_exercisefile_ExercisefileId",
                        column: x => x.ExercisefileId,
                        principalTable: "tbl_exercisefile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_question_exercisefile_tbl_question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "tbl_question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question_learninggoal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    DidacticalModelLevelId = table.Column<int>(type: "int", nullable: false),
                    Learninggoal = table.Column<string>(type: "TEXT", nullable: false),
                    IsMeasurable = table.Column<ulong>(type: "BIT(1)", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    SortOrder = table.Column<int>(type: "INT(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question_learninggoal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_question_learninggoal_tbl_didactical_model_level_Didacti~",
                        column: x => x.DidacticalModelLevelId,
                        principalTable: "tbl_didactical_model_level",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_question_learninggoal_tbl_question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "tbl_question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question_pre_knowledge_skill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Skill = table.Column<string>(type: "TEXT", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "INT(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question_pre_knowledge_skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_question_pre_knowledge_skill_tbl_question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "tbl_question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_quiz_question",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Sortorder = table.Column<int>(type: "INT(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_quiz_question", x => new { x.QuestionId, x.QuizId });
                    table.ForeignKey(
                        name: "FK_tbl_quiz_question_tbl_question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "tbl_question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_quiz_question_tbl_quiz_QuizId",
                        column: x => x.QuizId,
                        principalTable: "tbl_quiz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_course_module",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Sortorder = table.Column<int>(type: "INT(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_course_module", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_course_module_tbl_course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "tbl_course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_quiz_question_answer",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionAnswerId = table.Column<int>(type: "int", nullable: false),
                    QuestionId1 = table.Column<int>(type: "int", nullable: false),
                    Fraction = table.Column<decimal>(type: "DECIMAL(12,7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_quiz_question_answer", x => new { x.QuestionAnswerId, x.QuestionId, x.QuizId });
                    table.ForeignKey(
                        name: "FK_tbl_quiz_question_answer_tbl_question_answer_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "tbl_question_answer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_quiz_question_answer_tbl_question_QuestionId1",
                        column: x => x.QuestionId1,
                        principalTable: "tbl_question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_quiz_question_answer_tbl_quiz_QuizId",
                        column: x => x.QuizId,
                        principalTable: "tbl_quiz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_course_module_topic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseModuleId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Sortorder = table.Column<int>(type: "INT(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_course_module_topic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_course_module_topic_tbl_course_module_CourseModuleId",
                        column: x => x.CourseModuleId,
                        principalTable: "tbl_course_module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_course_module_topic_element",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ContentElementTypeId = table.Column<int>(type: "int", nullable: false),
                    CourseModuleTopicId = table.Column<int>(type: "int", nullable: false),
                    ContentElementId = table.Column<int>(type: "INT(11)", nullable: false),
                    DifficultyLevelId = table.Column<int>(type: "int", nullable: false),
                    Sortorder = table.Column<int>(type: "INT(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_course_module_topic_element", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_course_module_topic_element_tbl_content_element_type_Con~",
                        column: x => x.ContentElementTypeId,
                        principalTable: "tbl_content_element_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_course_module_topic_element_tbl_course_module_topic_Cour~",
                        column: x => x.CourseModuleTopicId,
                        principalTable: "tbl_course_module_topic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_course_module_topic_element_tbl_difficulty_level_Difficu~",
                        column: x => x.DifficultyLevelId,
                        principalTable: "tbl_difficulty_level",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_content_element_type_Name",
                table: "tbl_content_element_type",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_content_element_type_translation_ContentElementTypeId",
                table: "tbl_content_element_type_translation",
                column: "ContentElementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_content_theme_Name",
                table: "tbl_content_theme",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_content_theme_translation_LanguageId",
                table: "tbl_content_theme_translation",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_CreatedBy",
                table: "tbl_course",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_InstructionsLanguageId",
                table: "tbl_course",
                column: "InstructionsLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_OfficeApplicationId",
                table: "tbl_course",
                column: "OfficeApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_Replicationkey",
                table: "tbl_course",
                column: "Replicationkey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_UserinterfaceLanguageId",
                table: "tbl_course",
                column: "UserinterfaceLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_CourseId",
                table: "tbl_course_module",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_Sortorder",
                table: "tbl_course_module",
                column: "Sortorder",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_Title",
                table: "tbl_course_module",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_topic_CourseModuleId",
                table: "tbl_course_module_topic",
                column: "CourseModuleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_topic_Sortorder",
                table: "tbl_course_module_topic",
                column: "Sortorder",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_topic_Title",
                table: "tbl_course_module_topic",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_topic_element_ContentElementId",
                table: "tbl_course_module_topic_element",
                column: "ContentElementId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_topic_element_ContentElementTypeId",
                table: "tbl_course_module_topic_element",
                column: "ContentElementTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_topic_element_CourseModuleTopicId",
                table: "tbl_course_module_topic_element",
                column: "CourseModuleTopicId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_topic_element_DifficultyLevelId",
                table: "tbl_course_module_topic_element",
                column: "DifficultyLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_Name",
                table: "tbl_didactical_model",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_level_DidacticalModelId",
                table: "tbl_didactical_model_level",
                column: "DidacticalModelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_level_Name",
                table: "tbl_didactical_model_level",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_level_SortOrder",
                table: "tbl_didactical_model_level",
                column: "SortOrder",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_level_translation_DidacticalModelLevelId",
                table: "tbl_didactical_model_level_translation",
                column: "DidacticalModelLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_translation_DidacticalModelId",
                table: "tbl_didactical_model_translation",
                column: "DidacticalModelId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_difficulty_level_Name",
                table: "tbl_difficulty_level",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_difficulty_level_translation_DifficultyLevelId",
                table: "tbl_difficulty_level_translation",
                column: "DifficultyLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_exercisefile_Filename",
                table: "tbl_exercisefile",
                column: "Filename",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_language_Code",
                table: "tbl_language",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_language_NativeName",
                table: "tbl_language",
                column: "NativeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_language_translation_TranslationLanguageId",
                table: "tbl_language_translation",
                column: "TranslationLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_office_application_Name",
                table: "tbl_office_application",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_InstructionsLanguageId",
                table: "tbl_question",
                column: "InstructionsLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_MasterQuestionId",
                table: "tbl_question",
                column: "MasterQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_OfficeApplicationId",
                table: "tbl_question",
                column: "OfficeApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_QuestionFormulationTypeId",
                table: "tbl_question",
                column: "QuestionFormulationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_QuestionTypeId",
                table: "tbl_question",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_Replicationkey",
                table: "tbl_question",
                column: "Replicationkey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_UserinterfaceLanguageId",
                table: "tbl_question",
                column: "UserinterfaceLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_answer_Questionid",
                table: "tbl_question_answer",
                column: "Questionid");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_content_theme_QuestionId",
                table: "tbl_question_content_theme",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_exercisefile_ExercisefileId",
                table: "tbl_question_exercisefile",
                column: "ExercisefileId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_formulation_type_translation_QuestionFormulatio~",
                table: "tbl_question_formulation_type_translation",
                column: "QuestionFormulationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_learninggoal_DidacticalModelLevelId",
                table: "tbl_question_learninggoal",
                column: "DidacticalModelLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_learninggoal_QuestionId",
                table: "tbl_question_learninggoal",
                column: "QuestionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_learninggoal_SortOrder",
                table: "tbl_question_learninggoal",
                column: "SortOrder",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_pre_knowledge_skill_QuestionId",
                table: "tbl_question_pre_knowledge_skill",
                column: "QuestionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_pre_knowledge_skill_SortOrder",
                table: "tbl_question_pre_knowledge_skill",
                column: "SortOrder",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_questions_history_ActionDoneByUserId",
                table: "tbl_questions_history",
                column: "ActionDoneByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_questiontype_Name",
                table: "tbl_questiontype",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_questiontype_translation_QuestiontypeId",
                table: "tbl_questiontype_translation",
                column: "QuestiontypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quiz_Identification_code",
                table: "tbl_quiz",
                column: "Identification_code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quiz_InstructionsLanguageId",
                table: "tbl_quiz",
                column: "InstructionsLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quiz_OfficeApplicationId",
                table: "tbl_quiz",
                column: "OfficeApplicationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quiz_Replicationkey",
                table: "tbl_quiz",
                column: "Replicationkey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quiz_UserinterfaceLanguageId",
                table: "tbl_quiz",
                column: "UserinterfaceLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quiz_question_QuizId",
                table: "tbl_quiz_question",
                column: "QuizId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quiz_question_Sortorder",
                table: "tbl_quiz_question",
                column: "Sortorder",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quiz_question_answer_QuestionId",
                table: "tbl_quiz_question_answer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quiz_question_answer_QuestionId1",
                table: "tbl_quiz_question_answer",
                column: "QuestionId1");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quiz_question_answer_QuizId",
                table: "tbl_quiz_question_answer",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_role_Name",
                table: "tbl_role",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_role_translation_RoleId",
                table: "tbl_role_translation",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_user_Email",
                table: "tbl_user",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_user_PreferredLanguageId",
                table: "tbl_user",
                column: "PreferredLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_user_role_UserId",
                table: "tbl_user_role",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_content_element_type_translation");

            migrationBuilder.DropTable(
                name: "tbl_content_theme_translation");

            migrationBuilder.DropTable(
                name: "tbl_course_module_topic_element");

            migrationBuilder.DropTable(
                name: "tbl_didactical_model_level_translation");

            migrationBuilder.DropTable(
                name: "tbl_didactical_model_translation");

            migrationBuilder.DropTable(
                name: "tbl_difficulty_level_translation");

            migrationBuilder.DropTable(
                name: "tbl_language_translation");

            migrationBuilder.DropTable(
                name: "tbl_question_content_theme");

            migrationBuilder.DropTable(
                name: "tbl_question_exercisefile");

            migrationBuilder.DropTable(
                name: "tbl_question_formulation_type_translation");

            migrationBuilder.DropTable(
                name: "tbl_question_learninggoal");

            migrationBuilder.DropTable(
                name: "tbl_question_pre_knowledge_skill");

            migrationBuilder.DropTable(
                name: "tbl_questions_history");

            migrationBuilder.DropTable(
                name: "tbl_questiontype_translation");

            migrationBuilder.DropTable(
                name: "tbl_quiz_question");

            migrationBuilder.DropTable(
                name: "tbl_quiz_question_answer");

            migrationBuilder.DropTable(
                name: "tbl_role_translation");

            migrationBuilder.DropTable(
                name: "tbl_user_role");

            migrationBuilder.DropTable(
                name: "tbl_content_element_type");

            migrationBuilder.DropTable(
                name: "tbl_course_module_topic");

            migrationBuilder.DropTable(
                name: "tbl_difficulty_level");

            migrationBuilder.DropTable(
                name: "tbl_content_theme");

            migrationBuilder.DropTable(
                name: "tbl_exercisefile");

            migrationBuilder.DropTable(
                name: "tbl_didactical_model_level");

            migrationBuilder.DropTable(
                name: "tbl_question_answer");

            migrationBuilder.DropTable(
                name: "tbl_quiz");

            migrationBuilder.DropTable(
                name: "tbl_role");

            migrationBuilder.DropTable(
                name: "tbl_course_module");

            migrationBuilder.DropTable(
                name: "tbl_didactical_model");

            migrationBuilder.DropTable(
                name: "tbl_question");

            migrationBuilder.DropTable(
                name: "tbl_course");

            migrationBuilder.DropTable(
                name: "tbl_question_formulation_type");

            migrationBuilder.DropTable(
                name: "tbl_questiontype");

            migrationBuilder.DropTable(
                name: "tbl_office_application");

            migrationBuilder.DropTable(
                name: "tbl_user");

            migrationBuilder.DropTable(
                name: "tbl_language");
        }
    }
}
