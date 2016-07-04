function replaceTags(args) {
    var text = args[0],
        searchFor = /<a href="(.*?)">(.*?)<\/a>/gi;

        text = text.replace(searchFor, '[$2]($1)');
    
    console.log(text);
}

/*
var re = /(\w+)\s(\w+)/;
var str = 'John Smith';
str.replace(re, '$2, $1'); // "Smith, John"
RegExp.$1; // "John"
RegExp.$2; // "Smith"
*/