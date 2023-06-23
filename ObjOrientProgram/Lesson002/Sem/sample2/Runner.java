package Education_GeekBrains.ObjOrientProgram.Lesson002.Sem.sample2;

public interface Runner {


    String getName();

    int getMaxJump();

    int getMaxRun();

    // Переопределяем методы

    //Нужно выделить спецификацию
    default boolean jump(int height) {
        if(height <= getMaxJump()) {
            System.out.printf("%s перепрыгнул через стену %d см\n", getName(), height);
            return true;
        }
        else {
            System.out.
                    printf("%s не удалось перепрыгнуть через стену %d см, он смог прыгнуть d% см\n", 
                getName(), height, getMaxJump());
            return false;
        } 
    }
    

    // Интерфейс не может содержать реализации
    //boolean run(int length);
    default boolean run(int length) {
        if(length <= getMaxRun()) {
            System.out.printf("%s пробежал по беговой дорожке %d метров\n", getName(), length);
            return true;
        }
        else {
            System.out.printf("%s не удалось пробежать по беговой дорожке %d метров, он смог пробежать d% метров\n", 
                getName(), length, getMaxRun());
            return false;
        }
    }    
    
}
