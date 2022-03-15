var categories = modelCategories;
var mainCategories = modelMainCategories;
var news = modelNews;

var url_string = window.location.href.split('/');
var urlCategoryId = url_string[url_string.length - 1];

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


    // Ana kategori seçildikten sonra da ilgilierin hepsini yazdıralım.
    //
    //

    var news = modelNews;
    var newsTemp = [];

    // Seçilen option bilgisine göre verileri getirmek

    var subCategorySelectList = document.getElementById("mainCategory");
    var selectedCategory = subCategorySelectList.options[subCategorySelectList.selectedIndex].value;
    var selectedCategoryTxt = subCategorySelectList.options[subCategorySelectList.selectedIndex].text;

    // Seçilen filtrelerin yanında searchText bilgisi de dolu gelmişse;

    var searchTxtVal = document.getElementById("search").value;

    /////



    if (selectedCategory == "-1") {
        return fillCards();
    } else {
        if (searchTxtVal !== "") {
            for (var i = 0; i < news.length; i++) {
                if ((news[i].mainCategoryIds.toString() == selectedCategory) && news[i].title.toLowerCase().includes(searchTxtVal.toLowerCase())) {
                    newsTemp.push(news[i]);
                }
            }
        }
        else {
            for (var i = 0; i < news.length; i++) {
                if (news[i].mainCategoryIds.toString() == selectedCategory) {
                    newsTemp.push(news[i]);
                }
            }
        }
    }

    news = newsTemp;

    var cardsDiv = document.getElementById("cardsDiv");
    $("#cardsDiv").addClass("album py-5 bg-light");

    var silinecekDiv = document.getElementById("silinecekDiv");
    silinecekDiv.remove();

    var div2 = document.createElement('div');
    div2.id = "silinecekDiv";
    div2.classList.add("container");
    cardsDiv.appendChild(div2);

    var div3 = document.createElement('div');
    div3.classList.add('row', 'row-cols-1', 'row-cols-sm-2', 'row-cols-md-3', 'g-3');
    div2.appendChild(div3);

    for (var i = 0; i < news.length; i++) {
        var icDiv1 = document.createElement('div');
        icDiv1.classList.add("col");
        div3.appendChild(icDiv1);

        var icDiv2 = document.createElement('div');
        icDiv2.classList.add('card', 'shadow-sm');
        icDiv1.appendChild(icDiv2);

        var imgIcDiv2 = document.createElement('img');
        imgIcDiv2.classList.add('bd-placeholder-img', 'card-img-top');
        imgIcDiv2.src = "/images/news/" + news[i].imageUrl;
        imgIcDiv2.setAttribute("width", "100");
        imgIcDiv2.setAttribute("height", "225");
        icDiv2.appendChild(imgIcDiv2);

        var div1IcDiv2 = document.createElement('div');
        div1IcDiv2.classList.add("card-body");
        icDiv2.appendChild(div1IcDiv2);

        var h4div1IcDiv2 = document.createElement('h5');
        h4div1IcDiv2.classList.add("card-text");
        h4div1IcDiv2.appendChild(document.createTextNode(news[i].title));
        div1IcDiv2.appendChild(h4div1IcDiv2);

        var pdiv1IcDiv2 = document.createElement('p');
        pdiv1IcDiv2.classList.add("card-text");
        pdiv1IcDiv2.appendChild(document.createTextNode(news[i].detailHeader));
        div1IcDiv2.appendChild(pdiv1IcDiv2);

        var div1div1IcDiv2 = document.createElement('div');
        div1div1IcDiv2.classList.add('d-flex', 'justify-content-between', 'align-items-center');
        div1IcDiv2.appendChild(div1div1IcDiv2);

        var div1div1div1IcDiv2 = document.createElement('div');
        div1div1div1IcDiv2.classList.add("btn-group");
        div1div1IcDiv2.appendChild(div1div1div1IcDiv2);

        var buttondiv1div1div1IcDiv2 = document.createElement('button');
        buttondiv1div1div1IcDiv2.classList.add('btn', 'btn-sm', 'btn-outline-secondary');
        buttondiv1div1div1IcDiv2.appendChild(document.createTextNode("Görüntüle"));
        buttondiv1div1div1IcDiv2.setAttribute('onclick', `redirectToSearch('${news[i].url}');`);
        div1div1div1IcDiv2.appendChild(buttondiv1div1div1IcDiv2);

        var smalliv1div1div1IcDiv2 = document.createElement('small');
        smalliv1div1div1IcDiv2.classList.add("text-muted");
        smalliv1div1div1IcDiv2.appendChild(document.createTextNode("👁"));
        div1div1IcDiv2.appendChild(smalliv1div1div1IcDiv2);
    }

    // Filtrelenen seçenekleri yazdırma

    var searchBarDiv = document.getElementById("searchBarDiv"); // Ana div

    var silinecekBtn = document.getElementById("btnFilteredMainId");
    if (silinecekBtn != null) {
        silinecekBtn.remove();
    }

    var silinecekBtn2 = document.getElementById("btnFilteredId");
    if (silinecekBtn2 != null) {
        silinecekBtn2.remove();
    }

    var btnFiltered = document.createElement('button');
    btnFiltered.id = "btnFilteredMainId";
    btnFiltered.onclick = function () {
        ClearFilterMain();
    };
    btnFiltered.classList.add('btn', 'btn-secondary', 'rounded-pill');
    btnFiltered.setAttribute("style", "margin-top: 10px; background-color:#a6443c;");
    searchBarDiv.appendChild(btnFiltered);

    var iBtn = document.createElement('i');
    iBtn.classList.add('fa', 'fa-close');
    iBtn.appendChild(document.createTextNode("\u00A0" + selectedCategoryTxt));
    btnFiltered.appendChild(iBtn);
}

function fillCards() {

    var cardsDiv = document.getElementById("cardsDiv");
    $("#cardsDiv").addClass("album py-5 bg-light");

    var silinecekDiv = document.getElementById("silinecekDiv");
    if (silinecekDiv != null) {
        silinecekDiv.remove();
    }

    var silinecekBtn = document.getElementById("btnFilteredId");
    if (silinecekBtn != null) {
        silinecekBtn.remove();
    }

    var silinecekMainBtn = document.getElementById("btnFilteredMainId");
    if (silinecekMainBtn != null) {
        silinecekMainBtn.remove();
    }

    var div2 = document.createElement('div');
    div2.id = "silinecekDiv";
    div2.classList.add("container");
    cardsDiv.appendChild(div2);

    var div3 = document.createElement('div');
    div3.classList.add('row', 'row-cols-1', 'row-cols-sm-2', 'row-cols-md-3', 'g-3');
    div2.appendChild(div3);

    if (urlCategoryId.length > 2) {
        var tempCategoryIdFromUrl = urlCategoryId;
        urlCategoryId = "-1";

        for (var i = 0; i < categories.length; i++) {
            if (categories[i].categoryUrl == tempCategoryIdFromUrl) {
                tempCategoryIdFromUrl = categories[i].id;
            }
        }


        
        var tempNewsList = [];

        for (var i = 0; i < news.length; i++) {
            if (news[i].mainCategoryIds == tempCategoryIdFromUrl || news[i].categoryIds == tempCategoryIdFromUrl) {
                tempNewsList.push(news[i]);
            }
        }
        // newse atama

        //news = tempNewsList;

        for (var i = 0; i < tempNewsList.length; i++) {
            var icDiv1 = document.createElement('div');
            icDiv1.classList.add("col");
            div3.appendChild(icDiv1);

            var icDiv2 = document.createElement('div');
            icDiv2.classList.add('card', 'shadow-sm');
            icDiv1.appendChild(icDiv2);

            var imgIcDiv2 = document.createElement('img');
            imgIcDiv2.classList.add('bd-placeholder-img', 'card-img-top');
            imgIcDiv2.src = "/images/news/" + tempNewsList[i].imageUrl;
            imgIcDiv2.setAttribute("width", "100");
            imgIcDiv2.setAttribute("height", "225");
            icDiv2.appendChild(imgIcDiv2);

            var div1IcDiv2 = document.createElement('div');
            div1IcDiv2.classList.add("card-body");
            icDiv2.appendChild(div1IcDiv2);

            var h4div1IcDiv2 = document.createElement('h5');
            h4div1IcDiv2.classList.add("card-text");
            h4div1IcDiv2.appendChild(document.createTextNode(tempNewsList[i].title));
            div1IcDiv2.appendChild(h4div1IcDiv2);

            var pdiv1IcDiv2 = document.createElement('p');
            pdiv1IcDiv2.classList.add("card-text");
            pdiv1IcDiv2.appendChild(document.createTextNode(tempNewsList[i].detailHeader));
            div1IcDiv2.appendChild(pdiv1IcDiv2);

            var div1div1IcDiv2 = document.createElement('div');
            div1div1IcDiv2.classList.add('d-flex', 'justify-content-between', 'align-items-center');
            div1IcDiv2.appendChild(div1div1IcDiv2);

            var div1div1div1IcDiv2 = document.createElement('div');
            div1div1div1IcDiv2.classList.add("btn-group");
            div1div1IcDiv2.appendChild(div1div1div1IcDiv2);

            var buttondiv1div1div1IcDiv2 = document.createElement('button');
            buttondiv1div1div1IcDiv2.classList.add('btn', 'btn-sm', 'btn-outline-secondary');
            buttondiv1div1div1IcDiv2.appendChild(document.createTextNode("Görüntüle"));
            buttondiv1div1div1IcDiv2.setAttribute('onclick', `redirectToSearch('${tempNewsList[i].url}');`);
            div1div1div1IcDiv2.appendChild(buttondiv1div1div1IcDiv2);

            var smalliv1div1div1IcDiv2 = document.createElement('small');
            smalliv1div1div1IcDiv2.classList.add("text-muted");
            smalliv1div1div1IcDiv2.appendChild(document.createTextNode("👁"));
            div1div1IcDiv2.appendChild(smalliv1div1div1IcDiv2);

        }
    } else {
        if (urlCategoryId == "-1") {
            for (var i = 0; i < news.length; i++) {
                var icDiv1 = document.createElement('div');
                icDiv1.classList.add("col");
                div3.appendChild(icDiv1);

                var icDiv2 = document.createElement('div');
                icDiv2.classList.add('card', 'shadow-sm');
                icDiv1.appendChild(icDiv2);

                var imgIcDiv2 = document.createElement('img');
                imgIcDiv2.classList.add('bd-placeholder-img', 'card-img-top');
                imgIcDiv2.src = "/images/news/" + news[i].imageUrl;
                imgIcDiv2.setAttribute("width", "100");
                imgIcDiv2.setAttribute("height", "225");
                icDiv2.appendChild(imgIcDiv2);

                var div1IcDiv2 = document.createElement('div');
                div1IcDiv2.classList.add("card-body");
                icDiv2.appendChild(div1IcDiv2);

                var h4div1IcDiv2 = document.createElement('h5');
                h4div1IcDiv2.classList.add("card-text");
                h4div1IcDiv2.appendChild(document.createTextNode(news[i].title));
                div1IcDiv2.appendChild(h4div1IcDiv2);

                var pdiv1IcDiv2 = document.createElement('p');
                pdiv1IcDiv2.classList.add("card-text");
                pdiv1IcDiv2.appendChild(document.createTextNode(news[i].detailHeader));
                div1IcDiv2.appendChild(pdiv1IcDiv2);

                var div1div1IcDiv2 = document.createElement('div');
                div1div1IcDiv2.classList.add('d-flex', 'justify-content-between', 'align-items-center');
                div1IcDiv2.appendChild(div1div1IcDiv2);

                var div1div1div1IcDiv2 = document.createElement('div');
                div1div1div1IcDiv2.classList.add("btn-group");
                div1div1IcDiv2.appendChild(div1div1div1IcDiv2);

                var buttondiv1div1div1IcDiv2 = document.createElement('button');
                buttondiv1div1div1IcDiv2.classList.add('btn', 'btn-sm', 'btn-outline-secondary');
                buttondiv1div1div1IcDiv2.appendChild(document.createTextNode("Görüntüle"));
                buttondiv1div1div1IcDiv2.setAttribute('onclick', `redirectToSearch('${news[i].url}');`);
                div1div1div1IcDiv2.appendChild(buttondiv1div1div1IcDiv2);

                var smalliv1div1div1IcDiv2 = document.createElement('small');
                smalliv1div1div1IcDiv2.classList.add("text-muted");
                smalliv1div1div1IcDiv2.appendChild(document.createTextNode("👁"));
                div1div1IcDiv2.appendChild(smalliv1div1div1IcDiv2);
            }

        }
        else {
            var tempCategoryIdFromUrl = urlCategoryId;
            urlCategoryId = "-1";

            for (var i = 0; i < categories.length; i++) {
                if (categories[i].categoryUrl == tempCategoryIdFromUrl || news[i].categoryIds == tempCategoryIdFromUrl) {
                    tempCategoryIdFromUrl = categories[i].id;
                }
            }

            var tempNewsList = [];

            for (var i = 0; i < news.length; i++) {
                if (news[i].mainCategoryIds == tempCategoryIdFromUrl) {
                    tempNewsList.push(news[i]);
                }
            }
            // newse atama

            //news = tempNewsList;

            for (var i = 0; i < tempNewsList.length; i++) {
                var icDiv1 = document.createElement('div');
                icDiv1.classList.add("col");
                div3.appendChild(icDiv1);

                var icDiv2 = document.createElement('div');
                icDiv2.classList.add('card', 'shadow-sm');
                icDiv1.appendChild(icDiv2);

                var imgIcDiv2 = document.createElement('img');
                imgIcDiv2.classList.add('bd-placeholder-img', 'card-img-top');
                imgIcDiv2.src = "/images/news/" + tempNewsList[i].imageUrl;
                imgIcDiv2.setAttribute("width", "100");
                imgIcDiv2.setAttribute("height", "225");
                icDiv2.appendChild(imgIcDiv2);

                var div1IcDiv2 = document.createElement('div');
                div1IcDiv2.classList.add("card-body");
                icDiv2.appendChild(div1IcDiv2);

                var h4div1IcDiv2 = document.createElement('h5');
                h4div1IcDiv2.classList.add("card-text");
                h4div1IcDiv2.appendChild(document.createTextNode(tempNewsList[i].title));
                div1IcDiv2.appendChild(h4div1IcDiv2);

                var pdiv1IcDiv2 = document.createElement('p');
                pdiv1IcDiv2.classList.add("card-text");
                pdiv1IcDiv2.appendChild(document.createTextNode(tempNewsList[i].detailHeader));
                div1IcDiv2.appendChild(pdiv1IcDiv2);

                var div1div1IcDiv2 = document.createElement('div');
                div1div1IcDiv2.classList.add('d-flex', 'justify-content-between', 'align-items-center');
                div1IcDiv2.appendChild(div1div1IcDiv2);

                var div1div1div1IcDiv2 = document.createElement('div');
                div1div1div1IcDiv2.classList.add("btn-group");
                div1div1IcDiv2.appendChild(div1div1div1IcDiv2);

                var buttondiv1div1div1IcDiv2 = document.createElement('button');
                buttondiv1div1div1IcDiv2.classList.add('btn', 'btn-sm', 'btn-outline-secondary');
                buttondiv1div1div1IcDiv2.appendChild(document.createTextNode("Görüntüle"));
                buttondiv1div1div1IcDiv2.setAttribute('onclick', `redirectToSearch('${tempNewsList[i].url}');`);
                div1div1div1IcDiv2.appendChild(buttondiv1div1div1IcDiv2);

                var smalliv1div1div1IcDiv2 = document.createElement('small');
                smalliv1div1div1IcDiv2.classList.add("text-muted");
                smalliv1div1div1IcDiv2.appendChild(document.createTextNode("👁"));
                div1div1IcDiv2.appendChild(smalliv1div1div1IcDiv2);

            }
        }
    }

    

    
}

function SearchText() {

    var news = modelNews;

    var newsTemp = [];

    // Girilen text bilgilerine göre search texti getirmek

    var searchTxtVal = document.getElementById("search").value;

    // Seçilen option bilgisine göre verileri getirmek

    var subCategorySelectList = document.getElementById("subCategory");
    var selectedCategory = subCategorySelectList.options[subCategorySelectList.selectedIndex].value;

    if (selectedCategory !== "-1") {
        for (var i = 0; i < news.length; i++) {
            if ((news[i].categoryIds.toString() == selectedCategory) && news[i].title.toLowerCase().includes(searchTxtVal.toLowerCase())) {
                newsTemp.push(news[i]);
            }
        }
    }
    else {
        for (var i = 0; i < news.length; i++) {
            if (news[i].title.toLowerCase().includes(searchTxtVal.toLowerCase())) {
                newsTemp.push(news[i]);
            }
        }
    }

    news = newsTemp;

    var cardsDiv = document.getElementById("cardsDiv");
    $("#cardsDiv").addClass("album py-5 bg-light");

    var silinecekDiv = document.getElementById("silinecekDiv");
    silinecekDiv.remove();

    var div2 = document.createElement('div');
    div2.id = "silinecekDiv";
    div2.classList.add("container");
    cardsDiv.appendChild(div2);

    var div3 = document.createElement('div');
    div3.classList.add('row', 'row-cols-1', 'row-cols-sm-2', 'row-cols-md-3', 'g-3');
    div2.appendChild(div3);

    for (var i = 0; i < news.length; i++) {
        var icDiv1 = document.createElement('div');
        icDiv1.classList.add("col");
        div3.appendChild(icDiv1);

        var icDiv2 = document.createElement('div');
        icDiv2.classList.add('card', 'shadow-sm');
        icDiv1.appendChild(icDiv2);

        var imgIcDiv2 = document.createElement('img');
        imgIcDiv2.classList.add('bd-placeholder-img', 'card-img-top');
        imgIcDiv2.src = "/images/news/" + news[i].imageUrl;
        imgIcDiv2.setAttribute("width", "100");
        imgIcDiv2.setAttribute("height", "225");
        icDiv2.appendChild(imgIcDiv2);

        var div1IcDiv2 = document.createElement('div');
        div1IcDiv2.classList.add("card-body");
        icDiv2.appendChild(div1IcDiv2);

        var h4div1IcDiv2 = document.createElement('h5');
        h4div1IcDiv2.classList.add("card-text");
        h4div1IcDiv2.appendChild(document.createTextNode(news[i].title));
        div1IcDiv2.appendChild(h4div1IcDiv2);

        var pdiv1IcDiv2 = document.createElement('p');
        pdiv1IcDiv2.classList.add("card-text");
        pdiv1IcDiv2.appendChild(document.createTextNode(news[i].detailHeader));
        div1IcDiv2.appendChild(pdiv1IcDiv2);

        var div1div1IcDiv2 = document.createElement('div');
        div1div1IcDiv2.classList.add('d-flex', 'justify-content-between', 'align-items-center');
        div1IcDiv2.appendChild(div1div1IcDiv2);

        var div1div1div1IcDiv2 = document.createElement('div');
        div1div1div1IcDiv2.classList.add("btn-group");
        div1div1IcDiv2.appendChild(div1div1div1IcDiv2);

        var buttondiv1div1div1IcDiv2 = document.createElement('button');
        buttondiv1div1div1IcDiv2.classList.add('btn', 'btn-sm', 'btn-outline-secondary');
        buttondiv1div1div1IcDiv2.appendChild(document.createTextNode("Görüntüle"));
        buttondiv1div1div1IcDiv2.setAttribute('onclick', `redirectToSearch('${news[i].url}');`);
        div1div1div1IcDiv2.appendChild(buttondiv1div1div1IcDiv2);

        var smalliv1div1div1IcDiv2 = document.createElement('small');
        smalliv1div1div1IcDiv2.classList.add("text-muted");
        smalliv1div1div1IcDiv2.appendChild(document.createTextNode("👁"));
        div1div1IcDiv2.appendChild(smalliv1div1div1IcDiv2);
    }

}

function filterByCategory() {
    var news = modelNews;
    var newsTemp = [];

    // Seçilen option bilgisine göre verileri getirmek

    var subCategorySelectList = document.getElementById("subCategory");
    var selectedCategory = subCategorySelectList.options[subCategorySelectList.selectedIndex].value;
    var selectedCategoryTxt = subCategorySelectList.options[subCategorySelectList.selectedIndex].text;

    var mainCategorySelectList = document.getElementById("mainCategory");
    var mainCategoryTxt = mainCategorySelectList.options[mainCategorySelectList.selectedIndex].text;

    // Seçilen filtrelerin yanında searchText bilgisi de dolu gelmişse;

    var searchTxtVal = document.getElementById("search").value;

    if (selectedCategory == "-1") {
        return changeCategoryBySubCategory();
    }
    else {
        if (searchTxtVal !== "") {
            for (var i = 0; i < news.length; i++) {
                if ((news[i].categoryIds.toString() == selectedCategory) && news[i].title.toLowerCase().includes(searchTxtVal.toLowerCase())) {
                    newsTemp.push(news[i]);
                }
            }
        }
        else {
            for (var i = 0; i < news.length; i++) {
                if (news[i].categoryIds.toString() == selectedCategory) {
                    newsTemp.push(news[i]);
                }
            }
        }
    }

    

    news = newsTemp;

    var cardsDiv = document.getElementById("cardsDiv");
    $("#cardsDiv").addClass("album py-5 bg-light");

    var silinecekDiv = document.getElementById("silinecekDiv");
    silinecekDiv.remove();

    var div2 = document.createElement('div');
    div2.id = "silinecekDiv";
    div2.classList.add("container");
    cardsDiv.appendChild(div2);

    var div3 = document.createElement('div');
    div3.classList.add('row', 'row-cols-1', 'row-cols-sm-2', 'row-cols-md-3', 'g-3');
    div2.appendChild(div3);

    for (var i = 0; i < news.length; i++) {
        var icDiv1 = document.createElement('div');
        icDiv1.classList.add("col");
        div3.appendChild(icDiv1);

        var icDiv2 = document.createElement('div');
        icDiv2.classList.add('card', 'shadow-sm');
        icDiv1.appendChild(icDiv2);

        var imgIcDiv2 = document.createElement('img');
        imgIcDiv2.classList.add('bd-placeholder-img', 'card-img-top');
        imgIcDiv2.src = "/images/news/" + news[i].imageUrl;
        imgIcDiv2.setAttribute("width", "100");
        imgIcDiv2.setAttribute("height", "225");
        icDiv2.appendChild(imgIcDiv2);

        var div1IcDiv2 = document.createElement('div');
        div1IcDiv2.classList.add("card-body");
        icDiv2.appendChild(div1IcDiv2);

        var h4div1IcDiv2 = document.createElement('h5');
        h4div1IcDiv2.classList.add("card-text");
        h4div1IcDiv2.appendChild(document.createTextNode(news[i].title));
        div1IcDiv2.appendChild(h4div1IcDiv2);

        var pdiv1IcDiv2 = document.createElement('p');
        pdiv1IcDiv2.classList.add("card-text");
        pdiv1IcDiv2.appendChild(document.createTextNode(news[i].detailHeader));
        div1IcDiv2.appendChild(pdiv1IcDiv2);

        var div1div1IcDiv2 = document.createElement('div');
        div1div1IcDiv2.classList.add('d-flex', 'justify-content-between', 'align-items-center');
        div1IcDiv2.appendChild(div1div1IcDiv2);

        var div1div1div1IcDiv2 = document.createElement('div');
        div1div1div1IcDiv2.classList.add("btn-group");
        div1div1IcDiv2.appendChild(div1div1div1IcDiv2);

        var buttondiv1div1div1IcDiv2 = document.createElement('button');
        buttondiv1div1div1IcDiv2.classList.add('btn', 'btn-sm', 'btn-outline-secondary');
        buttondiv1div1div1IcDiv2.appendChild(document.createTextNode("Görüntüle"));
        buttondiv1div1div1IcDiv2.setAttribute('onclick', `redirectToSearch('${tempNewsList[i].url}');`);
        div1div1div1IcDiv2.appendChild(buttondiv1div1div1IcDiv2);

        var smalliv1div1div1IcDiv2 = document.createElement('small');
        smalliv1div1div1IcDiv2.classList.add("text-muted");
        smalliv1div1div1IcDiv2.appendChild(document.createTextNode("👁"));
        div1div1IcDiv2.appendChild(smalliv1div1div1IcDiv2);
    }

    // Filtrelenen seçenekleri yazdırma

    var searchBarDiv = document.getElementById("searchBarDiv"); // Ana div

    
    var silinecekBtn = document.getElementById("btnFilteredId");
    if (silinecekBtn != null) {
        silinecekBtn.remove();
    }

    var silinecekMainBtn = document.getElementById("btnFilteredMainId");
    if (silinecekMainBtn != null) {
        silinecekMainBtn.remove();
    }

    // Üst kategorinin filtesinin yazdırılması
    //mainCategoryTxt

    var btnFilteredMain = document.createElement('button');
    btnFilteredMain.id = "btnFilteredMainId";
    btnFilteredMain.setAttribute("type", "button");
    btnFilteredMain.onclick = function () {
        ClearFilterMain();
    };
    btnFilteredMain.classList.add('btn', 'btn-secondary', 'rounded-pill');
    btnFilteredMain.setAttribute("style", "margin-top: 10px; background-color:#a6443c;");
    searchBarDiv.appendChild(btnFilteredMain);

    var iBtnMain = document.createElement('i');
    iBtnMain.classList.add('fa', 'fa-close');
    iBtnMain.appendChild(document.createTextNode("\u00A0" + mainCategoryTxt));
    btnFilteredMain.appendChild(iBtnMain);

    var btnFiltered = document.createElement('button');
    btnFiltered.id = "btnFilteredId";
    btnFiltered.setAttribute("type", "button");
    btnFiltered.onclick = function () {
        ClearFilterSub();
    };
    btnFiltered.classList.add('btn', 'btn-secondary', 'rounded-pill');
    btnFiltered.setAttribute("style", "margin-top: 10px;");
    searchBarDiv.appendChild(btnFiltered);

    var iBtn = document.createElement('i');
    iBtn.classList.add('fa', 'fa-close');
    iBtn.appendChild(document.createTextNode("\u00A0" + selectedCategoryTxt));
    btnFiltered.appendChild(iBtn);
}



function ClearFilterMain() {
    var silinecekBtn = document.getElementById("btnFilteredId");
    if (silinecekBtn != null) {
        silinecekBtn.remove();
    }
    // Sub Filtre'nin Name'i
    var subFilterName;
    var silinecekMainBtn = document.getElementById("btnFilteredMainId");
    if (silinecekMainBtn != null) {
        silinecekMainBtn.remove();
    }

    var val = "-1";
    $('#mainCategory').val(val);
    filterByCategory();

    $('#subCategory').val(val);
    filterByCategory();
}

function ClearFilterSub() {
    var silinecekBtn = document.getElementById("btnFilteredId");
    if (silinecekBtn != null) {
        silinecekBtn.remove();
    }
    // Sub Filtre'nin Name'i
    var subFilterName;
    var silinecekMainBtn = document.getElementById("btnFilteredMainId");
    if (silinecekMainBtn != null) {
        subFilterName = silinecekMainBtn.value;
    }

    var val = "-1";
    $('#subCategory').val(val);
    filterByCategory();
}

function redirectToSearch(id) {
    window.location.href = '/Haberler/' + id;
}

fillCards();