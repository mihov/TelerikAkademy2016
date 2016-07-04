name(['(a+b)/5-d)']);
function name(params) {

    var arr = params[0].split(''),
        result = true,
        counter = 0;
    for (var index = 0; index < arr.length; index += 1) {
        var element = arr[index];
        if (element === '(') {
            counter += 1;
        } else if (element === ')') {
            counter -= 1;
        }
        if (counter < 0) {
            result = false;
            break;
        }
    }

    console.log(result ? "Correct" : "Incorrect");
}