package Education_GeekBrains.ObjOrientProgram.Lesson003.HW;

public class Worker extends Employer {

    public Worker(String name, String surname, double salary) {
        super(name, surname, salary);
    }

    @Override
    public double calculateSalary() {
        return 0;
    }

    
}
