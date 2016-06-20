function name(params) {
    var thirth = params[0]|0;
    thirth = ((thirth/100)|0)%10;
    if(thirth===7){return true; }else{return false +" "+thirth;}
}