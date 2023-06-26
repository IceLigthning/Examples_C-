package Education_GeekBrains.ObjOrientProgram.Lesson003.Sem;

/*Это класс наследник */
public class Cat extends Animal {
    
    //public Cat(String name, int maxSwim, int maxRun) {
    //    /**Super нужен для того, чтобы вызвать
    //     * конструктор базового типа.
    //     */
    //    super(name, maxSwim, maxRun);
    //}

    public Cat(String name) {
        /**Super нужен для того, чтобы вызвать
         * конструктор базового типа.
         */
        super(name, 0, 200);
    }


    /*Можно переопределить метод swim */
    /*Реализация на уровне Animal,
     * но тут идёт переопределение!
     */
    @Override
    void swim(int distance) {
    System.out.println(name + "не умеет плавать!\n");
    }
}
