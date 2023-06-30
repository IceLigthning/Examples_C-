package Education_GeekBrains.ObjOrientProgram.Lesson003.HW;

import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Random;

public class Program {


    static Random random = new Random();

    static Worker generateEmployer() {
        String[] names = new String[] {"Ярослав", "Евгений", "Кирил"};
        String[] surnames = new String[] {"Авдеев", "Багров", "Буслаев"};
        int salary = random.nextInt(20000, 80000);
        return new Worker(names[random.nextInt(names.length)], surnames[random.nextInt(surnames.length)], salary);
    }

    public static void main(String[] args) {

        //Worker worker1 = generateEmployer();
        /*чтобы не выводилось 16-ное число,
         *нужно переопределить toString()
         *(в Worker)
        */
        //System.out.println(worker1);

        Employee[] employees = new Employee[7];
        for (int i = 0; i < employees.length; i++) {
            employees[i] = generateEmployer();
        }

        //Arrays.sort(employees, new SalaryComparator());
        Arrays.sort(employees);

        for (Employee employee : employees) {
            System.out.println(employee);
        }
         
    }
    
}
