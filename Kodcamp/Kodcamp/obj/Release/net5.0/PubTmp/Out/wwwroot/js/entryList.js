
function searchKeyPressDict(e) {
    e = e || window.event;
    if (e.keyCode == 13) {
        getSearchedEntries();
    }
    return true;
}

function getSearchedEntries() {
    var txtSearch = document.getElementById("txtSearch2").value; /* Aramadan gelen texti çektik. */ 

    var elements = document.getElementsByClassName("selectEntry");  /* Tüm başlıkları çektik. */
    var mainElements = document.getElementsByClassName("selectLink");  /* Tüm başlıkları çektik. */

    /* Her harfe basıldığında d-none temizlenir.. */
    for (var i = 0; i < mainElements.length; i++) {
        mainElements[i].classList.remove('d-none');
    }


    var tempList = [];
    for (var i = 0; i < elements.length; i++) {
        if (!elements[i].textContent.toLowerCase().includes(txtSearch.toLowerCase())) {
            tempList.push(elements[i]);
        }
    }

    for (var i = 0; i < mainElements.length; i++) {
        for (var k = 0; k < tempList.length; k++) {
            if (mainElements[i].id.substring(4) == tempList[k].id.substring(4)) {
                mainElements[i].classList.add('d-none');
            }
        }
        
    }
    
}