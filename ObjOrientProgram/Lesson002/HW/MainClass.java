package Education_GeekBrains.ObjOrientProgram.Lesson002.HW;

public class MainClass {
    public static void main(String[] args) {
        
        /*Cat cat = new Cat("Barsik", 5);

        Plate plate = new Plate(100);*/

        A_result [] cats = {

            new Cat("Onyx", 17),
            new Cat("Lucy", 10),
            new Cat("Nora", 7)

        };

        Feeding [] feeding = {

            new Plate(-1)

        };



        /*/
        plate.info();
        cat.eat();
        
        plate.setFood(plate.getFood() - cat.getAppetite());
        */

        for (A_result cat : cats) {
            for (Feeding one_feed : feeding) {
                if (one_feed instanceof Plate) {
                    if(!cat.appetite(one_feed.getFood()))
                    continue;
                
                }
            }
        }

    }
}