fn main() {
    println!("{:?}", product_array(&[12,20]));
}

fn product_array(arr: &[u64]) -> Vec<u64> {
    let mut s: u64 = 1;
    let mut r = vec![0; arr.len()];

    for x in 0..arr.len() {
        s *= arr[x];
    }

    for x in 0..arr.len() {
        r[x] = s / arr[x];
    }

    r
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn basic() {
        assert_eq!(product_array(&[12,20]), [20,12]);
        assert_eq!(product_array(&[3,27,4,2]), [216,24,162,324]);
        assert_eq!(product_array(&[13,10,5,2,9]), [900,1170,2340,5850,1300]);
        assert_eq!(product_array(&[16,17,4,3,5,2]), [2040,1920,8160,10880,6528,16320]);
    }
}