

// # id
// . class
// h1

$('#submitButton').on('click', function (e) {
    var $name = $('#name'),
        $comment = $('#comment');

    e.preventDefault();

    $.ajax('http://localhost:53460/memory/save', {
        contentType: "application/json",
        method: "POST",
        data: JSON.stringify({Name: $name.val(), Comment: $comment.val()})
    }).done(function () { console.log('im so fucking done.'); });
});

