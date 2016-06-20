function solve(args) {
    var theNum = args[0] | 0;
    if ((theNum % 5 === 0) && (theNum % 7 === 0)) {
        console.log(true + " " + theNum);
    } else {
        console.log(false + " " + theNum);
    }
}