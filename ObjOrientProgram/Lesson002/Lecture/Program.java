
package Education_GeekBrains.ObjOrientProgram.Lesson002.Lecture;

public class Program {

    void A() {
        System.out.println("A()");
    }
    public static void main(String[] args) {

        Program prog = new Program();
        prog.A();
        /*f1, f2, f3 - это экземпляры класса. */
        Foo f1 = new Foo();
        f1.value = 123;
        //System.out.println(f1.value);
        f1.printCount();
 

        Foo f2 = new Foo();
        f2.value = 444;
        //System.out.println(f2.value);
        f2.printCount();

        Foo f3 = new Foo();
        f3.value = 725;
        //System.out.println(f3.value);
        f3.printCount();
    }

}