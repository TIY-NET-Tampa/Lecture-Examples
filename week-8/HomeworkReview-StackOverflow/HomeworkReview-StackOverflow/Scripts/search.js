﻿let searchQuestions = () => {
    var _data = {
        needle: $("#needle").val()
    };
    console.log("searching...");
    $.ajax({
        url: '/home/search',
        type: "POST",
        data: JSON.stringify(_data),
        contentType: "application/json",
        dataType: "html",
        success: (results) => {
            $("#results").html(results);
        }
    });
}


