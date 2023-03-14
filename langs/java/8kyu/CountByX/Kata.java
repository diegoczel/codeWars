public class Kata {
	public static void main(string [] args) {
		
	}
	
	public static int[] countBy(int x, int n) {
		int [] result = new int[n];
		for(int ind = 1; ind <= n; ind++) {
			result[ind - 1] = x * ind;
		}
		return result;
	}
}