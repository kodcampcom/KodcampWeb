var comments = news;

function GetSubCategories(clicked_id) {

    var btnId = clicked_id.substring(4, 5);
    var selectedCatVal = document.getElementById("cat-" + btnId).value; // Seçilen kategorinin Id'si

    var emptyCategories = [];
    for (var i = 0; i < comments.length; i++) {
        if (comments[i].id == selectedCatVal) {
            emptyCategories.push(comments[i].comments);
        }
    }

    // Tablo Ekleme

    var categoryTable = document.getElementById("tableSubCategory");

    var silinecekH = document.getElementById("h4Silinecek");
    if (silinecekH != null) {
        silinecekH.remove();
    }

    var h1Title = document.createElement('h4');
    h1Title.id = "h4Silinecek";
    h1Title.appendChild(document.createTextNode("Alt Kategoriler"));
    categoryTable.appendChild(h1Title);


    var silinecekTbl = document.getElementById("tblCreated");
    if (silinecekTbl != null) {
        silinecekTbl.remove();
    }

    var createdTable = document.createElement('table');
    createdTable.id = "tblCreated";
    createdTable.classList.add('table', 'table-striped', 'table-hover');
    categoryTable.appendChild(createdTable);

    //Thead

    var thead = document.createElement('thead');

    var trThead = document.createElement('tr');

    var th1 = document.createElement('th');
    th1.appendChild(document.createTextNode("Yorum"));
    trThead.appendChild(th1);

    var th2 = document.createElement('th');
    th2.appendChild(document.createTextNode("Nickname"));
    trThead.appendChild(th2);

    var th3 = document.createElement('th');
    th3.appendChild(document.createTextNode("Onaylama"));
    trThead.appendChild(th3);

    thead.appendChild(trThead);
    createdTable.appendChild(thead);

    // Tbody

    var tbody = document.createElement('tbody');

    for (var i = 0; i < emptyCategories.length; i++) {
        for (var j = 0; j < emptyCategories[i].length; j++) {
            var trBody = document.createElement('tr');
            tbody.appendChild(trBody);

            var th1 = document.createElement('th');
            th1.appendChild(document.createTextNode(emptyCategories[i][j].text));
            trBody.appendChild(th1);

            var th2 = document.createElement('th');
            th2.appendChild(document.createTextNode(emptyCategories[i][j].nickName));
            trBody.appendChild(th2);

            var th3 = document.createElement('th');
            trBody.appendChild(th3);

            if (emptyCategories[i][j].approved === "0") {
                var btnConfirm = document.createElement('button');
                btnConfirm.appendChild(document.createTextNode("Onayla"));
                btnConfirm.classList.add('btn', 'btn-success')
                btnConfirm.setAttribute('onclick', `confirm('${emptyCategories[i][j].id}', 1);`);
                btnConfirm.id = "btnConfirm";
                btnConfirm.href = "/" + emptyCategories[i][j].text;
                th3.appendChild(btnConfirm);
            }
            else {
                var btnConfirm = document.createElement('button');
                btnConfirm.appendChild(document.createTextNode("Kaldır"));
                btnConfirm.classList.add('btn', 'btn-danger')
                btnConfirm.setAttribute('onclick', `confirm('${emptyCategories[i][j].id}', 0);`);
                btnConfirm.id = "btnConfirm";
                btnConfirm.href = "/" + emptyCategories[i][j].text;
                th3.appendChild(btnConfirm);
            }
            


            createdTable.appendChild(tbody);
        }
    }
}


function confirm(e, t) {
    window.location.href = '/Management/news/comment/approve/' + e + '/' + t;
}


function ClearSubCategories() {
    var silinecekTbl = document.getElementById("tblCreated");
    if (silinecekTbl != null) {
        silinecekTbl.remove();
    }

    var silinecekH = document.getElementById("h4Silinecek");
    if (silinecekH != null) {
        silinecekH.remove();
    }
}




function checkAndDisable() {
    var categorySelectList = document.getElementById("mainCategory");
    var hiddenInput = document.getElementById("isMainCategory");
    var isChecked = document.getElementById("flexCheckDefault");
    if (isChecked.checked == true) {
        mainCategory.disabled = true;
        hiddenInput.value = "1";
    }
    else {
        mainCategory.disabled = false;
        hiddenInput.value = "0";
    }
}




// Category Ekleme

var categories = categories;
var mainCategories = mainCategories;


function changeCategoryBySubCategory() {
    var categorySelectList = document.getElementById("mainCategory");
    var subCategorySelectList = document.getElementById("subCategory");
    var selectedCategory = categorySelectList.options[categorySelectList.selectedIndex].value;

    while (subCategorySelectList.options.length) {
        subCategorySelectList.remove(0);
    }

    var selectedCategoryId = "";
    for (var i = 0; i < categories.length; i++) {
        if (categories[i].id == selectedCategory) {
            selectedCategoryId = categories[i].id;
        }
    }

    var subCatOption = new Option("Alt Kategori Seçiniz", "-1");
    subCategorySelectList.options.add(subCatOption);
    for (var i = 0; i < categories.length; i++) {
        if (categories[i].mainCategory == selectedCategoryId) {
            subCatOption = new Option(categories[i].name, categories[i].id);
            subCategorySelectList.options.add(subCatOption);
        }
    }

}