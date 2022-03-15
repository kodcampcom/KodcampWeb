//

function GetBasliklarim() {
    // İlgili alan doluyor.

    var elementBasliklar = document.getElementById("divBaslik");
    if (elementBasliklar.classList != null) {
        elementBasliklar.classList.remove('d-none');
        elementBasliklar.classList.add('active');
    }

    var aBaslik = document.getElementById("aBaslik");
    aBaslik.classList.add('active');

    // Diğerleri boşalıyor.

    var elementEntryler = document.getElementById("divEntry");
    elementEntryler.classList.add('d-none');

    var elementMakaleler = document.getElementById("divMakale");
    elementMakaleler.classList.add('d-none');

    var elementRaporlar = document.getElementById("divRapor");
    elementRaporlar.classList.add('d-none');

    
    var aMessage = document.getElementById("aMesaj");
    aMessage.classList.remove('active');

    var aMakale = document.getElementById("aMakale");
    aMakale.classList.remove('active');

    var aRapor = document.getElementById("aRapor");
    aRapor.classList.remove('active');

    // Başlık Değişiyor

    document.getElementById("h1Baslik").textContent = 'Açtığım Başlıklar';

}

function GetEntrilerim() {
    var elementEntryler = document.getElementById("divEntry");
    if (elementEntryler.classList != null) {
        elementEntryler.classList.remove('d-none');
        elementEntryler.classList.add('active');
    }

    var aMessage = document.getElementById("aMesaj");
    aMessage.classList.add('active');


    // Diğerleri boşalıyor.

    var elementBasliklar = document.getElementById("divBaslik");
    elementBasliklar.classList.add('d-none');

    var elementMakaleler = document.getElementById("divMakale");
    elementMakaleler.classList.add('d-none');

    var elementRaporlar = document.getElementById("divRapor");
    elementRaporlar.classList.add('d-none');


    var aBaslik = document.getElementById("aBaslik");
    aBaslik.classList.remove('active');

    var aMakale = document.getElementById("aMakale");
    aMakale.classList.remove('active');

    var aRapor = document.getElementById("aRapor");
    aRapor.classList.remove('active');

    
    // Başlık Değişiyor

    document.getElementById("h1Baslik").textContent = 'Girdiğim Entryler';
}

function GetMakalelerim() {
    var elementMakaleler = document.getElementById("divMakale");
    if (elementMakaleler.classList != null) {
        elementMakaleler.classList.remove('d-none');
        elementMakaleler.classList.add('active');
    }

    var aMakale = document.getElementById("aMakale");
    aMakale.classList.add('active');


    // Diğerleri boşalıyor.

    var elementBasliklar = document.getElementById("divBaslik");
    elementBasliklar.classList.add('d-none');

    var elementEntry = document.getElementById("divEntry");
    elementEntry.classList.add('d-none');

    var elementRaporlar = document.getElementById("divRapor");
    elementRaporlar.classList.add('d-none');


    var aBaslik = document.getElementById("aBaslik");
    aBaslik.classList.remove('active');

    var aMesaj = document.getElementById("aMesaj");
    aMesaj.classList.remove('active');

    var aRapor = document.getElementById("aRapor");
    aRapor.classList.remove('active');


    // Başlık Değişiyor

    document.getElementById("h1Baslik").textContent = 'Girdiğim Entryler';
}

function GetRaporlarim() {
    var elementRapor = document.getElementById("divRapor");
    if (elementRapor.classList != null) {
        elementRapor.classList.remove('d-none');
        elementRapor.classList.add('active');
    }

    var aRapor = document.getElementById("aRapor");
    aRapor.classList.add('active');


    // Diğerleri boşalıyor.

    var elementBasliklar = document.getElementById("divBaslik");
    elementBasliklar.classList.add('d-none');

    var elementMakaleler = document.getElementById("divMakale");
    elementMakaleler.classList.add('d-none');

    var elementEntry = document.getElementById("divEntry");
    elementEntry.classList.add('d-none');


    var aBaslik = document.getElementById("aBaslik");
    aBaslik.classList.remove('active');

    var aMakale = document.getElementById("aMakale");
    aMakale.classList.remove('active');

    var aMesaj = document.getElementById("aMesaj");
    aMesaj.classList.remove('active');


    // Başlık Değişiyor

    document.getElementById("h1Baslik").textContent = 'Raporlar';
}