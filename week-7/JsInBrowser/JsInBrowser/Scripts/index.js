console.log("js loaded");


let welcomeMessageHandler = () => {
    let _inputForFullName = document.getElementById("name");
    console.log(_inputForFullName);
    document.getElementById("welcomeMessage").innerHTML = _inputForFullName.value;
}

