package Education_GeekBrains.ObjOrientProgram.Lesson001.HW;

public class New_product {
    
    /** Поля переменных: */
    protected String brand;
    protected String name;
    protected double price;

    /** Защита от изменения значения цены. */
    private void checkPrice(double price) {
        if(price <= 0){
            this.price = 120;
        }
        else{
            this.price = price;
        }
    }



    public void setPrice(double price) {
        checkPrice(price);
    }

    
    public New_product()
    {
        this("product", 100);
    }


    public New_product(String inputName, double inputPrice)
    {
        this("noname", inputName, inputPrice);
    }


    public New_product(String brand, String name, double price)
    {
        if (brand == null || brand.length() < 5){
            this.brand = "noname";
        }
        else {
            this.brand = brand;
        }
        if (name == null || name.length() < 5){
            this.name = "product";
        }
        else {
            this.name = name;
        }
        checkPrice(price);
    }


    /** Вывод информации о товаре */
    public String displayInfo(){
        return String.format("%s - %s - %f", brand, name, price);
    }


}
