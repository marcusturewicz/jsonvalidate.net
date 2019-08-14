var cm;

window.codemirror = {
    create: function (textArea) {
        cm = CodeMirror.fromTextArea(textArea, {
            mode: { name: 'javascript', json: true },
            lineNumbers: true,
            tabSize: 2
        });
        return null;
    },
    clear: function () {
        cm.doc.setValue('');
    },
    getValue: function () {
        var value = cm.doc.getValue();
        return value;
    },
    setValue: function (value) {
        cm.doc.setValue(value);
        return null;
    },
    highlight: function (fromLine, fromChar, toLine, toChar)
    {
        cm.doc.markText({line: fromLine, ch: fromChar}, {line: toLine, ch: toChar}, {
            css: "background: #81dee4"
        })
    }
};