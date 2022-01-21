function oddOrEven(n) {
  if(n % 2 === 0) {
    // 4 / 2 is 2, that is Even
    // 1 3 | 2 4
    if(n / 2 % 2 === 0) {
      return EVEN;
    // 6 / 2 is 3, that is Odd
    // 1 3 5 | 2 4 6
    } else {
      return ODD;
    }
  }
  return EITHER;
}