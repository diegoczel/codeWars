fn main() {
    println!("{:?}", valid_parentheses(&"(())"));
}

fn valid_parentheses(parens: &str) -> bool {
    let mut r: Vec<u8> = Vec::new();

    for x in parens.bytes() {
        if r.len() == 0 {
            r.push(x);
        } else {
            match r.last() {
                Some(s) => {
                    if *s == b'(' && x == b')' {
                        r.pop();
                    } else {
                        r.push(x);
                    }
                },
                _ => {}
            }
        }
    }

    r.len() == 0
}

#[cfg(test)]
mod tests {
    use super::*;
    
    fn do_test(expected: bool, input: &str) {
        assert_eq!(valid_parentheses(input), expected, "\nYour result (left) did not match the expected output (right) for the input: {input:?}");
    }

    #[test]
    fn valid_cases() {
        do_test(true, "()");
        do_test(true, "((()))");
        do_test(true, "()()()");
        do_test(true, "(()())()");
        do_test(true, "()(())((()))(())()");
    }
    
    #[test]
    fn invalid_cases()  {
        do_test(false, ")(");
        do_test(false, "()()(");
        do_test(false, "((())");
        do_test(false, "())(()");
        do_test(false, ")()");
        do_test(false, ")");
    }
    
    #[test]
    fn empty_string() {
        do_test(true, "");
    }
}