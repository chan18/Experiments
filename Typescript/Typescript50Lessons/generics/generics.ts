
/*

    URL is the browser’s built-in class of URLs.

*/

type VideoFormatURLs = {
    format360p: URL,
    format480p: URL,
    format720p: URL,
    format1080p: URL
}



// api for developers.
declare const videos: VideoFormatURLs
declare function loadFormat(format: string): void


// incoming formate valid key in DS.
function isFormatVailable(obj: VideoFormatURLs,key: string): 
        key is keyof VideoFormatURLs 
{
    return key in obj
}


//VideoFormatURLs
if(isFormatAvailable(videos, format)) {
    // format is now “format360p” | “format480p” |
    // “format720p” | “format1080p”
    // and index accessing perfectly works:
    videos[format]
}


// ---------------------

type SubtitleURLs = {
    english: URL,
    german: URL,
    french: URL
}

// validation function

function isSubtitleAvailable(
    obj: SubtitleURLs,
    key: string
): key is keyof SubtitleURLs {
    return key in obj
}

function isAvailable(obj, key) {
    return key in obj
}

