function checkFormAddStaff(){
    var name = document.getElementById("name1").value;
    if(name == ''){
        document.getElementById("errorName").innerHTML = "Tên không được trống";
        return false;
    }
    return true;
}
