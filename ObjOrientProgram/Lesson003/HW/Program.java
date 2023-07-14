package Education_GeekBrains.ObjOrientProgram.Lesson003.HW;

import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Random;

public class Program {


    static Random random = new Random();

    static Employee generateEmployer() {
        String[] names = new String[] {"Ярослав", "Евгений", "Кирил", "Егор", "Влад", "Дмитрий"};
        String[] surnames = new String[] {"Авдеев", "Багров", "Буслаев", "Пересыпкин", "Карпов", "Щеблинский"};
        /**Зарплата работника на полной ставке */
        int salary1 = random.nextInt(45000, 120000);


        int quantityOfHours = random.nextInt(10, 400);
        int hourlyCost = 500;
        /**Расчёт оплаты труда фактически сделанной работы */
        int salary2 = quantityOfHours * hourlyCost;

        int typeOfWorker = random.nextInt(0, 2);
        //return new Worker(names[random.nextInt(names.length)], surnames[random.nextInt(surnames.length)], salary);
        
        if (typeOfWorker == 0 ) {
            return new Worker(names[random.nextInt(names.length)], surnames[random.nextInt(surnames.length)], salary1);
        }
        else {
            return new Freelancer(names[random.nextInt(names.length)], surnames[random.nextInt(surnames.length)], salary2);
        }
        
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
