import java.util.Arrays;

public class Kata {
	public static int nextId(int[] ids) {
		int minId = 0;
		
		if(ids.length == 0) return minId;
		
		Arrays.sort(ids);
		
		if(ids[0] < 0) return minId; // negative min
		
		if(ids[0] == 0 && ids[ids.length - 1] == 0) return 1; // all zero in array
		
		for(int i = 0; i < ids.length; i++) {
			if(ids[i] == minId) {
				minId++;
			}
		}
		
		return minId;
	}
}
