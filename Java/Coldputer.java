import java.util.*;

public class Main{
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int len = s.nextInt();
        int count = 0;
        for (int i = 0; i < len; i++){
             int cur = s.nextInt();
             if (cur < 0){
                 count++;
             }
        }
        System.out.println(count);
    }
}
