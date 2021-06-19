function checkPassword(){
    var password = document.getElementById("password").value;

    var passwordConfirm = document.getElementById("passwordConfirm").value;
    if(validatePassword(password) == false){
        document.getElementById("errorPassword").innerHTML = "Password không đúng định dạng";
        return false;
    }
   
    if(password != passwordConfirm){
        document.getElementById("errorPasswordConfirm").innerHTML = "Password không trùng khớp";
        return false;
    }
}

function validatePassword(password) {
    const r1 = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[ -/:-@\[-`{-~]).{8,64}$/;
    return r1.test(password);
  }
