function name(params) {

    var a = parseFloat(params[0]);
    var b = parseFloat(params[1]);
    var c = parseFloat(params[2]);

    var d = (Math.pow(b, 2) - (4 * a * c));
    var x1 = ((-b + Math.sqrt(d)) / (-2 * a)).toFixed(2);
    var x2 = ((-b - Math.sqrt(d)) / (-2 * a)).toFixed(2);

    if (d > 0) {
        //var x1 = ((-b - Math.sqrt(d)) / (-2 * a)).toFixed(2);
        //var x2 = ((-b + Math.sqrt(d)) / (2 * a)).toFixed(2);

        //if (x1 === n2) return "x1=x2=" + x1;

        if (x1 < x2) {
            return "x1=" + x1 + "; x2=" + x2;
        } else {
            return "x1=" + x2 + "; x2=" + x1;
        }
    }
    
    if (d === 0) {
        var x = ((-b) / (-2 * a)).toFixed(2);
        return ("x1=x2=" + x);
    }


    if (d < 0) {
        return ("no real roots");
    }
}

/*
a = quad.a_val.value 
b = quad.b_val.value
c = quad.c_val.value
root = Math.pow(b, 2) - 4 * a * c
answer1 = (-b + Math.sqrt(root)) / 2*a
answer2 = (-b - Math.sqrt(root)) / 2*a
     if(root<'0')
     {
     alert('This equation has no real solution.')
     }else{
              if(root=='0')
              {          
              quad.answerOne.value = answer1
              quad.answerTwo.value = 'No Second Answer'
              }else{
                   quad.answerOne.value = answer1
                   quad.answerTwo.value = answer2
                   }
          }
}
*/