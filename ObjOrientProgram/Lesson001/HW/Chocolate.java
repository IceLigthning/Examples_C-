package Education_GeekBrains.ObjOrientProgram.Lesson001.HW;

public class Chocolate {

    protected String name_1; // Наименование шоколада
    protected String brand_1; // Бренд
    protected double price_1; // Цена
    
    
    private void checkPrice(double price_1){
        if (price_1 <= 70){
            this.price_1 = 80;
        }
        else {
            this.price_1 = price_1;
        }
    }


    public void setPrice(double price_1) {
        checkPrice(price_1);
    }
    
    

    



    
    public String displayInfo() {
        return String.format("%s - %s - %f", brand_1, name_1, price_1);
    }
    
}
