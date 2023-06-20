package Education_GeekBrains.ObjOrientProgram.Lesson002.Sem.sample2;

public class Cat extends  Animal implements Runner {


    // final запрещает дальнейшее изменение переменной
    private final String name;
    private final int maxRun;
    private final int maxJump;

    public Cat(String name, int maxRun, int maxJump) {
        this.name = name;
        this.maxRun = maxRun;
        this.maxJump = maxJump;        
    }

    // Переопределяем методы
    @Override
    public boolean run(int length) {
        if(length <= maxRun) {
            System.out.printf("%s пробежал по беговой дорожке %d метров\n", name, length);
            return true;
        }
        else {
            System.out.printf("%s не удалось пробежать по беговой дорожке %d метров, он смог пробежать d% метров\n", 
                name, length, maxRun);
            return false;
        }
    }


    @Override
    public boolean jump(int height) {

        if(height <= maxJump) {
            System.out.printf("%s перепрыгнул через стену %d см\n", name, height);
            return true;
        }
        else {
            System.out.
                    printf("%s не удалось перепрыгнуть через стену %d см, он смог прыгнуть d% см\n", 
                name, height, maxJump);
            return false;
        } 
    }
    
}
