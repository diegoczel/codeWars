import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

public class KataTest {
	public Player[] playersOne = new Player[] {
		new Player("diego")
	};
	
	public Player[] playersFive = new Player[] {
			new Player("diego"),
			new Player("cris"),
			new Player("tales"),
			new Player("kevin"),
			new Player("lili")
	};
	
	public Player[] playersEmpty = new Player[] {};
	
	@Test
	void duckDuckGoose_OnePlayer_ReturnItPlayer() {
		assertEquals("diego", Kata.duckDuckGoose(playersOne, 3));
	}
	
	@Test
	void duckDuckGoose_EmptyPlayer_ReturnEmptyStr() {
		assertEquals("", Kata.duckDuckGoose(playersEmpty, 3));
	}

	@Test
	void duckDuckGoose_GooserLessThanOne_ReturnEmptyStr() {
		assertEquals("", Kata.duckDuckGoose(playersOne, 0));
	}
	
	@Test
	void duckDuckGoose_FivePlayersGoose1_ReturnDiego() {
		assertEquals("diego", Kata.duckDuckGoose(playersFive, 1));
	}
	
	@Test
	void duckDuckGoose_FivePlayersGoose6_ReturnDiego() {
		assertEquals("diego", Kata.duckDuckGoose(playersFive, 6));
	}
	
	@Test
	void duckDuckGoose_FivePlayersGoose5_ReturnLili() {
		assertEquals("lili", Kata.duckDuckGoose(playersFive, 5));
	}
	
	@Test
	void duckDuckGoose_FivePlayersGoose10_ReturnLili() {
		assertEquals("lili", Kata.duckDuckGoose(playersFive, 10));
	}
}
