fn main() {
    println!("{:?}", convert_lojban(&"civozeno"));
}

fn convert_lojban(input: &str) -> u64 {
    let v: Vec<char> = input.chars().collect();

    let mut r :u64 = 0;
    let mut p :u32 = v.len() as u32 / 2; // control pow

    for x in (0..v.len()).step_by(2) {
        p -= 1;
        r += lojban_to_u64(v[x], v[x+1], p);
    }

    r
}

fn lojban_to_u64(c1: char, c2: char, pow: u32) -> u64 {
    /*
    Example of calc of "civozeno" using pow.

    "civozeno" has 4 digits
    ci -> 3 -> 3 * 1000 = 3000
    vo -> 4 -> 4 *  100 =  400
    ze -> 7 -> 7 *   10 =   70
    no -> 0 -> 0 *    1 =    0
    sum of is 3470
    */
    match (c1, c2) {
        ('p', 'a') => 1 * 10u64.pow(pow),
        ('r', 'e') => 2 * 10u64.pow(pow),
        ('c', 'i') => 3 * 10u64.pow(pow),
        ('v', 'o') => 4 * 10u64.pow(pow),
        ('m', 'u') => 5 * 10u64.pow(pow),
        ('x', 'a') => 6 * 10u64.pow(pow),
        ('z', 'e') => 7 * 10u64.pow(pow),
        ('b', 'i') => 8 * 10u64.pow(pow),
        ('s', 'o') => 9 * 10u64.pow(pow),
        ('n', 'o') => 0 * 10u64.pow(pow),
        _ => 0,
    }
}

#[test]
fn static_tests() {
    assert_eq!(convert_lojban("no"), 0);
    assert_eq!(convert_lojban("sobi"), 98);
    assert_eq!(convert_lojban("muxa"), 56);
    assert_eq!(convert_lojban("zexamu"), 765);
    assert_eq!(convert_lojban("vocirepa"), 4321);
    assert_eq!(convert_lojban("civozeno"), 3470);
    assert_eq!(convert_lojban("renonore"), 2002);
    assert_eq!(convert_lojban("panonononononono"), 10000000);
}