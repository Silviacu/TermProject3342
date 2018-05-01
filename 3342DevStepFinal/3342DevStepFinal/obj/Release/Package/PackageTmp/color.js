function getRandomColor() {
    var settings = {
        "async": true,
        "crossDomain": true,
        "url": "http://www.colourlovers.com/api/colors",
        "method": "GET",
        "headers": {
            "cache-control": "no-cache",
            "postman-token": "8eef2206-eab9-44c5-7374-98460161acc4"
        }
    }

    $.ajax(settings).done(function (response) {
        console.log(response);
    });
}