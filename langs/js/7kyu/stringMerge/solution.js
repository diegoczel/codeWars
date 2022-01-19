function stringMerge(str1, str2, letter){
  return str1.substr(0, str1.indexOf(letter)) + str2.substr(str2.indexOf(letter));
}

console.log(stringMerge("hello", "world", "l"));
console.log(stringMerge("coding", "anywhere", "n"));
console.log(stringMerge("jason", "samson", "s"));
console.log(stringMerge("wonderful", "people", "e"));