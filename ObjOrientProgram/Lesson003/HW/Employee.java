package Education_GeekBrains.ObjOrientProgram.Lesson003.HW;

public abstract class Employee implements Comparable<Employee> {

    protected String name;
    protected String surname;
    protected double salary;   // Ставка заработной платы


    public String getName() {
        return name;
    }


    public String getSurname() {
        return surname;
    }


    public double getSalary() {
        return salary;
    }


    public Employee(String name, String surname, double salary) {
        this.name = name;
        this.surname = surname;
        this.salary = salary;
    }

    /**
     * Расчёт среднемесячной заработной платы
     * @return
     */

     
     public abstract double calculateSalary();

     /* Сортировка по фамилии и зарплате */
     @Override
     public int compareTo(Employee o) {
        int res = name.compareTo(o.name);
        if(res == 0) {
            return Double.compare(calculateSalary(), o.calculateSalary());
        }
        else {
            return res;
        }
     }
    
}
