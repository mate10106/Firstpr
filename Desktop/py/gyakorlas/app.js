const min_password_size = 7;

document.getElementById("myButton").onclick = function(){

    let password = document.getElementById("password").value;
    let text = document.getElementById("text");
    if (String(password.Lenght) > min_password_size) {
        text.innerHTML = "Your password is perfect!"
    }
    else{
        text.innerHTML = "Your password is shit!"
    }
};