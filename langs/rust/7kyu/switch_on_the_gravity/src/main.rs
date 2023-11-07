fn main() {
    println!(
        "{:?}", 
        switch_gravity(
            &[
                vec!['-', '#', '#', '-'],
                vec!['-', '-', '#', '-'],
                vec!['-', '-', '-', '-']
            ]
        )
    );
}

fn switch_gravity(lst: &[Vec<char>]) -> Vec<Vec<char>> {  
    let mut r = vec![vec!['-'; lst[0].len()]; lst.len()];

    for col in 0..lst[0].len() {
        let mut index = lst.len();
        for row in 0..lst.len() {
            if lst[row][col] == '#' {
                r[index - 1][col] = '#';
                index = index - 1;
            }
        }
    }

    r
}

#[cfg(test)]
mod tests {
    use super::switch_gravity;
        
    fn dotest(lst: &[Vec<char>], expected: Vec<Vec<char>>) {
        let actual = switch_gravity(lst);
        assert!(actual == expected, 
            "With lst = {lst:?}\nExpected {expected:?} but got {actual:?}")
    }

    #[test]
    fn fixed_tests() {
        /*
        dotest(&[
               vec!['-', '#', '#', '-'],
               vec!['-', '-', '#', '-'],
               vec!['-', '-', '-', '-'],
               ]
               , vec![
                 vec!['-', '-', '-', '-'],
                 vec!['-', '-', '#', '-'],
                 vec!['-', '#', '#', '-']
                    ]);
        
        dotest(&[
               vec!['-', '#', '#', '-'],
               vec!['-', '-', '#', '-'],
               vec!['-', '-', '-', '-'],
                ], 
            vec![
            vec!['-', '-', '-', '-'],
            vec!['-', '-', '#', '-'],
            vec!['-', '#', '#', '-']
                ]);
        dotest(&[
               vec!['-', '#', '#', '#', '#', '-'],
               vec!['#', '-', '-', '#', '#', '-'],
               vec!['-', '#', '-', '-', '-', '-'],
               vec!['-', '-', '-', '-', '-', '-']
                ], vec![
            vec!['-', '-', '-', '-', '-', '-'],
            vec!['-', '-', '-', '-', '-', '-'],
            vec!['-', '#', '-', '#', '#', '-'],
            vec!['#', '#', '#', '#', '#', '-']
        ]);
        dotest(&[
            vec!['-', '#', '#', '#', '#', '-'],
            vec!['#', '-', '-', '#', '#', '-'],
            vec!['-', '#', '-', '-', '-', '-'],
            vec!['-', '#', '-', '#', '-', '-']
        ], vec![
            vec!['-', '-', '-', '-', '-', '-'],
            vec!['-', '#', '-', '#', '-', '-'],
            vec!['-', '#', '-', '#', '#', '-'],
            vec!['#', '#', '#', '#', '#', '-']
        ]);
        dotest(&[
            vec!['-', '#', '#', '-'],
            vec!['-', '-', '#', '-'],
            vec!['#', '#', '-', '-'],
        ], vec![
            vec!['-', '-', '-', '-'],
            vec!['-', '#', '#', '-'],
            vec!['#', '#', '#', '-']
        ]);
         */
        dotest(&[
            vec!['#'],
            vec!['-'],
            vec!['#'],
            vec!['-']
        ], vec![
            vec!['-'],
            vec!['-'],
            vec!['#'],
            vec!['#']
        ]);
        dotest(&[
            vec!['#'],
            vec!['#'],
            vec!['#'],
            vec!['#']
        ], vec![
            vec!['#'],
            vec!['#'],
            vec!['#'],
            vec!['#']
        ]);
        
    }
}