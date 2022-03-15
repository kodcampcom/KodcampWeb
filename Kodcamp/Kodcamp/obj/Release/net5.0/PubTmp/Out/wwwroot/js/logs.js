var news = news;
var logs = logs;

function getSelectedLogs() {

    var newsSelectList = document.getElementById("logNews");
    var selectedNews = newsSelectList.options[newsSelectList.selectedIndex].value;

    if (selectedNews === "-1") {
        for (var i = 0; i < logs.length; i++) {
            var isClassExist = document.getElementsByClassName('d-none');
            if (isClassExist.length > 0) {
                for (var i = 0; i < isClassExist.length; i++) {
                    isClassExist[i].classList.remove('d-none')
                }
            }
        }
        var a = document.getElementById("countOfLogs");
        var c = document.getElementById("countOfLogs").childNodes;
        c[0].remove();
        var text = logs.length;
        a.appendChild(document.createTextNode("👁 \u00A0" + text));
    }
    else {
        var tempList = [];
        for (var i = 0; i < logs.length; i++) {
            if (logs[i].newsId != selectedNews) {
                tempList.push(logs[i]);
            }

        }

        for (var i = 0; i < logs.length; i++) {
            var isClassExist = document.getElementsByClassName('d-none');
            if (isClassExist.length > 0) {
                for (var i = 0; i < isClassExist.length; i++) {
                    isClassExist[i].classList.remove('d-none')
                }
            }
        }
        for (var i = 0; i < logs.length; i++) {
            var classNameNews = "logs-" + logs[i].id;
            for (var k = 0; k < tempList.length; k++) {
                if (classNameNews === "logs-" + tempList[k].id) {
                    var selectedElementDate = document.getElementById(classNameNews);
                    selectedElementDate.classList.add('d-none');
                    selectedElementDate = null;
                }
            }
        }

        var a = document.getElementById("countOfLogs");
        var c = document.getElementById("countOfLogs").childNodes;
        c[0].remove();
        var text =(logs.length - tempList.length)
        a.appendChild(document.createTextNode("👁 \u00A0" + text));
    }

}
