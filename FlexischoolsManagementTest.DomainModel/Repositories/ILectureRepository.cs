using FlexischoolsManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexischoolsManagement.Domain.Repositories
{
    public interface ILectureRepository
    {
        Task<IEnumerable<Lecture>> ListAsync(CancellationToken cancellationToken = default);

        Task<Lecture> GetByIdAsync(int Id, CancellationToken cancellationToken = default);

        void Add(Lecture Lecture);

        void Delete(Lecture Lecture);

        Task<Lecture> EnrollStudent(Student student, CancellationToken cancellationToken = default);
    }
}
