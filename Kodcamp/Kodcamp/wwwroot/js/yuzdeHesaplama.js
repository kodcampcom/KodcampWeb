
function yuzdeHesapla() {
    var number = document.getElementById("number").value;
    var ratio = document.getElementById("ratio").value;
    var result = (number * ratio) / 100;
    var element = document.getElementById("result");
    var divResult = document.getElementById("divResult");
    element.classList.remove('d-none');
    divResult.classList.remove('d-none');
    element.textContent = "Sonuç : " + result;
}

function indirimHesapla() {
    var number = document.getElementById("number").value;
    var ratio = document.getElementById("ratio").value;

    var indirimTutari = (number * ratio) / 100;
    var sonFiyat = number - indirimTutari;

    var divResult1 = document.getElementById("divResult1");
    divResult1.classList.remove('d-none');

    var divResult2 = document.getElementById("divResult2");
    divResult2.classList.remove('d-none');

    var indirimTutariElement = document.getElementById("indirimTutari");
    indirimTutariElement.classList.remove('d-none');
    indirimTutariElement.textContent = "İndirim Tutarı : " + indirimTutari + " ₺";

    var sonFiyatiElement = document.getElementById("sonFiyati");
    sonFiyatiElement.classList.remove('d-none');
    sonFiyatiElement.textContent = "İndirimli Son Fiyat : " + sonFiyat + " ₺";
    
}

function kelimeDegistir() {
    var duzenlenecekTxt = document.getElementById("duzeltilecekTxt").value;
    var degisenKelime = document.getElementById("degisenKelime").value;
    var degistirilecekKelime = document.getElementById("degistirilecekKelime").value;

    var sonuc = duzenlenecekTxt.replaceAll(degisenKelime, degistirilecekKelime);

    var divResult1 = document.getElementById("divResult1");
    divResult1.classList.remove('d-none');

    var duzenlenenTxt = document.getElementById("duzenlenenTxt");
    duzenlenenTxt.textContent = sonuc;

}

function getLengthOfText() {
    var duzenlenecekTxt = document.getElementById("duzeltilecekTxt").value;
    var wordList = duzenlenecekTxt.split(" ");
    var result = wordList.length;

    var divResult1 = document.getElementById("divResult1");
    divResult1.classList.remove('d-none');

    var duzenlenenTxt = document.getElementById("duzenlenenTxt");
    duzenlenenTxt.classList.remove('d-none');
    duzenlenenTxt.textContent = "Metinde yaklaşık " + result + " kelime bulunmaktadır";
}

function calculateAvg() {
    var not1 = document.getElementById("not1").value;
    not1 = parseFloat(not1);
    var not2 = document.getElementById("not2").value;
    not2 = parseFloat(not2);
    var not3 = document.getElementById("not3").value;
    not3 = parseFloat(not3);
    var not4 = document.getElementById("not4").value;
    not4 = parseFloat(not4);
    var not5 = document.getElementById("not5").value;
    not5 = parseFloat(not5);

    var oran1Select = document.getElementById("oran1");
    var oran1 = oran1Select.options[oran1Select.selectedIndex].value;
    oran1 = parseFloat(oran1);

    var oran2Select = document.getElementById("oran2");
    var oran2 = oran2Select.options[oran2Select.selectedIndex].value;
    oran2 = parseFloat(oran2);

    var oran3Select = document.getElementById("oran3");
    var oran3 = oran3Select.options[oran3Select.selectedIndex].value;
    oran3 = parseFloat(oran3);

    var oran4Select = document.getElementById("oran4");
    var oran4 = oran4Select.options[oran4Select.selectedIndex].value;
    oran4 = parseFloat(oran4);

    var oran5Select = document.getElementById("oran5");
    var oran5 = oran5Select.options[oran5Select.selectedIndex].value;
    oran5 = parseFloat(oran5);

    /* Sayı toplamının 100 olmasının kontrolü */
    var oranToplam = oran1 + oran2 + oran3 + oran4 + oran5;
    if (oranToplam != 100) return false;

    var count = 0;

    var not1Agirlik = 0.0;
    var not2Agirlik = 0.0;
    var not3Agirlik = 0.0;
    var not4Agirlik = 0.0;
    var not5Agirlik = 0.0;

    if (not1 != 0 && oran1 != 0) {
        not1Agirlik = (not1 * oran1)/100;
        count = count + 1;
    }
    if (not2 != 0 && oran2 != 0) {
        not2Agirlik = (not2 * oran2)/100;
        count = count + 1;
    }
    if (not3 != 0 && oran3 != 0) {
        not3Agirlik = (not3 * oran3)/100;
        count = count + 1;
    }
    if (not4 != 0 && oran4 != 0) {
        not4Agirlik = (not4 * oran4)/100;
        count = count + 1;
    }
    if (not5 != 0 && oran5 != 0) {
        not5Agirlik = (not5 * oran5)/100;
        count = count + 1;
    }

    var sonuc = (not1Agirlik + not2Agirlik + not3Agirlik + not4Agirlik + not5Agirlik);


    var divResult2 = document.getElementById("divResult2");
    divResult2.classList.remove('d-none');

    var indirimTutariElement = document.getElementById("divResultSonuc");
    indirimTutariElement.classList.remove('d-none');
    indirimTutariElement.textContent = count + " adet not girdiniz. Ortalamanız : " + sonuc;



}