fn main() {
    println!("{:?}", flick_switch(&vec!["codewars", "flick", "code", "wars"]));
}

fn flick_switch(list: &[&str]) -> Vec<bool> {
    if list.len() == 0 {
        return Vec::new();
    }

    let mut control_of_bool: bool = true;

    list.iter().map(|x| {
        match x {
            &"flick" => {
                control_of_bool = !control_of_bool;
                control_of_bool
            },
            _ => control_of_bool,
        }
    })
    .collect::<Vec<bool>>()

}

#[cfg(test)]
mod tests {
    use crate::flick_switch;

    #[test]
    fn codewars_test1() {
        assert_eq!(
            flick_switch(&vec!["codewars", "flick", "code", "wars"]),
            vec![true, false, false, false]
        );
    }

    #[test]
    fn codewars_test2() {
        assert_eq!(
            flick_switch(&vec!["flick", "chocolate", "adventure", "sunshine"]),
            vec![false, false, false, false]
        );
    }

    #[test]
    fn codewars_test3() {
        assert_eq!(
            flick_switch(&vec!["bicycle", "jarmony", "flick", "sheep", "flick"]),
            vec![true, true, false, false, true]
        );
    }
    
}