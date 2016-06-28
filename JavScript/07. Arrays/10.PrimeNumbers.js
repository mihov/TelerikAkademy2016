var arr0 = ['30'];
console.log(solve(arr0));

function solve(args) {
    var n = +args[0];
    for (var i = n; i>3; i-=1) {
      if (chechPrime(i)) {
        console.log(i);
        break;
      }
    }


    function chechPrime(a) {
        for (var i = 2; i <= Math.sqrt(a); i++) {
            if (a % i === 0) {
                return false;
            }
        }
        return true;
    }
}


/*
function primeNumber(params) {
    var n = params[0] | 0;
    var i, j;
    // true-table
    var prime = [];
    for (i = 0; i <= n; i += 1) prime.push(true); // mark 'numbers' 0..n as 'true'

    // mark for swipe
    for (i = 2; i <= n; i += 1) {
        if (prime[i]) {
            for (j = i * i; j <= n; j += i) {
                prime[j] = false; // eliminate all none prime numbers and mark them as 'false'
            }
        }
    }

    // extract primes

    for (i = n; i > 0; i -= 1) { // 'zero' and 'one' is not prime
        if (prime[i]) return i; // get all primes from 2..n
    }
}*/