
function loadNews2() {
    document.getElementById("newsDiv2").classList.remove('d-none');
    document.getElementById("btnDiv2").classList.add('d-none');
}
    


    function searchKeyPress(e) {
        e = e || window.event;
        if (e.keyCode == 13) {
            var keyVal = document.getElementById('txtSearch').value;
            location.href = '/PageSearchFilterSort/' + keyVal;
        }
        return true;
    }