fn main() {
    println!("{:?}", alternate(10, "true", "false"));
}

fn alternate<'a>(n: usize, first_value: &'a str, second_value: &'a str) -> Vec<&'a str> {
    if n == 0 { return Vec::new(); }
    
    let mut control = true;

    (0..n).map(|_| {
        if control {
            control = false;
            first_value
        } else {
            control = true;
            second_value
        }
    }).collect()
}

#[cfg(test)]
mod tests {
    use super::alternate;

    #[test]
    fn sample_tests() {
        assert_eq!(alternate(5, "true", "false"), ["true", "false", "true", "false", "true"]);
        assert_eq!(alternate(20, "blue", "red"), ["blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red"]);
        let empty_vec:Vec<String> = Vec::new();
        assert_eq!(alternate(0, "lemons", "apples"), empty_vec);
    }
}