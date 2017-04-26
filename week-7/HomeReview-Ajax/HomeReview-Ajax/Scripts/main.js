console.log("loaded main.js");


let loadRandomMarble = () => {
    let bagOfMarbles = $("#bagOfMarbles").children();
    var rand = Math.floor(Math.random() * bagOfMarbles.length);
    $("#random").html(bagOfMarbles[rand].innerHTML);
}

let loadAllMarbles = () => {
    $.ajax({
        url: "/api/marbles",
        dataType: "json",
        success: (marbles) => {
            marbles.map((m) => {
                var _li = $("<li>").html(m.Color);
                $("#bagOfMarbles").append(_li);
            });
        }
    });
}

$(document).ready(() => {
   
    console.log("ready...");
    loadAllMarbles();
});

