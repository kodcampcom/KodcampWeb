

getAdviceCategory();
async function getAdviceCategory() {
    const endPoint = `https://localhost:5001/GetAdviceCategory`;
    const response = await fetch(endPoint);
    const data = await response.json();

    var subCategorySelectList = document.getElementById("mainCategory");
    for (var i = 0; i < data.length; i++) {
        subCatOption = new Option(data[i].name, data[i].id);
            subCategorySelectList.options.add(subCatOption);
    }
}

async function getAdvice() {
    var categorySelectList = document.getElementById("mainCategory");
    var selectedCategory = categorySelectList.options[categorySelectList.selectedIndex].value;
    if (selectedCategory !== "-1") {
        const endPoint = "https://localhost:5001/api/getadvice/" + selectedCategory;
        const response = await fetch(endPoint);
        const data = await response.json();
        var element = document.getElementById("selectedActivity");
        element.classList.remove('d-none');
        element.innerHTML = data.detail;
    }
    
}