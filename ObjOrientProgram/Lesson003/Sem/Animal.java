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
    /*Статический член класса не  живёт на объекте,
     * он живёт на описателе объекта!
     */
    public static int identifier;

    public static int counter;

    public static int getCounter() {
        return counter;
    }

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


    // Инициализаторы
    /*При добавлении блока инициализатора,
     *он будет выполняться всегда при
     *создании объекта, перед выполнение
     конструктора!
     */
    {
        System.out.println("Инициализатор!");
        id = ++identifier;
        counter++;
    }


    /*Статический инициализатор
     * вызывается перед выполнение 
     *  конструкторов
     */
    static {
        System.out.println("Статический инициализатор!");
        identifier = 1000;
    }


    // Добавляем конструктор
    // для того, чтобы на основе полей можно было создать экземпляр класса
    // сразу проинициализировать, объявим правила 
    public Animal(String name, int maxSwim, int maxRun) {
        System.out.println("Конструктор!");
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
