using System;
using System.Linq;
using S360Entity;

namespace S360BusinessLogic
{
    public class S360Repository
    {
        static IUnitOfWork uow = null;
        static StudentRepository repo = null;

        static S360Repository()
        {
            uow = new UnitOfWork();
            repo = new StudentRepository(uow);
        }


        public static Student FirstStudent()
        {
            Student stu = repo.GetAll().Where(l => l.MotherName == "Cicy").FirstOrDefault();
            return stu;
        }
    }
}
