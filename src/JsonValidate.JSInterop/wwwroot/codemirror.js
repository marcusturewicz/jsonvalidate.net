var cm;

window.codemirror = {
    create: function (textArea) {
        cm = CodeMirror.fromTextArea(textArea, {
            mode: { name: 'javascript', json: true },
            lineNumbers: true,
            tabSize: 2
        });
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
    },
    setOption: function (key, value) {
        cm.setOption(key, value);
    },
    highlight: function (fromLine, fromChar, toLine, toChar, isLightTheme) {
        cm.doc.markText({ line: fromLine, ch: fromChar }, { line: toLine, ch: toChar }, {
            css: `background: ${isLightTheme ? '#81dee4' : '#7E211B'}`
        })
    }
};