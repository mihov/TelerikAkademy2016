(function () {
    console.log(name(['2', '3']));      // I will invoke myself
})();

function name(params) {
    var circleX = 0, circleY = 0, circleR = 2;
    var pointX = parseFloat(params[0]), pointY = parseFloat(params[1]);

    var distance = Math.sqrt(Math.pow(circleX - pointX, 2) + Math.pow(circleY - pointY, 2));

    return (distance > circleR?"no ":"yes ")+distance.toFixed(2);
}