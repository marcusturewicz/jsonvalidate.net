window.clipboard = {
  copy: function (text) {
    if (!navigator.clipboard) {
      var textArea = document.createElement("textarea");
      textArea.value = text;
      document.body.appendChild(textArea);
      textArea.focus();
      textArea.select();
      document.execCommand('copy');
      textArea.remove();
      return new Promise(() => {});
    }
    return navigator.clipboard.writeText(text);
  }
};
