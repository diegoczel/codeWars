const regex = /\b(?!code\b)\b(?!war\b)\w+/gi;
/*
\b(?!code\b)    \\first word that be ignored
\b(?!war\b)     \\second word that be ignored
\w+             \\match all words that is a combination of: [a-z][A-Z][0-9][_]

\b    \\start of word
(?!   \\ignore the group
code  \\word ignored
\b    \\end of word
)     \\end of group
*/

const tests = [
  "Regex is my favorite tool",
  "In JavaScript, You can write 1000 as 1_000, 10_00, 100_0, or 1_0_0_0",
  "There are no sym!bols bet@ween us!"
];
const results = [
  ["Regex", "is", "my", "favorite", "tool"],
  ["In", "JavaScript", "You", "can", "write", "1000", "as", "1_000", "10_00", "100_0", "or", "1_0_0_0"],
  ["There", "are", "no", "sym", "bols", "bet", "ween", "us"]
];

for(let x of tests) {
  console.log(x.match(regex));
}