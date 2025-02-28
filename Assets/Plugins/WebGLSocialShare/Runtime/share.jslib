mergeInto(LibraryManager.library, {
    ShareFB: function (text, link) 
    {
        var shareURL = 'https://www.facebook.com/sharer/sharer.php?';
        if (link != undefined)
        {
            shareURL += '&u=' + UTF8ToString(link);
        }
        if (text != undefined)
        {
            shareURL += '&quote=' + UTF8ToString(text);
        }
        options = 'width=550,height=450,personalbar=0,toolbar=0,scrollbars=0,resizable=0'; 
        window.open(shareURL, 'sharer', options);  
    },
    
    ShareTwitter: function (text, link, hashtag) 
    {
        var shareURL = 'http://twitter.com/share?';
        if (link != undefined)
        {
            shareURL += '&url=' + UTF8ToString(link);
        }
        if (text != undefined)
        {
            shareURL += '&text=' + UTF8ToString(text);
        }
        if (hashtag != undefined)
        {
            shareURL += '&hashtags=' + UTF8ToString(hashtag);
        }
        options = 'width=550,height=450,personalbar=0,toolbar=0,scrollbars=0,resizable=0'; 
        window.open(shareURL, 'sharer', options);  
    },
  });
  