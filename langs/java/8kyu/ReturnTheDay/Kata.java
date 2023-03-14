public class Kata {
	public static String getDay(int n) {
		if(n < 1 || n > 7) return "Wrong, please enter a number between 1 and 7";
		
		String [] days = new String[] {
			"Sunday", 
			"Monday", 
			"Tuesday",
			"Wednesday", 
			"Thursday", 
			"Friday",
			"Saturday"
		};
		return days[n - 1];
	}
}