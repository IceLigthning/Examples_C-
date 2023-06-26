package Education_GeekBrains.ObjOrientProgram.Lesson001.HW;

public class Chocolate extends New_product {

    private double calories; // Число калорий!

    public double getСalories() {
        return calories;
    }

    public void setСalories(int calories) {
        this.calories = calories;
    }

    public Chocolate(String brand, String name, double price, double calories) {
        super(brand, name, price);
        this.calories = calories;
    }


    @Override
    public String displayInfo() {
        return String.format("[Плитка шоколада] %s - %s - %f [калории: %f]", brand, name, price, calories);
    }


    
}
