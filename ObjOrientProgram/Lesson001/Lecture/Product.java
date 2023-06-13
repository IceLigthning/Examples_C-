package Education_GeekBrains.ObjOrientProgram.Lesson001.Lecture;

public class Product{

    String name; // Наименование
    String brand; // Бренд
    double price; // Цена

    Product(){

    }

    /**Вывод информации */
    String displayInfo(){
            return String.format ("%s - %s - %f", brand, name, price);
    }

}
