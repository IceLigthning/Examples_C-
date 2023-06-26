package Education_GeekBrains.ObjOrientProgram.Lesson003.Sem;

public class Program {

    public static void main(String[] args) {
        
        /*Создаём несколько объектов */
        //cat1 - указатель на объект!
        // и через переменную cat1  обращаемся к объекту 
        Cat cat1 = new Cat("Барсик");
        // выводим значение поля id!
        System.out.println(cat1.getId());
        cat1.run(10);

        Cat cat2 = new Cat("Персик");
        cat2.swim(20);
        System.out.println(cat2.getId());

        Cat cat3 = new Cat("Бублик");
        cat3.run(300);
        System.out.println(cat3.getId());


        Dog dog1 = new Dog("Шарик");
        System.out.println(dog1.getId());

        Dog dog2 = new Dog("Бобик");
        System.out.println(dog2.getId());

        /* Члены класса могут быть как статические,
         * так и нестатические!
         */

        /* static означает, что эти члены классов не принадлежать
         * к каким-то конкретным объектам!
         */

         /*Можно присвоить значение
          * или поработать с полем на чтение
          */
          /*тут мы напрямую обращаемся к классу */
        Animal.identifier = 2;
    }
    
}
