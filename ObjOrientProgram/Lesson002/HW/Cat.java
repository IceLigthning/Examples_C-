package Education_GeekBrains.ObjOrientProgram.Lesson002.HW;

public class Cat extends Animal {

    private final String name;
    private final int appetite;


    public String getName() {
        return name;
    }
    public void setName(String name) {
        setName(name);
    }    


    public int getAppetite() {
        return appetite;
    }
    public void setAppetite(Integer appetite) {
        setAppetite(appetite);
    }    


    public Cat(String name, int appetite) {
        
        this.name = name;
        this.appetite = appetite;

    }

    public void eat() { }
}