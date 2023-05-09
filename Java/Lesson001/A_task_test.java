import java.util.Scanner; 


public class A_task_test {

    static public void main(String[] args) {
        java.util.Scanner iScan = new Scanner(System.in);

        
        
        System.out.printf("Введите арифметический символ: ");
        String sign = iScan.nextLine();
        
        
        iScan.close();

        String mark1 = "+";
        String mark2 = "-";
        String mark3 = "/";
        String mark4 = "*";

        if (sign == mark1 ){
            System.out.println("A");
        }
        else if(sign == mark2){
            System.out.println("V");
        }
        else if(sign == mark3){
            System.out.println("C");
        }
        else if(sign == mark4){
            System.out.println("D");
        }
        else
        {
            System.out.println("Вы не ввели арифметический символ или ввели его не привильно!");
        }
    }
}
