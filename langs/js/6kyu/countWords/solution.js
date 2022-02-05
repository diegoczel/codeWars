function wordCount(s) {
  // capture all word's with one or more char
  let words = s.match(/[a-z]{1,}/gmi);
  // capture all word's with need remove.
  let exclude = words.join(' ').match(/\ba\b|\bthe\b|\bon\b|\bat\b|\bof\b|\bupon\b|\bin\b|\bas\b/gmi);
  // if exclude is null, then return length of words, else,
  // return words.length - exclude.length
  return words.length - ((exclude === null) ? 0 : exclude.length);
}
console.log(wordCount("Hello there, little user5453 374 ())$."));
console.log(wordCount("I’d been using my sphere as a stool. I traced counterclockwise circles on it with my fingertips and it shrank until I could palm it. My bolt had shifted while I’d been sitting. I pulled it up and yanked the pleats straight as I careered around tables, chairs, globes, and slow-moving fraas. I passed under a stone arch into the Scriptorium. The place smelled richly of ink. Maybe it was because an ancient fraa and his two fids were copying out books there. But I wondered how long it would take to stop smelling that way if no one ever used it at all; a lot of ink had been spent there, and the wet smell of it must be deep into everything."));
console.log(wordCount("hello there and a hi"));