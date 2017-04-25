let doSomething = () => {
    let _fullName = $("#name").val();
    $("#welcomeMessage").html(_fullName);
}

let addToList = (data) => {
    $("#petList")
        .append($("<li>").html(data.Name));
}

let talkToServer = () => {

    let newPet = {
        name: $("#newPetName").val()
    };

    $.ajax({
        url: '/api/pets',
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(newPet),
        type: "POST",
        success: (data) => {
            addToList(data);
        },
        error: (data) => {
            console.log("oops", data)
        },
        complete: (data) => {
            console.log("done", data);
        }
    });
}

let loadPets = () => {
    // pull all pets from the API
    // add to the list
    $.ajax({
        url: "/api/pets",
        dataType: "json",
        success: (data) => {
            data.map((item) => { addToList(item); });
        }
    })
}

loadPets();