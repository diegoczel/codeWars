public class Kata {
	public static String duckDuckGoose(Player[] players, int goose) {
		if(players.length == 0 || goose < 1) return "";
		
		return players[(goose - 1) % players.length].name;
	}
}