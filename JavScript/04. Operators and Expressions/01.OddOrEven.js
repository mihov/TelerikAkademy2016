function solve(args) {
    var  theNum = Number(args[0]);
    if (theNum % 2 === 0) {
        return "even " + theNum;
    } else {
        return "odd " + theNum;
    }
}