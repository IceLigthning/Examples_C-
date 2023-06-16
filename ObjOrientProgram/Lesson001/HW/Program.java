package Education_GeekBrains.ObjOrientProgram.Lesson001.HW;

import java.util.ArrayList;
import java.util.List;

public class Program {

    public static void main(String[] args) {

        int a = 12;



        Product product1 = new Product();
        //product1.brand = "ООО Чистый Источник";
        //product1.name = "Бутылка с водой";
        //product1.price = 125.15;
        System.out.println(product1.displayInfo());



        Product product2 = new Product("ООО Чистый Источник", "Бутылка с водой #2", -90.15);
        //product2.brand = "ООО Чистый Источник";
        //product2.name = "__";
        //product2.price = -15;
        product2.setPrice(-30);
        System.out.println(product2.displayInfo());



        BottleOfWater bottleOfWater1 =
                new BottleOfWater("ООО Чистый Источник", "Бутылка с водой #3", -90.15, 1.5);
        System.out.println(bottleOfWater1.displayInfo());



        Product bottleOfMilk
                = new BottleOfMilk("ООО Чистый Источник", "Бутылка с молоком #1", -90.15, 1.5, 10);
        System.out.println(bottleOfMilk.displayInfo());



        New_product chocolate1 = new New_product("ООО Евразийская сказка", "Горький шоколад", 50);
        System.out.println(chocolate1.displayInfo());


        Chocolate chocolate2 = 
            new Chocolate("ООО  Северные сладости", "Карамельный шоколад", 75, 250);
        System.out.println(chocolate2.displayInfo());

        Chocolate chocolate3 = 
            new Chocolate("ООО  Северные сладости", "Молочный шоколад с бананом", 150, 350);
        System.out.println(chocolate3.displayInfo());



        List<Product> products = new ArrayList<>();
        products.add(product1);
        products.add(product2);
        products.add(bottleOfWater1);
        products.add(bottleOfMilk);



        List<New_product> sweets = new ArrayList<>();
        sweets.add(chocolate1);
        sweets.add(chocolate2);
        sweets.add(chocolate3);


        VendingMachine vendingMachine = new VendingMachine(products, sweets);


        BottleOfWater bottleOfWaterResult = vendingMachine.getBottleOfWater(1.5);
        if (bottleOfWaterResult != null){
            System.out.println("Вы купили:");
            System.out.println(bottleOfWaterResult.displayInfo());
        }
        else {
            System.out.println("Такой бутылки с водой нет в автомате.");
        }

        Chocolate chocolateResult = vendingMachine.getChocolate(350);
        if (chocolateResult != null){
            System.out.println("Вы купили:");
            System.out.println(chocolateResult.displayInfo());
        }
        else {
            System.out.println("Такого шоколада нет в автомате.");
        }
        
        

        
    }

}
