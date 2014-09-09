function calcCircleArea(r) {

    var r = window.prompt().valueOf();
    var result = r * r * Math.PI;
    function toHtml(r, result) {
        var res = document.getElementById('result').innerHTML = "r=" + r + "; area=" + result;
    }
    toHtml(r, result);
}

