fn main() {
    println!("{}", quarter_of(1));
}

fn quarter_of(month: u8) -> u8 {
    match month {
        1..=3 => 1,
        4..=6 => 2,
        7..=9 => 3,
        10..=12 => 4,
        _ => 0,
    }
}

#[cfg(test)]
mod tests {
    use super::quarter_of;

    #[test]
    fn test1() {
        assert_eq!(quarter_of(1), 1);
        assert_eq!(quarter_of(3), 1);
    }

    #[test]
    fn test2() {
        assert_eq!(quarter_of(4), 2);
        assert_eq!(quarter_of(6), 2);
    }

    #[test]
    fn test3() {
        assert_eq!(quarter_of(7), 3);
        assert_eq!(quarter_of(9), 3);
    }

    #[test]
    fn test4() {
        assert_eq!(quarter_of(10), 4);
        assert_eq!(quarter_of(12), 4);
    }

    #[test]
    fn test5() {
        assert_eq!(quarter_of(0), 0);
        assert_eq!(quarter_of(13), 0);
    }
}