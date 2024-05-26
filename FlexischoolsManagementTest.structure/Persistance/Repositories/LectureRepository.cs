using Microsoft.EntityFrameworkCore;
using FlexischoolsManagement.Domain.Entities;
using FlexischoolsManagement.Domain.Repositories;


namespace FlexischoolsManagement.Infrastructure.Persistance.Repositories
{
    internal sealed class LectureRepository : ILectureRepository
    {
        private readonly FlexischoolsManagementDbContext _dbContext;

        public LectureRepository(FlexischoolsManagementDbContext dbContext) => _dbContext = dbContext;

        public void Add(Lecture Lecture) => _dbContext.Lectures.Add(Lecture);

        public void Delete(Lecture Lecture) => _dbContext.Lectures.Remove(Lecture);

        public Task<Lecture> EnrollStudent(Student student, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Lecture>> ListAsync(CancellationToken cancellationToken = default) =>
            await _dbContext.Lectures.Include(x => x.Subject).Include(m => m.LectureTheatre).ToListAsync(cancellationToken);

        public async Task<Lecture> GetByIdAsync(int Id, CancellationToken cancellationToken = default) =>
            await _dbContext.Lectures.Include(x => x.Subject).Include(m => m.LectureTheatre).FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);
    }
}
