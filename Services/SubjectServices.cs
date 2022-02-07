using EFMVC.Context;
using EFMVC.Models;

namespace EFMVC.Services
{
    public class SubjectServices : ISubjectServices
    {
        MVCContext db;

        public SubjectServices(MVCContext _db)
        {
            this.db = _db;
        }

        public void DeleteSubject(int id)
        {
            Subject subject = db.Subjects.FirstOrDefault(s => s.SubjectId == id);
            if (subject != null)
            {
                db.Remove(subject);
                db.SaveChanges();
            }
        }

        public void CreateSubject(string subjectName, string subjectTerm, int subjectCredits)
        {
            try
            {
                db.Subjects.Add(new Subject { SubjectName = subjectName, SubjectCredits = subjectCredits, SubjectTerm = subjectTerm });
                db.SaveChanges(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }


        }

        public Subject GetEditSubject(int id)
        {
            var subject = db.Subjects.FirstOrDefault(s => s.SubjectId == id);
            return subject;
        }

        public void EditSubject(Subject subject)
        {
            if (subject != null)
            {
                db.Subjects.Update(subject);
                db.SaveChanges(true);
            }

        }

        public IEnumerable<Subject> GetAllSubjects()
        {
            return (db.Subjects.Select(s => s).ToList());
        }

        public Subject GetDetailSubject(int id)
        {
            var subject = db.Subjects.FirstOrDefault(s => s.SubjectId == id);
            return subject;
        }
    }
}
