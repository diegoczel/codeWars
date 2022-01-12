function remove (string) {  
  // regex /!*$/g ->
  // ! target
  // * zero or more
  // $ at the end
  return string.replace(/!*$/g, '');
}