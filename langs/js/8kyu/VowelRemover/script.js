function shortcut(str) {
  if(!str) { return ''; } // when str is empty, null or undefined

  s = "";
  for(let x of str) {
    if(x.charCodeAt(0) === 97 ||  //a
      x.charCodeAt(0) === 101 ||  //e
      x.charCodeAt(0) === 105 ||  //i
      x.charCodeAt(0) === 111 ||  //o
      x.charCodeAt(0) === 117 ) { //u
      s += '';
    } else {
      s += x;
    }
  }
  return s;
}

/*
// Resposta da maioria dos malucos usando regex
function shortcut(string){
  return string.replace(/[aeiou]/g,'')
}
*/

console.log(shortcut(''));
console.log(shortcut('hello'));
console.log(shortcut('how are you today?'));
console.log(shortcut('complain'));
console.log(shortcut('never'));