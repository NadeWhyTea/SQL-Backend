SELECT * FROM Students;

SELECT 
    C.ClassId, C.Name AS ClassName, C.Grade, C.TotalStudents, 
    T.TeacherId, T.Name AS TeacherName, T.Experience
FROM Classes C
FULL OUTER JOIN Teachers T
ON C.TeacherId = T.TeacherId;

UPDATE Students
SET Year = 4
WHERE StudentId = 1;



