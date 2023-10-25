fn main() {
    println!("Hello, world!");
}

fn add_length(s: &str) -> Vec<String> {
    s.split(' ')
        .map(|x| format!("{} {}", x, x.len()))
        .collect()
}

#[cfg(test)]
mod tests {
    use super::add_length;

    #[test]
    fn test1() {
        assert_eq!(
            add_length("apple ban"), 
            ["apple 5", "ban 3"].iter().map(|x| x.to_string()).collect::<Vec<_>>()
        );

        assert_eq!(
            add_length("you will win"), 
            ["you 3", "will 4", "win 3"].iter().map(|x| x.to_string()).collect::<Vec<_>>()
        );
        
        assert_eq!(
            add_length("y"), 
            ["y 1"].iter().map(|x| x.to_string()).collect::<Vec<_>>()
        );
    }
}