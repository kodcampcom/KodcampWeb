
//function showLoginPage(){
//    var div = document.getElementById("formDiv");
//    div.classList.remove('d-none');
//}


var status = status;
if (status == 2) {
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