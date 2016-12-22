console.log("loaded scripts");


$(document).ready(function () {
    $("button").css("border", "10px green solid");
    //$(".btn").html("BOOOM Jquery!");
});

function getRandomColor() {
    var letters = '0123456789ABCDEF';
    var color = '#';
    for (var i = 0; i < 6; i++) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}
function ClickHandler() {
    $("button")
        .css("border", "10px " + getRandomColor() + " solid")
        .css("color", getRandomColor());
}
function ChangeBackgroundColor() {
    $("body").css("background-color", getRandomColor());
}
$("#MyAction").on("click", ClickHandler);
$("#MyAction2").on("click", ClickHandler);
//setInterval(ClickHandler, 750);
//setInterval(ChangeBackgroundColor, 500);
$(document).scroll(function () {
    if (window.scrollY > 300) {
        //alert("SUBSCRICE");
    } else {
        // console.log(window.scrollY)
    }
})


var successHandler = function (data) {
    console.log(data);
    var parent = $("#Animals");
    parent.html("");
    data.forEach(function (item) {
        console.log(item.Name);
        var newDiv = $("<div>").html(item.Name + " is a " + item.Species).css("border", "3px " + getRandomColor() + " dotted");
        parent.append(newDiv);

    });
}

var failureHander = function (data) {
    console.log('oooooooooooops');
}

var completeHandler = function (data) {
    console.log("complete");
}

var dynamicHandler = function () {
    $.ajax({
        url: '/api/animals',
        success: successHandler,
        failure: failureHander,
        complete: completeHandler
    });
}

var createAnimal = function () {

    var dom = {
        Id: 4,
        Name: $("#newName").val(),
        Species: "Donkey"
    }

    $.ajax({
        type: 'POST',
        url: '/api/animals',
        data: JSON.stringify(dom),
        success: successHandler,
        failure: failureHander,
        complete: completeHandler,
        contentType: "application/json",
        dataType: "json"

    });
}

$("#MyAction3").on("click", dynamicHandler);
$("#MyAction4").on("click", createAnimal);
// run ajax on page ready
//$(document).ready(function () {
//    dynamicHandler();
//});