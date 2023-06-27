package Education_GeekBrains.ObjOrientProgram.Lesson003.Sem;

public class Dog extends Animal {

    private static int counter;

    public static int getDogCounter() {
        return counter;
    }

    public Dog(String name) {
        /**Super нужен для того, чтобы вызвать
         * конструктор базового типа.
         */
        super(name, 10, 500);
    }

    {
        System.out.println("Инициализатор Dog!");
        counter++;
    }

    static {
        System.out.println("Static Инициализатор Dog!");
    } 

}
