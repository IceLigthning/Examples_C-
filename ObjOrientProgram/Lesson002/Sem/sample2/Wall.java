package Education_GeekBrains.ObjOrientProgram.Lesson002.Sem.sample2;

public class Wall extends Obstacle {

    private final int height;
    
    public Wall(int height) {
        this.height = height;
    }

    @Override
    public int getLenght() {
        return 0;
    }

    @Override
    public int getHeight() {
        return height;
    }
    
}
