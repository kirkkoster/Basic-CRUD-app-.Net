using EFMVC.Models;

namespace EFMVC.Services
{
    public interface ISubjectServices
    {
        public IEnumerable<Subject> GetAllSubjects();
        public void DeleteSubject(int id);
        void CreateSubject(string subjectName, string subjectTerm, int subjectCredits);
        void EditSubject(Subject subject);
        public Subject GetEditSubject(int id);
        public Subject GetDetailSubject(int id);
    }
}
