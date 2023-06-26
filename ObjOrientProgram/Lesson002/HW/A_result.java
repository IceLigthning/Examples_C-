package Education_GeekBrains.ObjOrientProgram.Lesson002.HW;

public interface A_result {
    

    String getName();

    int getAppetite();

    default boolean appetite(int food) {
        if (food < 0) {
            System.out.printf("Кормление кота %s не возможно!\n", getName());
            return false;
        }
        else {
            if(food >= getAppetite()) {
                System.out.printf("Кот %s съел %d корма!\n", getName(), getAppetite());
                return true;
            }
            else {
                System.out.
                        printf("Кот %s не тронул %d корма, так как этого мало!\n", 
                    getName(), getAppetite());
                return false;
            }
        }

    }

}