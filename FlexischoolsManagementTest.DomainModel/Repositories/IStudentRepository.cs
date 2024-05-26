using FlexischoolsManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Domain.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> ListAsync(CancellationToken cancellationToken = default);

        Task<Student> GetByIdAsync(int Id, CancellationToken cancellationToken = default);

        void Add(Student Student);

        void Update(Student Student);

        void Delete(Student Student);

        Task<IEnumerable<Student>> GetBySubjectIdAsync(int subjectId, CancellationToken cancellationToken);
    }
}
