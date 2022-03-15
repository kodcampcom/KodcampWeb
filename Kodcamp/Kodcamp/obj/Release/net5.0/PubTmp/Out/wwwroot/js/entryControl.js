
function checkEntry() {
    var txtTitle = document.getElementById("txtTitle").value;
    if (txtTitle.length > 40) {
        $('#myModal').modal('show');
        return false;
    } else {
        return true;
    }
}

function checkTextLength() {
    var txtTitle = document.getElementById("txtTitle").value;
    var txtLenth = txtTitle.length;
    var txtResult = (40 - txtLenth);
    if (txtResult < 0) {
        document.getElementById("txtLengthOfText").innerHTML = `<i style=color:red;> ${txtResult.toString()} </i> `;
    } else {
        document.getElementById("txtLengthOfText").innerHTML = `<i> ${txtResult.toString()} </i> `;
    }
    
}