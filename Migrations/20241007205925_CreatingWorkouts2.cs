using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymNotes.Migrations
{
    /// <inheritdoc />
    public partial class CreatingWorkouts2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExcerciseRecord_Excercise_ExcerciseId",
                table: "ExcerciseRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_ExcerciseRecord_Workout_WorkoutId",
                table: "ExcerciseRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_ExcerciseSet_ExcerciseRecord_ExcerciseRecordId",
                table: "ExcerciseSet");

            migrationBuilder.DropForeignKey(
                name: "FK_Workout_Users_UserId",
                table: "Workout");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workout",
                table: "Workout");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExcerciseSet",
                table: "ExcerciseSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExcerciseRecord",
                table: "ExcerciseRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Excercise",
                table: "Excercise");

            migrationBuilder.RenameTable(
                name: "Workout",
                newName: "Workouts");

            migrationBuilder.RenameTable(
                name: "ExcerciseSet",
                newName: "ExcerciseSets");

            migrationBuilder.RenameTable(
                name: "ExcerciseRecord",
                newName: "ExcerciseRecords");

            migrationBuilder.RenameTable(
                name: "Excercise",
                newName: "Excercises");

            migrationBuilder.RenameIndex(
                name: "IX_Workout_UserId",
                table: "Workouts",
                newName: "IX_Workouts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ExcerciseSet_ExcerciseRecordId",
                table: "ExcerciseSets",
                newName: "IX_ExcerciseSets_ExcerciseRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_ExcerciseRecord_WorkoutId",
                table: "ExcerciseRecords",
                newName: "IX_ExcerciseRecords_WorkoutId");

            migrationBuilder.RenameIndex(
                name: "IX_ExcerciseRecord_ExcerciseId",
                table: "ExcerciseRecords",
                newName: "IX_ExcerciseRecords_ExcerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExcerciseSets",
                table: "ExcerciseSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExcerciseRecords",
                table: "ExcerciseRecords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Excercises",
                table: "Excercises",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExcerciseRecords_Excercises_ExcerciseId",
                table: "ExcerciseRecords",
                column: "ExcerciseId",
                principalTable: "Excercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExcerciseRecords_Workouts_WorkoutId",
                table: "ExcerciseRecords",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExcerciseSets_ExcerciseRecords_ExcerciseRecordId",
                table: "ExcerciseSets",
                column: "ExcerciseRecordId",
                principalTable: "ExcerciseRecords",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Users_UserId",
                table: "Workouts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExcerciseRecords_Excercises_ExcerciseId",
                table: "ExcerciseRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ExcerciseRecords_Workouts_WorkoutId",
                table: "ExcerciseRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_ExcerciseSets_ExcerciseRecords_ExcerciseRecordId",
                table: "ExcerciseSets");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Users_UserId",
                table: "Workouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExcerciseSets",
                table: "ExcerciseSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Excercises",
                table: "Excercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExcerciseRecords",
                table: "ExcerciseRecords");

            migrationBuilder.RenameTable(
                name: "Workouts",
                newName: "Workout");

            migrationBuilder.RenameTable(
                name: "ExcerciseSets",
                newName: "ExcerciseSet");

            migrationBuilder.RenameTable(
                name: "Excercises",
                newName: "Excercise");

            migrationBuilder.RenameTable(
                name: "ExcerciseRecords",
                newName: "ExcerciseRecord");

            migrationBuilder.RenameIndex(
                name: "IX_Workouts_UserId",
                table: "Workout",
                newName: "IX_Workout_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ExcerciseSets_ExcerciseRecordId",
                table: "ExcerciseSet",
                newName: "IX_ExcerciseSet_ExcerciseRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_ExcerciseRecords_WorkoutId",
                table: "ExcerciseRecord",
                newName: "IX_ExcerciseRecord_WorkoutId");

            migrationBuilder.RenameIndex(
                name: "IX_ExcerciseRecords_ExcerciseId",
                table: "ExcerciseRecord",
                newName: "IX_ExcerciseRecord_ExcerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workout",
                table: "Workout",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExcerciseSet",
                table: "ExcerciseSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Excercise",
                table: "Excercise",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExcerciseRecord",
                table: "ExcerciseRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExcerciseRecord_Excercise_ExcerciseId",
                table: "ExcerciseRecord",
                column: "ExcerciseId",
                principalTable: "Excercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExcerciseRecord_Workout_WorkoutId",
                table: "ExcerciseRecord",
                column: "WorkoutId",
                principalTable: "Workout",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExcerciseSet_ExcerciseRecord_ExcerciseRecordId",
                table: "ExcerciseSet",
                column: "ExcerciseRecordId",
                principalTable: "ExcerciseRecord",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workout_Users_UserId",
                table: "Workout",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
