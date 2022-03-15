var categories = categories;
var mainCategories = mainCategories;


function GetSubCategories(clicked_id) {
 
    var btnId = clicked_id.substring(4, 5);
    var selectedCatVal = document.getElementById("cat-" + btnId).value; // Seçilen kategorinin Id'si

    var emptyCategories = [];
    for (var i = 0; i < categories.length; i++) {
        if (categories[i].mainCategory == selectedCatVal) {
            emptyCategories.push(categories[i]);
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
    th1.appendChild(document.createTextNode("Id"));
    trThead.appendChild(th1);

    var th2 = document.createElement('th');
    th2.appendChild(document.createTextNode("Name"));
    trThead.appendChild(th2);

    var th3 = document.createElement('th');
    th3.appendChild(document.createTextNode("Ana Kategori"));
    trThead.appendChild(th3);

    var th4 = document.createElement('th');
    th4.appendChild(document.createTextNode("Resim"));
    trThead.appendChild(th4);

    var th5 = document.createElement('th');
    th5.appendChild(document.createTextNode("Sil"));
    trThead.appendChild(th5);

    var th6 = document.createElement('th');
    th6.appendChild(document.createTextNode("Güncelle"));
    trThead.appendChild(th6);

    thead.appendChild(trThead);
    createdTable.appendChild(thead);

    // Tbody

    var tbody = document.createElement('tbody');
    
    for (var i = 0; i < emptyCategories.length; i++) {
        var trBody = document.createElement('tr');
        tbody.appendChild(trBody);

        var th1 = document.createElement('th');
        th1.appendChild(document.createTextNode(emptyCategories[i].id));
        trBody.appendChild(th1);

        var th2 = document.createElement('th');
        th2.appendChild(document.createTextNode(emptyCategories[i].name));
        trBody.appendChild(th2);

        var th3 = document.createElement('th');
        th3.appendChild(document.createTextNode(emptyCategories[i].mainCategory));
        trBody.appendChild(th3);

        var th4 = document.createElement('th');
        th4.appendChild(document.createTextNode(emptyCategories[i].imageUrl));
        trBody.appendChild(th4);

        var th5 = document.createElement('th');
        th5.appendChild(document.createTextNode("Sil"));
        trBody.appendChild(th5);

        var th6 = document.createElement('th');
        th6.appendChild(document.createTextNode("Güncelle"));
        trBody.appendChild(th6);

        createdTable.appendChild(tbody);
    }
    



    //var h1tAG = document.getElementById("h1Id");
    //h1tAG.textContent = "değişti";
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