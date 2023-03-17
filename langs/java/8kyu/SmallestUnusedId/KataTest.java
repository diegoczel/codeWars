import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class KataTest {

	@Test
	public void nextId_NegativeValueInArray_ShouldReturn0() {
		assertEquals(0, Kata.nextId(new int[] {0, -1, 15}));
	}
	
	@Test
	public void nextId_EmptyArray_ShouldReturn0() {
		assertEquals(0, Kata.nextId(new int[] {}));
	}
	
	@Test
	public void nextId_InputArray_ShouldReturn1() {
		assertEquals(1, Kata.nextId(new int[] {5, 0, 3, 8}));
	}
	
	@Test
	public void nextId_InputArray_ShouldReturn4() {
		assertEquals(4, Kata.nextId(new int[] {1, 0, 3, 2}));
	}
	
	@Test
	public void nextId_InputEqualElementsIntArray_ShouldReturn0() {
		assertEquals(0, Kata.nextId(new int[] {3, 3, 3, 3}));
	}
	
	@Test
	public void nextId_InputEqualElementsIntArray2_ShouldReturn0() {
		assertEquals(1, Kata.nextId(new int[] {0, 0, 0, 0}));
	}

}