import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner s = new Scanner(System.in);
        int len = s.nextInt();
        int[] list = new int[2*len];
        int[] cal = new int[365];
        for (int i = 0; i < list.length; i++){
            list[i] = s.nextInt();
        }

        int count = 0;
        while (count < list.length){
            int start = list[count] - 1;
            int end = list[count+1] - 1;
            for (int i = start; i <= end; i++){
                cal[i] = 1;
            }
            count = count +2;
        }

        int day = 0;
        for (int i = 0; i < cal.length; i++){
            if (cal[i] == 1){
                day++;
            }
        }
        System.out.println(day);
    }
}
