//$.ready(function () {
//    $("form[name='signupform']").validate({
//        rules: {
//            email: "required"
//        },
        
//        messages: {
//            email: "Email không được bỏ trống"
//        }
       
//    });          
//});
function validateform() {
    var firstname = document.getElementById('firstname').value;
    var lastname = document.getElementById('lastname').value;
    var position = document.getElementById('position').value;
    var phone = document.getElementById('phoneNumber').value;
    var email = document.getElementById('email').value;
    var ok = false;
    //Check first name
    if (firstname == null || firstname == ""){
        document.getElementById('firstmess').innerHTML = "Vui lòng nhập Tên"; 
        
    } else document.getElementById('firstmess').innerHTML = "";   
    
    //Check last name
    if (lastname == null || lastname == "") {
        document.getElementById('lastmess').innerHTML = "Vui lòng nhập Họ";
    } else document.getElementById('lastmess').innerHTML = "";  
    
    //Check position
    if (position == null || position == "") {
        document.getElementById('positionmess').innerHTML = "Vui lòng nhập Vị trí";
    } else document.getElementById('positionmess').innerHTML = "";  
    
    //Check phone number
    if (phone == null || phone == "") {
        document.getElementById('phonemess').innerHTML = "Vui lòng nhập Số điện thoại";
    } else document.getElementById('phonemess').innerHTML = "";  
    
    //Checkemail
    if (email == null || email == "") {
        document.getElementById('emailmess').innerHTML = "Vui lòng nhập Email";
    } else document.getElementById('emailmess').innerHTML = "";

    //All inputs are not null
    if (firstname.length > 0 && lastname.length > 0 && position.length > 0 && phone.length > 0 && email.length > 0 )
    {
        ok = true;
    }   
    return ok;
}


