function removeParentheses(s){
  if(!s) return ''; // empty, null or undefined

  /*
  \(    // start of match
  [^()] // ignore () inside of match, for capture only (*), not (*))
  *     // 0 or more char into ()
  \)    // end of match
  */
  let regex = /\([^()]*\)/g;
  let sAux = s;
  
  while(regex.test(sAux)) {
    let captures = sAux.match(regex);
    for(let capture of captures) {
      sAux = sAux.replace(capture, '');
    }
  }
  return sAux;
}
removeParentheses("example (unwanted thing) example");
removeParentheses("a (bc d)e");
removeParentheses("a(b(c))");
removeParentheses("hello example (words(more words) here) something");
removeParentheses("(first group) (second group) (third group)");
removeParentheses("((()))");
removeParentheses("((()()))");
removeParentheses("()");
