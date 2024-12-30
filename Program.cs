using DependencyInjection;

Console.Clear();

Teacher teacher = new Teacher("Martin", "Eden");
sailorTeacher sailorTeacher = new sailorTeacher("Jack", "London", "Sailor");

Classrom classrom = new Classrom(teacher);

if (sailorTeacher != null)
{
    Classrom London = new Classrom(sailorTeacher);

    classrom.GetTeacherInfo();
    London.GetTeacherInfo();
}

Console.ReadKey();