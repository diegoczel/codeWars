fn main() {
    println!("Hello, world!");
}

fn each_cons(arr: &[u8], n: usize) -> Vec<Vec<u8>> {
    //if arr.len() == 0  { return Vec::new() }; // in test of codewars
    if arr.len() == 0 || n > arr.len() { return vec![vec![]] };

    (0..=arr.len()-n)
        .map(|x| {
            (x..x+n).map(|y| arr[y]).collect()
        })
        .collect()
}

#[cfg(test)]
mod test {
    use super::*;
    #[test]
    fn test1() {
        assert_eq!(
            each_cons(&[3, 5, 8, 13], 1), 
            vec![vec![3], vec![5], vec![8], vec![13]]
        );
    }

    #[test]
    fn test2() { 
        assert_eq!(
            each_cons(&[3, 5, 8, 13], 2), 
            vec![vec![3, 5], vec![5, 8], vec![8, 13]]
        );
    }

    #[test]
    fn test3() {     
        assert_eq!(
            each_cons(&[3, 5, 8, 13], 3), 
            vec![vec![3, 5, 8], vec![5, 8, 13]]
        );
    }

    #[test]
    fn test4() {     
        assert_eq!(
            each_cons(&[], 0), 
            vec![vec![]]
        );
    }

    #[test]
    fn test5() {
        assert_eq!(
            each_cons(&[3, 5, 8, 13, 15], 3), 
            vec![vec![3, 5, 8], vec![5, 8, 13], vec![8, 13, 15]]
        );
    }
}
