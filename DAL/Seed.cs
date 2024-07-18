using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_college_project.DAL
{
    static internal class Seed
    {
         static public string GetCreateQuery() {
            return @"
CREATE TABLE courses(
id INT PRIMARY KEY IDENTITY(1,1),
name NVARCHAR(30) NOT NULL,
start_date DATE NOT NULL,
start_huor INT NOT NULL,
end_huor INT NOT NULL,
price FLOAT NOT NULL,
is_active BIT NOT NULL DEFAULT(1),
UNIQUE(name, start_date)
);

CREATE TABLE dow(
id INT PRIMARY KEY IDENTITY(1,1),
name  NVARCHAR(20) UNIQUE NOT NULL 
);


CREATE TABLE course_dow(
id INT PRIMARY KEY IDENTITY(1,1),
course_id INT FOREIGN KEY REFERENCES courses(id) NOT NULL,
dow_id INT FOREIGN KEY REFERENCES dow(id) NOT NULL,
UNIQUE(course_id, dow_id)
);

CREATE TABLE  via(
id INT PRIMARY KEY IDENTITY(1,1),
type nvarchar(30) UNIQUE NOT NULL,
);

CREATE TABLE interesters(
id INT PRIMARY KEY IDENTITY(1,1),
name NVARCHAR(30) NOT NULL,
message NVARCHAR(80) NOT NULL,
phone NVARCHAR(20) NOT NULL,
via_id INT FOREIGN KEY REFERENCES via(id) NOT NULL
);

CREATE TABLE roles(
id INT PRIMARY KEY IDENTITY(1,1),
role_name NVARCHAR(30) UNIQUE NOT NULL
);

CREATE TABLE users(
id INT PRIMARY KEY IDENTITY(1,1),
name NVARCHAR(30) UNIQUE NOT NULL,
address NVARCHAR(100) NOT NULL,
phone NVARCHAR(20) NOT NULL,
username NVARCHAR(30) UNIQUE NOT NULL,
password NVARCHAR(255) NOT NULL,
role_id INT FOREIGN KEY REFERENCES roles(id) NOT NULL 
);

CREATE TABLE lectures(
id INT PRIMARY KEY IDENTITY(1,1),
user_id INT FOREIGN KEY REFERENCES users(id) NOT NULL, 
hourly_wage float NOT NULL
);

CREATE TABLE subjects(
id INT PRIMARY KEY IDENTITY(1,1),
name NVARCHAR(30) UNIQUE NOT NULL,
course_id INT FOREIGN KEY REFERENCES courses(id) NOT NULL, 
lecture_id INT FOREIGN KEY REFERENCES lectures(id) NOT NULL,
UNIQUE(name, course_id)
);

CREATE TABLE students_cards(
id INT PRIMARY KEY IDENTITY(1,1),
user_id INT FOREIGN KEY REFERENCES users(id) UNIQUE NOT NULL
);

CREATE TABLE card_rows(
id INT PRIMARY KEY IDENTITY(1,1),
card_id INT FOREIGN KEY REFERENCES students_cards(id) NOT NULL,
course_id INT FOREIGN KEY REFERENCES courses(id) NOT NULL, 
amount_paid float NOT NULL,
UNIQUE(card_id, course_id)
);
";
        }

        static public string GetInsertQuery()
        {
            return @"
-- Insert data into roles table
INSERT INTO roles (role_name) VALUES
(N'מנהל'),
(N'מרצה'),
(N'תלמיד');

-- Insert data into courses table
INSERT INTO courses (name, start_date, start_huor, end_huor, price, is_active) VALUES
(N'קורס פיתוח אתרים', '2024-08-01', 9, 17, 1500.00, 1),
(N'קורס מדעי המחשב', '2024-08-15', 10, 16, 2000.00, 1);

-- Insert data into dow table
INSERT INTO dow (name) VALUES
(N'ראשון'),
(N'שני'),
(N'שלישי'),
(N'רביעי'),
(N'חמישי');

-- Insert data into course_dow table
INSERT INTO course_dow (course_id, dow_id) VALUES
(1, 1), -- קורס פיתוח אתרים ביום ראשון
(1, 3), -- קורס פיתוח אתרים ביום שלישי
(2, 2), -- קורס מדעי המחשב ביום שני
(2, 4); -- קורס מדעי המחשב ביום רביעי

-- Insert data into via table
INSERT INTO via (type) VALUES
(N'טלפון'),
(N'אינטרנט');

-- Insert data into interesters table
INSERT INTO interesters (name, message, phone, via_id) VALUES
(N'יוסי כהן', N'מעוניין להירשם לקורס פיתוח אתרים', N'050-1234567', 1),
(N'רחל לוי', N'שאלה לגבי הקורס מדעי המחשב', N'052-7654321', 2);

-- Insert data into users table
INSERT INTO users (name, address, phone, username, password, role_id) VALUES
(N'משה ישראלי', N'רחוב הרצל 5, תל אביב', N'054-9876543', N'ad1', N'ad1', 1), -- מנהל
(N'דנה בר', N'רחוב אחד העם 10, ירושלים', N'053-1234567', N'l1', N'l1', 2), -- מרצה
(N'דוד כהן', N'רחוב ביאליק 12, חיפה', N'052-9876543', N's1', N's1', 3), -- תלמיד
(N'שרה לוי', N'רחוב החשמונאים 25, תל אביב', N'054-7654321', N's2', N's2', 3), -- תלמידה
(N'יעקב רונן', N'רחוב יהודה הלוי 18, ירושלים', N'050-8765432', N's3', N's3', 3); -- תלמיד

-- Insert data into lectures table
INSERT INTO lectures (user_id, hourly_wage) VALUES
(2, 100.00); -- מרצה דנה בר

-- Insert data into subjects table
INSERT INTO subjects (name, course_id, lecture_id) VALUES
(N'HTML', 1, 1),
(N'JavaScript', 1, 1),
(N'Introduction to CS', 2, 1);

-- Insert data into students_cards table
INSERT INTO students_cards (user_id) VALUES
(3), -- תלמיד דוד כהן
(4), -- תלמידה שרה לוי
(5); -- תלמיד יעקב רונן

-- Insert data into card_rows table
INSERT INTO card_rows (card_id, course_id, amount_paid) VALUES
(1, 1, 1500.00), -- דוד כהן שילם על קורס פיתוח אתרים
(1, 2, 500.00), -- דוד כהן שילם חלקית על קורס מדעי המחשב
(2, 1, 1500.00), -- שרה לוי שילמה על קורס פיתוח אתרים
(3, 2, 2000.00); -- יעקב רונן שילם על קורס מדעי המחשב

";
        }
    }
}
