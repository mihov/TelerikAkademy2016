function name(params) {
    if (parseFloat(params[0]) > parseFloat(params[1])) {
        return params[1] +" "+params[0];
    }
    else{
        return params[0] +" "+params[1];
    }
}