function name(params) {
    var html = params[1];
    var data = params[0];

    console.log(html.bind(data));

    String.prototype.bind = function (obj) {
        var property,
            reContent,
            reHref,
            reClass,
            result = this;

        for (property in obj) {
            reContent = new RegExp('(<.*data-bind-content="' + property + '".*>)(.*)(<.*>)', 'gi'),
                reHref = new RegExp('(<.*data-bind-href="' + property + '")', 'gi'),
                reClass = new RegExp('(data-bind-class="' + property + '")', 'gi');

            result = result.replace(reContent, function (none, opening, content, closing) {
                content = obj[property];
                return opening + content + closing;
            })
                .replace(reHref, function (none, content) {
                    return content + ' href="' + obj[property] + '"';
                })
                .replace(reClass, 'data-bind-class="' + obj[property] + '"');
        }
        return result;
    };

};