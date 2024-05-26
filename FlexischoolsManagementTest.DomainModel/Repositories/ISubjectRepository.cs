using FlexischoolsManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Domain.Repositories
{
    public interface ISubjectRepository
    {
        Task<IEnumerable<Subject>> ListAsync(CancellationToken cancellationToken = default);

        Task<Subject> GetByIdAsync(int Id, CancellationToken cancellationToken = default);

        List<Lecture> GetLecturesBySubjectId(int subjectId);

        void Add(Subject Subject);

        void Delete(Subject Subject);

        Task<IEnumerable<Subject>> GetByStudentIdAsync(int studentId, CancellationToken cancellationToken);
    }
}
