package Education_GeekBrains.ObjOrientProgram.Lesson001.Lecture;

public class ex_001 {

    public static void main(String[] args) {
        
        Product product1 = new Product();
        product1.brand = "ООО Зимняя Роза";
        product1.name = "Бутылка с водой";
        product1.price = 125.15;
        System.out.println(product1.displayInfo());
        
    }

}