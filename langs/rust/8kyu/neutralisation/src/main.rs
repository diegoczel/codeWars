fn main() {
    println!("{}", neutralise("+-+-", "----"));
}

fn neutralise(s1: &str, s2: &str) -> String {
    s1.bytes()
        .zip(s2.bytes())
        .map(|(x, y)| {
            match (x, y)  {
                (b'+', b'+') => "+",
                (b'-', b'-') => "-",
                _ => "0"
            }
        })
        .collect::<String>()
}

#[cfg(test)]
mod tests {
    use crate::neutralise;

    #[test]
    fn codewars_test1() {
        assert_eq!(
            neutralise("--++--", "++--++"),
            "000000".to_string()
        );
    }

    #[test]
    fn codewars_test2() {
        assert_eq!(
            neutralise("-+-+-+", "-+-+-+"),
            "-+-+-+".to_string()
        );
    }

    #[test]
    fn codewars_test3() {
        assert_eq!(
            neutralise("-++-", "-+-+"),
            "-+00".to_string()
        );
    }

    #[test]
    fn codewars_test4() {
        assert_eq!(
            neutralise("+-+", "+--"),
            "+-0".to_string()
        );
    }

}