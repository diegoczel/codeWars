import static org.junit.jupiter.api.Assertions.*;

public class KataTest {
	@Test
	void getDay_InputZero_ReturnMessageWrong() {
		assertEquals("Wrong, please enter a number between 1 and 7", Kata.getDay(0));
	}
	
	@Test
	void getDay_InputEigth_ReturnMessageWrong() {
		assertEquals("Wrong, please enter a number between 1 and 7", Kata.getDay(8));
	}
	
	@Test
	void getDay_InputOne_ReturnSunday() {
		assertEquals("Sunday", Kata.getDay(1));
	}
	
	@Test
	void getDay_InputTwo_ReturnMonday() {
		assertEquals("Monday", Kata.getDay(2));
	}
	
	@Test
	void getDay_InputThree_ReturnTuesday() {
		assertEquals("Tuesday", Kata.getDay(3));
	}
	
	@Test
	void getDay_InputFour_ReturnWednesday() {
		assertEquals("Wednesday", Kata.getDay(4));
	}
	
	@Test
	void getDay_InputFive_ReturnThursday() {
		assertEquals("Thursday", Kata.getDay(5));
	}
	
	@Test
	void getDay_InputSix_ReturnFriday() {
		assertEquals("Friday", Kata.getDay(6));
	}
	
	@Test
	void getDay_InputSeven_ReturnSaturday() {
		assertEquals("Saturday", Kata.getDay(7));
	}
}