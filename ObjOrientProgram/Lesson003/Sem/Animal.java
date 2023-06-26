package Education_GeekBrains.ObjOrientProgram.Lesson003.Sem;

public abstract class Animal {
    /* На уровне класса Animal можно описать
     * какиенибудь базовые поля
    */

     // Поля:

     
     /* работа с полями может потребоваться
      * на уровне класов наследников
    */

    protected String name;
    protected int maxSwim;
    protected int maxRun;

    private int id;

    /**Статическоеп поле */
    /*для обращения к этому полю создание нового объекта
     * не требуется!
     */
    public static int identifier = 1000;
    public int getId() {
        return id;
    }


    // Эта хрень нужна, чтобы в какой-то момоент можно было прочитать значение полей
    public String getName() {
        return name;
    }

    public int getMaxSwim() {
        return maxSwim;
    }

    public int getMaxRun() {
        return maxRun;
    }


    // Добавляем конструктор
    // для того, чтобы на основе полей можно было создать экземпляр класса
    // сразу проинициализировать, объявим правила 
    public Animal(String name, int maxSwim, int maxRun) {
        id = ++identifier;
        this.name = name;
        this.maxSwim = maxSwim;
        this.maxRun = maxRun;
    }

    // методы

    void run(int distance) {
        if (distance <= maxRun) {
            System.out.printf("%s пробежал %d метров!\n", name, distance);
        }
        else {
            System.out.printf("%s не смог пробежать %d метров!\n", name, distance);
        }
    }

    void swim(int distance) {
        if (distance <= maxSwim) {
            System.out.printf("%s пробежал %d метров!\n", name, distance);
        }
        else {
            System.out.printf("%s не смог пробежать %d метров!\n", name, distance);
        }
    }

}
