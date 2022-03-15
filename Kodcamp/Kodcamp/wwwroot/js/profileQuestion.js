function ChangeStatus(id) {
    var categorySelectList = document.getElementById("isSolvedOption");
    var selectedValue = categorySelectList.options[categorySelectList.selectedIndex].value;
    window.location.href = "/Profile/Questions/ChangeStatus/"+id+"/"+selectedValue
}