public class Kata {
    public static String tripleTrouble(String one, String two, String three) {
        if(one.length() != two.length() || one.length() != three.length() || one.length() == 0)
            return "";
        
        String result = "";
        
        for(int ind = 0; ind < one.length(); ind++) {
            result +=
                String.valueOf(one.charAt(ind)) +
                String.valueOf(two.charAt(ind)) +
                String.valueOf(three.charAt(ind));
        }
        
        return result;
    }
}