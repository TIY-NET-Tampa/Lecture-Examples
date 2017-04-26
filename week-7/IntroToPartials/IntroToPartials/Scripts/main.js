let loadNewStory = () => {
    $.ajax({
        url: "/home/GetNewsStory",
        dataType: "html",
        success: (story) => {
            $("#newArticles").prepend(story);
        }
    })
}


let loadStoryNoPartial = () => {
    $.ajax({
        url: "/home/GetNewsStory",
        dataType: "html",
        success: (story) => {
          $("<div>").html($("<h2>").html(story.header))
        }
    })

}