package Education_GeekBrains.ObjOrientProgram.Lesson002.Sem.sample2;

public class Robot extends BaseRobot implements Runner {
    

    // final запрещает дальнейшее изменение переменной
    private final String name;
    private final int maxRun;
    private final int maxJump;

    
    public String getName() {
        return name;
    }

    public int getMaxRun() {
        return maxRun;
    }

    public int getMaxJump() {
        return maxJump;
    }

    public Robot(String name, int maxRun, int maxJump) {
        this.name = name;
        this.maxRun = maxRun;
        this.maxJump = maxJump;        
    }

}
