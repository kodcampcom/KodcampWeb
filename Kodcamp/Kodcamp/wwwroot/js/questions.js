var questions = questions;

function GetQuestionsByTag(id) {
    var elements = document.getElementsByClassName("articleListItems");

    for (var i = 0; i < elements.length; i++) {
        elements[i].classList.remove('d-none');
    }

    if (id.toLowerCase() == "hepsi") {

    }
    else {
        var tempList = [];
        for (var i = 0; i < questions.length; i++) {
            if (!questions[i].tags.toLowerCase().includes(id.toLowerCase())) {
                tempList.push(questions[i]);
            }
        }

        for (var i = 0; i < tempList.length; i++) {
            for (var k = 0; k < elements.length; k++) {
                if (tempList[i].id == elements[k].id) {
                    elements[k].classList.add('d-none');
                }
            }

        }
    }
}

function GetQuestionsByCategory(id) {
    var elements = document.getElementsByClassName("articleListItems");

    for (var i = 0; i < elements.length; i++) {
        elements[i].classList.remove('d-none');
    }

    var tempList = [];
    for (var i = 0; i < questions.length; i++) {
        if (questions[i].categoryId != id) {
            tempList.push(questions[i]);
        }
    }

    for (var i = 0; i < tempList.length; i++) {
        for (var k = 0; k < elements.length; k++) {
            if (tempList[i].id == elements[k].id) {

                elements[k].classList.add('d-none');
            }
        }

    }
}

function getQuestionsBySearch(id) {
    var elements = document.getElementsByClassName("articleListItems");

    for (var i = 0; i < elements.length; i++) {
        elements[i].classList.remove('d-none');
    }

    var tempList = [];
    for (var i = 0; i < questions.length; i++) {
        if (!questions[i].title.toLowerCase().includes(id.toLowerCase())) {
            tempList.push(questions[i]);
        }
    }

    for (var i = 0; i < tempList.length; i++) {
        for (var k = 0; k < elements.length; k++) {
            if (tempList[i].id == elements[k].id) {

                elements[k].classList.add('d-none');
            }
        }

    }
}

function GetResponse(id, username) {
    var id = id;
    var username = username;

    var txtArea = document.getElementById("cevapTxt");
    txtArea.textContent = "'" + username + "'" + " adlı kullanıcıya cevap veriyorsunuz.";

    var hiddenAnswer = document.getElementById("hiddenAnswer");
    hiddenAnswer.value = id;
}