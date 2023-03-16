import static org.junit.jupiter.api.Assertions.*;

public class KataTest {
    @Test
    public void tripleTrouble_EmptyArgOne_ShouldReturnEmptyStr()
    {
        assertEquals("", Kata.tripleTrouble("", "a", "b"));
    }
    
    @Test
    public void tripleTrouble_EmptyArgTwo_ShouldReturnEmptyStr()
    {
        assertEquals("", Kata.tripleTrouble("c", "", "b"));
    }
    
    @Test
    public void tripleTrouble_EmptyArgThree_ShouldReturnEmptyStr()
    {
        assertEquals("", Kata.tripleTrouble("c", "", ""));
    }
    
    @Test
    public void tripleTrouble_EmptyArgAll_ShouldReturnEmptyStr()
    {
        assertEquals("", Kata.tripleTrouble("", "", ""));
    }
	
	@Test
    public void tripleTrouble_AllValid_ShouldReturnBatman()
    {
        assertEquals("batman", Kata.tripleTrouble("bm", "aa", "tn"));
    }
    
    @Test
    public void tripleTrouble_AllValid_ShouldReturnAnd()
    {
        assertEquals("and", Kata.tripleTrouble("a", "n", "d"));
    }
}