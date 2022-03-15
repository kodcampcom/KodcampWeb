
function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            var element = document.getElementById("blah")
            element.classList.remove('d-none');
            element.setAttribute('src', e.target.result)
            element.setAttribute('style', "width:200px; height: 200px;")
        };

        reader.readAsDataURL(input.files[0]);
    }
}

function writeLengthCount() {
    txtElement = document.getElementById("formGroupExampleInput2");
    txtCount = txtElement.value;
    txtCount = txtCount.length;
    lblElement = document.getElementById("lblCount");
    //lblElement.appendChild(document.createTextNode("En az 60 en fazla 80 karakter girilmelidir : " + txtCount));
    lblElement.textContent = "En az 65 en fazla 75 karakter girilmelidir : " + txtCount;
}