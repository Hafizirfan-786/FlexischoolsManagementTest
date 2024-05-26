using Mapster;
using FlexischoolsManagement.Application.Contract;
using FlexischoolsManagement.Application.DTOs;
using FlexischoolsManagement.Domain.Entities;
using FlexischoolsManagement.Domain.Repositories;

namespace FlexischoolsManagement.Application.Logic
{
    public class LectureService : ILectureService
    {
        private readonly IGenericRepository _repositoryManager;

        public LectureService(IGenericRepository repositoryManager) => _repositoryManager = repositoryManager;

        public async Task<IEnumerable<LectureDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var Lectures = await _repositoryManager.LectureRepository.ListAsync(cancellationToken);

            return Lectures.Adapt<IEnumerable<LectureDto>>();
        }

        public async Task<LectureDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var Lectures = await _repositoryManager.LectureRepository.GetByIdAsync(id, cancellationToken);

            return Lectures.Adapt<LectureDto>();
        }

        public async Task<LectureDto> AddAsync(LectureAdditionDto LectureForCreationDto, CancellationToken cancellationToken = default)
        {
            var Lectures = LectureForCreationDto.Adapt<Lecture>();

            _repositoryManager.LectureRepository.Add(Lectures);

            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Lectures.Adapt<LectureDto>();
        }
    }
}
