const filterItem = (item) => {
  // when item is empty, null or undefined
  if(!item) return false;
  let firstPos = item.indexOf("!");
  
  if(firstPos === -1) return true; // not contais !
  // true if contains more than one !
  // false if contains one !
  return item.indexOf("!", firstPos + 1) !== - 1;
};
const remove = (str) => str.split(' ').filter(filterItem).join(' ');
console.log(remove("Hi!"));
console.log(remove("Hi! Hi!"));
console.log(remove("Hi! Hi! Hi!"));
console.log(remove("Hi a Hi! Hi!"));
console.log(remove("Hi! !Hi Hi!"));
console.log(remove("Hi! Hi!! Hi!"));
console.log(remove("Hi! !Hi! Hi!"));