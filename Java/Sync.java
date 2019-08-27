import java.util.*;
import java.io.Reader;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Scanner;

public class Sync{
    
    public static void main(String[] args){

        Scanner scanner = new Scanner(System.in);
        HashMap<Integer, Integer> map = new HashMap<>();
        int len = scanner.nextInt();
        while (len != 0){
            int[] first = new int[len];
            int[] firstsort = new int[len];
            int[] second = new int[len];
            for (int i = 0; i < len; i++){
                first[i] = scanner.nextInt();
                firstsort[i] = first[i];
            }
            for (int i = 0; i < len; i++){
                second[i] = scanner.nextInt();
            }
            Arrays.sort(firstsort);
            Arrays.sort(second);
            for (int i = 0; i < len; i++){
                map.put(firstsort[i],second[i]);
            }
            for (int i =0; i < len; i++){
                System.out.println(""+ map.get(first[i]));
            }
            System.out.println();
            map.clear();
            len = scanner.nextInt();
        }
        scanner.close();
    }
}
