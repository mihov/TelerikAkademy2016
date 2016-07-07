function name(params) {

    var data = JSON.parse(params[0]),
        template = params[1],
        insertArr = '',
        substr = "";


    for (var prop in data) {

        insertArr = new RegExp('#{' + prop + '}', 'g');

        substr = data[prop];
        template = template.replace(insertArr, substr);
    }
    console.log(template);
}

name([
    '{ "name": "John", age: 13 }', // options as JSON
    'My name is #{name} and I am #{age}-years-old' // template
]);
