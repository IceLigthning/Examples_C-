package Education_GeekBrains.ObjOrientProgram.Lesson003.Lecture;

public class Program {
    public static void main(String[] args) {
        //Создаём экземпляр класса
        Foo foo1 = new Foo() {

            
            @Override
            public void m1() {
                System.out.println("m1");
            }
            @Override
            public void m2() {
                // TODO Auto-generated method stud
                System.out.println("m2");
            }

        };

        //На экземпляре Foo1 вызываем метод, который есть m1 или m2/
        foo1.m1();

        Foo foo2 = new Foo() {
    
            @Override
            public void m1() {
                System.out.println(">>>>>m1");
            }
            @Override
            public void m2() {
                // TODO Auto-generated method stud
                System.out.println(">>>>>m2");
            }
        };

        foo2.m1();

    }
    
}
