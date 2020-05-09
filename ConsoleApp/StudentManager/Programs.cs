using System.Collections.Generic;

namespace ConsoleApp.StudentManager
{
    public class Programs
    {
        public static void Main(string[] args)
        {
            Student st = new Student();
            st.addStudent(new Student(1,"Thang",24,"HN",9.5));
            st.addStudent(new Student(2,"Tuan",25,"HN",9.5));
            st.showStudent();
            st.editStudent(1,"long","HCM",27,5.6);
            st.showStudent();
        }
    }
}