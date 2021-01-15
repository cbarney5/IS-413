
function calculateGrade() {
    alert("This is working")
    var finalGrade = 0;
    var letterGrade = "";
    finalGrade = (((document.getElementById("assignments").value) * .5) +
                  ((document.getElementById("project").value) * .1) +
                  ((document.getElementById("quizzes").value) * .1) +
                  ((document.getElementById("exams").value * .2) +
                  ((document.getElementById("intex").value * .1))));

    if (finalGrade >= 94) {
        letterGrade = "A";
    } else if (finalGrade < 94 && finalGrade >= 90) {
        letterGrade = "A-"
    } else if (finalGrade < 90 && finalGrade >= 87) {
        letterGrade = "B+"
    } else if (finalGrade < 87 && finalGrade >= 84) {
        letterGrade = "B"
    } else if (finalGrade < 84 && finalGrade >= 80) {
        letterGrade = "B-"
    } else if (finalGrade < 80 && finalGrade >= 77) {
        letterGrade = "C+"
    } else if (finalGrade < 77 && finalGrade >= 74) {
        letterGrade = "C"
    } else if (finalGrade < 74 && finalGrade >= 70) {
        letterGrade = "C-"
    } else if (finalGrade < 70 && finalGrade >= 67) {
        letterGrade = "D+"
    } else if (finalGrade < 67 && finalGrade >= 64) {
        letterGrade = "D"
    } else if (finalGrade < 64 && finalGrade >= 60) {
        letterGrade = "D-"
    } else if (finalGrade < 60) {
        letterGrade = "E"
    };
    alert(finalGrade);
    alert(letterGrade);
    output = "Your final grade is a " + finalGrade + " %" + " (" + letterGrade + ")";

    document.getElementById("ptag").innerHTML = output
}

