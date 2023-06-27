package Education_GeekBrains.ObjOrientProgram.Lesson003.HW;

public abstract class Employer {

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


    public Employer(String name, String surname, double salary) {
        this.name = name;
        this.surname = surname;
        this.salary = salary;
    }

    /**
     * Расчётсреднемесячной заработной платы
     * @return
     */

     public abstract double calculateSalary();
    
}
