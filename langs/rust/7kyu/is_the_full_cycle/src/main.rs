fn main() {
    println!("Hello, world!");
}

fn full_cycle(lst: &[usize]) -> bool {
    let mut index: usize = lst[0];
    let mut cycle: usize = 1;

    while cycle < lst.len() {
        if index == 0 && cycle < lst.len() { return false; }

        index = lst[index];
        cycle += 1;
    }

    index == 0 
}

#[cfg(test)]
mod tests {
    use super::full_cycle;
        
    fn dotest(lst: &[usize], expected: bool) {
        let actual = full_cycle(lst);
        assert!(actual == expected, 
            "With lst = {lst:?}\nExpected {expected} but got {actual}")
    }

    #[test]
    fn fixed_tests() {
        dotest(&[0, 1], false);
        dotest(&[1, 0], true);
        dotest(&[2, 1, 0], false);
        dotest(&[2, 0, 1], true);
        dotest(&[1, 2, 0, 3], false);
        dotest(&[3, 2, 0, 1], true);
        dotest(&[4, 1, 2, 3, 0], false);
        dotest(&[2, 0, 4, 1, 3], true);
        dotest(&[1, 3, 4, 0, 5, 2], false);
        dotest(&[1, 5, 4, 2, 0, 3], true);
        dotest(&[1, 5, 4, 2, 0, 3, 6], false);
        dotest(&[6, 8, 3, 0, 2, 7, 4, 1, 5], false);
        dotest(&[2, 8, 5, 9, 1, 3, 7, 4, 0, 6], true);
        dotest(&[2, 17, 7, 19, 18, 9, 5, 15, 16, 8, 11, 6, 14, 4, 3, 13, 0, 12, 1, 10], true);
        dotest(&[21, 18, 19, 14, 8, 0, 9, 2, 1, 3, 7, 4, 5, 10, 13, 12, 6, 17, 11, 15, 20, 16], false);
    }
}