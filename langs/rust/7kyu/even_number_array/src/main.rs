fn main() {
    println!("{:?}", even_numbers(&vec![1, 2, 3, 4], 2));
}

fn even_numbers(array: &Vec<i32>, number: usize) -> Vec<i32> {
    let mut r = vec![0_i32; number];
    let mut index = number;

    for x in (0..array.len()).rev() {
        if array[x] % 2 == 0 {
            if index == 0 {
                break;
            }
            
            r[index - 1] = array[x];
            index -= 1;
        }
    }

    r
}

#[cfg(test)]
mod tests {
    use super::*;
    
    #[test]
    fn sample_tests() {
        assert_eq!(even_numbers(&vec!(1, 2, 3, 4, 5, 6, 7, 8, 9), 3), vec!(4, 6, 8));
        assert_eq!(even_numbers(&vec!(-22, 5, 3, 11, 26, -6, -7, -8, -9, -8, 26), 2), vec!(-8, 26));
        assert_eq!(even_numbers(&vec!(6, -25, 3, 7, 5, 5, 7, -3, 23), 1), vec!(6));
    }   

}
