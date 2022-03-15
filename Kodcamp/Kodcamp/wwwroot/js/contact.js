var isSend = isSend;

if (isSend == "1") {
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