function translate(speech, vocabulary) {
  if(!speech || !vocabulary) return ''; // when arg's is null or empty or undefined

  const speechArr = speech.match(/[\*a-z]+/gm);

  for(let s of speechArr) {
    let sRegex = s;
    while(sRegex.indexOf('*') !== -1) sRegex = sRegex.replace('*', '.');

    let pattern = new RegExp(sRegex, 'g');

    // find a word into vocabulary for change it
    for(let v of vocabulary) {
      if(sRegex.length === v.length && pattern.test(v)) {
        speech = speech.replace(s, v);
        break;
      }
    }
  }
  return speech;
}

translate( 
  "*ow ****v* **** ****u oq**y *t***. s*opq. qro***, q*x", 
  ["ooqqu","ptqqq","qqqovq","qpqq","qpx","oqqqy","qropoo","sqopq","qow"]);
console.log('qow qqqovq qpqq ooqqu oqqqy ptqqq. sqopq. qropoo, qpx');
/*

translate("***lo w***d!", ["hello", "world"]);
translate("c**l, w*ak!", ["hell", "cell", "week", "weak"]);
translate("hell*, w***d!", ["hello", "hell", "word", "world"]);
translate("***", ["mel", "dell"]);
translate("", ["hell", "weak"]);
translate("****. ***,", ["aaa", "bbbb"]);
translate( 
  "*ow ****v* **** ****u oq**y *t***. s*opq. qro***, q*x", 
  ["ooqqu","ptqqq","qqqovq","qpqq","qpx","oqqqy","qropoo","sqopq","qow"]);
*/