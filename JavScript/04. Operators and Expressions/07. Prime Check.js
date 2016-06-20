function PrimeCheck(args) {
    var n = args[0] | 0;
    if (n < 2) {
        return false;
    }
    else {
        var primeCount = 0;
        for (var i = 1; i <= Math.sqrt(n); i += 1) {
            if (n % i === 0) {
                primeCount++;
            }
        }
        if (primeCount > 2) {
            return false;
        }
        else {
            return true;
        }
    }
}
