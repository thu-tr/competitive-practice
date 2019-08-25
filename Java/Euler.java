Main.java
import java.util.*;

public class Main{
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        int num = s.nextInt();
        double sum = 1;
        double cur = 1;
        if (num == 0){
            System.out.println(cur);
        }
        else{
            for (int i = 1; i <= num && i <= 15; i++){
                cur *= i;
                sum += 1/cur;
            }
            System.out.println(sum);
        }
    }
}
