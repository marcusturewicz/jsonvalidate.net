window.clipboard = {
  copy: function (text) {
    return navigator.clipboard.writeText(text);
  }
};
