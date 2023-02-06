
// function determines the grade
$("#calc").click(function () {

    // calculates grade % using values inputed by the user
    var grade = 0;
    grade = (($('#assignment').val() * .5) +
        ($('#gproject').val() * .1) +
        ($('#quiz').val() * .1) +
        ($('#midterm').val() * .1) +
        ($('#final').val() * .1) +
        ($('#intex').val() * .1));

    // determines letter grade based on calculated grade value
    var letterGrade = "";

    if (grade >= 94) {
        letterGrade = "A";
    }
    else if (grade >= 90 & grade < 94) {
        letterGrade = "A-";
    }
    else if (grade >= 87 & grade < 90) {
        letterGrade = "B+";
    }
    else if (grade >= 84 & grade < 87) {
        letterGrade = "B";
    }
    else if (grade >= 80 & grade < 84) {
        letterGrade = "B-";
    }
    else if (grade >= 77 & grade < 80) {
        letterGrade = "C+";
    }
    else if (grade >= 74 & grade < 77) {
        letterGrade = "C";
    }
    else if (grade >= 70 & grade < 74) {
        letterGrade = "C-";
    }
    else if (grade >= 67 & grade < 70) {
        letterGrade = "D+";
    }
    else if (grade >= 64 & grade < 67) {
        letterGrade = "D";
    }
    else if (grade >= 60 & grade < 64) {
        letterGrade = "D-";
    }
    else {
        letterGrade = "E";
    }

    alert("You got a(n) " + letterGrade + "! (" + grade + "%) Way to go!");
})