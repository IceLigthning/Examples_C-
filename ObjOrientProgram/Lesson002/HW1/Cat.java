package Education_GeekBrains.ObjOrientProgram.Lesson002.HW1;

public class Cat {

    private String name;
    private int appetite;

    public String getName() {
        return name;
    }

    public int getAappetite() {
        return appetite;
    }

    public void setAappetite() {
        this.appetite = appetite;
    }


    public Cat(String name, int appetite) {
        this.name = name;
        this.appetite = appetite;
    }

    public void eat() { 
        
        System.out.println("Name: " + name +
                           "appetite:" + appetite);

    }
}