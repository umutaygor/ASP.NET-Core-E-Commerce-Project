using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migration_contact_entity_edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentSubject",
                table: "Contacts",
                newName: "ContactSubject");

            migrationBuilder.RenameColumn(
                name: "CommentMessage",
                table: "Contacts",
                newName: "ContactMessage");

            migrationBuilder.RenameColumn(
                name: "CommentMail",
                table: "Contacts",
                newName: "ContactMail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactSubject",
                table: "Contacts",
                newName: "CommentSubject");

            migrationBuilder.RenameColumn(
                name: "ContactMessage",
                table: "Contacts",
                newName: "CommentMessage");

            migrationBuilder.RenameColumn(
                name: "ContactMail",
                table: "Contacts",
                newName: "CommentMail");
        }
    }
}
