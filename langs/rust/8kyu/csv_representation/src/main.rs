fn main() {
    to_csv_text(&vec![
        vec![0, 1, 2, 3, 45],
        vec![10, 11, 12, 13, 14],
        vec![20, 21, 22, 23, 24],
        vec![30, 31, 32, 33, 34]
    ]);
}

fn to_csv_text(array: &[Vec<i8>]) -> String {
    let mut s = "".to_string();
    for r in 0..array.len() - 1 {

        for c in 0..array[0].len() - 1 {
            s.push_str(&array[r][c].to_string());
            s.push_str(",");
        }
        s.push_str(&array[r][array[0].len() - 1].to_string());
        s.push_str("\n");

    }
    for last in 0..array[0].len() - 1 {
        s.push_str(&array[array.len() - 1][last].to_string());
        s.push_str(",");
    }
    s.push_str(&array[array.len() - 1][array[0].len() - 1].to_string());

    s
}

#[cfg(test)]
mod tests {
    use super::to_csv_text;

    #[test]
    fn codewars_fixed_tests() {
        assert_eq!(
            to_csv_text(&vec![
                vec![0, 1, 2, 3, 45],
                vec![10, 11, 12, 13, 14],
                vec![20, 21, 22, 23, 24],
                vec![30, 31, 32, 33, 34]
            ]),
            "0,1,2,3,45\n10,11,12,13,14\n20,21,22,23,24\n30,31,32,33,34"
        );

        assert_eq!(
            to_csv_text(&vec![
                vec![-25, 21, 2, -33, 48],
                vec![30, 31, -32, 33, -34]
            ]),
            "-25,21,2,-33,48\n30,31,-32,33,-34"
        );

        assert_eq!(
            to_csv_text(&vec![
                vec![5, 55, 5, 5, 55],
                vec![6, 6, 66, 23, 24],
                vec![127, 31, 66, 33, 7]
            ]),
            "5,55,5,5,55\n6,6,66,23,24\n127,31,66,33,7"
        );
    }
}