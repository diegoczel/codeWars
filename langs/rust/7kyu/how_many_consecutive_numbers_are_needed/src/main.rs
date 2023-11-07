fn main() {
    println!("{}", consecutive(&[1, 2, 3]));
}

fn consecutive(xs: &[i16]) -> i16 {
    if xs.len() < 2 { return 0 };

    let mut num_min = std::i16::MAX;
    let mut num_max = std::i16::MIN;

    for i in 0..xs.len() {
        if xs[i] < num_min { num_min = xs[i]; }
        if xs[i] > num_max { num_max = xs[i]; }
    }

    (num_max - num_min + 1) - (xs.len() as i16)
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn basic() {
        assert_eq!(consecutive(&[4,8,6]), 2);
        assert_eq!(consecutive(&[1,2,3,4]), 0);
        assert_eq!(consecutive(&[]), 0);
        assert_eq!(consecutive(&[1]), 0);
    }
}