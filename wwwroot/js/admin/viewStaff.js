function checkKey(){
    var key = document.getElementById("key").value;
    if(key == null || key == ""){
        return false;
    }
    return true;
}