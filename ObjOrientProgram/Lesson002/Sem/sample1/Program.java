package Education_GeekBrains.ObjOrientProgram.Lesson002.Sem.sample1;

import java.util.ArrayList;
import java.util.List;

public class Program {

    public static void main(String[] args) {
        
        Cat cat1 = new Cat("Персик", "Рыжий");
        cat1.jump();
        cat1.voice();

        Dog dog1 = new Dog("Шарик", 8);
        dog1.jump();
        dog1.voice();

        List<Animal> animals = new ArrayList<>();
        animals.add(cat1);
        animals.add(dog1);

        System.out.println("==============================");

        processAnimals(animals);

    }
    
    public static void processAnimals(List<Animal> animals) {
        for (Animal animal : animals) {
            animal.voice();
            if (animal instanceof Cat)  
                System.out.println(((Cat)animal).getColor()); //Можно без промежуточной переменной

        }
    }

}


class Dog extends Animal {

    private int weight; 

    public int getWeight() {
        return weight; 
    }

    

    public void setWeight(int weight) {
        this.weight = weight;
    }

    public Dog(String name, int weight) {
        super(name);
        this.weight = weight;
    }

    @Override
    public void voice () {
        System.out.println("Собака лает.");
    }

}

class Cat extends Animal {

    String color;

    
    public String getColor() {
        return color;
    }

    public void setColor(String color) {
        this.color = color;
    }


    public Cat(String name, String color) {
        super(name);
        this.color = color;
    }


    @Override
    public void voice () {
        System.out.println("Кот мяукает.");
    }

}


/*Abstract - значит класс будет базовым, на основе которого будут созданы другие классы!*/
/* Абстрактные методы можно создавать только внутри абстрактных классов */
abstract class Animal {

    private String name;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    /** Это конструктор */
    public Animal(String name) {
        this.name = name;
    }

    public abstract void voice(); 
    /*{
        // Абстракция это тип описывающий контракт, но не предоставляющая его полную реализацию.
        // у данного метода не может быть кодового блока
        // может быть только спецификация
        // System.out.println("Животное подаёт голос");
    }*/


    public void jump() {
        System.out.println("Животное попдпрыгнуло.");
    }

}