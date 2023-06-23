package Education_GeekBrains.ObjOrientProgram.Lesson002.Sem.sample2;

public class Track extends Obstacle {

    private final int length;

    public Track(int length) {
        this.length = length;
    }

    @Override
    public int getLenght() {
        return length;
    }
    
    @Override
    public int getHeight() {
        return 0;
    }

}
