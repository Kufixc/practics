-- Database: DataBaseGJI

-- DROP DATABASE IF EXISTS "DataBaseGJI";

CREATE DATABASE "DataBaseGJI"
    WITH
    OWNER = "user"
    ENCODING = 'UTF8'
    LC_COLLATE = 'en_US.utf8'
    LC_CTYPE = 'en_US.utf8'
    LOCALE_PROVIDER = 'libc'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;

CREATE TABLE Report (
    ID SERIAL PRIMARY KEY,
    ContractNumber VARCHAR(50) NOT NULL,
    RegistrationDate DATE NOT NULL,
    ComplaintDate DATE NOT NULL,
    SenderName VARCHAR(100) NOT NULL,
    TaskStatus VARCHAR(50) NOT NULL,
    ResolutionDate DATE
);

INSERT INTO Report (ContractNumber, RegistrationDate, ComplaintDate, SenderName, TaskStatus, ResolutionDate)
VALUES
    ('CN001', '2024-01-01', '2024-01-01', 'Иван Иванов', 'Ожидает обработки', NULL),
    ('CN002', '2024-01-02', '2024-01-01', 'Анна Смирнова', 'Решено', '2024-01-03'),
    ('CN003', '2024-01-03', '2024-01-02', 'Петр Кузнецов', 'В работе', NULL),
    ('CN004', '2024-01-04', '2024-01-02', 'Ольга Орлова', 'Ожидает обработки', NULL),
    ('CN005', '2024-01-05', '2024-01-04', 'Дмитрий Алексеев', 'Решено', '2024-01-06'),
    ('CN006', '2024-01-06', '2024-01-05', 'Екатерина Петрова', 'В работе', NULL),
    ('CN007', '2024-01-07', '2024-01-06', 'Николай Сидоров', 'Ожидает обработки', NULL),
    ('CN008', '2024-01-08', '2024-01-07', 'Мария Федорова', 'Решено', '2024-01-09'),
    ('CN009', '2024-01-09', '2024-01-08', 'Алексей Попов', 'В работе', NULL),
    ('CN010', '2024-01-10', '2024-01-09', 'Наталья Воронцова', 'Ожидает обработки', NULL),
    ('CN011', '2024-01-11', '2024-01-10', 'Сергей Кравцов', 'Решено', '2024-01-12'),
    ('CN012', '2024-01-12', '2024-01-11', 'Оксана Павлова', 'В работе', NULL),
    ('CN013', '2024-01-13', '2024-01-12', 'Александр Лебедев', 'Ожидает обработки', NULL),
    ('CN014', '2024-01-14', '2024-01-13', 'Виктория Соколова', 'Решено', '2024-01-15'),
    ('CN015', '2024-01-15', '2024-01-14', 'Григорий Беляев', 'В работе', NULL),
    ('CN016', '2024-01-16', '2024-01-15', 'Елена Елисеева', 'Ожидает обработки', NULL),
    ('CN017', '2024-01-17', '2024-01-16', 'Михаил Зайцев', 'Решено', '2024-01-18'),
    ('CN018', '2024-01-18', '2024-01-17', 'Светлана Карпова', 'В работе', NULL),
    ('CN019', '2024-01-19', '2024-01-18', 'Андрей Мальцев', 'Ожидает обработки', NULL),
    ('CN020', '2024-01-20', '2024-01-19', 'Вера Логинова', 'Решено', '2024-01-21'),
    ('CN021', '2024-01-21', '2024-01-20', 'Игорь Козлов', 'В работе', NULL),
    ('CN022', '2024-01-22', '2024-01-21', 'Алла Климова', 'Ожидает обработки', NULL),
    ('CN023', '2024-01-23', '2024-01-22', 'Юрий Литвинов', 'Решено', '2024-01-24'),
    ('CN024', '2024-01-24', '2024-01-23', 'Евгения Морозова', 'В работе', NULL),
    ('CN025', '2024-01-25', '2024-01-24', 'Борис Новиков', 'Ожидает обработки', NULL),
    ('CN026', '2024-01-26', '2024-01-25', 'Маргарита Пахомова', 'Решено', '2024-01-27'),
    ('CN027', '2024-01-27', '2024-01-26', 'Владимир Сергеев', 'В работе', NULL),
    ('CN028', '2024-01-28', '2024-01-27', 'Людмила Старкова', 'Ожидает обработки', NULL),
    ('CN029', '2024-01-29', '2024-01-28', 'Артем Трофимов', 'Решено', '2024-01-30'),
    ('CN030', '2024-01-30', '2024-01-29', 'Ирина Ульянова', 'В работе', NULL),
    ('CN031', '2024-01-31', '2024-01-30', 'Константин Харитонов', 'Ожидает обработки', NULL),
    ('CN032', '2024-02-01', '2024-01-31', 'Олеся Цветкова', 'Решено', '2024-02-02'),
    ('CN033', '2024-02-02', '2024-02-01', 'Василий Ширяев', 'В работе', NULL),
    ('CN034', '2024-02-03', '2024-02-02', 'Алиса Юдина', 'Ожидает обработки', NULL),
    ('CN035', '2024-02-04', '2024-02-03', 'Егор Абрамов', 'Решено', '2024-02-05'),
    ('CN036', '2024-02-05', '2024-02-04', 'София Блинова', 'В работе', NULL),
    ('CN037', '2024-02-06', '2024-02-05', 'Денис Волков', 'Ожидает обработки', NULL),
    ('CN038', '2024-02-07', '2024-02-06', 'Полина Громова', 'Решено', '2024-02-08'),
    ('CN039', '2024-02-08', '2024-02-07', 'Семен Дорофеев', 'В работе', NULL),
    ('CN040', '2024-02-09', '2024-02-08', 'Марина Евсеева', 'Ожидает обработки', NULL),
    ('CN041', '2024-02-10', '2024-02-09', 'Артур Жданов', 'Решено', '2024-02-11'),
    ('CN042', '2024-02-11', '2024-02-10', 'Надежда Захарова', 'В работе', NULL),
    ('CN043', '2024-02-12', '2024-02-11', 'Анатолий Игнатьев', 'Ожидает обработки', NULL),
    ('CN044', '2024-02-13', '2024-02-12', 'Татьяна Капустина', 'Решено', '2024-02-14'),
    ('CN045', '2024-02-14', '2024-02-13', 'Федор Князев', 'В работе', NULL),
    ('CN046', '2024-02-15', '2024-02-14', 'Лариса Лаврова', 'Ожидает обработки', NULL),
    ('CN047', '2024-02-16', '2024-02-15', 'Геннадий Малышев', 'Решено', '2024-02-17'),
    ('CN048', '2024-02-17', '2024-02-16', 'Юлия Назарова', 'В работе', NULL),
    ('CN049', '2024-02-18', '2024-02-17', 'Павел Одинцов', 'Ожидает обработки', NULL),
    ('CN050', '2024-02-19', '2024-02-18', 'Ольга Рябова', 'Решено', '2024-02-20');

CREATE TABLE Users (
    ID SERIAL PRIMARY KEY,
    FIO VARCHAR(255) NOT NULL,
    Role VARCHAR(20) NOT NULL,
    UserName VARCHAR(20) NOT NULL,
    Password VARCHAR(50) NOT NULL
);

INSERT INTO Users (FIO, Role, UserName, Password)
VALUES
    ('Иван Иванов', 'Администратор', 'admin1', 'password1'),
    ('Пётр Петров', 'Администратор', 'admin2', 'password2'),
    ('Сергей Сергеев', 'Администратор', 'admin3', 'password3'),
    ('Ольга Смирнова', 'Сотрудник', 'user1', 'password4'),
    ('Анна Иванова', 'Сотрудник', 'user2', 'password5'),
    ('Алексей Алексеев', 'Сотрудник', 'user3', 'password6'),
    ('Мария Петрова', 'Сотрудник', 'user4', 'password7'),
    ('Дмитрий Дмитриев', 'Сотрудник', 'user5', 'password8'),
    ('Екатерина Николаева', 'Сотрудник', 'user6', 'password9'),
    ('Николай Васильев', 'Сотрудник', 'user7', 'password10');
