package Education_GeekBrains.ObjOrientProgram.Lesson003.Sem;

public class Dog extends Animal {
    public Dog(String name) {
        /**Super нужен для того, чтобы вызвать
         * конструктор базового типа.
         */
        super(name, 10, 500);
    }    
}
