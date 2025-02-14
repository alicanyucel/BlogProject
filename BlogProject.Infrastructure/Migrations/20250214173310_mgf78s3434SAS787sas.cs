using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mgf78s3434SAS787sas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_BlogCategory_BlogCategoryId1",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Departments_DepartmentId1",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_Languages_LanguageId1",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogGallery_Blog_Id",
                table: "BlogGallery");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId1",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Languages_LanguageId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Languages_LanguageId1",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ModulCategories_ModulCategoryId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ModulCategories_ModulCategoryId1",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AcademicTitle_AcademicTitleId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AcademicTitle_AcademicTitleId1",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Cities_CityId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Countries_CountryId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartmentId1",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Genders_GenderId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Languages_LanguageId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Specializations_SpecialityId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Specializations_SpecialityId1",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_States_StateId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Users_AppUserId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_treatmentCategories_TreatmentCategoryId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulCategories_Languages_LanguageId",
                table: "ModulCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulCategories_Languages_LanguageId1",
                table: "ModulCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulCategories_Moduls_ModulId",
                table: "ModulCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulSubCategories_ModulCategories_ModulCategoryId",
                table: "ModulSubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulSubCategories_ModulCategories_ModulCategoryId1",
                table: "ModulSubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Specializations_Departments_DepartmentId",
                table: "Specializations");

            migrationBuilder.DropForeignKey(
                name: "FK_Specializations_Departments_DepartmentId1",
                table: "Specializations");

            migrationBuilder.DropForeignKey(
                name: "FK_Specializations_Languages_LanguageId",
                table: "Specializations");

            migrationBuilder.DropForeignKey(
                name: "FK_Specializations_Languages_LanguageId1",
                table: "Specializations");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Departments_DepartmentId",
                table: "Treatments");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Departments_DepartmentId1",
                table: "Treatments");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Languages_LanguageId",
                table: "Treatments");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Languages_LanguageId1",
                table: "Treatments");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_treatmentCategories_TreatmentCategoryId",
                table: "Treatments");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_treatmentCategories_TreatmentCategoryId1",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_DepartmentId1",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_LanguageId1",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_TreatmentCategoryId1",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Specializations_DepartmentId1",
                table: "Specializations");

            migrationBuilder.DropIndex(
                name: "IX_Specializations_LanguageId1",
                table: "Specializations");

            migrationBuilder.DropIndex(
                name: "IX_ModulSubCategories_ModulCategoryId1",
                table: "ModulSubCategories");

            migrationBuilder.DropIndex(
                name: "IX_ModulCategories_LanguageId1",
                table: "ModulCategories");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_AcademicTitleId1",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_DepartmentId1",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_SpecialityId1",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Comments_LanguageId1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ModulCategoryId1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CountryId1",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Blog_BlogCategoryId1",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Blog_DepartmentId1",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Blog_LanguageId1",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "LanguageId1",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "TreatmentCategoryId1",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "Specializations");

            migrationBuilder.DropColumn(
                name: "LanguageId1",
                table: "Specializations");

            migrationBuilder.DropColumn(
                name: "ModulCategoryId1",
                table: "ModulSubCategories");

            migrationBuilder.DropColumn(
                name: "LanguageId1",
                table: "ModulCategories");

            migrationBuilder.DropColumn(
                name: "AcademicTitleId1",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "SpecialityId1",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "LanguageId1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ModulCategoryId1",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CountryId1",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "BlogCategoryId1",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "Blog");

            migrationBuilder.DropColumn(
                name: "LanguageId1",
                table: "Blog");

            migrationBuilder.AddColumn<Guid>(
                name: "BlogId",
                table: "BlogGallery",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_BlogGallery_BlogId",
                table: "BlogGallery",
                column: "BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogGallery_Blog_BlogId",
                table: "BlogGallery",
                column: "BlogId",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Languages_LanguageId",
                table: "Comments",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ModulCategories_ModulCategoryId",
                table: "Comments",
                column: "ModulCategoryId",
                principalTable: "ModulCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AcademicTitle_AcademicTitleId",
                table: "Doctors",
                column: "AcademicTitleId",
                principalTable: "AcademicTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Cities_CityId",
                table: "Doctors",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Countries_CountryId",
                table: "Doctors",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Genders_GenderId",
                table: "Doctors",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Languages_LanguageId",
                table: "Doctors",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Specializations_SpecialityId",
                table: "Doctors",
                column: "SpecialityId",
                principalTable: "Specializations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_States_StateId",
                table: "Doctors",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Users_AppUserId",
                table: "Doctors",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_treatmentCategories_TreatmentCategoryId",
                table: "Doctors",
                column: "TreatmentCategoryId",
                principalTable: "treatmentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModulCategories_Languages_LanguageId",
                table: "ModulCategories",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModulCategories_Moduls_ModulId",
                table: "ModulCategories",
                column: "ModulId",
                principalTable: "Moduls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ModulSubCategories_ModulCategories_ModulCategoryId",
                table: "ModulSubCategories",
                column: "ModulCategoryId",
                principalTable: "ModulCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specializations_Departments_DepartmentId",
                table: "Specializations",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specializations_Languages_LanguageId",
                table: "Specializations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Departments_DepartmentId",
                table: "Treatments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Languages_LanguageId",
                table: "Treatments",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_treatmentCategories_TreatmentCategoryId",
                table: "Treatments",
                column: "TreatmentCategoryId",
                principalTable: "treatmentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogGallery_Blog_BlogId",
                table: "BlogGallery");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Languages_LanguageId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ModulCategories_ModulCategoryId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AcademicTitle_AcademicTitleId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Cities_CityId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Countries_CountryId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Genders_GenderId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Languages_LanguageId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Specializations_SpecialityId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_States_StateId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Users_AppUserId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_treatmentCategories_TreatmentCategoryId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulCategories_Languages_LanguageId",
                table: "ModulCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulCategories_Moduls_ModulId",
                table: "ModulCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ModulSubCategories_ModulCategories_ModulCategoryId",
                table: "ModulSubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Specializations_Departments_DepartmentId",
                table: "Specializations");

            migrationBuilder.DropForeignKey(
                name: "FK_Specializations_Languages_LanguageId",
                table: "Specializations");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Departments_DepartmentId",
                table: "Treatments");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Languages_LanguageId",
                table: "Treatments");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_treatmentCategories_TreatmentCategoryId",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_BlogGallery_BlogId",
                table: "BlogGallery");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "BlogGallery");

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId1",
                table: "Treatments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LanguageId1",
                table: "Treatments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TreatmentCategoryId1",
                table: "Treatments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId1",
                table: "Specializations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LanguageId1",
                table: "Specializations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModulCategoryId1",
                table: "ModulSubCategories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LanguageId1",
                table: "ModulCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AcademicTitleId1",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId1",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SpecialityId1",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LanguageId1",
                table: "Comments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModulCategoryId1",
                table: "Comments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId1",
                table: "Cities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BlogCategoryId1",
                table: "Blog",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId1",
                table: "Blog",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LanguageId1",
                table: "Blog",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_DepartmentId1",
                table: "Treatments",
                column: "DepartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_LanguageId1",
                table: "Treatments",
                column: "LanguageId1");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_TreatmentCategoryId1",
                table: "Treatments",
                column: "TreatmentCategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Specializations_DepartmentId1",
                table: "Specializations",
                column: "DepartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Specializations_LanguageId1",
                table: "Specializations",
                column: "LanguageId1");

            migrationBuilder.CreateIndex(
                name: "IX_ModulSubCategories_ModulCategoryId1",
                table: "ModulSubCategories",
                column: "ModulCategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_ModulCategories_LanguageId1",
                table: "ModulCategories",
                column: "LanguageId1");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_AcademicTitleId1",
                table: "Doctors",
                column: "AcademicTitleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DepartmentId1",
                table: "Doctors",
                column: "DepartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_SpecialityId1",
                table: "Doctors",
                column: "SpecialityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_LanguageId1",
                table: "Comments",
                column: "LanguageId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ModulCategoryId1",
                table: "Comments",
                column: "ModulCategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId1",
                table: "Cities",
                column: "CountryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_BlogCategoryId1",
                table: "Blog",
                column: "BlogCategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_DepartmentId1",
                table: "Blog",
                column: "DepartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_LanguageId1",
                table: "Blog",
                column: "LanguageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_BlogCategory_BlogCategoryId1",
                table: "Blog",
                column: "BlogCategoryId1",
                principalTable: "BlogCategory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Departments_DepartmentId1",
                table: "Blog",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_Languages_LanguageId1",
                table: "Blog",
                column: "LanguageId1",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogGallery_Blog_Id",
                table: "BlogGallery",
                column: "Id",
                principalTable: "Blog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId1",
                table: "Cities",
                column: "CountryId1",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Languages_LanguageId",
                table: "Comments",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Languages_LanguageId1",
                table: "Comments",
                column: "LanguageId1",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ModulCategories_ModulCategoryId",
                table: "Comments",
                column: "ModulCategoryId",
                principalTable: "ModulCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ModulCategories_ModulCategoryId1",
                table: "Comments",
                column: "ModulCategoryId1",
                principalTable: "ModulCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AcademicTitle_AcademicTitleId",
                table: "Doctors",
                column: "AcademicTitleId",
                principalTable: "AcademicTitle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AcademicTitle_AcademicTitleId1",
                table: "Doctors",
                column: "AcademicTitleId1",
                principalTable: "AcademicTitle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Cities_CityId",
                table: "Doctors",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Countries_CountryId",
                table: "Doctors",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartmentId1",
                table: "Doctors",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Genders_GenderId",
                table: "Doctors",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Languages_LanguageId",
                table: "Doctors",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Specializations_SpecialityId",
                table: "Doctors",
                column: "SpecialityId",
                principalTable: "Specializations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Specializations_SpecialityId1",
                table: "Doctors",
                column: "SpecialityId1",
                principalTable: "Specializations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_States_StateId",
                table: "Doctors",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Users_AppUserId",
                table: "Doctors",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_treatmentCategories_TreatmentCategoryId",
                table: "Doctors",
                column: "TreatmentCategoryId",
                principalTable: "treatmentCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulCategories_Languages_LanguageId",
                table: "ModulCategories",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulCategories_Languages_LanguageId1",
                table: "ModulCategories",
                column: "LanguageId1",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulCategories_Moduls_ModulId",
                table: "ModulCategories",
                column: "ModulId",
                principalTable: "Moduls",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulSubCategories_ModulCategories_ModulCategoryId",
                table: "ModulSubCategories",
                column: "ModulCategoryId",
                principalTable: "ModulCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulSubCategories_ModulCategories_ModulCategoryId1",
                table: "ModulSubCategories",
                column: "ModulCategoryId1",
                principalTable: "ModulCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specializations_Departments_DepartmentId",
                table: "Specializations",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Specializations_Departments_DepartmentId1",
                table: "Specializations",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Specializations_Languages_LanguageId",
                table: "Specializations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Specializations_Languages_LanguageId1",
                table: "Specializations",
                column: "LanguageId1",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Departments_DepartmentId",
                table: "Treatments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Departments_DepartmentId1",
                table: "Treatments",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Languages_LanguageId",
                table: "Treatments",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Languages_LanguageId1",
                table: "Treatments",
                column: "LanguageId1",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_treatmentCategories_TreatmentCategoryId",
                table: "Treatments",
                column: "TreatmentCategoryId",
                principalTable: "treatmentCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_treatmentCategories_TreatmentCategoryId1",
                table: "Treatments",
                column: "TreatmentCategoryId1",
                principalTable: "treatmentCategories",
                principalColumn: "Id");
        }
    }
}
