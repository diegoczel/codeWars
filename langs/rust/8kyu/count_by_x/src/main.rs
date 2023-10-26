fn main() {
    println!("Hello, world!");
}

fn count_by(x: u32, n: u32) -> Vec<u32> {
    (1..=n).step_by(1).map(|f| f * x).collect()
}

#[cfg(test)]
mod tests {
    use super::count_by;
    #[test]
    fn test1() {
        assert_eq!(
            vec![1,2,3,4,5,6,7,8,9,10], 
            count_by(1, 10)
        );
        
        assert_eq!(
            vec![2,4,6,8,10], 
            count_by(2, 5)
        );
        
        assert_eq!(
            vec![3,6,9,12,15,18,21], 
            count_by(3, 7)
        );
        
        assert_eq!(
            vec![50,100,150,200,250], 
            count_by(50, 5)
        );

        assert_eq!(
            vec![100,200,300,400,500,600], 
            count_by(100, 6)
        );
    }
}