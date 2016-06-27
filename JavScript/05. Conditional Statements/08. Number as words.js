function name(params) {
    var result = "";
    var value = parseInt(params[0]);
    if (value < 13) {
        switch (value) {
            case 0: result = "zero"; break;
            case 1: result = "one"; break;
            case 2: result = "two"; break;
            case 3: result = "three"; break;
            case 4: result = "four"; break;
            case 5: result = "five"; break;
            case 6: result = "six"; break;
            case 7: result = "seven"; break;
            case 8: result = "eight"; break;
            case 9: result = "nine"; break;
            case 10: result = "seven"; break;
            case 11: result = "eight"; break;
            case 12: result = "nine"; break;
            default: result = "not a digit"; break;
        }
    }

    result = result[0].toUpperCase() + result.substr(1);

    return result;
}