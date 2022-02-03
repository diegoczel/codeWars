function isbnConverter(isbn) {
  const arr = [];
  
  isbn = '978-' + isbn;

  for(let ind = 0; ind < isbn.length; ind++) arr.push(isbn[ind]);

  arr.pop();

  // take 12 digits
  const digits = arr.filter((item) => isNaN(item) === false);

  // * alter by 1 or 3
  let checkDigit = digits.reduce(function (total, value, index) {
    value = Number(value);
    total = Number(total);
    if(index % 2 === 0) return total + value * 1;
    return total + value * 3;
  });

  // calculate the last digit
  checkDigit = (checkDigit % 10 === 0) ? 0 : 10 - (checkDigit % 10);

  arr.push(checkDigit);

  return arr.join('');
}

console.log(isbnConverter("1-85326-158-0"));//"978-1-85326-158-9"
console.log(isbnConverter("1-85326-158-9"));//'978-1-85326-158-9'
console.log(isbnConverter("0-14-143951-3"));//"978-0-14-143951-8"
console.log(isbnConverter("0-02-346450-X"));//"978-0-02-346450-8"
console.log(isbnConverter("963-14-2164-3"));//"978-963-14-2164-4"
console.log(isbnConverter("1-7982-0894-6"));//"978-1-7982-0894-6"
console.log(isbnConverter('540708-5-72-9'));