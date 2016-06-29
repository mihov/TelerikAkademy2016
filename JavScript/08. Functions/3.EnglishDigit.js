console.log(EnglishDigit(['1234']));

function EnglishDigit(params) {
    var n = params[0];
    n = +n[n.length - 1];
    switch (n) {
        case 1: return 'one';
        case 2: return 'two';
        case 3: return 'three';
        case 4: return 'four';
        case 5: return 'five';
        case 6: return 'six';
        case 7: return 'seven';
        case 8: return 'eight';
        case 9: return 'nine';
        default: return 'zero';
    }
}