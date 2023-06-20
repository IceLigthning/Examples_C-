package Education_GeekBrains.ObjOrientProgram.Lesson002.Lecture;

class Doo extends Foo {
    public void M(){
        Foo.count = 234;
    }
}

public class Foo {
    public Integer value;

    public static Integer count;

    protected static Integer getCount(){
        return count;
        // Статика позаоляет обращаться к статическим элементам через имя типа черех public;
        // обращение через this и super нещдоступно!

        // public - доступен откуда угодо;
        // protected - достуаный член в рамках созданного класса и доступен в наследуемых классах;
        // privot - доступен в рамках текущего класса.
    }

    static{
        count = 0;
    }
    public Foo() {
        count++;
    }

    public void printCount() {
        System.out.println(count);
    }

    @Override
    // TODO Auto-generated method stud
    public String toString() {
        return value.toString();
    }

}