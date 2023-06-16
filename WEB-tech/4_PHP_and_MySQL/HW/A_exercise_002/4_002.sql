CREATE TABLE classmate (
  Id INTEGER PRIMARY KEY,
  name    TEXT NOT NULL,
  age     TEXT NOT NULL,
  address TEXT NOT NULL
);

-- insert
INSERT INTO classmate VALUES (0001, 'Ярослав', '21', 'Взлётная 109');
INSERT INTO classmate VALUES (0002, 'Евгений', '17', 'Волгоградская 29');
INSERT INTO classmate VALUES (0003, 'Илья', '25', 'Мира 40');
INSERT INTO classmate VALUES (0004, 'Андрей', '22', 'Декабрьских Событий 83');
INSERT INTO classmate VALUES (0005, 'Александр', '18', 'Красная 9');


-- fetch 
SELECT * FROM classmate;