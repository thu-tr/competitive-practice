import java.util.*;

public class Main{
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int len = s.nextInt();
        ArrayList ls = new ArrayList(len);
        System.out.println();
        for (int i = 0; i < len && ls.size() < 12; i++) {
            String uni = s.next();
            String team = s.next();
            if (!ls.contains(uni)){
                ls.add(uni);
                System.out.println(uni + " " + team);
            }
        }
    }
}
