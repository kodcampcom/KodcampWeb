
getUrl();
function getUrl() {
    var currentLocation = window.location;
    currentLocation = currentLocation.toString();

    var type = "Anasayfa";
    if (currentLocation.includes("Sozluk")) {
        type = "Sözlük";
    }
    else if (currentLocation.includes("PageSearchFilterSort")) {
        type = "Detaylı Arama";
    }
    else if (currentLocation.includes("Sorular")) {
        type = "Soru-Cevap";
    }
    else if (currentLocation.includes("Haberler")) {
        type = "Haberler";
    }
    else if (currentLocation.includes("Makaleler")) {
        type = "Makaleler";
    }
    else if (currentLocation.includes("Egitimler")) {
        type = "Eğitimler";
    }
    else if (currentLocation.includes("sosyal")) {
        type = "Sosyal Medya";
    }
    else if (currentLocation.includes("kategoriler")) {
        type = "Kategoriler";
    }
    else if (currentLocation.includes("uygulamalar")) {
        type = "Uygulamalar";
    }
    else {
        type = "Anasayfa";
    }

    var elements = document.getElementsByClassName("isactive");
    for (var i = 0; i < elements.length; i++) {
        if (elements[i].textContent.trim().toLowerCase().includes(type.toLowerCase())) {
            elements[i].classList.add('active');
        }
    }

}