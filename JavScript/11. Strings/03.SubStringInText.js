name([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);
function name(params) {
    var result = 0,
        theWord = params[0].toLowerCase(),
        theArray = params[1].toLowerCase(),
        //result = theArray,
        positionFound = 0;

    while (1) {
        positionFound = theArray.indexOf(theWord, positionFound);
        if (positionFound >= 0) {
            result += 1;
            positionFound += theWord.length-1;
        } else {
            break;
        }
    }


    console.log(result);
}