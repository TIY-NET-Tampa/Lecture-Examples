let upVote = (postId) => {
    $.ajax({
        url: "/vote/up",
        data: JSON.stringify({ id: postId }),
        dataType: "html",
        success: (newHtml) => {
            $("#voteContainer-" + postId).html(newHtml);
        }
    })
}

let downVote = () => {
    $.ajax({
        url: "/vote/down",
        data: JSON.stringify({ id: postId }),
        dataType: "html",
        success: (newHtml) => {
            $("#voteContainer-" + postId).html(newHtml);
        }
    })
}


