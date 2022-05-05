# Examination System 📃✒️✅

The main objective of this examination system is to automate the random generation of exams, performing them online and correcting them based on model answers.
It was designed and constructed using **MySQLServer database and C# EntityFramework Core.**


Instructors can choose how many models of the exam to be generated on each course topic.
They can choose the format of the exam, number of MCQ, True or False and Essay Questions on each course topic.
They can also track how many students took the exam and how well they did based on a mark-percentage grading system.


Students can take the exam online with all randomly-set questions appearing one after one with their potential answers.
They can check the remaining time of the exam online before it no longer accepts answer submissions.
They can also see the results right after the answers are submitted and may check which answers were correct or wrong.

# 

#### Content:
*	ERD
*	Desktop Application
*	Database Dictionary
*	Stored Procedures:  
    -	CRUD operations for every table
    -	Exam Generation
    -	Exam Answers 
    -	Exam Correction

DB will help the staff see the following Reports:
*	Report that returns the students information according to Department.
*	Report that takes the student ID and returns the grades of the student in all courses. %
*	Report that takes the instructor ID and returns the name of the courses that they teach and the number of students per course.
*	Report that takes course ID and returns its topics  
*	Report that takes exam number and returns the Questions in it and chocies
*	Report that takes exam number and the student ID then returns the Questions in this exam with the student answers. 

Used Crystal Report for report design and stored procedures to return data for each Report.
  
#

### Instructor:

* Login/Logout: User have to login with their credentials to access the examination system.
* Insert Exam Questions: Instructor can feed the system the sample questions of the exams and their answers.
* Generate Exam: Instructor can choose the format of the exam, number of MCQ, True or False and Essay Questions.
* View live Results: Instructor can track students results right after they submit their final answers.

### Student:

* Login/Logout: User have to login with their credentials to access the exam.
* Answer Exam Questions: Student can submit the answer of each exam question one after the other.
* Edit Exam Answers: Student can edit their previous exam answers before submission of the exam.
* View Exam Result: Student can view the result of the exam after final submission of the exam on time.

