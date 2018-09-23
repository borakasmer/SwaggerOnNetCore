using System.Collections.Generic;
using System.Threading.Tasks;

public class SchollService : ISchollService
{
    public static List<Class> classList = new List<Class>(){
        new Class(){ID=1,Name="1-A",Population=30,TeacherName="X Bayan"},
        new Class(){ID=2,Name="1-B",Population=20,TeacherName="Y Bayan"},
        new Class(){ID=3,Name="2-A",Population=22,TeacherName="Z Erkek"},
        new Class(){ID=4,Name="2-B",Population=32,TeacherName="No name"},
    };
    public static List<Student> studentList = new List<Student>(){
        new Student(){ID=1,Name="Abc",Age=6,Gender="Kız",No=111,ClassID=1},
        new Student(){ID=2,Name="XXX",Age=5,Gender="Erkek",No=222,ClassID=1},
        new Student(){ID=3,Name="YYY",Age=7,Gender="Erkek",No=333,ClassID=2},
        new Student(){ID=4,Name="ZZZZ",Age=6,Gender="kız",No=444,ClassID=2}
    };

    public List<Class> GetAllClass()
    {
        return classList;
    }

    public List<Student> GetAllStudents()
    {
        return studentList;
    }

    public Class GetClassByID(int id)
    {
        return classList.Find(result => result.ID == id);
    }

    public Class GetClassByName(string name)
    {
        return classList.Find(result => result.Name == name);
    }

    public List<Student> GetStudentByClass(int classID)
    {
        return studentList.FindAll(result => result.ClassID == classID);
    }

    public Student GetStudentByID(int ID)
    {
        return studentList.Find(result => result.ID == ID);
    }

    public Student GetStudentByName(string Name)
    {
        return studentList.Find(result => result.Name == Name);
    }
    public void AddStudent(Student student)
    {
        studentList.Add(student);
    }
    public void AddClass(Class _class)
    {
        classList.Add(_class);
    }
}