fn main() {
    println!("{:?}", closing_in_sum(121));
}

fn closing_in_sum(n: u64) -> u32 {
    let arr: Vec<u32> = n.to_string().chars()
        .map(
            |x| match x.to_digit(10) {
                Some(y) => y,
                None => 0,
            }
        )
        .collect();

    let mut s: u32 = 0;
     if arr.len() % 2 == 0 {
        for i in 0..arr.len() / 2 {
            s += arr[i] * 10 + arr[arr.len() - 1 - i];
        }
    }
    else {
        for i in 0..(arr.len() - 1) / 2 {
            s += arr[i] * 10 + arr[arr.len() - 1 - i];
        }  
        s += arr[(arr.len() - 1) / 2];
    }

    s
}


#[cfg(test)]
mod tests {
    use super::closing_in_sum;
        
    fn dotest(n: u64, expected: u32) {
        let actual = closing_in_sum(n);
        assert!(actual == expected, 
            "With n = {n}\nExpected {expected} but got {actual}")
    }

    #[test]
    fn fixed_tests() {
        dotest(1039, 22);
        dotest(121, 13);
        dotest(1039, 22);
        dotest(22225555, 100);
        dotest(2520, 72);
        dotest(5332824166496569, 331);
        dotest(1979672314137318116, 485);
        dotest(1795459644013947776, 548);
        dotest(2801980378842185820, 426);
        dotest(3440584288422776554, 430);
        dotest(1985124000275401986, 342);
    }
}