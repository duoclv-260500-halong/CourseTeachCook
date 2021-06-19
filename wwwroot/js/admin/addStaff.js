function checkFormAddStaff(){
    var name = document.getElementById("name1").value;
    var email = document.getElementById("email").value;
    var phone = document.getElementById("phone").value;
    var password = document.getElementById("password").value;
    var passwordConfirm = document.getElementById("passwordConfirm").value;
    if(name == ''){
        document.getElementById("errorName").innerHTML = "Tên không được trống";
        return false;
    }
    
    if(validateEmail(email) == false){
        document.getElementById("errorEmail").innerHTML = "Email không đúng";
        return false;
    }
    if(validatePhone(phone) == false){
        document.getElementById("errorPhone").innerHTML = "Số điện thoại không đúng (10 chữ số)";
        return false;
    }
    
    if(validatePassword(password) == false){
        document.getElementById("errorPassword").innerHTML = "Password phải bao gồm chữ hoa, chữ thường, chữ số và kí tự đặc biệt";
        return false;
    }
    if(password != passwordConfirm){
        document.getElementById("errorPasswordConfirm").innerHTML = "Password không trùng khớp";
        return false;
    }
    return true;
}
function validateEmail(email) {
    const re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
  }

 
  function validatePassword(password) {
    const r1 = /^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[ -/:-@\[-`{-~]).{8,64}$/;
    return r1.test(password);
  }
  function validatePhone(phoneNumber) {
    const r1 = /^0(?=.*[0-9]).{9}$/;
    return r1.test(phoneNumber);
  }