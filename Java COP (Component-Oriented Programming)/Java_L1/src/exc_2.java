import java.util.Scanner;

public class exc_2 {
    static int a, b, max, s;

    static void input(){
        Scanner sc = new Scanner(System.in);
        System.out.print("a = ");
        a = sc.nextInt();
        System.out.print("b = ");
        b = sc.nextInt();
    }

    static String findMax(){
        if (a > b)
        {
            return Integer.toString(a);
        }
        else {
            return Integer.toString(b);
        }
    }
    static String getSum(){
        int sum = a + b;
        return Integer.toString(sum);
    }
    exc_2(){
        input();
        System.out.println("MAX(" + a + "," + b + ") = " + findMax());
        System.out.println(a + " + " + b + " = " + getSum());
    }
    public static void main(String[] args) {
       new exc_2();
    }
}
