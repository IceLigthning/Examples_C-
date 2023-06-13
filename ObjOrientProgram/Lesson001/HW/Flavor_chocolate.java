package Education_GeekBrains.ObjOrientProgram.Lesson001.HW;

public class Flavor_chocolate extends Chocolate {
    
    private double calories;

    public double getCalories() {
        return calories;
    }

    public void setCalories(double calories) {
        this.calories = calories;
    }

    public Flavor_chocolate(String brand_1, String name_1, double price_1, double calories) {
        super(brand_1, name_1, price_1);
        this.calories = calories;
    }

    @Override
    public String displayInfo() {
        return String.format("[Шоколад] %s - %s - %f [Калории: %f]", brand_1, name_1, price_1, calories);
    }

}
