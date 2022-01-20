var grade;
var letter_grade;

//calculate final percentage
$("#calculate").click(function () {
    grade = 0;
    grade = Number($("#assignments").val()) +
        Number($("#group_project").val()) +
        Number($("#quizzes").val()) +
        Number($("#intex").val());

//letter grades
    if (grade >= 94) {
        letter_grade = "A"

    } else if (grade >= 90) {
        letter_grade = "A-"

    } else if (grade >= 87) {
        letter_grade = "B+"


    } else if (grade >= 84) {
        letter_grade = "B"

    } else if (grade >= 80) {
        letter_grade = "B-"

    } else if (grade >= 77) {
        letter_grade = "C+"

    } else if (grade >= 74) {
        letter_grade = "C"

    } else if (grade >= 70) {
        letter_grade = "C-"

    } else if (grade >= 67) {
        letter_grade = "D+"

    } else if (grade >= 64) {
        letter_grade = "D"

    } else if (grade >= 60) {
        letter_grade = "D-"

    } else if (grade < 60) {
        letter_grade = "E"

    } 

    //grade and letter grade output
    alert("You scored a(n) " + grade + "%. You got a(n) " + letter_grade + " in the class.");

})
