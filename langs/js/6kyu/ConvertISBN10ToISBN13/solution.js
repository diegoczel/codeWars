function isbnConverter(isbn) {
  const arr = [];
  
  isbn = '978-' + isbn;

  for(let ind = 0; ind < isbn.length; ind++) arr.push(isbn[ind]);

  console.log(arr);
  
  console.log(arr.pop());

  return isbn;
}

isbnConverter("1-85326-158-0");