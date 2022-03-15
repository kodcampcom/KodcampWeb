
var isCommentSend = isCommentSend;

if (isCommentSend == "0") {
    $(window).on('load', function () {
        $('#myModal').modal('show');
    });
}

function hidePopUp() {
    $('#myModal').modal('hide');
}

//var categories = modelCategories;
//var mainCategories = modelMainCategories;

//function changeCategoryBySubCategory() {
//    var categorySelectList = document.getElementById("mainCategory");
//    var subCategorySelectList = document.getElementById("subCategory");
//    var selectedCategory = categorySelectList.options[categorySelectList.selectedIndex].value;
//    subCategorySelectList.classList.remove('d-none');

//    while (subCategorySelectList.options.length) {
//        subCategorySelectList.remove(0);
//    }

//    var selectedCategoryId = "";
//    for (var i = 0; i < categories.length; i++) {
//        if (categories[i].id == selectedCategory) {
//            selectedCategoryId = categories[i].id;
//        }
//    }

//    var subCatOption = new Option("Alt Kategori Seçebilirsiniz", "-1");
//    subCategorySelectList.options.add(subCatOption);
//    for (var i = 0; i < categories.length; i++) {
//        if (categories[i].mainCategory == selectedCategoryId) {
//            subCatOption = new Option(categories[i].name, categories[i].id);
//            subCategorySelectList.options.add(subCatOption);
//        }
//    }
//}