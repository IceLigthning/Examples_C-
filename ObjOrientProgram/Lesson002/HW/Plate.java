package Education_GeekBrains.ObjOrientProgram.Lesson002.HW;

public class Plate extends Feeding{

    private final int food;

    /*
    public int getFood() {
        return food;
    }*/
    public void setFood(Integer food) {
        setFood(food);
    }    

    


    public Plate(int food) {
        this.food = food;
    }
    public void info() {
        System.out.println("plate: " + food);
    }

    @Override
    public int getFood() {
        return food;
    }

}