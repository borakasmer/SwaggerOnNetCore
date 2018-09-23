using System.Collections.Generic;
public interface ISchollService
{
    List<Class> GetAllClass();
    Class GetClassByID(int id);
    Class GetClassByName(string Name);
    List<Student> GetAllStudents();
    List<Student> GetStudentByClass(int classID);
    Student GetStudentByID(int ID);
    Student GetStudentByName(string Name);

    void AddStudent(Student student);
    void AddClass(Class _class);
    
}