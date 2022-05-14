mergeInto(LibraryManager.library, {

    ShareFB: function (str) {
      var text = UTF8ToString(str)
      url = 'https://www.facebook.com/sharer/sharer.php?' +
      'u=https://learnukraine.github.io' +
      '&picture=https://learnukraine.github.io/logo.png' +
  //    '&title=TITLE!' +
      '&quote=' + text;
  //    '&description=""';
      options = 'toolbar=0,status=0,resizable=1,width=626,height=436'; 
      window.open(url,'sharer',options);  
    },
    
      ShareTwitter: function (str) {
        var text = UTF8ToString(str)
        // Opens a pop-up with twitter sharing dialog
        var shareURL = "http://twitter.com/share?"; //url base
        //params
        var params = {
          url: "https://learnukraine.github.io/ \n\n", 
          text: text,
  //        via: "sometwitterusername",
          hashtags: "LearnUkraine"
        }
        for(var prop in params) shareURL += '&' + prop + '=' + encodeURIComponent(params[prop]);
        window.open(shareURL, '', 'left=0,top=0,width=550,height=450,personalbar=0,toolbar=0,scrollbars=0,resizable=0');
    },
  });
  