package Education_GeekBrains.ObjOrientProgram.Lesson002.HW;

public class Program {
    

    public class Cat {

        private String name;
        private int appetite;

        public String getName() {
            return name;
        }
        public int getAappetite() {
            return appetite;
        }
        
        
        public void setAappetite(int appetite) {
            this.appetite = appetite;
        }
        

        public Cat(String name, int appetite) {
            this.name = name;
            this.appetite = appetite;
        }
        public void eat() { 

            System.out.println("Name: " + name +
                               "appetite: " + appetite);

        }
    }


    public class Plate {

        private int food;

        public int getFood() {
            return food;
        }
        public void setFood(int food) {
            this.food = food;
        }

        public Plate(int food) {
            this.food = food;
        }

        public void info() {
            System.out.println("plate: " + food);
        }
    }   


    public class MainClass {
        public static void main(String[] args) {

            Cat cat = new Cat("Barsik", 5);
            Plate plate = new Plate(100);

            plate.info();
            cat.eat();
            plate.setFood(plate.getFood() - cat.getAppetite());
            
        }
    }


}
