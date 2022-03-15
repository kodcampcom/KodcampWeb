var isCommentSend = isCommentSend;

var isCommentSend = isCommentSend;

if (isCommentSend == "1") {
    $(window).on('load', function () {
        $('#myModal').modal('show');
    });
}

function hidePopUp() {
    $('#myModal').modal('hide');
}

function hidePopUp2() {
    $('#myModal2').modal('hide');
}

// Parametre kontrolü
function checkParameters() {
    var txtContent = document.getElementById("form76").value;
    if (txtContent.length < 10) {
        $('#myModal2').modal('show');
        return false;
    }
    else {
        return true;
    }
}

function reactionRedirect(newsId, type) {
    var element = document.getElementById("btn1");
    var h = getOffset(element).toString().substring(0, 6);
    window.location = '/News/Interact/' + newsId + '/' + type + '/' + h;
}

function getOffset(el) {
    const rect = el.getBoundingClientRect();
    return rect.top + window.scrollY;
}

abc();
function abc() {
    var position = hPosition;
    if (position != "" && position != undefined) {
        window.scrollTo(0, position-300);
    }
    else {
        return true;
    }
}
