function getRandomColor() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var colorDiv = document.querySelector("html")
            var jsonData = JSON.parse(this.responseText) 
            openData = jsonData
            colorDiv.style.background = `linear-gradient(45deg, #${jsonData.schemes[0].colors[0]}, #${jsonData.schemes[0].colors[1]}, #${jsonData.schemes[0].colors[2]})`
            colorDiv.style.color = 'white'
            colorDiv.style.padding = '16px'
            colorDiv.style.textShadow = '0 2px 8px rgba(0,20,40,0.5)'
            colorDiv.style.borderRadius = '4px'
            colorDiv.style.boxShadow = '0 16px 32px -8px rgba(0,20,40,0.5)'
        }
    };
    xhttp.open("GET", "http://www.colr.org/json/scheme/random", true);
    xhttp.send();
}

(function () {
    getRandomColor()
})()