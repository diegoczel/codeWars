fn main() {
    println!("2  {}, {}", is_esthetic(9, 2), base10_to_basex(9, 2));
    println!("3  {}, {}", is_esthetic(9, 3), base10_to_basex(9, 3));
    println!("4  {}, {}", is_esthetic(9, 4), base10_to_basex(9, 4));
    println!("5  {}, {}", is_esthetic(9, 5), base10_to_basex(9, 5));
    println!("6  {}, {}", is_esthetic(9, 6), base10_to_basex(9, 6));
    println!("7  {}, {}", is_esthetic(9, 7), base10_to_basex(9, 7));
    println!("8  {}, {}", is_esthetic(9, 8), base10_to_basex(9, 8));
    println!("9  {}, {}", is_esthetic(9, 9), base10_to_basex(9, 9));
    println!("10 {}, {}", is_esthetic(9, 10), base10_to_basex(9, 10));

    println!("");

    println!("9 {:?}", esthetic(9));
}

fn esthetic(num: u32) -> Vec<u8> {
    let mut r: Vec<u8> = Vec::new();
    for base in 2..=10 {
        if is_esthetic(num, base) {
            r.push(base as u8);
        }
    }

    r
}

fn is_esthetic(num: u32, base: u32) -> bool {
    let mut x = num;
    let mut m = 0;

    let mut r: Vec<u32> = Vec::new();
    while x != 0 {
        m = x % base;
        x = x / base;
        r.push(m);
    }

    if r.len() == 0 { return false; } 

    for ind in 0..r.len() - 1 {
        if r[ind].abs_diff(r[ind + 1]) != 1 {
            return false;
        }
    }

    true
}

fn base10_to_basex(num: u32, base: u32) -> u32 {
    let mut x = num;
    let mut p = 0;
    let mut m = 0;
    let mut r:u32 = 0;

    while x != 0 {
        m = x % base;
        x = x / base;
        r += m * 10u32.pow(p);
        p += 1;
    }

    r
}


#[cfg(test)]
mod tests {
    use super::{esthetic, base10_to_basex, is_esthetic};
        
    fn dotest(num: u32, expected: &[u8]) {
        let actual = esthetic(num);
        assert!(actual == expected, 
            "With num = {num}\nExpected {expected:?} but got {actual:?}")
    }

    #[test]
    fn fixed_tests() {
        dotest(10, &[2, 3, 8, 10]);
        dotest(23, &[3, 5, 7, 10]);
        dotest(666, &[8]);
        dotest(13, &[5, 6]);
        dotest(1, &[2, 3, 4, 5, 6, 7, 8, 9, 10]);
        dotest(9, &[4, 7, 9, 10]);
        dotest(74, &[]);
        dotest(740, &[4, 6, 9]);
        dotest(928, &[]);
        dotest(259259, &[9]);
        dotest(883271, &[]);
        dotest(1080898, &[7]);
        dotest(1080899, &[]);
    }

    #[test]
    fn base10_to_basex_test() {
        assert_eq!(base10_to_basex(9, 4), 14);
    }

    #[test]
    fn is_esthetic_test() {
        assert_eq!(is_esthetic(9, 2), false);
        assert_eq!(is_esthetic(9, 3), false);
        assert_eq!(is_esthetic(9, 4), true);
        assert_eq!(is_esthetic(9, 5), false);
        assert_eq!(is_esthetic(9, 6), false);
        assert_eq!(is_esthetic(9, 7), true);
        assert_eq!(is_esthetic(9, 8), false);
        assert_eq!(is_esthetic(9, 9), true);
        assert_eq!(is_esthetic(9, 10), true);
    }
}
