package Education_GeekBrains.ObjOrientProgram.Lesson003.HW;

public class Worker extends Employee {

    public Worker(String name, String surname, double salary) {
        super(name, surname, salary);
    }

    @Override
    public double calculateSalary() {
        return salary;
    }

    // Нужна для перевода исз 16-ричной в 10-ную систему
    @Override
    public String toString() {
        return String.format("%s %s; Рабочий; Среднемесячная заработная плата (фиксированная месячная оплата): %.2f (руб.)", 
            surname, name, calculateSalary());
    }
    
}
