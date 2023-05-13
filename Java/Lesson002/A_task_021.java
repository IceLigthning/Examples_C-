/*
 * 
 * В файле содержится строка с исходными данными в такой форме:
 * 
{"name":"Ivanov", "country":"Russia", "city":"Moscow", "age":"null"}

Требуется на её основе построить и вывести на экран новую строку, в форме SQL запроса:

SELECT * FROM students WHERE name = "Ivanov" AND country = "Russia" AND city = "Moscow";

Для разбора строки используйте String.split. Сформируйте новую строку, используя StringBuilder. 
Значения null не включаются в запрос.
 * 
 */

package Education_GeekBrains.Java.Lesson002;

//import java.io.FileWriter;
import java.io.FileReader;
import java.io.IOException;



public class A_task_021 {
    static public void main(String[] args) throws Exception {
        FileReader reader = null;
        try {
            
            reader = new FileReader("person.txt");
        
        } 
        catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
        finally {
            if (reader != null) {
                reader.close();
            }

        }

    }
}
