package Education_GeekBrains.ObjOrientProgram.Lesson001.HW;

import java.util.ArrayList;
import java.util.List;

public class VendingMachine {

    private final List<Product> products;
    private final List<New_product> sweets;


    public VendingMachine(List<Product> products, List<New_product> sweets) {

        this.products = products;
        this.sweets = sweets;
    }

    public  BottleOfWater getBottleOfWater(double volume){

        for(Product product : products){
            if (product instanceof BottleOfWater){
               if ( ((BottleOfWater)product).getVolume()  == volume){
                   return (BottleOfWater)product;
               }
            }
        }
        return null;
    }

    public  Chocolate getChocolate(double calories){
    for(New_product a_sweet : sweets){
        if (a_sweet instanceof Chocolate){
           if ( ((Chocolate)a_sweet).getСalories()  == calories){
               return (Chocolate)a_sweet;
           }
        }
    }
    return null;
}

}
